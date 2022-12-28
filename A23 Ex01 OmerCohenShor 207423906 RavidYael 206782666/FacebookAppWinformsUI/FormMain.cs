using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Windows.Forms;
using FacebookWrapper.ObjectModel;
using FacebookWrapper;
using System.Drawing;
using System.Drawing.Drawing2D;
using BasicFacebookFeatures.FormsUtils;
using BasicFacebookFeatures.SubForms;
using CefSharp.DevTools.Profiler;
using FacebookAppEngine;
using System.Threading;

namespace BasicFacebookFeatures
{
    public partial class FormMain : Form
    {
        private readonly FaceBookUserManager r_UserManager = FaceBookUserManager.Instance; 
        private PictureBoxOval m_PictureBoxProfilePicture;
        private Button m_ChosenButton = null;
        private readonly Dictionary<FormFactory.eFormType, Form> r_CreatedSubForms = new Dictionary<FormFactory.eFormType, Form>();
        private readonly Dictionary<Button, FormFactory.eFormType> r_ButtonToFormTypeDictionary;

        public FormMain()
        {
            InitializeComponent();
            FacebookWrapper.FacebookService.s_CollectionLimit = 100;
            setPanelsColors();
            initializeProfilePanel();
            initializeMenuPanel();
            centerHeadlineLocation();
            r_ButtonToFormTypeDictionary = initializeSubFormsForButtons();
        }
            
        private Dictionary<Button, FormFactory.eFormType> initializeSubFormsForButtons()
        {
            Dictionary<Button, FormFactory.eFormType> buttonToFormTypeDictionary = new Dictionary<Button, FormFactory.eFormType>
                {
                    {buttonAlbums, FormFactory.eFormType.AlbumsForm},
                    {buttonGrouper, FormFactory.eFormType.GrouperForm},
                    {buttonGroups, FormFactory.eFormType.GroupsForm},
                    {buttonLikedPages, FormFactory.eFormType.LikedPagesForm},
                    {buttonMemoryGame, FormFactory.eFormType.MemoryGameForm},
                    {buttonProfile, FormFactory.eFormType.ProfileForm},
                    {buttonPosts, FormFactory.eFormType.PostsForm}
                };

            return buttonToFormTypeDictionary;
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
            labelHeadline.Left = panelSideBar.Width + (panelMain.Width - labelHeadline.Width) / 2;
        }

        private void initializeProfilePanel()
        {
            PictureBoxOval pictureBoxProfileBorder =
                new PictureBoxOval() { Width = panelSideBar.Width - 40, Height = panelSideBar.Width - 40 };
            pictureBoxProfileBorder.BackColor = Color.White;
            m_PictureBoxProfilePicture = 
                new PictureBoxOval() { Width = pictureBoxProfileBorder.Width - 10, Height = pictureBoxProfileBorder.Height - 10 };
            m_PictureBoxProfilePicture.BackgroundImageLayout = ImageLayout.Stretch;
            pictureBoxProfileBorder.Controls.Add(m_PictureBoxProfilePicture);
            pictureBoxProfileBorder.Top = 10;
            pictureBoxProfileBorder.Left = (panelSideBar.Width - pictureBoxProfileBorder.Width) / 2;
            m_PictureBoxProfilePicture.Left = (pictureBoxProfileBorder.Width - m_PictureBoxProfilePicture.Width) / 2;
            m_PictureBoxProfilePicture.Top = (pictureBoxProfileBorder.Height - m_PictureBoxProfilePicture.Height) / 2;
            panelProfile.Controls.Add(pictureBoxProfileBorder);
            LabelName.Top = pictureBoxProfileBorder.Bottom + 5;
            checkBoxRememberMe.Top = LabelName.Bottom + 5;
            checkBoxRememberMe.Left = (panelProfile.Width - checkBoxRememberMe.Width) / 2;
            panelProfile.Height = checkBoxRememberMe.Bottom + 5;
            m_PictureBoxProfilePicture.Click += ((i_Sender, i_Args) => buttonProfile.PerformClick());
        }

        private void setMainMenuToLoggedOutUser()
        {
            r_CreatedSubForms.Clear();
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

            buttonGrouper.Enabled = false;
            buttonMemoryGame.Enabled = false;
            buttonLogin.Enabled = true;
            checkBoxRememberMe.Checked = false;
        }

        private void setMainMenuToLoggedInUser()
        {
            LabelName.Left = (panelProfile.Width - LabelName.Width) / 2;
            m_PictureBoxProfilePicture.Cursor = Cursors.Hand;
            panelProfile.Enabled = true;
            foreach (Control control in panelMenu.Controls)
            {
                control.Enabled = true;
            }

            buttonGrouper.Enabled = true;
            buttonMemoryGame.Enabled = true;
            buttonLogin.Enabled = false;
            checkBoxRememberMe.Checked = r_UserManager.DoesUserWantToRememberHim;
            new Thread(viewLoggedInUserDetails) { IsBackground = true }.Start();
        }

        private void viewLoggedInUserDetails()
        {
            string name = r_UserManager.LoggedInUserName;
            Image profileImage = r_UserManager.LoggedInUserProfilePictureLarge;

            LabelName.Invoke(new Action(() => {
                    LabelName.Text = name;
                    LabelName.Left = (panelProfile.Width - LabelName.Width) / 2;
                }));
            m_PictureBoxProfilePicture.Invoke(
                new Action((() => m_PictureBoxProfilePicture.BackgroundImage = profileImage)));
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
            panelMain.Controls.Clear();
            panelMain.Controls.Add(i_ChosenSubForm);
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

        private void subFormButtonClick(object sender, EventArgs e)
        {
            FormFactory.eFormType requestedFormType;

            if(sender is Button clickedButton)
            {
                requestedFormType = r_ButtonToFormTypeDictionary[clickedButton];
                if(!r_CreatedSubForms.ContainsKey(requestedFormType))
                {
                    r_CreatedSubForms.Add(requestedFormType, FormFactory.CreateForm(requestedFormType));
                }

                setSubForm(r_CreatedSubForms[requestedFormType]);
            }
        }

        private void checkBoxRememberMe_CheckedChanged(object sender, EventArgs e)
        {
            r_UserManager.DoesUserWantToRememberHim = checkBoxRememberMe.Checked;
        }

        private void FormMain_FormClosing(object sender, FormClosingEventArgs e)
        {
            r_UserManager.SaveSettingsChanges();
        }

        private void FormMain_Shown(object sender, EventArgs e)
        {
            if(r_UserManager.TryLogInIfUserIsRememberedAndReturnIfSucceeded())
            {
                setMainMenuToLoggedInUser();
            }
            else
            {
                setMainMenuToLoggedOutUser();
            }
        }
    }
}
