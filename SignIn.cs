using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;
using GroupProject.Data;
using GroupProject.Models;

namespace GroupProject
{
    public partial class SignIn : Form
    {
        public SignIn()
        {
            InitializeComponent();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void SignIn_Load(object sender, EventArgs e)
        {

        }

        private void btnSignIn_Click(object sender, EventArgs e)
        {
            string email = txtLoginEmail.Text.Trim();
            string password = txtLoginPassword.Text;

            if (string.IsNullOrWhiteSpace(email) || string.IsNullOrWhiteSpace(password))
            {
                MessageBox.Show("Please enter both email and password.");
                return;
            }

            User user = UserDatabase.Authenticate(email, password);

            if (user == null)
            {
                MessageBox.Show("Invalid email or password.");
                return;
            }

            // Successful login
            MessageBox.Show($"Welcome, {user.Name}! Position: {user.Role}");

            // Navigate to role-based homepage
            this.Hide();

            if (user.Role == "Driver")
            {
                DriverHomePage driverPage = new DriverHomePage(user); // set up for homepage
                driverPage.Show();
            }
            else
            {
                // Add manager home page
                MessageBox.Show("Need to impliment managers homepage");
            }
        }
    }
}
