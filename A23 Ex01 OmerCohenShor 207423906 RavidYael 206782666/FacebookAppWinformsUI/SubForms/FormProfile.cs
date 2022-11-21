using System.Drawing;
using System.Windows.Forms;
using FacebookAppEngine;
using FacebookWrapper.ObjectModel;

namespace BasicFacebookFeatures.SubForms
{
    public partial class FormProfile : Form
    {
        private readonly FaceBookUserManager r_UserManager = FaceBookUserManager.GetFaceBookUserManagerInstance();
        public FormProfile()
        {
            InitializeComponent();
            setPictures();
        }

        void setPictures()
        {
            pictureBoxCoverPhoto.BackgroundImage = r_UserManager.CoverImage;
            pictureBoxCoverPhoto.Location = new Point(0, 0);
            pictureBoxCoverPhoto.Width = panelMain.Width;
            pictureBoxCoverPhoto.Height = 200;
            pictureBoxProfilePic.BackgroundImage = r_UserManager.ProfilePicLarge;
            pictureBoxProfilePic.Size = new Size(200, 200);
            pictureBoxProfilePic.Left = (panelMain.Width - pictureBoxProfilePic.Width) / 2;
            pictureBoxProfilePic.Top = pictureBoxCoverPhoto.Bottom - pictureBoxProfilePic.Height / 2;
        }
    }
}
