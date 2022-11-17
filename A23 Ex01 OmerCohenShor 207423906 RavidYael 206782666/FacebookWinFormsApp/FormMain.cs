using System;
using System.Windows.Forms;
using FacebookWrapper.ObjectModel;
using FacebookWrapper;

namespace BasicFacebookFeatures
{
    public partial class FormMain : Form
    {
        public FormMain()
        {
            InitializeComponent();
            FacebookWrapper.FacebookService.s_CollectionLimit = 100;
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
