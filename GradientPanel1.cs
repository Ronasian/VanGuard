using System.Drawing;
using System.Drawing.Drawing2D;
using System.Windows.Forms;

public class GradientPanel1 : Panel
{
    public Color StartColor { get; set; } = Color.FromArgb(255, 255, 49, 49);   // Peach Red
    public Color EndColor { get; set; } = Color.FromArgb(255, 255, 187, 77);    // Peach Orange
    public LinearGradientMode GradientDirection { get; set; } = LinearGradientMode.Horizontal;

    public GradientPanel1()
    {
        this.DoubleBuffered = true;
        this.ResizeRedraw = true;
    }

    protected override void OnPaint(PaintEventArgs e)
    {
        using (LinearGradientBrush brush = new LinearGradientBrush(this.ClientRectangle, StartColor, EndColor, GradientDirection))
        {
            e.Graphics.FillRectangle(brush, this.ClientRectangle); 
        }
    }
}