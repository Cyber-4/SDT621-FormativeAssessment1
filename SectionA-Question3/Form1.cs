using System;
using System.Windows.Forms;

namespace SectionA_Question3
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            string language = txtLanguage.Text.Trim();

            if (string.IsNullOrWhiteSpace(language))
            {
                MessageBox.Show("Please enter a programming language.", "Input Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            foreach (var item in lstLanguages.Items)
            {
                if (item.ToString().Equals(language, StringComparison.OrdinalIgnoreCase))
                {
                    MessageBox.Show("This language is already in your list.", "Duplicate Entry", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    return;
                }
            }

            lstLanguages.Items.Add(language);

            lblStatus.Text = $"Added '{language}' at {DateTime.Now.ToString("dd Apr yyyy HH:mm:ss")}";

            txtLanguage.Clear();
            txtLanguage.Focus();
        }

        private void btnRemove_Click(object sender, EventArgs e)
        {
            if (lstLanguages.SelectedIndex != -1)
            {
                string selectedLanguage = lstLanguages.SelectedItem.ToString();

                lstLanguages.Items.RemoveAt(lstLanguages.SelectedIndex);

                lblStatus.Text = $"Removed '{selectedLanguage}' at {DateTime.Now.ToString("dd Apr yyyy HH:mm:ss")}";
            }
            else
            {
                MessageBox.Show("Please select a language from the list to remove.", "Selection Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }
    }
}
