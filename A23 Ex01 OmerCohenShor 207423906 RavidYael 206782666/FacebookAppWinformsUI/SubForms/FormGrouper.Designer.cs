
namespace BasicFacebookFeatures.SubForms
{
    partial class FormGrouper
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormGrouper));
            this.panelMain = new System.Windows.Forms.Panel();
            this.labelChooseFriends = new System.Windows.Forms.Label();
            this.buttonCrateGroup = new System.Windows.Forms.Button();
            this.checkedListBoxMatchedUsers = new System.Windows.Forms.CheckedListBox();
            this.panelHeader = new System.Windows.Forms.Panel();
            this.pictureBoxHeadline = new System.Windows.Forms.PictureBox();
            this.flowLayoutPanelGroups = new System.Windows.Forms.FlowLayoutPanel();
            this.panelMain.SuspendLayout();
            this.panelHeader.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxHeadline)).BeginInit();
            this.SuspendLayout();
            // 
            // panelMain
            // 
            this.panelMain.BackColor = System.Drawing.Color.Transparent;
            this.panelMain.Controls.Add(this.labelChooseFriends);
            this.panelMain.Controls.Add(this.buttonCrateGroup);
            this.panelMain.Controls.Add(this.checkedListBoxMatchedUsers);
            this.panelMain.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelMain.Location = new System.Drawing.Point(0, 78);
            this.panelMain.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.panelMain.Name = "panelMain";
            this.panelMain.Size = new System.Drawing.Size(800, 387);
            this.panelMain.TabIndex = 9;
            // 
            // labelChooseFriends
            // 
            this.labelChooseFriends.AutoSize = true;
            this.labelChooseFriends.BackColor = System.Drawing.Color.Transparent;
            this.labelChooseFriends.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.labelChooseFriends.Location = new System.Drawing.Point(393, 16);
            this.labelChooseFriends.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.labelChooseFriends.Name = "labelChooseFriends";
            this.labelChooseFriends.Size = new System.Drawing.Size(197, 29);
            this.labelChooseFriends.TabIndex = 2;
            this.labelChooseFriends.Text = "Choose friends:";
            // 
            // buttonCrateGroup
            // 
            this.buttonCrateGroup.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.buttonCrateGroup.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.buttonCrateGroup.Location = new System.Drawing.Point(465, 328);
            this.buttonCrateGroup.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.buttonCrateGroup.Name = "buttonCrateGroup";
            this.buttonCrateGroup.Size = new System.Drawing.Size(240, 48);
            this.buttonCrateGroup.TabIndex = 1;
            this.buttonCrateGroup.Text = "Create friend list";
            this.buttonCrateGroup.UseVisualStyleBackColor = true;
            this.buttonCrateGroup.Click += new System.EventHandler(this.buttonCrateGroup_Click);
            // 
            // checkedListBoxMatchedUsers
            // 
            this.checkedListBoxMatchedUsers.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.checkedListBoxMatchedUsers.FormattingEnabled = true;
            this.checkedListBoxMatchedUsers.Location = new System.Drawing.Point(393, 54);
            this.checkedListBoxMatchedUsers.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.checkedListBoxMatchedUsers.Name = "checkedListBoxMatchedUsers";
            this.checkedListBoxMatchedUsers.Size = new System.Drawing.Size(387, 242);
            this.checkedListBoxMatchedUsers.TabIndex = 0;
            // 
            // panelHeader
            // 
            this.panelHeader.BackColor = System.Drawing.Color.Transparent;
            this.panelHeader.Controls.Add(this.pictureBoxHeadline);
            this.panelHeader.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelHeader.Location = new System.Drawing.Point(0, 0);
            this.panelHeader.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.panelHeader.Name = "panelHeader";
            this.panelHeader.Size = new System.Drawing.Size(800, 78);
            this.panelHeader.TabIndex = 8;
            // 
            // pictureBoxHeadline
            // 
            this.pictureBoxHeadline.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.pictureBoxHeadline.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("pictureBoxHeadline.BackgroundImage")));
            this.pictureBoxHeadline.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pictureBoxHeadline.Location = new System.Drawing.Point(237, 7);
            this.pictureBoxHeadline.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.pictureBoxHeadline.Name = "pictureBoxHeadline";
            this.pictureBoxHeadline.Size = new System.Drawing.Size(309, 68);
            this.pictureBoxHeadline.TabIndex = 4;
            this.pictureBoxHeadline.TabStop = false;
            // 
            // flowLayoutPanelGroups
            // 
            this.flowLayoutPanelGroups.AutoScroll = true;
            this.flowLayoutPanelGroups.BackColor = System.Drawing.Color.Transparent;
            this.flowLayoutPanelGroups.Dock = System.Windows.Forms.DockStyle.Left;
            this.flowLayoutPanelGroups.Location = new System.Drawing.Point(0, 78);
            this.flowLayoutPanelGroups.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.flowLayoutPanelGroups.Name = "flowLayoutPanelGroups";
            this.flowLayoutPanelGroups.Size = new System.Drawing.Size(376, 387);
            this.flowLayoutPanelGroups.TabIndex = 10;
            // 
            // FormGrouper
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 465);
            this.Controls.Add(this.flowLayoutPanelGroups);
            this.Controls.Add(this.panelMain);
            this.Controls.Add(this.panelHeader);
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "FormGrouper";
            this.Text = "FormGrouper";
            this.panelMain.ResumeLayout(false);
            this.panelMain.PerformLayout();
            this.panelHeader.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxHeadline)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panelMain;
        private System.Windows.Forms.Panel panelHeader;
        private System.Windows.Forms.PictureBox pictureBoxHeadline;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanelGroups;
        private System.Windows.Forms.Button buttonCrateGroup;
        private System.Windows.Forms.CheckedListBox checkedListBoxMatchedUsers;
        private System.Windows.Forms.Label labelChooseFriends;
    }
}