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

namespace SAPMS
{
    public partial class updtSalesFRM : DevExpress.XtraEditors.XtraForm
    {
        SalesRercord _sales;
        DXErrorProvider dxErrorProvider;
        public updtSalesFRM(SalesRercord sales)
        {
            InitializeComponent();
            _sales = sales;
            dxErrorProvider = new DXErrorProvider();
        }

        private void updtSalesFRM_Load(object sender, EventArgs e)
        {
            // Initialize the form with the sales record data
            clientCode.Text = _sales.BusinessCode;
            cusName.Text = _sales.CustomerName;
            grossSales.Text = _sales.GrossSales;
            x12OutVat.Text = _sales.VatSales;
            x12VatSales.Text = _sales.OutputSales;
            transacDate.EditValue = _sales.DateOfTransact;
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

        private void updatebtn_Click(object sender, EventArgs e)
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
            using (var conn = new MySqlConnection(connectionString))
               
            {
                conn.Open();
                string query = "UPDATE sales SET customerName = @CustomerName, grossSales = @GrossSales, VatSales = @VatSales, outputSales = @OutputSales, dateOfTransac = @Date WHERE code = @Code";

                using (var cmd = new MySqlCommand(query, conn))
                {
                    cmd.Parameters.AddWithValue("@CustomerName", cusName.Text);
                    cmd.Parameters.AddWithValue("@GrossSales", grossSales.Text);
                    cmd.Parameters.AddWithValue("@VatSales", x12VatSales.Text);
                    cmd.Parameters.AddWithValue("@OutputSales", x12OutVat.Text);
                    cmd.Parameters.AddWithValue("@Date", DateTime.Parse(transacDate.Text));
                    cmd.Parameters.AddWithValue("@Code", clientCode.Text);

                    cmd.ExecuteNonQuery();
                    MessageBox.Show("Record updated successfully.");
                }
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