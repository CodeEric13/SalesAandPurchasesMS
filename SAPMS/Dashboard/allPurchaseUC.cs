using DevExpress.XtraEditors;
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

namespace SAPMS.Dashboard
{
    public partial class allPurchaseUC : DevExpress.XtraEditors.XtraUserControl
    {
        public allPurchaseUC()
        {
            InitializeComponent();
        }

        private async void allPurchaseUC_Load(object sender, EventArgs e)
        {
            string storedProcedure = "GetPurchaseRecord";

            try
            {
                List<PurchaseRecord> purchaseRec = new List<PurchaseRecord>();

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
                                PurchaseRecord purchase = new PurchaseRecord
                                {
                                    PurchaseID = reader["id"] != DBNull.Value ? Convert.ToInt32(reader["id"]) : 0,
                                    Code = reader["code"]?.ToString() ?? string.Empty,
                                    Tin = reader["TinNo"] != DBNull.Value ? Convert.ToInt32(reader["TinNo"]) : 0,
                                    SupplierName = reader["supplier"]?.ToString() ?? string.Empty,
                                    GrossPurchase = reader["grossPurchase"] != DBNull.Value ? Convert.ToDecimal(reader["grossPurchase"]) : 0m,
                                    NetOfVat = reader["netOfVat"] != DBNull.Value ? Convert.ToDecimal(reader["netOfVat"]) : 0m,
                                    InputVat = reader["inputVat"] != DBNull.Value ? Convert.ToDecimal(reader["inputVat"]) : 0m,
                                    DateOfTransact = reader["dateOfTransac"] != DBNull.Value ? Convert.ToDateTime(reader["dateOfTransac"]) : DateTime.MinValue
                                };
                                purchaseRec.Add(purchase);
                            }
                        }
                    }
                }

                allPurchaseGrdCtrl.DataSource = purchaseRec;
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error loading data: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        private async void FilterPurchaseData_TextChanged(object sender, EventArgs e)
        {
            string connectionString = "server=localhost;uid=root;pwd=;database=sapmsdb";

            string query = @"
        SELECT 
            id,code,TinNo,supplier,grossPurchase,netOfVat,inputVat,dateOfTransac
            
        FROM purchase
        WHERE (@date IS NULL OR DATE(dateOfTransac) = @date)
          AND (@supplier IS NULL OR supplier LIKE CONCAT('%', @supplier, '%'))
          AND (@code IS NULL OR code LIKE CONCAT('%', @code, '%'));";

            using (MySqlConnection conn = new MySqlConnection(connectionString))
            {
                try
                {
                    await conn.OpenAsync();

                    using (MySqlCommand cmd = new MySqlCommand(query, conn))
                    {
                        cmd.Parameters.AddWithValue("@date", DateTime.TryParse(fltrDate.Text, out DateTime date) ? date : (object)DBNull.Value);
                        cmd.Parameters.AddWithValue("@supplier", string.IsNullOrWhiteSpace(fltrSupplier.Text) ? (object)DBNull.Value : fltrSupplier.Text.Trim());
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

                        allPurchaseGrdCtrl.DataSource = dt;
                        allPurchaseGrdCtrl.MainView.PopulateColumns();
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error filtering purchase data:\n" + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        //private async void FilterData_TextChanged(object sender, EventArgs e)
        //{
        
        ////    string codeFilter = fltrCode.Text.Trim();
        ////    string dateFilter = fltrDate.Text.Trim();
        ////    string supplierFilter = fltrSupplier.Text.Trim();  // ✅ New filter

        ////    string query = @"
        ////SELECT code, customerName, VatSales, outputSales, dateOfTransac, grossSales
        ////FROM sales
        ////WHERE (@code IS NULL OR code LIKE CONCAT('%', @code, '%'))
        ////  AND (@date IS NULL OR DATE(dateOfTransac) = @date)
        ////  AND (@supplier IS NULL OR customerName LIKE CONCAT('%', @supplier, '%'));";

        ////    using (MySqlConnection conn = new MySqlConnection("server=localhost;uid=root;pwd=;database=sapmsdb"))
        ////    {
        ////        try
        ////        {
        ////            await conn.OpenAsync();
        ////            using (MySqlCommand cmd = new MySqlCommand(query, conn))
        ////            {
        ////                cmd.Parameters.AddWithValue("@code", string.IsNullOrWhiteSpace(codeFilter) ? (object)DBNull.Value : codeFilter);

        ////                if (DateTime.TryParse(dateFilter, out DateTime parsedDate))
        ////                    cmd.Parameters.AddWithValue("@date", parsedDate.Date);
        ////                else
        ////                    cmd.Parameters.AddWithValue("@date", DBNull.Value);

        ////                cmd.Parameters.AddWithValue("@supplier", string.IsNullOrWhiteSpace(supplierFilter) ? (object)DBNull.Value : supplierFilter);

        ////                DataTable dt = new DataTable();
        ////                using (MySqlDataReader reader = (MySqlDataReader)await cmd.ExecuteReaderAsync())
        ////                {
        ////                    dt.Load(reader);
        ////                }

        ////                allPurchaseGrdCtrl.DataSource = dt;
        ////                allPurchaseGrdCtrl.MainView.PopulateColumns();
        ////            }
        ////        }
        ////        catch (Exception ex)
        ////        {
        ////            MessageBox.Show($"Error filtering data: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
        ////        }
        ////    }
        //}

        private void fltrCode_TextChanged_1(object sender, EventArgs e)
        {
            FilterPurchaseData_TextChanged(sender, e);
        }

        private void fltrDate_TextChanged_1(object sender, EventArgs e)
        {
            FilterPurchaseData_TextChanged(sender, e);
        }

        private void fltrSupplier_TextChanged(object sender, EventArgs e)
        {
            FilterPurchaseData_TextChanged(sender, e);
        }
    }
}