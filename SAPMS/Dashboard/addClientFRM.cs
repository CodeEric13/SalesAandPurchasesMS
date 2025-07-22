using DevExpress.XtraEditors.DXErrorProvider;
using DevExpress.XtraSplashScreen;
using System;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;
using MySql.Data.MySqlClient;

namespace SAPMS
{
    public partial class addClientFRM : DevExpress.XtraEditors.XtraForm
    {
        private DXErrorProvider dxErrorProvider;
        public addClientFRM()
        {
            InitializeComponent();
            dxErrorProvider = new DXErrorProvider();
            dateAdded.EditValue = DateTime.Today;
        }

        private async void savebtn_Click(object sender, EventArgs e)
        {
            dxErrorProvider.ClearErrors();

            bool hasError = false;
            if (string.IsNullOrWhiteSpace(clientName.Text))
            {
                dxErrorProvider.SetError(clientName, "Client Name is required.");
                hasError = true;
            }
            if (string.IsNullOrWhiteSpace(busName.Text))
            {
                dxErrorProvider.SetError(busName, "Business Address is required.");
                hasError = true;
            }
            if (string.IsNullOrWhiteSpace(taxTypecmb.Text))
            {
                dxErrorProvider.SetError(taxTypecmb, "Tax Type is required.");
                hasError = true;
            }
            if (string.IsNullOrWhiteSpace(bCode.Text))
            {
                dxErrorProvider.SetError(bCode, "Business Address is required.");
                hasError = true;
            }
            if (string.IsNullOrWhiteSpace(busAddress.Text))
            {
                dxErrorProvider.SetError(busAddress, "Tax Type is required.");
                hasError = true;
            }
            if (hasError)
            {
                return; // Do not proceed with saving if there are validation errors
            }

            try
            {
                string admittedDateText = ((DateTime)dateAdded.EditValue).ToString("yyyy-MM-dd");
                //SplashScreenManager.ShowForm(this, typeof(loadingScrn), true, true, false);

                string myConnectionString = "server=localhost;uid=root;pwd=;database=sapmsDB";
                using (MySqlConnection connection = new MySqlConnection(myConnectionString))
                {
                    await connection.OpenAsync();

                    string duplicateCheckQuery = @"
                    SELECT COUNT(*) 
                    FROM clientInformation 
                    WHERE code = @code";

                    using (MySqlCommand duplicateCmd = new MySqlCommand(duplicateCheckQuery, connection))
                    {
                      
                        duplicateCmd.Parameters.AddWithValue("@code", bCode.Text.ToUpper());

                        int duplicateCount = Convert.ToInt32(await duplicateCmd.ExecuteScalarAsync());
                        if (duplicateCount > 0)
                        {
                            MessageBox.Show("This client record already exists in the database.", "Duplicate Entry", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                            return;
                        }
                    }

                    // Insert new record in patient_record
                    string insertPatientInfoQuery = @"
                    INSERT INTO clientInformation
                    (clientName, busAddress,taxType, code, dateAdded, busName)
                    VALUES 
                    (@clientName, @busAddress, @taxType, @code, @dateAdded, @busName)";

                    using (MySqlCommand insertCmd = new MySqlCommand(insertPatientInfoQuery, connection))
                    {
                        //insertCmd.Parameters.AddWithValue("@id", schoolID.Text.ToUpper());
                        insertCmd.Parameters.AddWithValue("@clientName", clientName.Text.ToUpper());
                        insertCmd.Parameters.AddWithValue("@busAddress", busAddress.Text.ToUpper());
                        insertCmd.Parameters.AddWithValue("@taxType", taxTypecmb.Text.ToUpper());
                        insertCmd.Parameters.AddWithValue("@code", bCode.Text.ToUpper());
                        insertCmd.Parameters.AddWithValue("@dateAdded", admittedDateText);
                        insertCmd.Parameters.AddWithValue("@busName", busName.Text.ToUpper());

                        await insertCmd.ExecuteNonQueryAsync();
                    }
                }
                //await Task.Delay(1000);
                //SplashScreenManager.CloseForm(false);
                MessageBox.Show("Client record saved.", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }

            catch (MySqlException ex)
            {
                Console.WriteLine("MySQL Error: " + ex.Message);
                //await Task.Delay(2000);
                //SplashScreenManager.CloseForm(false);
                MessageBox.Show("An error occurred: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void cancelbtn_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void addClientFRM_Load(object sender, EventArgs e)
        {
            // Initialize any additional components or settings if needed

        }

        private void labelControl6_Click(object sender, EventArgs e)
        {

        }

        private void textEdit2_EditValueChanged(object sender, EventArgs e)
        {

        }

        private void addClientFRM_Load_1(object sender, EventArgs e)
        {

        }
    }
}