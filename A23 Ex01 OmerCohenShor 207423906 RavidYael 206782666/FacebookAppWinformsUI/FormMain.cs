using System;
using System.Windows.Forms;
using FacebookWrapper.ObjectModel;
using FacebookWrapper;
using System.Drawing;
using System.Drawing.Drawing2D;
using BasicFacebookFeatures.SubForms;
using CefSharp.DevTools.Profiler;
using FacebookAppEngine;

namespace BasicFacebookFeatures
{
    public partial class FormMain : Form
    {
        private readonly FaceBookUserManager r_UserManager = FaceBookUserManager.GetFaceBookUserManagerInstance(); 
        private PictureBoxOval m_PictureBoxProfilePicture;
        private Button m_ChosenButton = null;
        private Form m_SubForm = null;

        public FormMain()
        {
            InitializeComponent();
            FacebookWrapper.FacebookService.s_CollectionLimit = 100;
            setPanelsColors();
            initializeProfilePanel();
            initializeMenuPanel();
            centerHeadlineLocation();
            setMainMenuToLoggedOutUser();
        }

        private void initializeMenuPanel()
        {
            foreach (Control control in panelMenu.Controls)
            {
                control.Height = 40;
                control.Width = panelMenu.Width;
            }

            buttonLogin.Top = 0;
            buttonProfile.Top = buttonLogin.Bottom;
            buttonGroups.Top = buttonProfile.Bottom;
            buttonAlbums.Top = buttonGroups.Bottom;
            buttonLikedPages.Top = buttonAlbums.Bottom;
            buttonPosts.Top = buttonLikedPages.Bottom;
            buttonLogout.Top = buttonPosts.Bottom;
        }

        private void centerHeadlineLocation()
        {
            labelHeadline.Top = (panelTopBar.Height - labelHeadline.Height) / 2;
            labelHeadline.Left = (panelTopBar.Width - labelHeadline.Width) / 2;
        }

        private void initializeProfilePanel()
        {
            PictureBoxOval pictureBoxProfileBorder = new PictureBoxOval(panelSideBar.Width - 40, panelSideBar.Width - 40);
            pictureBoxProfileBorder.BackColor = Color.White;
            m_PictureBoxProfilePicture = new PictureBoxOval(pictureBoxProfileBorder.Width - 10, pictureBoxProfileBorder.Height - 10);
            m_PictureBoxProfilePicture.BackgroundImageLayout = ImageLayout.Stretch;
            pictureBoxProfileBorder.Controls.Add(m_PictureBoxProfilePicture);
            pictureBoxProfileBorder.Top = 10;
            pictureBoxProfileBorder.Left = (panelSideBar.Width - pictureBoxProfileBorder.Width) / 2;
            m_PictureBoxProfilePicture.Left = (pictureBoxProfileBorder.Width - m_PictureBoxProfilePicture.Width) / 2;
            m_PictureBoxProfilePicture.Top = (pictureBoxProfileBorder.Height - m_PictureBoxProfilePicture.Height) / 2;
            panelProfile.Controls.Add(pictureBoxProfileBorder);
            LabelName.Left = (panelProfile.Width - LabelName.Width) / 2;
            LabelName.Top = pictureBoxProfileBorder.Bottom + 5;
            panelProfile.Height = LabelName.Bottom + 5;
        }

        private void setMainMenuToLoggedOutUser()
        {
            m_SubForm?.Close();
            panelMain.Controls.Clear();
            LabelName.Text = @"Please log in";
            m_PictureBoxProfilePicture.Cursor = Cursors.Default;
            m_PictureBoxProfilePicture.BackgroundImage = Properties.Resources.guest;
            LabelName.Left = (panelProfile.Width - LabelName.Width) / 2;
            panelProfile.Enabled = false;
            foreach (Control control in panelMenu.Controls)
            {
                control.Enabled = false;
            }

            buttonLogin.Enabled = true;
        }

        private void setMainMenuToLoggedInUser()
        {
            LabelName.Text = r_UserManager.LoggedInUserName;
            LabelName.Left = (panelProfile.Width - LabelName.Width) / 2;
            m_PictureBoxProfilePicture.Cursor = Cursors.Hand;
            m_PictureBoxProfilePicture.BackgroundImage = r_UserManager.ProfilePicLarge;
            panelProfile.Enabled = true;
            foreach (Control control in panelMenu.Controls)
            {
                control.Enabled = true;
            }

            buttonLogin.Enabled = false;
        }

        private void setPanelsColors()
        {
            panelSideBar.BackColor = ColorsUtils.sr_SideBarColor;
            panelMain.BackColor = ColorsUtils.sr_MainColor;
            panelTopBar.BackColor = ColorsUtils.sr_TopBarColor;
            panelProfile.BackColor = ColorsUtils.sr_ProfileInfoColor;
        }

        private void setChosenButtonAsClicked(Button i_ChosenButton)
        {
            if (m_ChosenButton != null)
            {
                m_ChosenButton.BackColor = ColorsUtils.sr_ButtonsDefaultColor;
            }

            m_ChosenButton = i_ChosenButton;
            if (m_ChosenButton != null)
            {
                m_ChosenButton.BackColor = ColorsUtils.sr_ButtonsChosenColor;
            }
        }

        private void setSubForm(Form i_ChosenSubForm)
        {
            m_SubForm?.Close();
            panelMain.Controls.Clear();
            m_SubForm = i_ChosenSubForm;
            i_ChosenSubForm.TopLevel = false;
            i_ChosenSubForm.Dock = DockStyle.Fill;
            i_ChosenSubForm.FormBorderStyle = FormBorderStyle.None;
            panelMain.Controls.Add(i_ChosenSubForm);
            i_ChosenSubForm.BringToFront();
            i_ChosenSubForm.BackColor = ColorsUtils.sr_MainColor;
            i_ChosenSubForm.Visible = true;
            i_ChosenSubForm.Show();
        }

        private void buttonLogin_Click(object sender, EventArgs e)
        {
            if(r_UserManager.UserLogInAndReturnIfSucceeded())
            {
                setMainMenuToLoggedInUser();
            }
        }

        private void buttonLogout_Click(object sender, EventArgs e)
        {
            r_UserManager.UserLogOut();
            setChosenButtonAsClicked(null);
            setMainMenuToLoggedOutUser();
        }

        private void buttonProfile_Click(object sender, EventArgs e)
        {
            setChosenButtonAsClicked(buttonProfile);
            setSubForm(new FormProfile());
        }

        private void buttonGroups_Click(object sender, EventArgs e)
        {
            setChosenButtonAsClicked(buttonGroups);
            setSubForm(new FormGroups());
        }

        private void buttonAlbums_Click(object sender, EventArgs e)
        {
            setChosenButtonAsClicked(buttonAlbums);
            setSubForm(new FormAlbums());
        }

        private void buttonLikedPages_Click(object sender, EventArgs e)
        {
            setChosenButtonAsClicked(buttonLikedPages);
            setSubForm(new FormLikedPages());
        }

        private void buttonPosts_Click(object sender, EventArgs e)
        {
            setChosenButtonAsClicked(buttonPosts);
            setSubForm(new FormPosts());
        }
    }
}
