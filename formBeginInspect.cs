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

namespace GroupProject
{
    public partial class formBeginInspect : Form
    {
        public formBeginInspect()
        {
            InitializeComponent();
            this.DoubleBuffered = true; //smooth rendering

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
        private void formBeginInspect_Resize(object sender, EventArgs e) 
        {
            this.Invalidate(); // triggers repaint
        }

        private void formBeginInspect_Load(object sender, EventArgs e)
        {

        }
    }
}
