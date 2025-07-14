using DevExpress.XtraBars;
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
        public spDashboardFRM()
        {
            InitializeComponent();
        }

        private void spDashboardFRM_Load(object sender, EventArgs e)
        {

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
            OpenFormAsTab(new viewSalesFRM());
        }

        private void viewPurchase_ItemClick(object sender, ItemClickEventArgs e)
        {
            OpenFormAsTab(new viewPurchaseFRM());
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