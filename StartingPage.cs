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
            
            //gradient paint on top bar
            LPpanel.Invalidate();

            //reduces flicker when drawing
            this.DoubleBuffered = true;

        }

        //gradient bar drawing
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
            //open the SignIn form
            SignIn signInForm = new SignIn();
            this.Hide();
            signInForm.FormClosed += (s, args) => this.Show(); // return to this form after closing
            signInForm.Show();


        }

        private void StartingPage_Load(object sender, EventArgs e)
        {

        }

        private void panelLogin_Paint(object sender, PaintEventArgs e)
        {

        }

        private void btnCreateAccount_Click(object sender, EventArgs e)
        {
            CreateAccount createAccountForm = new CreateAccount();
            this.Hide();//hides the current form
            createAccountForm.FormClosed += (s, args) => this.Show(); //Re-show when user closes the form
            createAccountForm.Show();

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

        
    }
}
