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

namespace SAPMS
{
    public partial class dashboard : DevExpress.XtraBars.FluentDesignSystem.FluentDesignForm
    {
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
            List<ClientRecords> clientList = new List<ClientRecords>();

            string connectionString = "server=localhost;uid=root;pwd=;database=sapmsDB";

            using (MySqlConnection conn = new MySqlConnection(connectionString))
            {
                conn.Open();
                string query = "SELECT * FROM clientInformation";

                using (MySqlCommand cmd = new MySqlCommand(query, conn))
                using (MySqlDataReader reader = cmd.ExecuteReader())
                {
                    while (reader.Read())
                    {
                        clientList.Add(new ClientRecords
                        {
                            Name = reader["clientName"].ToString(),
                            BusinessAddress = reader["busAddress"].ToString(),
                            BusinessCode = reader["code"].ToString(),
                            BusinessName = reader["busName"].ToString(),
                            TaxtType = reader["taxType"].ToString(),
                            DateAdded = Convert.ToDateTime(reader["dateAdded"])
                        });
                    }
                }
            }
            clientsGrdCtrl.DataSource = clientList;
        }

        private void gridView1_RowCellClick(object sender, DevExpress.XtraGrid.Views.Grid.RowCellClickEventArgs e)
        {
            // proceed to another form 
            if (e.Clicks.Equals(2))
            {
                var selectedClient = gridView1.GetRow(e.RowHandle) as ClientRecords;
                if (selectedClient != null)
                {
                    // Open the client details form and pass the selected client data
                    spDashboardFRM detailsForm = new spDashboardFRM();
                    detailsForm.ShowDialog();
                }
            }
        }
    }
}
