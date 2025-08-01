using DevExpress.XtraEditors;
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
using DevExpress.XtraEditors.DXErrorProvider;
using MySql.Data.MySqlClient;

namespace SAPMS.Purchase
{
    public partial class updtPurchaseFRM : DevExpress.XtraEditors.XtraForm
    {
        PurchaseRecord _purchase;
        DXErrorProvider dxErrorProvider;
        public updtPurchaseFRM(PurchaseRecord purchase)
        {
            InitializeComponent();
            _purchase = purchase;
            dxErrorProvider = new DXErrorProvider();
        }

        private void updtPurchaseFRM_Load(object sender, EventArgs e)
        {
            // Initialize the form with the sales record data
            purchaseID.Text = _purchase.PurchaseID.ToString();
            TIN.Text = _purchase.Tin.ToString();
            supplier.Text = _purchase.SupplierName;
            grossPurchase.Text = _purchase.GrossPurchase.ToString("N2");
            inputVat.Text = _purchase.InputVat.ToString("N2");
            netOfVat.Text = _purchase.NetOfVat.ToString("N2");
            transacDate.EditValue = _purchase.DateOfTransact;
        }

        private void updatebtn_Click(object sender, EventArgs e)
        {
            dxErrorProvider.ClearErrors();
            bool hasError = false;
            if (string.IsNullOrWhiteSpace(transacDate.Text))
            {
                dxErrorProvider.SetError(transacDate, "Transaction date is required.");
                hasError = true;
            }
            if (string.IsNullOrWhiteSpace(supplier.Text))
            {
                dxErrorProvider.SetError(supplier, "Supplier name is required.");
                hasError = true;
            }
            if (string.IsNullOrWhiteSpace(purchaseID.Text))
            {
                dxErrorProvider.SetError(purchaseID, "Purchase ID is required.");
                hasError = true;
            }
            if (string.IsNullOrWhiteSpace(TIN.Text) || !int.TryParse(TIN.Text, out _))
            {
                dxErrorProvider.SetError(TIN, "Valid TIN is required.");
                hasError = true;
            }
            if (string.IsNullOrWhiteSpace(grossPurchase.Text) || !decimal.TryParse(grossPurchase.Text, out _))
            {
                dxErrorProvider.SetError(grossPurchase, "Valid gross purchase amount is required.");
                hasError = true;
            }
            if (string.IsNullOrWhiteSpace(inputVat.Text) || !decimal.TryParse(inputVat.Text, out _))
            {
                dxErrorProvider.SetError(inputVat, "Valid input VAT amount is required.");
                hasError = true;
            }
            if (string.IsNullOrWhiteSpace(netOfVat.Text) || !decimal.TryParse(netOfVat.Text, out _))
            {
                dxErrorProvider.SetError(netOfVat, "Valid net of VAT amount is required.");
                hasError = true;
            }
            if (hasError)
            {
                MessageBox.Show("Please correct the errors before updating.", "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            string connectionString = "server=localhost;uid=root;pwd=;database=sapmsDB";

            using (var conn = new MySqlConnection(connectionString))
            {
                conn.Open();

                string query = @"UPDATE purchase
                         SET dateOfTransac = @dateOfTransac, 
                             supplier = @supplier, 
                             TinNo = @TinNo, 
                             netOfVat = @netOfVat, 
                             inputVat = @inputVat, 
                             grossPurchase = @grossPurchase 
                         WHERE id = @id";

                using (var cmd = new MySqlCommand(query, conn))
                {
                    cmd.Parameters.AddWithValue("@dateOfTransac", DateTime.Parse(transacDate.Text));
                    cmd.Parameters.AddWithValue("@supplier", supplier.Text);
                    cmd.Parameters.AddWithValue("@TinNo", TIN.Text);
                    cmd.Parameters.AddWithValue("@netOfVat", decimal.Parse(netOfVat.Text));
                    cmd.Parameters.AddWithValue("@inputVat", decimal.Parse(inputVat.Text));
                    cmd.Parameters.AddWithValue("@grossPurchase", decimal.Parse(grossPurchase.Text));
                    cmd.Parameters.AddWithValue("@id", int.Parse(purchaseID.Text));

                    cmd.ExecuteNonQuery();
                }

                MessageBox.Show("Purchase record updated successfully.");
            }
        }
    }
} 