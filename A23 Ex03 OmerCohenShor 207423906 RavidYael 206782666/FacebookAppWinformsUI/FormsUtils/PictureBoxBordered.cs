using System.Drawing;
using System.Windows.Forms;

namespace BasicFacebookFeatures.FormsUtils
{
    class PictureBoxBordered : PictureBoxDecorator
    {
        public int BorderSize { set; get; }

        public PictureBoxBordered(PictureBox i_InnerPicture, int i_BorderSize = 10) : base(i_InnerPicture)
        {
            (this as PictureBox).Size = new Size(i_InnerPicture.Width + i_BorderSize, i_InnerPicture.Height + i_BorderSize);
            this.m_InnerPictureBox.Location = new Point(i_BorderSize / 2, i_BorderSize / 2);
        }
    }
}
