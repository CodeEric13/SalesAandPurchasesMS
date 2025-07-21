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
        public viewSalesFRM()
        {
            InitializeComponent();
        }

        private async void viewSalesFRM_Load(object sender, EventArgs e)
        {
            string query = @"SELECT 
                                id,
                                code,
                                dateOfTransac,
                                customerName,
                                VatSales,
                                outputSales,
                                grossSales
                            FROM sales";
            try
            {
                List<SalesRercord> dailyTreatmentList = new List<SalesRercord>();

                using (MySqlConnection connection = new MySqlConnection("server =localhost;uid=root;pwd=;database=sapmsDB"))
                {
                    await connection.OpenAsync();

                    using (MySqlCommand command = new MySqlCommand(query, connection))
                    using (MySqlDataReader reader = (MySqlDataReader)await command.ExecuteReaderAsync())
                    {
                        while (await reader.ReadAsync())
                        {
                            SalesRercord treatment = new SalesRercord
                            {
                                //SalesID = reader["id"] != DBNull.Value ? Convert.ToInt32(reader["id"]) : 0,
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

                // Bind the data to the GridControl
                viewSalesGrdCtrl.DataSource = dailyTreatmentList;

            //    // Format the Date of Consultation column
            //    GridView gridView = dailyTreatmentRprtGridCntrl.MainView as GridView;

            //    if (gridView != null)
            //    {
            //        gridView.Columns["DateofConsultation"].DisplayFormat.FormatType = DevExpress.Utils.FormatType.DateTime;
            //        gridView.Columns["DateofConsultation"].DisplayFormat.FormatString = "yyyy-MM-dd"; // Date-only format
            //    }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error loading data: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}