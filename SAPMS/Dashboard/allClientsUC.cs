using DevExpress.XtraEditors;
using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using SAPMS.Classes;
using SAPMS.Sales;


namespace SAPMS.Dashboard
{
    public partial class allClientsUC : DevExpress.XtraEditors.XtraUserControl
    {
        public allClientsUC()
        {
            InitializeComponent();
        }

        private void allClientsUC_Load(object sender, EventArgs e)
        {
            string storedProcedure = "GetClientRecord";

            try
            {
                string myConnectionString = "server=localhost;uid=root;pwd=;database=sapmsDb";

                using (MySqlConnection connection = new MySqlConnection(myConnectionString))
                {
                    connection.Open();

                    using (MySqlCommand cmd = new MySqlCommand(storedProcedure, connection))
                    {
                        cmd.CommandType = CommandType.StoredProcedure;

                        using (MySqlDataAdapter adapter = new MySqlDataAdapter(cmd))
                        {
                            DataTable dataTable = new DataTable();
                            adapter.Fill(dataTable);

                            if (dataTable.Rows.Count > 0)
                            {
                                allClientsGrdCtrl.DataSource = dataTable;
                                //clientsGrdCtrl.ForceInitialize();
                                gridView1.PopulateColumns();
                                gridView1.BestFitColumns();

                                // Auto adjust column widths to fit content
                                gridView1.BestFitColumns();
                            }
                            else
                            {
                                XtraMessageBox.Show("No data found in the table.", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
                            }
                        }
                    }
                }
            }
            catch (MySqlException ex)
            {
                XtraMessageBox.Show("An error occurred: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        //private void gridView1_RowCellClick(object sender, DevExpress.XtraGrid.Views.Grid.RowCellClickEventArgs e)
        //{
        //    if (e.Clicks == 2 && e.RowHandle >= 0)
        //    {
        //        var client = new ClientRecords()
        //        {
        //            TinNo = gridView1.GetRowCellValue(e.RowHandle, "tinNo").ToString()
        //        };
        //        var sales = new spDashboardFRM(client);
        //        sales.ShowDialog();
        //    }
        //}

        private void allClientsGrdCtrl_Click(object sender, EventArgs e)
        {

        }

        private void gridView1_RowCellClick(object sender, DevExpress.XtraGrid.Views.Grid.RowCellClickEventArgs e)
        {
            if (e.Clicks == 2 && e.RowHandle >= 0)
            {
                var client = new ClientRecords()
                {
                    TinNo = gridView1.GetRowCellValue(e.RowHandle, "tinNo").ToString(),
                    BusinessCode = gridView1.GetRowCellValue(e.RowHandle, "code").ToString()

                };
                var sales = new spDashboardFRM(client);
                sales.ShowDialog();
            }
        }

        private void allClientsGrdCtrl_Click_1(object sender, EventArgs e)
        {

        }
    }
}
