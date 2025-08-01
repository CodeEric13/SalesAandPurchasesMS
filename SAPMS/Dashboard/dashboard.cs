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
using SAPMS.Dashboard;

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
            // Clear the content panel
            contentPanel.Controls.Clear();

            // Create an instance of the medInventoryUC
            allClientsUC medTreatment = new allClientsUC();
            medTreatment.Dock = DockStyle.Fill;

            // Add the new user control to the content panel
            contentPanel.Controls.Add(medTreatment);
        }

        private void allSalesbtn_Click(object sender, EventArgs e)
        {
            // Clear the content panel
            contentPanel.Controls.Clear();

            // Create an instance of the medInventoryUC
            allSalesUC medTreatment = new allSalesUC();
            medTreatment.Dock = DockStyle.Fill;

            // Add the new user control to the content panel
            contentPanel.Controls.Add(medTreatment);
        }

        private void allClientsbtn_Click(object sender, EventArgs e)
        {
            // Clear the content panel
            contentPanel.Controls.Clear();

            // Create an instance of the medInventoryUC
            allClientsUC medTreatment = new allClientsUC();
            medTreatment.Dock = DockStyle.Fill;

            // Add the new user control to the content panel
            contentPanel.Controls.Add(medTreatment);
        }
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
        