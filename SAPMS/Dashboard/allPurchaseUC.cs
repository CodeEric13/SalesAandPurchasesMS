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
    }
}