using DevExpress.XtraBars;
using MySql.Data.MySqlClient;
using MySqlX.XDevAPI;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using SAPMS.Classes;
using SAPMS.Sales;
using DevExpress.XtraEditors;

namespace SAPMS
{
    public partial class dashboard : DevExpress.XtraBars.FluentDesignSystem.FluentDesignForm
    {
        //private ClientRecords _clients;
        public dashboard()
        {
            InitializeComponent();
            if (!mvvmContext1.IsDesignMode)
                InitializeBindings();
        }

        void InitializeBindings()
        {
            var fluent = mvvmContext1.OfType<MainViewModel>();
        }

        private void addClient_Click(object sender, EventArgs e)
        {
            addClientFRM mainForm = new addClientFRM();
            mainForm.Show();
            this.Show(); // Hide the login form
        }

        private void dashboard_Load(object sender, EventArgs e)
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
                                clientsGrdCtrl.DataSource = dataTable;
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




            //List<ClientRecords> clientList = new List<ClientRecords>();

            //string connectionString = "server=localhost;uid=root;pwd=;database=sapmsDB";

            //using (MySqlConnection conn = new MySqlConnection(connectionString))
            //{
            //    conn.Open();
            //    string query = "SELECT clientName, busAddress, code, busName, taxType, dateAdded FROM clientInformation";

            //    using (MySqlCommand cmd = new MySqlCommand(query, conn))
            //    using (MySqlDataReader reader = cmd.ExecuteReader())
            //    {
            //        while (reader.Read())
            //        {
            //            clientList.Add(new ClientRecords
            //            {
            //                Name = reader["clientName"].ToString(),
            //                BusinessAddress = reader["busAddress"].ToString(),
            //                BusinessCode = reader["code"].ToString(),
            //                BusinessName = reader["busName"].ToString(),
            //                TaxType = reader["taxType"] == DBNull.Value ? "" : reader["taxType"].ToString(),
            //                DateAdded = Convert.ToDateTime(reader["dateAdded"])
            //            });
            //        }
            //    }
            //}
            //clientsGrdCtrl.DataSource = clientList;


            private void gridView1_RowCellClick(object sender, DevExpress.XtraGrid.Views.Grid.RowCellClickEventArgs e)
        {

            if (e.Clicks == 2 && e.RowHandle >= 0)
            {
                var client = new ClientRecords()
                {
                    BusinessCode = gridView1.GetRowCellValue(e.RowHandle, "code").ToString()
                };
                var sales = new spDashboardFRM(client);
                sales.ShowDialog();


                //if (e.Clicks == 2 && e.RowHandle >= 0)
                //{
                //    object codeObj = gridView1.GetRowCellValue(e.RowHandle, "code");
                //    string code = (codeObj != null && !Convert.IsDBNull(codeObj)) ? codeObj.ToString() : string.Empty;

                //    var client = new ClientRecords()
                //    {
                //        BusinessCode = code
                //    };

                //    var sales = new newSalesFRM(client);
                //    sales.ShowDialog();
                //}
            }
        }

        private void fluentDesignFormControl1_Click(object sender, EventArgs e)
        {

        }

        private void fluentDesignFormControl1_Click_1(object sender, EventArgs e)
        {

        }
    }
}
        