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
    }
}
