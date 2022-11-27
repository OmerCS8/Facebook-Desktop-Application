using System;
using System.Drawing;
using System.Windows.Forms;
using FacebookAppEngine;
using FacebookWrapper.ObjectModel;

namespace BasicFacebookFeatures.SubForms
{
    public partial class FormProfile : Form
    {
        private const int k_MarginAmount = 10;
        private readonly FaceBookUserManager r_UserManager = FaceBookUserManager.Instance();

        public FormProfile()
        {
            InitializeComponent();
            setCoverPicture();
            setProfilePicture();
            setDataLabels();
            setScrollMinSize();
        }

        private void setScrollMinSize()
        {
            panelMain.AutoScrollMinSize = new Size((labelName.Width + k_MarginAmount) * 2 + pictureBoxProfilePic.Width ,labelGroups.Bottom + k_MarginAmount);
        }

        private void setDataLabels()
        {
            labelName.Text = $"Name: {r_UserManager.LoggedInUserName}";
            labelName.Location = new Point(k_MarginAmount, pictureBoxCoverPhoto.Bottom + k_MarginAmount);
            labelAge.Text = $"Age: {r_UserManager.LoggedInUserAge}";
            labelAge.Location = new Point(k_MarginAmount, labelName.Bottom + k_MarginAmount);
            labelGender.Text = $"Gender: {r_UserManager.LoggedInUserGender}";
            labelGender.Location = new Point(k_MarginAmount, labelAge.Bottom + k_MarginAmount);
            labelBirthday.Text = $"Birthday: {r_UserManager.LoggedInUserBirthday}";
            labelBirthday.Location = new Point(k_MarginAmount, labelGender.Bottom + k_MarginAmount);
            labelEmail.Text = $"Email: {r_UserManager.LoggedInUserEmail}";
            labelEmail.Location = new Point(k_MarginAmount, labelBirthday.Bottom + k_MarginAmount);
            labelResidence.Text = $"Residence: {r_UserManager.LoggedInUserLocation.Name}";
            labelResidence.Location = new Point(k_MarginAmount, labelEmail.Bottom + k_MarginAmount);
            labelFriends.Text = $"Friends: {r_UserManager.LoggedInUserFriends.Count}";
            labelFriends.Location = new Point(k_MarginAmount, labelResidence.Bottom + k_MarginAmount);
            labelGroups.Text = $"Groups: {r_UserManager.LoggedInUserGroups.Count}";
            labelGroups.Location = new Point(k_MarginAmount, labelFriends.Bottom + k_MarginAmount);
        }

        private void setProfilePicture()
        {
            pictureBoxProfilePic.BackgroundImage = r_UserManager.LoggedInUserProfilePictureLarge;
            pictureBoxProfilePic.Left = (panelMain.Width - pictureBoxProfilePic.Width) / 2;
            pictureBoxProfilePic.Top = pictureBoxCoverPhoto.Bottom - pictureBoxProfilePic.Height / 2;
        }

        private void setCoverPicture()
        {
            pictureBoxCoverPhoto.BackgroundImage = r_UserManager.LoggedInUserCoverImage;
            pictureBoxCoverPhoto.Width = panelMain.Width;
        }
    }
}
