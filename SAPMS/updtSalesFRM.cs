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
            salesID.Text = _sales.SalesID.ToString();
            cusName.Text = _sales.CustomerName;
            grossSales.Text = _sales.GrossSales;
            x12OutVat.Text = _sales.VatSales;
            x12VatSales.Text = _sales.OutputSales;
            transacDate.EditValue = _sales.DateOfTransact;
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

            if (string.IsNullOrWhiteSpace(salesID.Text))
            {
                dxErrorProvider.SetError(salesID, "Client code is required.");
                hasError = true;
            }

            //if (string.IsNullOrWhiteSpace(vatSales.Text))
            //{
            //    dxErrorProvider.SetError(vatSales, "VAT Sales is required.");
            //    hasError = true;
            //}

            //if (string.IsNullOrWhiteSpace(outVat.Text))
            //{
            //    dxErrorProvider.SetError(outVat, "Output VAT is required.");
            //    hasError = true;
            //}

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
                try
                {
                    conn.Open();
                    string query = "UPDATE sales SET customerName = @CustomerName, grossSales = @GrossSales, VatSales = @VatSales, outputSales = @OutputSales, dateOfTransac = @Date WHERE id = @id";

                    using (var cmd = new MySqlCommand(query, conn))
                    {
                        cmd.Parameters.AddWithValue("@CustomerName", cusName.Text);
                        cmd.Parameters.AddWithValue("@GrossSales", decimal.Parse(grossSales.Text));
                        cmd.Parameters.AddWithValue("@VatSales", decimal.Parse(x12VatSales.Text));
                        cmd.Parameters.AddWithValue("@OutputSales", decimal.Parse(x12OutVat.Text));
                        cmd.Parameters.AddWithValue("@Date", DateTime.Parse(transacDate.Text));
                        cmd.Parameters.AddWithValue("@id", salesID.Text);

                        cmd.ExecuteNonQuery();
                        MessageBox.Show("Record updated successfully.");
                    }
                }
                catch (MySqlException ex)
                {
                    MessageBox.Show("MySQL error: " + ex.Message, "Database Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private void vatSales_TextChanged(object sender, EventArgs e)
        {
            if (decimal.TryParse(vatSales.Text, out decimal value))
            {
                x12VatSales.Text = (value * 0.12m).ToString("0.00");
            }
            else
            {
                x12VatSales.Text = "0.00";
            }
        }

        private void outVat_TextChanged(object sender, EventArgs e)
        {
            if (decimal.TryParse(outVat.Text, out decimal value))
            {
                x12OutVat.Text = (value * 0.12m).ToString("0.00");
            }
            else
            {
                x12OutVat.Text = "0.00";
            }
        }

        private void labelControl8_Click(object sender, EventArgs e)
        {

        }
    }
}