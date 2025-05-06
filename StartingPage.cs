using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using GroupProject.Models;
using GroupProject.Data;

//testing
namespace GroupProject
{
    public partial class StartingPage : Form
    {
        public StartingPage()
        {
            InitializeComponent();

            //Sets up dropdown role options
            cmbRole.Items.Add("Driver");
            cmbRole.Items.Add("Manager");

            //Default view
            panelLogin.Visible = true;
            panelCreateAccount.Visible = false;
          
            LPpanel.Invalidate();
            this.DoubleBuffered = true;

        }

        private void LPpanel_Paint(object sender, PaintEventArgs e)
        {
            using (LinearGradientBrush brush = new LinearGradientBrush(
                LPpanel.ClientRectangle,
                Color.FromArgb(255, 255, 49, 49),    // Start color
                Color.FromArgb(255, 255, 187, 77),  // End color
                LinearGradientMode.Horizontal))     // Direction
            {
                e.Graphics.FillRectangle(brush, LPpanel.ClientRectangle);
            }
        }

        private void AppTitle_Click(object sender, EventArgs e)
        {

        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            SignIn signin = new SignIn();
            this.Hide();
            signin.Show();
        }

        private void StartingPage_Load(object sender, EventArgs e)
        {

        }

        private void panelLogin_Paint(object sender, PaintEventArgs e)
        {

        }

        private void btnCreateAccount_Click(object sender, EventArgs e)
        {
            panelLogin.Visible = false;
            panelCreateAccount.Visible = true;

        }
        private void panelCreateAccount_Paint(object sender, PaintEventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void label7_Click(object sender, EventArgs e)
        {

        }

        private void btnSubmitCreate_Click(object sender, EventArgs e)
        {
            //reads inputs from the form
            string name = txtName.Text.Trim();
            string email = txtEmail.Text.Trim();
            string password = txtPassword.Text.Trim();
            string role = cmbRole.SelectedItem?.ToString(); // role selected from dropdown list

            MessageBox.Show($"Name: '{name}'\nEmail: '{email}'\nPassword: '{password}'\nRole: '{role}");

            //checks fields are not empty
            if (string.IsNullOrEmpty(name) || string.IsNullOrEmpty(email) ||
                string.IsNullOrEmpty(password) || string.IsNullOrEmpty(role))
            {
                MessageBox.Show("All fields are required.");
                return;
            }

            //check if email hjas been used
            if (UserDatabase.Users.Any(u => u.Email == email))
            {
                MessageBox.Show("Email is already in use.");
                return;
            }

            //Creates a new user and adds to the database
            var newUser = new User(name, email, password, role);
            UserDatabase.AddUser(newUser);

            MessageBox.Show("Account created successfully!");
        }
    }
}
