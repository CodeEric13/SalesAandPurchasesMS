using DevExpress.Xpo.DB.Helpers;
using DevExpress.XtraEditors;
using DevExpress.XtraGrid.Views.Grid;
using MySql.Data.MySqlClient;
using SAPMS.Classes;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SAPMS
{
    public partial class viewSalesFRM : DevExpress.XtraEditors.XtraForm
    {
        public string ClientCodeText
        {
            get => clientCode.Text;
            set => clientCode.Text = value;
        }
        public viewSalesFRM()
        {
            InitializeComponent();
        }

        public viewSalesFRM(string clientCodeText)
        {
            InitializeComponent();
            clientCode.Text = clientCodeText;
        }

        private async void viewSalesFRM_Load(object sender, EventArgs e)
        {
            string storedProcedure = "GetSalesRecordsByClientCode";

            try
            {
                using (MySqlConnection connection = new MySqlConnection("server=localhost;uid=root;pwd=;database=sapmsdb"))
                {
                    await connection.OpenAsync();

                    using (MySqlCommand command = new MySqlCommand(storedProcedure, connection))
                    {
                        command.CommandType = CommandType.StoredProcedure;
                        command.Parameters.AddWithValue("@p_clientCode", clientCode.Text.Trim());

                        using (MySqlDataAdapter adapter = new MySqlDataAdapter(command))
                        {
                            DataTable dt = new DataTable();
                            adapter.Fill(dt);
                            viewSalesGrdCtrl.DataSource = dt;

                            // Optional: refresh view
                            viewSalesGrdCtrl.Refresh();
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error loading data: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

            //LoadSalesData();
        }

        private async void LoadSalesData()
        {
            //string storedProcedure = "GetSalesRecordsByClientCode";

            //try
            //{
            //    List<SalesRercord> dailyTreatmentList = new List<SalesRercord>();

            //    using (MySqlConnection connection = new MySqlConnection("server=localhost;uid=root;pwd=;database=sapmsDB"))
            //    {
            //        await connection.OpenAsync();

            //        using (MySqlCommand command = new MySqlCommand(storedProcedure, connection))
            //        {
            //            command.CommandType = CommandType.StoredProcedure;

            //            // 👇 Pass the value of the clientCode textbox
            //            command.Parameters.AddWithValue("@p_clientCode", clientCode.Text.Trim());

            //            using (MySqlDataReader reader = (MySqlDataReader)await command.ExecuteReaderAsync())
            //            {
            //                while (await reader.ReadAsync())
            //                {
            //                    SalesRercord treatment = new SalesRercord
            //                    {
            //                        BusinessCode = reader["code"]?.ToString() ?? string.Empty,
            //                        CustomerName = reader["customerName"]?.ToString() ?? string.Empty,
            //                        VatSales = reader["VatSales"]?.ToString() ?? string.Empty,
            //                        OutputSales = reader["outputSales"]?.ToString() ?? string.Empty,
            //                        DateOfTransact = reader["dateOfTransac"] != DBNull.Value ? Convert.ToDateTime(reader["dateOfTransac"]) : DateTime.MinValue,
            //                        GrossSales = reader["grossSales"]?.ToString() ?? string.Empty,
            //                    };
            //                    dailyTreatmentList.Add(treatment);
            //                }
            //            }
            //        }
            //    }

            //    viewSalesGrdCtrl.DataSource = dailyTreatmentList;
            //}
            //catch (Exception ex)
            //{
            //    MessageBox.Show($"Error loading data: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            //}
        }
        private void refreshbtn_Click(object sender, EventArgs e)
        {
            LoadSalesData();
        }

        private void gridView1_RowCellClick_1(object sender, RowCellClickEventArgs e)
        {
            if (e.Clicks.Equals(2))
            {
                var sales = new SalesRercord()
                {
                    BusinessCode = gridView1.GetRowCellValue(e.RowHandle, "code")?.ToString() ?? "",
                    CustomerName = gridView1.GetRowCellValue(e.RowHandle, "customerName")?.ToString() ?? "",
                    GrossSales = gridView1.GetRowCellValue(e.RowHandle, "grossSales")?.ToString() ?? "",
                    VatSales = gridView1.GetRowCellValue(e.RowHandle, "VatSales")?.ToString() ?? "",
                    OutputSales = gridView1.GetRowCellValue(e.RowHandle, "outputSales")?.ToString() ?? "",
                    DateOfTransact = DateTime.TryParse(gridView1.GetRowCellValue(e.RowHandle, "dateOfTransac")?.ToString(), out DateTime result)
                        ? result
                        : DateTime.MinValue
                };

                var updtSales = new updtSalesFRM(sales);
                updtSales.ShowDialog();
            }
        }
    }
}