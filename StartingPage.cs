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

            this.Resize += (s, e) => this.Invalidate();

        }

        protected override void OnPaint(PaintEventArgs e)
        {
            base.OnPaint(e);

            //create gradient brush from black to gray 
            using (LinearGradientBrush brush = new LinearGradientBrush(
                this.ClientRectangle,           //Area to paint
                Color.Black,                    //Start color
                Color.Gray,                     //End colo
                LinearGradientMode.Horizontal)) //Direction: vertical
            {
                e.Graphics.FillRectangle(brush, this.ClientRectangle);
            }
        }

        //redraw on resize
        private void StartingPage_Resize(object sender, EventArgs e)
        {
            this.Invalidate(); // triggers repaint
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

        private void btnLogin_Click(object sender, EventArgs e)
        {
            //open the SignIn form
            this.Hide();
            SignIn signInForm = new SignIn();            
            signInForm.FormClosed += (s, args) => this.Close(); // return to this form after closing
            signInForm.Show();


        }

        private void StartingPage_Load(object sender, EventArgs e)
        {

        }
        
        private void btnCreateAccount_Click(object sender, EventArgs e)
        {
            this.Hide();//hides the current form
            CreateAccount createAccountForm = new CreateAccount();            
            createAccountForm.FormClosed += (s, args) => this.Close(); //Re-show when user closes the form
            createAccountForm.Show();

        }
               
    }
}
