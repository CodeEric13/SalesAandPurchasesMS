using DevExpress.XtraEditors;
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
    public partial class newSalesFRM : DevExpress.XtraEditors.XtraForm
    {
        private ClientRecords _clients;
        private string _businessCode;
        public newSalesFRM(string businessCode)
        {
            InitializeComponent();
            _businessCode = businessCode;
        }
        public newSalesFRM(ClientRecords clients)
        {
            _clients = clients;
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

            if (decimal.TryParse(outSales.Text, out decimal outSalesValue))
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
            string connectionString = "server=localhost;uid=root;pwd=;database=sapmsdb";

            using (MySqlConnection conn = new MySqlConnection(connectionString))
            {
                try
                {
                    conn.Open();
                    string insertQuery = @"
                INSERT INTO sales (dateOfTransac,
                                   customerName,
                                   VatSales,
                                   outputSales,
                                   grossSales)

                           VALUES (@dateOfTransac,
                                   @customerName,
                                   @vatSales,
                                   @outputSales,
                                   @grossSales)";

                    using (MySqlCommand cmd = new MySqlCommand(insertQuery, conn))
                    {
                        cmd.Parameters.AddWithValue("@dateOfTransac", Convert.ToDateTime(transacDate.Text));
                        cmd.Parameters.AddWithValue("@customerName", cusName.Text.Trim().ToUpper());
                        cmd.Parameters.AddWithValue("@VatSales", Convert.ToDecimal(x12VatSales.Text));
                        cmd.Parameters.AddWithValue("@outputSales", Convert.ToDecimal(x12OutVat.Text));
                        cmd.Parameters.AddWithValue("@grossSales", Convert.ToDecimal(grossSales.Text));

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
            clientCode.Text = _businessCode;
        }

        private void vatSales_TextChanged(object sender, EventArgs e)
        {
            Calculate12PercentVAT();
        }

        private void outSales_TextChanged(object sender, EventArgs e)
        {
            Calculate12PercentVAT();
        }
    }
}