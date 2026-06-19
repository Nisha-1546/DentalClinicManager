using DentalApp.core.Contracts;
using DentalApp.core.Services;
using DentalClinicManager.Forms;
using System.Configuration;

namespace DentalClinicManager
{
    public partial class frmLogin : Form
    {
        public frmLogin()
        {
            InitializeComponent();
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            string username = txtUsername.Text.Trim();
            string password = txtPassword.Text.Trim();

            if (string.IsNullOrWhiteSpace(username) || string.IsNullOrWhiteSpace(password))
            {
                MessageBox.Show("Please enter username and password.",
                    "Validation", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            if (username == "admin" && password == "admin123")
            {
                ShowWelcomeMessage(username);

                this.Hide();
                var main = new MainDentalForm();
                main.ShowDialog();
                this.Close();
            }
            else
            {
                MessageBox.Show("Invalid username or password.",
                    "Login Failed", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txtPassword.Clear();
                txtPassword.Focus();
            }
        }

        private static void ShowWelcomeMessage(string username)
        {
            string greeting = DateTime.Now.Hour switch
            {
                < 12 => "Good Morning",
                < 17 => "Good Afternoon",
                _ => "Good Evening"
            };

            MessageBox.Show(
                $"{greeting}, {username}!\n\n" +
                $"Welcome to Dental Clinic Manager.\n" +
                $"Today is {DateTime.Now:dddd, dd MMMM yyyy}.\n\n" +
                $"Have a productive day caring for your patients.",
                "Welcome",
                MessageBoxButtons.OK,
                MessageBoxIcon.Information);
        }
    }
}
