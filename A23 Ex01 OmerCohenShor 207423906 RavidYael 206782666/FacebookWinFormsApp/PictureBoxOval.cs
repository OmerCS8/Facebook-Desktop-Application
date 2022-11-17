using System;
using System.Collections.Generic;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BasicFacebookFeatures
{
    public class PictureBoxOval : PictureBox
    {
        public PictureBoxOval(int i_width, int i_height)
        {
            this.Size = new Size(i_width, i_height);
            this.BackColor = Color.White;
            this.Visible = true;
            this.BorderStyle = BorderStyle.Fixed3D;
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
