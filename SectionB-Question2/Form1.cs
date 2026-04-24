namespace SectionB_Question2
{
    public partial class Form1 : Form
    {

        private CitizenProfile currentProfile;  

        public Form1()
        {
            InitializeComponent();
        }

        private void btnValidate_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtName.Text) ||
                string.IsNullOrWhiteSpace(txtId.Text) ||
                cmbCitizenship.SelectedItem == null)
            {
                MessageBox.Show("Please fill in all fields before validating.");
                return;
            }

            currentProfile = new CitizenProfile(
                txtName.Text.Trim(),
                txtId.Text.Trim(),
                cmbCitizenship.SelectedItem.ToString()
            );

            lblValidationResult.Text = currentProfile.ValidateID();
        }

        private void btnGenerate_Click(object sender, EventArgs e)
        {
            if (currentProfile == null)
            {
                MessageBox.Show("Please validate the ID first!");
                return;
            }

            txtResults.Text = "==== DIGITAL CITIZEN SUMMARY ====\r\n" +
                              $"Name: {currentProfile.FullName}\r\n" +
                              $"ID Number: {currentProfile.IDNumber}\r\n" +
                              $"Age: {currentProfile.Age}\r\n" +
                              $"Citizenship: {currentProfile.CitizenshipStatus}\r\n" +
                              $"Validation: {currentProfile.ValidateID()}\r\n" +
                              "Processed at: Home Affairs Digital Desk\r\n" +
                              $"Timestamp: {DateTime.Now.ToString("yyyy/MM/dd HH:mm:ss")}";
        }
    }
}
