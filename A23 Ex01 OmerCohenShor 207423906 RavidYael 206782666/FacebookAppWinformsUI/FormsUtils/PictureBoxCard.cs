using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BasicFacebookFeatures.FormsUtils
{
    class PictureBoxCard : PictureBox
    {
        private readonly Image r_BackImage;
        public Image FrontImage { get;}

        public PictureBoxCard(int i_Width, int i_Height, Image i_FrontImage)
        {
            setPictureBoxInitialProperties(i_Width, i_Height);
            r_BackImage = Properties.Resources.Card_back;
            FrontImage = i_FrontImage;
        }

        private void setPictureBoxInitialProperties(int i_Width, int i_Height)
        {
            this.Size = new Size(i_Width, i_Height);
            this.BackgroundImageLayout = ImageLayout.Stretch;
            FlipToBack();
        }

        public void FlipToBack()
        {
            this.BackgroundImage = r_BackImage;
            this.Cursor = Cursors.Hand;
        }

        public void FlipToFront()
        {
            this.BackgroundImage = FrontImage;
            this.Cursor = Cursors.Default;
        }
    }
}
