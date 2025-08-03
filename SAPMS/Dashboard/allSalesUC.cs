using DevExpress.XtraEditors;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MySql.Data.MySqlClient;
using SAPMS.Classes;

namespace SAPMS.Dashboard
{
    public partial class allSalesUC : DevExpress.XtraEditors.XtraUserControl
    {
        public allSalesUC()
        {
            InitializeComponent();
        }

        private async void allSalesUC_Load(object sender, EventArgs e)
        {
            string storedProcedure = "GetSalesRecord";

            try
            {
                List<SalesRercord> dailyTreatmentList = new List<SalesRercord>();

                using (MySqlConnection connection = new MySqlConnection("server=localhost;uid=root;pwd=;database=sapmsDB"))
                {
                    await connection.OpenAsync();

                    using (MySqlCommand command = new MySqlCommand(storedProcedure, connection))
                    {
                        command.CommandType = CommandType.StoredProcedure;

                        using (MySqlDataReader reader = (MySqlDataReader)await command.ExecuteReaderAsync())
                        {
                            while (await reader.ReadAsync())
                            {
                                SalesRercord treatment = new SalesRercord
                                {
                                    SalesID = reader["id"] != DBNull.Value ? Convert.ToInt32(reader["id"]) : 0,
                                    BusinessCode = reader["code"]?.ToString() ?? string.Empty,
                                    CustomerName = reader["customerName"]?.ToString() ?? string.Empty,
                                    VatSales = reader["VatSales"]?.ToString() ?? string.Empty,
                                    OutputSales = reader["outputSales"]?.ToString() ?? string.Empty,
                                    DateOfTransact = reader["dateOfTransac"] != DBNull.Value ? Convert.ToDateTime(reader["dateOfTransac"]) : DateTime.MinValue,
                                    GrossSales = reader["grossSales"]?.ToString() ?? string.Empty,
                                };
                                dailyTreatmentList.Add(treatment);
                            }
                        }
                    }
                }

                allSalesGrdCtrl.DataSource = dailyTreatmentList;
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error loading data: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        private async void FilterSalesData_TextChanged(object sender, EventArgs e)
        {
            string connectionString = "server=localhost;uid=root;pwd=;database=sapmsdb";

            //string codeFilter = fltrCode.Text.Trim();
            //string dateFilter = fltrDate.Text.Trim();
            //string supplierFilter = fltrCusName.Text.Trim();  // ✅ New filter

            string query = @"
                SELECT id, code, customerName, grossSales, VatSales, outputSales, dateOfTransac
                FROM sales
                WHERE (@code IS NULL OR code LIKE CONCAT('%', @code, '%'))
                  AND (@date IS NULL OR DATE(dateOfTransac) = @date)
                  AND (@customerName IS NULL OR customerName LIKE CONCAT('%', @customerName, '%'));";

            using (MySqlConnection conn = new MySqlConnection(connectionString))
            {
                try
                {
                    await conn.OpenAsync();

                    using (MySqlCommand cmd = new MySqlCommand(query, conn))
                    {
                        cmd.Parameters.AddWithValue("@date", DateTime.TryParse(fltrDate.Text, out DateTime date) ? date : (object)DBNull.Value);
                        cmd.Parameters.AddWithValue("@customerName", string.IsNullOrWhiteSpace(fltrCusName.Text) ? (object)DBNull.Value : fltrCusName.Text.Trim());
                        //cmd.Parameters.AddWithValue("@tinNo", int.TryParse(fltrTinNo.Text, out int tin) ? tin : (object)DBNull.Value);
                        //cmd.Parameters.AddWithValue("@netOfVat", decimal.TryParse(fltrNetOfVat.Text, out decimal netVat) ? netVat : (object)DBNull.Value);
                        //cmd.Parameters.AddWithValue("@inputVat", decimal.TryParse(fltrInputVat.Text, out decimal inputVat) ? inputVat : (object)DBNull.Value);
                        //cmd.Parameters.AddWithValue("@grossPurchase", decimal.TryParse(fltrGrossPurchase.Text, out decimal gross) ? gross : (object)DBNull.Value);
                        cmd.Parameters.AddWithValue("@code", string.IsNullOrWhiteSpace(fltrCode.Text) ? (object)DBNull.Value : fltrCode.Text.Trim());

                        DataTable dt = new DataTable();
                        using (MySqlDataReader reader = (MySqlDataReader)await cmd.ExecuteReaderAsync())
                        {
                            dt.Load(reader);
                        }

                        allSalesGrdCtrl.DataSource = dt;
                        allSalesGrdCtrl.MainView.PopulateColumns();
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error filtering purchase data:\n" + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private void fltrCode_TextChanged(object sender, EventArgs e)
        {
            FilterSalesData_TextChanged(sender, e);
        }

        private void fltrCusName_TextChanged(object sender, EventArgs e)
        {
            FilterSalesData_TextChanged(sender, e);
        }

        private void fltrDate_TextChanged(object sender, EventArgs e)
        {
            FilterSalesData_TextChanged(sender, e);
        }

        private void clearbtn_Click(object sender, EventArgs e)
        {
            //create a clear method to reset the filters
            fltrCode.Text = string.Empty;
            fltrCusName.Text = string.Empty;
            fltrDate.Text = string.Empty;
        }
    }
}
