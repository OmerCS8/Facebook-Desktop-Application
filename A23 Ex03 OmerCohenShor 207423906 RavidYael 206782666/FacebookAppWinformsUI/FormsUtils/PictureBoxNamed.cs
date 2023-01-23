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
        private readonly Label r_PictureNameLabel = new Label() { AutoEllipsis = true, Visible = true };
        private const string k_DefaultPictureName = "";

        public PictureBoxNamed(PictureBox i_InnerPictureBox = null ,string i_PictureName = k_DefaultPictureName) : base(i_InnerPictureBox)
        {
            (this as PictureBox).Size = new Size(this.Size.Width, this.Size.Height + 10);
            this.m_InnerPictureBox.Top = 10;
            this.Controls.Add(r_PictureNameLabel);
        }

        public string PictureName
        {
            get => r_PictureNameLabel.Text;
            set => r_PictureNameLabel.Text = value;
        }
    }
}
