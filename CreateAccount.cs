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

namespace GroupProject
{
    public partial class CreateAccount : Form
    {
        string filePath = "users.csv";
        public CreateAccount()
        {
            InitializeComponent();

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

        private void btnSubmitCreate_Click(object sender, EventArgs e)
        {
            string name = txtName.Text;
            string email = txtEmail.Text;
            string password = txtPassword.Text;
            string position = cmbPosition.SelectedItem?.ToString();

            if (string.IsNullOrWhiteSpace(name) || string.IsNullOrWhiteSpace(email) ||
                string.IsNullOrWhiteSpace(password) || string.IsNullOrWhiteSpace(position))
            {
                MessageBox.Show("Please fill in all fields.");
                return;
            }

            bool emailExists = File.ReadAllLines(filePath).Skip(1)
                .Any(line => line.Split(',')[1].Equals(email, StringComparison.OrdinalIgnoreCase));

            if (emailExists)
            {
                MessageBox.Show("An account with this email already exists.");
                return;
            }

            string newUser = $"{name},{email},{password},{position}";
            File.AppendAllText(filePath, newUser + Environment.NewLine);

            MessageBox.Show("Account created successfully!");
        }
    }
}
