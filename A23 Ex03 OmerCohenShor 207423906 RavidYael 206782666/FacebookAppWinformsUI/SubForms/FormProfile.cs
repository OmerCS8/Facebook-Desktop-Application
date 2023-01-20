using System;
using System.Drawing;
using System.Threading;
using System.Windows.Forms;
using FacebookAppEngine;
using FacebookWrapper.ObjectModel;

namespace BasicFacebookFeatures.SubForms
{
    public partial class FormProfile : Form
    {
        private const int k_MarginAmount = 10;
        private readonly FaceBookUserManager r_UserManager = FaceBookUserManager.Instance;

        public FormProfile()
        {
            InitializeComponent();
            setScrollMinSize();
            setControlsLocations();
        } private void setControlsLocations()
        {
            labelName.Location = new Point(k_MarginAmount, pictureBoxCoverPhoto.Bottom + k_MarginAmount);
            labelAge.Location = new Point(k_MarginAmount, labelName.Bottom + k_MarginAmount);
            labelGender.Location = new Point(k_MarginAmount, labelAge.Bottom + k_MarginAmount);
            labelBirthday.Location = new Point(k_MarginAmount, labelGender.Bottom + k_MarginAmount);
            labelEmail.Location = new Point(k_MarginAmount, labelBirthday.Bottom + k_MarginAmount);
            labelResidence.Location = new Point(k_MarginAmount, labelEmail.Bottom + k_MarginAmount);
            labelFriends.Location = new Point(k_MarginAmount, labelResidence.Bottom + k_MarginAmount);
            labelGroups.Location = new Point(k_MarginAmount, labelFriends.Bottom + k_MarginAmount);
            pictureBoxProfilePic.Left = (panelMain.Width - pictureBoxProfilePic.Width) / 2;
            pictureBoxProfilePic.Top = pictureBoxCoverPhoto.Bottom - pictureBoxProfilePic.Height / 2;
            pictureBoxCoverPhoto.Width = panelMain.Width;
        }

        private void setScrollMinSize()
        {
            panelMain.AutoScrollMinSize = new Size(
                (labelName.Width + k_MarginAmount) * 2 + pictureBoxProfilePic.Width,
                labelGroups.Bottom + k_MarginAmount);
        }

        private void setDataLabels()
        {
            string name = r_UserManager.LoggedInUserName;
            int? age = r_UserManager.LoggedInUserAge;
            User.eGender? gender = r_UserManager.LoggedInUserGender;
            string birthday = r_UserManager.LoggedInUserBirthday;
            string email = r_UserManager.LoggedInUserEmail;
            string residence = r_UserManager.LoggedInUserLocation.Name;
            int friends = r_UserManager.LoggedInUserFriends.Count;
            int groups = r_UserManager.LoggedInUserGroups.Count;

            labelName.Invoke(new Action(() => labelName.Text = $"Name: {name}"));
            labelAge.Invoke(new Action(() => labelAge.Text = $"Age: {age}"));
            labelGender.Invoke(new Action(() => labelGender.Text = $"Gender: {gender}"));
            labelBirthday.Invoke(new Action(() => labelBirthday.Text = $"Birthday: {birthday}"));
            labelBirthday.Invoke(new Action(() => labelEmail.Text = $"Email: {email}"));
            labelResidence.Invoke(new Action(() => labelResidence.Text = $"Residence: {residence}"));
            labelFriends.Invoke(new Action(() => labelFriends.Text = $"Friends: {friends}"));
            labelGroups.Invoke(new Action(() => labelGroups.Text = $"Groups: {groups}"));
        }

        private void setProfilePicture()
        {
            Image backImage = r_UserManager.LoggedInUserProfilePictureLarge;

            pictureBoxProfilePic.Invoke(new Action(() =>
                    pictureBoxProfilePic.BackgroundImage = backImage));
        }

        private void setCoverPicture()
        {
            Image backImage = r_UserManager.LoggedInUserCoverImage;

            pictureBoxCoverPhoto.Invoke(new Action(() =>
                    pictureBoxCoverPhoto.BackgroundImage = backImage));

        }

        private void FormProfile_Shown(object sender, EventArgs e)
        {
            new Thread(setDataLabels){IsBackground = true}.Start();
            new Thread(setProfilePicture){IsBackground = true}.Start();
            new Thread(setCoverPicture){IsBackground = true}.Start();
        }
    }
}
