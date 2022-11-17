using System;
using System.Windows.Forms;
using FacebookWrapper.ObjectModel;
using FacebookWrapper;
using System.Drawing;
using System.Drawing.Drawing2D;

namespace BasicFacebookFeatures
{
    public partial class FormMain : Form
    {
        public FormMain()
        {
            InitializeComponent();
            FacebookWrapper.FacebookService.s_CollectionLimit = 100;
            setPanelsColors();
            initializeProfilePictureBox();

        }

        private void initializeProfilePictureBox()
        {
            PictureBoxOval pictureBoxProfileBorder = new PictureBoxOval(panelSideBar.Width - 20, panelSideBar.Width - 20);
            PictureBoxOval pictureBoxProfilePicture = new PictureBoxOval(pictureBoxProfileBorder.Width - 10, pictureBoxProfileBorder.Height - 10);
            pictureBoxProfilePicture.BackgroundImage = Properties.Resources.guest;
            pictureBoxProfilePicture.BackgroundImageLayout = ImageLayout.Stretch;
            pictureBoxProfileBorder.Controls.Add(pictureBoxProfilePicture);
            pictureBoxProfileBorder.Top = 10;
            pictureBoxProfileBorder.Left = (panelSideBar.Width - pictureBoxProfileBorder.Width) / 2;
            pictureBoxProfilePicture.Left = (pictureBoxProfileBorder.Width - pictureBoxProfilePicture.Width) / 2;
            pictureBoxProfilePicture.Top = (pictureBoxProfileBorder.Height - pictureBoxProfilePicture.Height) / 2;
            panelSideBar.Controls.Add(pictureBoxProfileBorder);


//            pictureBoxProfileBorder.Visible = false;
//            pictureBoxProfilePicture.Visible = false;
        }

        private void setPanelsColors()
        {
            panelSideBar.BackColor = ColorsUtils.r_SideBarColor;
            panelMain.BackColor = ColorsUtils.r_MainColor;
            panelTopBar.BackColor = ColorsUtils.r_TopBarColor;
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
                buttonLogin.Text = $"Logged in as {loginResult.LoggedInUser.Name}";
            }
        }

        private void buttonLogout_Click(object sender, EventArgs e)
        {
			FacebookService.LogoutWithUI();
			buttonLogin.Text = "Login";
		}
    }
}
