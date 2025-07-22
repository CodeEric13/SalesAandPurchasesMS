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

namespace SAPMS.Sales
{
    public partial class viewPurchaseFRM : DevExpress.XtraEditors.XtraForm
    {
        public viewPurchaseFRM()
        {
            InitializeComponent();
        }

        private void LoadPurchaseData()
        {
            string connectionString = "server=localhost;uid=root;pwd=;database=sapmsdb";

            using (MySqlConnection conn = new MySqlConnection(connectionString))
            {
                try
                {
                    conn.Open();
                    using (MySqlCommand cmd = new MySqlCommand("GetPurchaseRecord", conn))
                    {
                        cmd.CommandType = CommandType.StoredProcedure;

                        MySqlDataAdapter adapter = new MySqlDataAdapter(cmd);
                        DataTable dt = new DataTable();
                        adapter.Fill(dt);

                        purchaseGrdCtrl.DataSource = dt;
                    }
                }
                catch (MySqlException ex)
                {
                    MessageBox.Show("MySQL error: " + ex.Message, "Database Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }
        private void viewPurchaseFRM_Load(object sender, EventArgs e)
        {
            LoadPurchaseData();
        }

        private void refreshbtn_Click(object sender, EventArgs e)
        {
            LoadPurchaseData();
        }
    }
}