using System;
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
            setCoverPicture();
            setProfilePicture();
            setLables();
        }

        private void setLables()
        {
            labelName.Text = $"Name: {r_UserManager.LoggedInUserName}";
            labelName.Location = new Point(10, pictureBoxCoverPhoto.Bottom + 10);
            labelAge.Text = $"Age: {r_UserManager.LoggedInUserAge}";
            labelAge.Location = new Point(10, labelName.Bottom + 10);
            labelGender.Text = $"Gender: {r_UserManager.LoggedInUserGender}";
            labelGender.Location = new Point(10, labelAge.Bottom + 10);
            labelBirthday.Text = $"Birthday: {r_UserManager.LoggedInUserBirthday}";
            labelBirthday.Location = new Point(10, labelGender.Bottom + 10);

        }

        private void setProfilePicture()
        {
            pictureBoxProfilePic.BackgroundImage = r_UserManager.ProfilePicLarge;
            pictureBoxProfilePic.Size = new Size(200, 200);
            pictureBoxProfilePic.Left = (panelMain.Width - pictureBoxProfilePic.Width) / 2;
            pictureBoxProfilePic.Top = pictureBoxCoverPhoto.Bottom - pictureBoxProfilePic.Height / 2;
        }

        private void setCoverPicture()
        {
            pictureBoxCoverPhoto.BackgroundImage = r_UserManager.CoverImage;
            pictureBoxCoverPhoto.Width = panelMain.Width;
            pictureBoxCoverPhoto.Height = 200;
        }
    }
}
