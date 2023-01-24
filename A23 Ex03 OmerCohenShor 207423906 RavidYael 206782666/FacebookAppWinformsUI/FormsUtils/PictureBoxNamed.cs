using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BasicFacebookFeatures.FormsUtils
{
    class PictureBoxNamed : PictureBoxDecorator
    {
        private readonly Label r_PictureNameLabel;
        private const string k_DefaultPictureName = "no-name";

        public PictureBoxNamed(PictureBox i_InnerPicture ,string i_PictureName = k_DefaultPictureName): base(i_InnerPicture)
        {
            (this as PictureBox).Size = new Size(this.Size.Width, this.Size.Height + 15);
            this.m_InnerPictureBox.Top = 15;
            r_PictureNameLabel = new Label() { AutoEllipsis = true, Visible = true, Text = i_PictureName};
            this.Controls.Add(r_PictureNameLabel);
            r_PictureNameLabel.Location = new Point(0,0);
        }

        public string PictureName
        {
            get => r_PictureNameLabel.Text;
            set => r_PictureNameLabel.Text = value;
        }
    }
}
