using System;
using System.Windows.Forms;
using FacebookWrapper.ObjectModel;
using FacebookWrapper;
using System.Drawing;
using System.Drawing.Drawing2D;
using CefSharp.DevTools.Profiler;

namespace BasicFacebookFeatures
{
    public partial class FormMain : Form
    {
        private PictureBoxOval m_PictureBoxProfilePicture;
        private Button m_ChosenButton = null;

        public FormMain()
        {
            InitializeComponent();
            FacebookWrapper.FacebookService.s_CollectionLimit = 100;
            setPanelsColors();
            initializeProfilePanel();
            initializeMenuPanel();
            setHeadlineLocation();
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

        private void setHeadlineLocation()
        {
            labelHeadline.Top = (panelTopBar.Height - labelHeadline.Height) / 2;
            labelHeadline.Left = (panelTopBar.Width - labelHeadline.Width) / 2;
        }

        private void initializeProfilePanel()
        {
            PictureBoxOval pictureBoxProfileBorder = new PictureBoxOval(panelSideBar.Width - 40, panelSideBar.Width - 40);
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
            panelMain.Controls.Clear();
            LabelName.Text = "Please log in";
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

        private void setMainMenuToLoggedInUser(LoginResult i_LoginResult)
        {
            LabelName.Text = i_LoginResult.LoggedInUser.Name;
            LabelName.Left = (panelProfile.Width - LabelName.Width) / 2;
            m_PictureBoxProfilePicture.Cursor = Cursors.Hand;
            panelProfile.Enabled = true;
            setChosenButtonAsClicked(buttonProfile);
            foreach (Control control in panelMenu.Controls)
            {
                control.Enabled = true;
            }

            buttonLogin.Enabled = false;
        }

        private void setPanelsColors()
        {
            panelSideBar.BackColor = ColorsUtils.r_SideBarColor;
            panelMain.BackColor = ColorsUtils.r_MainColor;
            panelTopBar.BackColor = ColorsUtils.r_TopBarColor;
            panelProfile.BackColor = ColorsUtils.r_ProfileInfoColor;
        }

        private void buttonLogin_Click(object sender, EventArgs e)
        {
            Clipboard.SetText("design.patterns20cc");
            LoginResult loginResult = FacebookService.Login(
                "522656449734305",
                "email",
                "public_profile"
            );
            if(loginResult.LoggedInUser != null)
            {
                setMainMenuToLoggedInUser(loginResult);
            }
        }

        private void buttonLogout_Click(object sender, EventArgs e)
        {
            FacebookService.Logout();
            setChosenButtonAsClicked(null);
            setMainMenuToLoggedOutUser();
        }

        private void setChosenButtonAsClicked(Button i_ChosenButton)
        {
            if (m_ChosenButton != null)
            {
                m_ChosenButton.BackColor = ColorsUtils.r_buttonsDefaultColor;
            }

            m_ChosenButton = i_ChosenButton;
            if (m_ChosenButton != null)
            {
                m_ChosenButton.BackColor = ColorsUtils.r_buttonsChosenColor;
            }
        }

        private void buttonProfile_Click(object sender, EventArgs e)
        {
            setChosenButtonAsClicked(buttonProfile);
        }

        private void buttonGroups_Click(object sender, EventArgs e)
        {
            setChosenButtonAsClicked(buttonGroups);
        }

        private void buttonAlbums_Click(object sender, EventArgs e)
        {
            setChosenButtonAsClicked(buttonAlbums);
        }

        private void buttonLikedPages_Click(object sender, EventArgs e)
        {
            setChosenButtonAsClicked(buttonLikedPages);
        }

        private void buttonPosts_Click(object sender, EventArgs e)
        {
            setChosenButtonAsClicked(buttonPosts);
        }
    }
}
