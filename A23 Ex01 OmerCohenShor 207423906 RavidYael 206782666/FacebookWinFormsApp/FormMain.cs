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
            splitContainerMain.Panel1.BackColor = Color.FromArgb(66, 103, 178);
            PictureBoxOval pictureBoxProfile = new PictureBoxOval(100,100);
            pictureBoxProfile.Parent = splitContainerMain.Panel1;
            pictureBoxProfile.Left = (splitContainerMain.Panel1.Width - 100) / 2;
            pictureBoxProfile.Top = 5;
            splitContainerMain.Panel2.BackColor = Color.FromArgb(247, 247, 247);
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
