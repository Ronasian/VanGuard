using System;
using System.Drawing;
using System.Windows.Forms;
using System.IO;
using System.Drawing.Drawing2D;
using GroupProject.Data;
using GroupProject.Models;

namespace GroupProject
{
    public partial class CreateAccount : Form
    {
        string filePath = "users.csv";
        public CreateAccount()
        {
            InitializeComponent();

            //gradient paint on top bar
            panel1.Invalidate();

            //reduces flicker when drawing
            this.DoubleBuffered = true;

            // checks for existing userdatabase
            if (!File.Exists(filePath))
            {
                File.WriteAllText(filePath, "Name,Email,Password,Position" + Environment.NewLine);
            }
        }

        private void CreateAccount_Load(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void label6_Click(object sender, EventArgs e)
        {

        }

        private void position_SelectedIndexChanged(object sender, EventArgs e)
        {
            
        }

        private void email_TextChanged(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }
        // event handling for create account button
        private void btnSubmitCreate_Click(object sender, EventArgs e)
        {
            // save inputs in variables
            string name = txtName.Text.Trim();
            string email = txtEmail.Text.Trim();
            string password = txtPassword.Text;
            string role = cmbPosition.SelectedItem?.ToString();
            // if user does not fill in every field
            if (string.IsNullOrWhiteSpace(name) || string.IsNullOrWhiteSpace(email) ||
                string.IsNullOrWhiteSpace(password) || string.IsNullOrWhiteSpace(role))
            {
                // prompt user for all entries
                MessageBox.Show("Please fill in all fields.");
                return;
            }
            // if email exists in the system
            if (UserDatabase.EmailExists(email))
            {
                // notify user
                MessageBox.Show("An account with this email already exists.");
                return;
            }
            // create a new user using User class
            var newUser = new User(name, email, password, role);
            // add user to database
            UserDatabase.AddUser(newUser);
            // message
            MessageBox.Show("Account created successfully!");
            // hide form
            this.Hide();
            // open sign in form
            new SignIn().Show();
        }

        private void lblLogin_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            this.Hide(); //return to StartingPage due to the FormClosed handler
            StartingPage startingPage = new StartingPage();
            startingPage.FormClosed += (s, args) => this.Close();
            startingPage.Show();

        }

        private void txtPassword_TextChanged(object sender, EventArgs e)
        {

        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {
            using (LinearGradientBrush brush = new LinearGradientBrush(
                panel1.ClientRectangle,
                Color.FromArgb(255, 255, 49, 49),    // Start color
                Color.FromArgb(255, 255, 187, 77),  // End color
                LinearGradientMode.Horizontal))     // Direction
            {
                e.Graphics.FillRectangle(brush, panel1.ClientRectangle);
            }
        }
    }
}
