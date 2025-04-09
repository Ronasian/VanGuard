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
//testing
namespace GroupProject
{
    public partial class StartingPage : Form
    {
        public StartingPage()
        {
            InitializeComponent();
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
    }
}
