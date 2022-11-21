using System;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Windows.Forms;

namespace BasicFacebookFeatures.FormsUtils
{
    public class PictureBoxOval : PictureBox
    {
        public PictureBoxOval(int i_Width, int i_Height)
        {
            this.Size = new Size(i_Width, i_Height);
            this.Visible = true;
        }
        protected override void OnResize(EventArgs e)
        {
            base.OnResize(e);
            using (var graphicsPath = new GraphicsPath())
            {
                graphicsPath.AddEllipse(new Rectangle(0, 0, this.Width - 1, this.Height - 1));
                this.Region = new Region(graphicsPath);
            }
        }
    }
}
