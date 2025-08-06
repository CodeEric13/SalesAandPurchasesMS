using DevExpress.XtraBars;
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
    public partial class spDashboardFRM : DevExpress.XtraBars.Ribbon.RibbonForm
    {
        private ClientRecords _clients;
        public spDashboardFRM(ClientRecords client)
        {
            _clients = client;
            InitializeComponent();
        }

        private void spDashboardFRM_Load(object sender, EventArgs e)
        {
            branchCode.Text = _clients.BusinessCode;
            tinNo.Text = _clients.TinNo;
            ClientSession.SelectedTIN = tinNo.Text; // Save it for use in child forms
            ClientSession.SelectedClientCode = branchCode.Text; // Save it for use in child forms
        }
        private void OpenFormAsTab(Form form)
        {
            // Check if the form is already open in a tab
            foreach (DevExpress.XtraBars.Docking2010.Views.BaseDocument doc in tabbedView1.Documents)
            {
                if (doc.Control.GetType() == form.GetType())
                {
                    tabbedView1.Controller.Activate(doc);
                    return;
                }
            }

            form.TopLevel = false;
            form.FormBorderStyle = FormBorderStyle.None;
            form.Dock = DockStyle.Fill;

            documentManager1.View.BeginUpdate();
            documentManager1.View.AddDocument(form);
            documentManager1.View.EndUpdate();

            form.Show();
        }
    
        private void newSales_ItemClick(object sender, EventArgs e)
        {
            OpenFormAsTab(new newSalesFRM());
        }

        private void viewSales_ItemClick(object sender, ItemClickEventArgs e)
        {
            var viewForm = new viewSalesFRM();
            viewForm.ClientCode = branchCode.Text;
            OpenFormAsTab(viewForm);
        }

        private void viewPurchase_ItemClick(object sender, ItemClickEventArgs e)
        {
            var viewForm = new viewPurchaseFRM();
            viewForm.ClientCode = branchCode.Text;
            OpenFormAsTab(viewForm);
        }

        private void newPurchse_ItemClick(object sender, ItemClickEventArgs e)
        {
            OpenFormAsTab(new newPurchaseFRM());
        }

        private void ribbon_Click(object sender, EventArgs e)
        {

        }
    }
}