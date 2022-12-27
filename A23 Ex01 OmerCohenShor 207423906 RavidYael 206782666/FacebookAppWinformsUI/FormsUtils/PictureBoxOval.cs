using System;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Windows.Forms;

namespace BasicFacebookFeatures.FormsUtils
{
    public class PictureBoxOval : PictureBox
    {
        protected override void OnResize(EventArgs e)
        {
            using (GraphicsPath ovalGraphicsPath = new GraphicsPath())
            {
                base.OnResize(e);
                ovalGraphicsPath.AddEllipse(new Rectangle(0, 0, this.Width - 1, this.Height - 1));
                this.Region = new Region(ovalGraphicsPath);
            }
        }
    }
}
