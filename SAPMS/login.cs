using DevExpress.XtraEditors;
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
    public partial class login : DevExpress.XtraEditors.XtraForm
    {
        public login()
        {
            InitializeComponent();
        }

        private void labelControl1_Click(object sender, EventArgs e)
        {

        }

        private void loginbtn_Click(object sender, EventArgs e)
        {
                // Open the main form
                Dashboard mainForm = new Dashboard ();
                mainForm.Show();
                this.Hide(); // Hide the login form
        }
    }
}