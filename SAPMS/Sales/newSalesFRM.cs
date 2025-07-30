using DevExpress.XtraEditors;
using DevExpress.XtraEditors.DXErrorProvider;
using MySql.Data.MySqlClient;
using MySqlX.XDevAPI;
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


    public partial class newSalesFRM : DevExpress.XtraEditors.XtraForm
    {
        // private ClientRecords _clients;
        private DXErrorProvider dxErrorProvider;
        public newSalesFRM() ///string businessCode
        {
            InitializeComponent();
            dxErrorProvider = new DXErrorProvider();
        }
        public newSalesFRM(ClientRecords clients)
        {
            //_clients = clients;
            InitializeComponent();
        }

        private void Calculate12PercentVAT()
        {
            if (decimal.TryParse(vatSales.Text, out decimal vatSalesValue))
            {
                decimal vatResult = vatSalesValue * 0.12m;
                x12VatSales.Text = vatResult.ToString("0.00");
            }
            else
            {
                x12VatSales.Text = "0.00";
            }

            if (decimal.TryParse(outVat.Text, out decimal outSalesValue))
            {
                decimal outVatResult = outSalesValue * 0.12m;
                x12OutVat.Text = outVatResult.ToString("0.00");
            }
            else
            {
                x12OutVat.Text = "0.00";
            }
        }

        private void savebtn_Click(object sender, EventArgs e)
        {
            dxErrorProvider.ClearErrors();
            bool hasError = false;

            if (string.IsNullOrWhiteSpace(transacDate.Text))
            {
                dxErrorProvider.SetError(transacDate, "Transaction date is required.");
                hasError = true;
            }

            if (string.IsNullOrWhiteSpace(cusName.Text))
            {
                dxErrorProvider.SetError(cusName, "Customer name is required.");
                hasError = true;
            }

            if (string.IsNullOrWhiteSpace(clientCode.Text))
            {
                dxErrorProvider.SetError(clientCode, "Client code is required.");
                hasError = true;
            }

            if (string.IsNullOrWhiteSpace(vatSales.Text))
            {
                dxErrorProvider.SetError(vatSales, "VAT Sales is required.");
                hasError = true;
            }

            if (string.IsNullOrWhiteSpace(outVat.Text))
            {
                dxErrorProvider.SetError(outVat, "Output VAT is required.");
                hasError = true;
            }

            if (string.IsNullOrWhiteSpace(grossSales.Text))
            {
                dxErrorProvider.SetError(grossSales, "Gross Sales is required.");
                hasError = true;
            }

            if (hasError)
            {
                return; // Don't proceed with saving if there's a validation error
            }

            string connectionString = "server=localhost;uid=root;pwd=;database=sapmsdb";
            string storedProcedure = "InsertSalesRecord";

            using (MySqlConnection conn = new MySqlConnection(connectionString))
            {
                try
                {
                    conn.Open();

                    using (MySqlCommand cmd = new MySqlCommand(storedProcedure, conn))
                    {
                        cmd.CommandType = CommandType.StoredProcedure;
                        cmd.Parameters.AddWithValue("@p_dateOfTransac", Convert.ToDateTime(transacDate.Text));
                        cmd.Parameters.AddWithValue("@p_customerName", cusName.Text.Trim().ToUpper());
                        cmd.Parameters.AddWithValue("@p_code", clientCode.Text.Trim().ToUpper());
                        cmd.Parameters.AddWithValue("@p_VatSales", Convert.ToDecimal(x12VatSales.Text));
                        cmd.Parameters.AddWithValue("@p_outputSales", Convert.ToDecimal(x12OutVat.Text));
                        cmd.Parameters.AddWithValue("@p_grossSales", Convert.ToDecimal(grossSales.Text));

                        cmd.ExecuteNonQuery();
                        MessageBox.Show("Sales record saved successfully.", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                }
                catch (MySqlException ex)
                {
                    MessageBox.Show("MySQL error: " + ex.Message, "Database Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                catch (FormatException)
                {
                    MessageBox.Show("Please enter valid numeric values for sales fields and a valid date.", "Input Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
            }
        }

        private void newSalesFRM_Load(object sender, EventArgs e)
        {
            if (!string.IsNullOrEmpty(ClientSession.SelectedClientCode))
            {
                clientCode.Text = ClientSession.SelectedClientCode;
            }
        }

        private void x12VatSales_TextChanged(object sender, EventArgs e)
        {
            Calculate12PercentVAT();
        }

        private void x12OutVat_TextChanged(object sender, EventArgs e)
        {
            Calculate12PercentVAT();
        }
    }
}