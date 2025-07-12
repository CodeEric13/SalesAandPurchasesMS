using DevExpress.XtraBars;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace SAPMS
{
    public partial class dashboard : DevExpress.XtraBars.FluentDesignSystem.FluentDesignForm
    {
        public dashboard()
        {
            InitializeComponent();
            if (!mvvmContext1.IsDesignMode)
                InitializeBindings();
        }

        void InitializeBindings()
        {
            var fluent = mvvmContext1.OfType<MainViewModel>();
        }

        private void addClient_Click(object sender, EventArgs e)
        {
            addClientFRM mainForm = new addClientFRM();
            mainForm.Show();
            this.Show(); // Hide the login form
        }
    }
}
