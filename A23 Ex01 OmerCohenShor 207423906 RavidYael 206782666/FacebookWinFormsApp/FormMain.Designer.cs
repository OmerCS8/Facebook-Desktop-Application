namespace BasicFacebookFeatures
{
    partial class FormMain
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormMain));
            this.panelTopBar = new System.Windows.Forms.Panel();
            this.labelHeadline = new System.Windows.Forms.Label();
            this.panelSideBar = new System.Windows.Forms.Panel();
            this.panelMenu = new System.Windows.Forms.Panel();
            this.buttonLogout = new System.Windows.Forms.Button();
            this.buttonLogin = new System.Windows.Forms.Button();
            this.panelProfile = new System.Windows.Forms.Panel();
            this.LabelName = new System.Windows.Forms.Label();
            this.panelMain = new System.Windows.Forms.Panel();
            this.buttonFeed = new System.Windows.Forms.Button();
            this.buttonSearch = new System.Windows.Forms.Button();
            this.panelTopBar.SuspendLayout();
            this.panelSideBar.SuspendLayout();
            this.panelMenu.SuspendLayout();
            this.panelProfile.SuspendLayout();
            this.SuspendLayout();
            // 
            // panelTopBar
            // 
            this.panelTopBar.Controls.Add(this.labelHeadline);
            this.panelTopBar.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelTopBar.Location = new System.Drawing.Point(0, 0);
            this.panelTopBar.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.panelTopBar.Name = "panelTopBar";
            this.panelTopBar.Size = new System.Drawing.Size(1486, 118);
            this.panelTopBar.TabIndex = 0;
            // 
            // labelHeadline
            // 
            this.labelHeadline.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.labelHeadline.AutoSize = true;
            this.labelHeadline.Font = new System.Drawing.Font("Arial", 48F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.labelHeadline.ForeColor = System.Drawing.Color.White;
            this.labelHeadline.Location = new System.Drawing.Point(470, 2);
            this.labelHeadline.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.labelHeadline.Name = "labelHeadline";
            this.labelHeadline.Size = new System.Drawing.Size(578, 111);
            this.labelHeadline.TabIndex = 55;
            this.labelHeadline.Text = "Facebook +";
            // 
            // panelSideBar
            // 
            this.panelSideBar.Controls.Add(this.panelMenu);
            this.panelSideBar.Controls.Add(this.panelProfile);
            this.panelSideBar.Dock = System.Windows.Forms.DockStyle.Left;
            this.panelSideBar.Location = new System.Drawing.Point(0, 118);
            this.panelSideBar.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.panelSideBar.Name = "panelSideBar";
            this.panelSideBar.Size = new System.Drawing.Size(268, 893);
            this.panelSideBar.TabIndex = 1;
            // 
            // panelMenu
            // 
            this.panelMenu.AutoScroll = true;
            this.panelMenu.Controls.Add(this.buttonSearch);
            this.panelMenu.Controls.Add(this.buttonFeed);
            this.panelMenu.Controls.Add(this.buttonLogout);
            this.panelMenu.Controls.Add(this.buttonLogin);
            this.panelMenu.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelMenu.Location = new System.Drawing.Point(0, 249);
            this.panelMenu.Name = "panelMenu";
            this.panelMenu.Size = new System.Drawing.Size(268, 644);
            this.panelMenu.TabIndex = 1;
            // 
            // buttonLogout
            // 
            this.buttonLogout.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.buttonLogout.BackColor = System.Drawing.Color.LightSteelBlue;
            this.buttonLogout.Cursor = System.Windows.Forms.Cursors.Hand;
            this.buttonLogout.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.buttonLogout.Location = new System.Drawing.Point(4, 57);
            this.buttonLogout.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.buttonLogout.Name = "buttonLogout";
            this.buttonLogout.Size = new System.Drawing.Size(260, 51);
            this.buttonLogout.TabIndex = 54;
            this.buttonLogout.Text = "Logout";
            this.buttonLogout.UseVisualStyleBackColor = false;
            this.buttonLogout.Click += new System.EventHandler(this.buttonLogout_Click);
            // 
            // buttonLogin
            // 
            this.buttonLogin.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.buttonLogin.BackColor = System.Drawing.Color.LightSteelBlue;
            this.buttonLogin.Cursor = System.Windows.Forms.Cursors.Hand;
            this.buttonLogin.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.buttonLogin.Location = new System.Drawing.Point(4, 6);
            this.buttonLogin.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.buttonLogin.Name = "buttonLogin";
            this.buttonLogin.Size = new System.Drawing.Size(260, 51);
            this.buttonLogin.TabIndex = 53;
            this.buttonLogin.Text = "Login";
            this.buttonLogin.UseVisualStyleBackColor = false;
            this.buttonLogin.Click += new System.EventHandler(this.buttonLogin_Click);
            // 
            // panelProfile
            // 
            this.panelProfile.Controls.Add(this.LabelName);
            this.panelProfile.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelProfile.Location = new System.Drawing.Point(0, 0);
            this.panelProfile.Name = "panelProfile";
            this.panelProfile.Size = new System.Drawing.Size(268, 249);
            this.panelProfile.TabIndex = 0;
            // 
            // LabelName
            // 
            this.LabelName.AutoSize = true;
            this.LabelName.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.LabelName.Location = new System.Drawing.Point(56, 208);
            this.LabelName.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.LabelName.Name = "LabelName";
            this.LabelName.Size = new System.Drawing.Size(135, 29);
            this.LabelName.TabIndex = 55;
            this.LabelName.Text = "user name";
            // 
            // panelMain
            // 
            this.panelMain.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelMain.Location = new System.Drawing.Point(268, 118);
            this.panelMain.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.panelMain.Name = "panelMain";
            this.panelMain.Size = new System.Drawing.Size(1218, 893);
            this.panelMain.TabIndex = 2;
            // 
            // buttonFeed
            // 
            this.buttonFeed.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.buttonFeed.BackColor = System.Drawing.Color.LightSteelBlue;
            this.buttonFeed.Cursor = System.Windows.Forms.Cursors.Hand;
            this.buttonFeed.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.buttonFeed.Location = new System.Drawing.Point(4, 108);
            this.buttonFeed.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.buttonFeed.Name = "buttonFeed";
            this.buttonFeed.Size = new System.Drawing.Size(260, 51);
            this.buttonFeed.TabIndex = 55;
            this.buttonFeed.Text = "Feed";
            this.buttonFeed.UseVisualStyleBackColor = false;
            // 
            // buttonSearch
            // 
            this.buttonSearch.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.buttonSearch.BackColor = System.Drawing.Color.LightSteelBlue;
            this.buttonSearch.Cursor = System.Windows.Forms.Cursors.Hand;
            this.buttonSearch.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.buttonSearch.Location = new System.Drawing.Point(4, 159);
            this.buttonSearch.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.buttonSearch.Name = "buttonSearch";
            this.buttonSearch.Size = new System.Drawing.Size(260, 51);
            this.buttonSearch.TabIndex = 56;
            this.buttonSearch.Text = "Search";
            this.buttonSearch.UseVisualStyleBackColor = false;
            // 
            // FormMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Window;
            this.ClientSize = new System.Drawing.Size(1486, 1011);
            this.Controls.Add(this.panelMain);
            this.Controls.Add(this.panelSideBar);
            this.Controls.Add(this.panelTopBar);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.MinimumSize = new System.Drawing.Size(900, 900);
            this.Name = "FormMain";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Facebook +";
            this.panelTopBar.ResumeLayout(false);
            this.panelTopBar.PerformLayout();
            this.panelSideBar.ResumeLayout(false);
            this.panelMenu.ResumeLayout(false);
            this.panelProfile.ResumeLayout(false);
            this.panelProfile.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panelTopBar;
        private System.Windows.Forms.Panel panelSideBar;
        private System.Windows.Forms.Button buttonLogout;
        private System.Windows.Forms.Button buttonLogin;
        private System.Windows.Forms.Panel panelMain;
        private System.Windows.Forms.Label LabelName;
        private System.Windows.Forms.Label labelHeadline;
        private System.Windows.Forms.Panel panelMenu;
        private System.Windows.Forms.Panel panelProfile;
        private System.Windows.Forms.Button buttonSearch;
        private System.Windows.Forms.Button buttonFeed;
    }
}

