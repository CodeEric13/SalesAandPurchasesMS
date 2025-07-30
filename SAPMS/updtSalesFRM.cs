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

namespace SAPMS
{
    public partial class updtSalesFRM : DevExpress.XtraEditors.XtraForm
    {
        SalesRercord _sales;
        public updtSalesFRM(SalesRercord sales)
        {
            InitializeComponent();
            _sales = sales;
        }

        private void updtSalesFRM_Load(object sender, EventArgs e)
        {
            // Initialize the form with the sales record data
            clientCode.Text = _sales.BusinessCode;
            cusName.Text = _sales.CustomerName;
            grossSales.Text = _sales.GrossSales;
            vatSales.Text = _sales.VatSales;
            outSales.Text = _sales.OutputSales;
            transacDate.EditValue = _sales.DateOfTransact;
        }

        private void updatebtn_Click(object sender, EventArgs e)
        {
            //using (var conn = new MySqlConnection(connectionString))
            //{
            //    conn.Open();
            //    string query = "UPDATE sales_table SET customerName = @CustomerName, grossSales = @GrossSales, VatSales = @VatSales, outputSales = @OutputSales, dateOfTransac = @Date WHERE code = @Code";

            //    using (var cmd = new MySqlCommand(query, conn))
            //    {
            //        cmd.Parameters.AddWithValue("@CustomerName", cusName.Text);
            //        cmd.Parameters.AddWithValue("@GrossSales", grossSales.Text);
            //        cmd.Parameters.AddWithValue("@VatSales", vatSales.Text);
            //        cmd.Parameters.AddWithValue("@OutputSales", outSales.Text);
            //        cmd.Parameters.AddWithValue("@Date", DateTime.Parse(transacDate.Text));
            //        cmd.Parameters.AddWithValue("@Code", clientCode.Text);

            //        cmd.ExecuteNonQuery();
            //        MessageBox.Show("Record updated successfully.");
            //    }
            //}
        }
    }
}