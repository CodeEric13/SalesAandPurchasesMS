using DevExpress.Utils.About;
using DevExpress.XtraEditors;
using DevExpress.XtraEditors.DXErrorProvider;
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

namespace SAPMS.Sales
{
    public partial class newPurchaseFRM : DevExpress.XtraEditors.XtraForm
    {
        private DXErrorProvider dxErrorProvider;
        public newPurchaseFRM()
        {
            InitializeComponent();
            dxErrorProvider = new DXErrorProvider();
            transacDate.EditValue = DateTime.Today; // Set default date to today
        }

        private void savebtn_Click(object sender, EventArgs e)
        {
            dxErrorProvider.ClearErrors();

            bool hasError = false;

            // Validate Date
            if (string.IsNullOrWhiteSpace(transacDate.Text))
            {
                dxErrorProvider.SetError(transacDate, "Transaction date is required.");
                hasError = true;
            }

            if (string.IsNullOrWhiteSpace(supplier.Text))
            {
                dxErrorProvider.SetError(supplier, "Supplier is required.");
                hasError = true;
            }

            if (string.IsNullOrWhiteSpace(TIN.Text))
            {
                dxErrorProvider.SetError(TIN, "TIN number is required.");
                hasError = true;
            }

            if (string.IsNullOrWhiteSpace(netOfVat.Text))
            {
                dxErrorProvider.SetError(netOfVat, "Net of VAT is required.");
                hasError = true;
            }

            if (string.IsNullOrWhiteSpace(inputVat.Text))
            {
                dxErrorProvider.SetError(inputVat, "Input VAT is required.");
                hasError = true;
            }

            if (string.IsNullOrWhiteSpace(clientCode.Text))
            {
                dxErrorProvider.SetError(clientCode, "Client code is required.");
                hasError = true;
            }

            if (string.IsNullOrWhiteSpace(grossPurchase.Text))
            {
                dxErrorProvider.SetError(grossPurchase, "Gross purchase is required.");
                hasError = true;
            }

            if (hasError)
            {
                return; // Stop saving if any required textbox is empty
            }

            string connectionString = "server=localhost;uid=root;pwd=;database=sapmsdb";
            string storedProcedure = "InsertPurchaseRecord";

            using (MySqlConnection conn = new MySqlConnection(connectionString))
            {
                try
                {
                    conn.Open();

                    using (MySqlCommand cmd = new MySqlCommand(storedProcedure, conn))
                    {
                        cmd.CommandType = CommandType.StoredProcedure;

                        cmd.Parameters.AddWithValue("@p_dateOfTransac", Convert.ToDateTime(transacDate.Text));
                        cmd.Parameters.AddWithValue("@p_supplier", supplier.Text.Trim().ToUpper());
                        cmd.Parameters.AddWithValue("@p_TinNo", Convert.ToInt32(TIN.Text));
                        cmd.Parameters.AddWithValue("@p_netOfVat", Convert.ToInt32(netOfVat.Text));
                        cmd.Parameters.AddWithValue("@p_inputVat", Convert.ToInt32(inputVat.Text));
                        cmd.Parameters.AddWithValue("@p_code", clientCode.Text.Trim().ToUpper());
                        cmd.Parameters.AddWithValue("@p_grossPurchase", Convert.ToInt32(grossPurchase.Text));

                        cmd.ExecuteNonQuery();

                        MessageBox.Show("Purchase record saved successfully.", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        
                        
                    }
                }
                catch (MySqlException ex)
                {
                    MessageBox.Show("MySQL error: " + ex.Message, "Database Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                catch (FormatException)
                {
                    MessageBox.Show("Please enter valid input values.", "Input Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
            }
        }

        private void newPurchaseFRM_Load(object sender, EventArgs e)
        {
            if (!string.IsNullOrEmpty(ClientSession.SelectedTIN))
            {
                clientCode.Text = ClientSession.SelectedTIN;
            }
        }
    }
}