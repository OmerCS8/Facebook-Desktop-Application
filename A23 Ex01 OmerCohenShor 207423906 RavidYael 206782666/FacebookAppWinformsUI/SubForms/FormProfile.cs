using System;
using System.Drawing;
using System.Windows.Forms;
using FacebookAppEngine;
using FacebookWrapper.ObjectModel;

namespace BasicFacebookFeatures.SubForms
{
    public partial class FormProfile : Form
    {
        private readonly int r_MarginAmount = 10;
        private readonly FaceBookUserManager r_UserManager = FaceBookUserManager.GetFaceBookUserManagerInstance();
        public FormProfile()
        {
            InitializeComponent();
            setCoverPicture();
            setProfilePicture();
            setDataLables();
            setScrollMinSize();
        }

        private void setScrollMinSize()
        {
            panelMain.AutoScrollMinSize = new Size((labelName.Width + r_MarginAmount) * 2 + pictureBoxProfilePic.Width ,labelGroups.Bottom + r_MarginAmount);
        }

        private void setDataLables()
        {
            labelName.Text = $"Name: {r_UserManager.LoggedInUserName}";
            labelName.Location = new Point(r_MarginAmount, pictureBoxCoverPhoto.Bottom + r_MarginAmount);
            labelAge.Text = $"Age: {r_UserManager.LoggedInUserAge}";
            labelAge.Location = new Point(r_MarginAmount, labelName.Bottom + r_MarginAmount);
            labelGender.Text = $"Gender: {r_UserManager.LoggedInUserGender}";
            labelGender.Location = new Point(r_MarginAmount, labelAge.Bottom + r_MarginAmount);
            labelBirthday.Text = $"Birthday: {r_UserManager.LoggedInUserBirthday}";
            labelBirthday.Location = new Point(r_MarginAmount, labelGender.Bottom + r_MarginAmount);
            labelEmail.Text = $"Email: {r_UserManager.LoggedInUserEmail}";
            labelEmail.Location = new Point(r_MarginAmount, labelBirthday.Bottom + r_MarginAmount);
            labelResidence.Text = $"Residence: {r_UserManager.LoggedInUserLocation.Name}";
            labelResidence.Location = new Point(r_MarginAmount, labelEmail.Bottom + r_MarginAmount);
            labelFriends.Text = $"Friends: {r_UserManager.LoggedInUserFriends.Count}";
            labelFriends.Location = new Point(r_MarginAmount, labelResidence.Bottom + r_MarginAmount);
            labelGroups.Text = $"Groups: {r_UserManager.LoggedInUserGroups.Count}";
            labelGroups.Location = new Point(r_MarginAmount, labelFriends.Bottom + r_MarginAmount);
        }

        private void setProfilePicture()
        {
            pictureBoxProfilePic.BackgroundImage = r_UserManager.ProfilePicLarge;
            pictureBoxProfilePic.Left = (panelMain.Width - pictureBoxProfilePic.Width) / 2;
            pictureBoxProfilePic.Top = pictureBoxCoverPhoto.Bottom - pictureBoxProfilePic.Height / 2;
        }

        private void setCoverPicture()
        {
            pictureBoxCoverPhoto.BackgroundImage = r_UserManager.CoverImage;
            pictureBoxCoverPhoto.Width = panelMain.Width;
        }
    }
}
