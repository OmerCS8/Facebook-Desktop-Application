﻿namespace BasicFacebookFeatures
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
            this.buttonGrouper = new System.Windows.Forms.Button();
            this.buttonMemoryGame = new System.Windows.Forms.Button();
            this.labelHeadline = new System.Windows.Forms.Label();
            this.panelSideBar = new System.Windows.Forms.Panel();
            this.panelMenu = new System.Windows.Forms.Panel();
            this.buttonGroups = new System.Windows.Forms.Button();
            this.buttonPosts = new System.Windows.Forms.Button();
            this.buttonLikedPages = new System.Windows.Forms.Button();
            this.buttonAlbums = new System.Windows.Forms.Button();
            this.buttonProfile = new System.Windows.Forms.Button();
            this.buttonLogout = new System.Windows.Forms.Button();
            this.buttonLogin = new System.Windows.Forms.Button();
            this.panelProfile = new System.Windows.Forms.Panel();
            this.checkBoxRememberMe = new System.Windows.Forms.CheckBox();
            this.LabelName = new System.Windows.Forms.Label();
            this.panelMain = new System.Windows.Forms.Panel();
            this.panelTopBar.SuspendLayout();
            this.panelSideBar.SuspendLayout();
            this.panelMenu.SuspendLayout();
            this.panelProfile.SuspendLayout();
            this.SuspendLayout();
            // 
            // panelTopBar
            // 
            this.panelTopBar.Controls.Add(this.buttonGrouper);
            this.panelTopBar.Controls.Add(this.buttonMemoryGame);
            this.panelTopBar.Controls.Add(this.labelHeadline);
            this.panelTopBar.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelTopBar.Location = new System.Drawing.Point(0, 0);
            this.panelTopBar.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.panelTopBar.Name = "panelTopBar";
            this.panelTopBar.Size = new System.Drawing.Size(1283, 95);
            this.panelTopBar.TabIndex = 0;
            // 
            // buttonGrouper
            // 
            this.buttonGrouper.BackColor = System.Drawing.Color.Transparent;
            this.buttonGrouper.BackgroundImage = global::BasicFacebookFeatures.Properties.Resources.grouper_icon;
            this.buttonGrouper.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.buttonGrouper.Cursor = System.Windows.Forms.Cursors.Hand;
            this.buttonGrouper.Enabled = false;
            this.buttonGrouper.FlatAppearance.BorderSize = 0;
            this.buttonGrouper.FlatAppearance.MouseDownBackColor = System.Drawing.Color.DarkCyan;
            this.buttonGrouper.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Cyan;
            this.buttonGrouper.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonGrouper.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.buttonGrouper.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.buttonGrouper.Location = new System.Drawing.Point(91, 14);
            this.buttonGrouper.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.buttonGrouper.Name = "buttonGrouper";
            this.buttonGrouper.Size = new System.Drawing.Size(69, 70);
            this.buttonGrouper.TabIndex = 57;
            this.buttonGrouper.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.buttonGrouper.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.buttonGrouper.UseVisualStyleBackColor = false;
            this.buttonGrouper.Click += new System.EventHandler(this.subFormButtonClick);
            // 
            // buttonMemoryGame
            // 
            this.buttonMemoryGame.BackColor = System.Drawing.Color.Transparent;
            this.buttonMemoryGame.BackgroundImage = global::BasicFacebookFeatures.Properties.Resources.memory_game_icon;
            this.buttonMemoryGame.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.buttonMemoryGame.Cursor = System.Windows.Forms.Cursors.Hand;
            this.buttonMemoryGame.Enabled = false;
            this.buttonMemoryGame.FlatAppearance.BorderSize = 0;
            this.buttonMemoryGame.FlatAppearance.MouseDownBackColor = System.Drawing.Color.DarkCyan;
            this.buttonMemoryGame.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Cyan;
            this.buttonMemoryGame.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonMemoryGame.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.buttonMemoryGame.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.buttonMemoryGame.Location = new System.Drawing.Point(13, 14);
            this.buttonMemoryGame.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.buttonMemoryGame.Name = "buttonMemoryGame";
            this.buttonMemoryGame.Size = new System.Drawing.Size(69, 70);
            this.buttonMemoryGame.TabIndex = 56;
            this.buttonMemoryGame.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.buttonMemoryGame.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.buttonMemoryGame.UseVisualStyleBackColor = false;
            this.buttonMemoryGame.Click += new System.EventHandler(this.subFormButtonClick);
            // 
            // labelHeadline
            // 
            this.labelHeadline.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.labelHeadline.AutoSize = true;
            this.labelHeadline.Font = new System.Drawing.Font("Arial", 48F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.labelHeadline.ForeColor = System.Drawing.Color.White;
            this.labelHeadline.Location = new System.Drawing.Point(397, 1);
            this.labelHeadline.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.labelHeadline.Name = "labelHeadline";
            this.labelHeadline.Size = new System.Drawing.Size(481, 93);
            this.labelHeadline.TabIndex = 55;
            this.labelHeadline.Text = "Facebook +";
            // 
            // panelSideBar
            // 
            this.panelSideBar.Controls.Add(this.panelMenu);
            this.panelSideBar.Controls.Add(this.panelProfile);
            this.panelSideBar.Dock = System.Windows.Forms.DockStyle.Left;
            this.panelSideBar.Location = new System.Drawing.Point(0, 95);
            this.panelSideBar.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.panelSideBar.Name = "panelSideBar";
            this.panelSideBar.Size = new System.Drawing.Size(239, 608);
            this.panelSideBar.TabIndex = 1;
            // 
            // panelMenu
            // 
            this.panelMenu.AutoScroll = true;
            this.panelMenu.Controls.Add(this.buttonGroups);
            this.panelMenu.Controls.Add(this.buttonPosts);
            this.panelMenu.Controls.Add(this.buttonLikedPages);
            this.panelMenu.Controls.Add(this.buttonAlbums);
            this.panelMenu.Controls.Add(this.buttonProfile);
            this.panelMenu.Controls.Add(this.buttonLogout);
            this.panelMenu.Controls.Add(this.buttonLogin);
            this.panelMenu.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelMenu.Location = new System.Drawing.Point(0, 228);
            this.panelMenu.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.panelMenu.Name = "panelMenu";
            this.panelMenu.Size = new System.Drawing.Size(239, 380);
            this.panelMenu.TabIndex = 1;
            // 
            // buttonGroups
            // 
            this.buttonGroups.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.buttonGroups.BackColor = System.Drawing.Color.Transparent;
            this.buttonGroups.Cursor = System.Windows.Forms.Cursors.Arrow;
            this.buttonGroups.FlatAppearance.BorderSize = 0;
            this.buttonGroups.FlatAppearance.MouseDownBackColor = System.Drawing.Color.DarkCyan;
            this.buttonGroups.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Cyan;
            this.buttonGroups.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonGroups.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.buttonGroups.Image = global::BasicFacebookFeatures.Properties.Resources.groups_icon;
            this.buttonGroups.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.buttonGroups.Location = new System.Drawing.Point(0, 103);
            this.buttonGroups.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.buttonGroups.Name = "buttonGroups";
            this.buttonGroups.Size = new System.Drawing.Size(239, 54);
            this.buttonGroups.TabIndex = 59;
            this.buttonGroups.Text = "  Groups";
            this.buttonGroups.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.buttonGroups.UseVisualStyleBackColor = false;
            this.buttonGroups.Click += new System.EventHandler(this.subFormButtonClick);
            // 
            // buttonPosts
            // 
            this.buttonPosts.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.buttonPosts.BackColor = System.Drawing.Color.Transparent;
            this.buttonPosts.Cursor = System.Windows.Forms.Cursors.Arrow;
            this.buttonPosts.FlatAppearance.BorderSize = 0;
            this.buttonPosts.FlatAppearance.MouseDownBackColor = System.Drawing.Color.DarkCyan;
            this.buttonPosts.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Cyan;
            this.buttonPosts.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonPosts.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.buttonPosts.Image = global::BasicFacebookFeatures.Properties.Resources.posts_icon;
            this.buttonPosts.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.buttonPosts.Location = new System.Drawing.Point(0, 247);
            this.buttonPosts.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.buttonPosts.Name = "buttonPosts";
            this.buttonPosts.Size = new System.Drawing.Size(239, 54);
            this.buttonPosts.TabIndex = 58;
            this.buttonPosts.Text = "  Posts";
            this.buttonPosts.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.buttonPosts.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.buttonPosts.UseVisualStyleBackColor = false;
            this.buttonPosts.Click += new System.EventHandler(this.subFormButtonClick);
            // 
            // buttonLikedPages
            // 
            this.buttonLikedPages.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.buttonLikedPages.BackColor = System.Drawing.Color.Transparent;
            this.buttonLikedPages.Cursor = System.Windows.Forms.Cursors.Arrow;
            this.buttonLikedPages.FlatAppearance.BorderSize = 0;
            this.buttonLikedPages.FlatAppearance.MouseDownBackColor = System.Drawing.Color.DarkCyan;
            this.buttonLikedPages.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Cyan;
            this.buttonLikedPages.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonLikedPages.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.buttonLikedPages.Image = global::BasicFacebookFeatures.Properties.Resources.liked_pages_icon;
            this.buttonLikedPages.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.buttonLikedPages.Location = new System.Drawing.Point(0, 199);
            this.buttonLikedPages.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.buttonLikedPages.Name = "buttonLikedPages";
            this.buttonLikedPages.Size = new System.Drawing.Size(239, 54);
            this.buttonLikedPages.TabIndex = 57;
            this.buttonLikedPages.Text = "  Liked pages";
            this.buttonLikedPages.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.buttonLikedPages.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.buttonLikedPages.UseVisualStyleBackColor = false;
            this.buttonLikedPages.Click += new System.EventHandler(this.subFormButtonClick);
            // 
            // buttonAlbums
            // 
            this.buttonAlbums.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.buttonAlbums.BackColor = System.Drawing.Color.Transparent;
            this.buttonAlbums.Cursor = System.Windows.Forms.Cursors.Arrow;
            this.buttonAlbums.FlatAppearance.BorderSize = 0;
            this.buttonAlbums.FlatAppearance.MouseDownBackColor = System.Drawing.Color.DarkCyan;
            this.buttonAlbums.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Cyan;
            this.buttonAlbums.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonAlbums.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.buttonAlbums.Image = global::BasicFacebookFeatures.Properties.Resources.albums_icon;
            this.buttonAlbums.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.buttonAlbums.Location = new System.Drawing.Point(0, 151);
            this.buttonAlbums.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.buttonAlbums.Name = "buttonAlbums";
            this.buttonAlbums.Size = new System.Drawing.Size(239, 54);
            this.buttonAlbums.TabIndex = 56;
            this.buttonAlbums.Text = "  Albums";
            this.buttonAlbums.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.buttonAlbums.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.buttonAlbums.UseVisualStyleBackColor = false;
            this.buttonAlbums.Click += new System.EventHandler(this.subFormButtonClick);
            // 
            // buttonProfile
            // 
            this.buttonProfile.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.buttonProfile.BackColor = System.Drawing.Color.Transparent;
            this.buttonProfile.Cursor = System.Windows.Forms.Cursors.Arrow;
            this.buttonProfile.FlatAppearance.BorderSize = 0;
            this.buttonProfile.FlatAppearance.MouseDownBackColor = System.Drawing.Color.DarkCyan;
            this.buttonProfile.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Cyan;
            this.buttonProfile.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonProfile.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.buttonProfile.Image = global::BasicFacebookFeatures.Properties.Resources.profile_icon;
            this.buttonProfile.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.buttonProfile.Location = new System.Drawing.Point(0, 55);
            this.buttonProfile.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.buttonProfile.Name = "buttonProfile";
            this.buttonProfile.Size = new System.Drawing.Size(239, 54);
            this.buttonProfile.TabIndex = 55;
            this.buttonProfile.Text = "  Profile";
            this.buttonProfile.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.buttonProfile.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.buttonProfile.UseVisualStyleBackColor = false;
            this.buttonProfile.Click += new System.EventHandler(this.subFormButtonClick);
            // 
            // buttonLogout
            // 
            this.buttonLogout.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.buttonLogout.BackColor = System.Drawing.Color.Transparent;
            this.buttonLogout.Cursor = System.Windows.Forms.Cursors.Arrow;
            this.buttonLogout.FlatAppearance.BorderSize = 0;
            this.buttonLogout.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Crimson;
            this.buttonLogout.FlatAppearance.MouseOverBackColor = System.Drawing.Color.IndianRed;
            this.buttonLogout.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonLogout.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.buttonLogout.Image = global::BasicFacebookFeatures.Properties.Resources.logout_icon;
            this.buttonLogout.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.buttonLogout.Location = new System.Drawing.Point(0, 295);
            this.buttonLogout.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.buttonLogout.Name = "buttonLogout";
            this.buttonLogout.Size = new System.Drawing.Size(239, 54);
            this.buttonLogout.TabIndex = 54;
            this.buttonLogout.Text = "  Logout";
            this.buttonLogout.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.buttonLogout.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.buttonLogout.UseVisualStyleBackColor = false;
            this.buttonLogout.Click += new System.EventHandler(this.buttonLogout_Click);
            // 
            // buttonLogin
            // 
            this.buttonLogin.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.buttonLogin.BackColor = System.Drawing.Color.Transparent;
            this.buttonLogin.Cursor = System.Windows.Forms.Cursors.Arrow;
            this.buttonLogin.FlatAppearance.BorderSize = 0;
            this.buttonLogin.FlatAppearance.MouseDownBackColor = System.Drawing.Color.DarkCyan;
            this.buttonLogin.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Cyan;
            this.buttonLogin.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonLogin.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.buttonLogin.Image = global::BasicFacebookFeatures.Properties.Resources.login_icon;
            this.buttonLogin.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.buttonLogin.Location = new System.Drawing.Point(0, 7);
            this.buttonLogin.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.buttonLogin.Name = "buttonLogin";
            this.buttonLogin.Size = new System.Drawing.Size(239, 54);
            this.buttonLogin.TabIndex = 53;
            this.buttonLogin.Text = "  Login";
            this.buttonLogin.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.buttonLogin.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.buttonLogin.UseVisualStyleBackColor = false;
            this.buttonLogin.Click += new System.EventHandler(this.buttonLogin_Click);
            // 
            // panelProfile
            // 
            this.panelProfile.BackColor = System.Drawing.Color.LightSteelBlue;
            this.panelProfile.Controls.Add(this.checkBoxRememberMe);
            this.panelProfile.Controls.Add(this.LabelName);
            this.panelProfile.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelProfile.Location = new System.Drawing.Point(0, 0);
            this.panelProfile.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.panelProfile.Name = "panelProfile";
            this.panelProfile.Size = new System.Drawing.Size(239, 228);
            this.panelProfile.TabIndex = 0;
            // 
            // checkBoxRememberMe
            // 
            this.checkBoxRememberMe.AutoSize = true;
            this.checkBoxRememberMe.Location = new System.Drawing.Point(55, 201);
            this.checkBoxRememberMe.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.checkBoxRememberMe.Name = "checkBoxRememberMe";
            this.checkBoxRememberMe.Size = new System.Drawing.Size(122, 21);
            this.checkBoxRememberMe.TabIndex = 56;
            this.checkBoxRememberMe.Text = "Remember me";
            this.checkBoxRememberMe.UseVisualStyleBackColor = true;
            this.checkBoxRememberMe.CheckedChanged += new System.EventHandler(this.checkBoxRememberMe_CheckedChanged);
            // 
            // LabelName
            // 
            this.LabelName.AutoSize = true;
            this.LabelName.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.LabelName.Location = new System.Drawing.Point(56, 172);
            this.LabelName.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.LabelName.Name = "LabelName";
            this.LabelName.Size = new System.Drawing.Size(113, 25);
            this.LabelName.TabIndex = 55;
            this.LabelName.Text = "user name";
            // 
            // panelMain
            // 
            this.panelMain.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelMain.Location = new System.Drawing.Point(239, 95);
            this.panelMain.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.panelMain.Name = "panelMain";
            this.panelMain.Size = new System.Drawing.Size(1044, 608);
            this.panelMain.TabIndex = 2;
            // 
            // FormMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Window;
            this.ClientSize = new System.Drawing.Size(1283, 703);
            this.Controls.Add(this.panelMain);
            this.Controls.Add(this.panelSideBar);
            this.Controls.Add(this.panelTopBar);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.MinimumSize = new System.Drawing.Size(799, 698);
            this.Name = "FormMain";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Facebook +";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.FormMain_FormClosing);
            this.Shown += new System.EventHandler(this.FormMain_Shown);
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
        private System.Windows.Forms.Button buttonGroups;
        private System.Windows.Forms.Button buttonPosts;
        private System.Windows.Forms.Button buttonLikedPages;
        private System.Windows.Forms.Button buttonAlbums;
        private System.Windows.Forms.Button buttonProfile;
        private System.Windows.Forms.Button buttonMemoryGame;
        private System.Windows.Forms.Button buttonGrouper;
        private System.Windows.Forms.CheckBox checkBoxRememberMe;
    }
}

