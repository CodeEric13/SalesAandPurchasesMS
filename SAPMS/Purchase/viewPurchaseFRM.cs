using DevExpress.XtraEditors;
using Google.Protobuf.WellKnownTypes;
using MySql.Data.MySqlClient;
using SAPMS.Classes;
using SAPMS.Purchase;
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
        public string ClientCode
        {
            get => branchCode.Text;
            set => branchCode.Text = value;
        }

        public viewPurchaseFRM()
        {
            InitializeComponent();
        }
        public viewPurchaseFRM(string clientCodeText)
        {
            InitializeComponent();
            branchCode.Text = clientCodeText;
        }

        private void LoadPurchaseData()
        {
            string connectionString = "server=localhost;uid=root;pwd=;database=sapmsdb";

            using (MySqlConnection conn = new MySqlConnection(connectionString))
            {
                try
                {
                    conn.Open();
                    using (MySqlCommand cmd = new MySqlCommand("GetPurchaseRecordsByClientCode", conn))
                    {
                        cmd.CommandType = CommandType.StoredProcedure;

                        // Pass clientCode from the TextBox to the stored procedure
                        cmd.Parameters.AddWithValue("@p_clientCode", branchCode.Text.Trim());
 
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

        private void gridView1_RowCellClick(object sender, DevExpress.XtraGrid.Views.Grid.RowCellClickEventArgs e)
        {
            if (e.Clicks.Equals(2))
            {
                var purchase = new PurchaseRecord()
                {
                    PurchaseID = Convert.ToInt32(gridView1.GetRowCellValue(e.RowHandle, "id") ?? 0),
                    Tin = Convert.ToInt32(gridView1.GetRowCellValue(e.RowHandle, "TinNo") ?? 0),
                    SupplierName = gridView1.GetRowCellValue(e.RowHandle, "supplier")?.ToString() ?? "",
                    GrossPurchase = Convert.ToDecimal(gridView1.GetRowCellValue(e.RowHandle, "grossPurchase") ?? 0),
                    NetOfVat = Convert.ToDecimal(gridView1.GetRowCellValue(e.RowHandle, "netOfVat") ?? 0),
                    InputVat = Convert.ToDecimal(gridView1.GetRowCellValue(e.RowHandle, "inputVat") ?? 0),
                    DateOfTransact = DateTime.TryParse(gridView1.GetRowCellValue(e.RowHandle, "dateOfTransac")?.ToString(), out DateTime result)
                        ? result
                        : DateTime.MinValue
                };

                var updatePurchase = new updtPurchaseFRM(purchase);
                updatePurchase.ShowDialog();
            }
        }
    }
}