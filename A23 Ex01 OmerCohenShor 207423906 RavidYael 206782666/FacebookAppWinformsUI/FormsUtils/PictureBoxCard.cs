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
        public bool IsCardOpen { get; private set; }
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
            this.Cursor = Cursors.Hand;
            this.BackgroundImage = Properties.Resources.Card_back;
        }

        public void FlipToBack()
        {
            this.BackgroundImage = r_BackImage;
            IsCardOpen = false;
            this.Cursor = Cursors.Hand;
        }

        public void FlipToFront()
        {
            this.BackgroundImage = FrontImage;
            IsCardOpen = true;
            this.Cursor = Cursors.Default;
        }
    }
}
