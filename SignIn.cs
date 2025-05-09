using System;
using System.Windows.Forms;
using GroupProject.Data;

namespace GroupProject
{
    public partial class SignIn : Form
    {
        public SignIn()
        {
            InitializeComponent();
        }
        // ignore
        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }
        //ignore
        private void SignIn_Load(object sender, EventArgs e)
        {

        }

        private void btnSignIn_Click(object sender, EventArgs e)
        {
            // save user input under variables
            string email = txtLoginEmail.Text.Trim();
            string password = txtLoginPassword.Text;

            if (string.IsNullOrWhiteSpace(email) || string.IsNullOrWhiteSpace(password))
            {
                MessageBox.Show("Please enter both email and password.");
                return;
            }

            var user = UserDatabase.Authenticate(email, password);

            if (user == null)
            {
                MessageBox.Show("Invalid email or password.");
                return;
            }

            MessageBox.Show($"Welcome, {user.Name}! Role: {user.Role}");
            this.Hide();

            Form homePageForm = null;

            if (user.Role == "Manager")
            {
                homePageForm = new ManagerHomePage(user);
            }
            else if (user.Role == "Driver")
            {
               homePageForm = new DriverHomePage (user);
            }
            else
            {
                MessageBox.Show("Unknown role assigned.");
                this.Show();
                return;
            }

            //ensures app exits when the home page closes
            homePageForm.FormClosed += (s, args) => this.Close();
            homePageForm.Show();
        }
    }
}
