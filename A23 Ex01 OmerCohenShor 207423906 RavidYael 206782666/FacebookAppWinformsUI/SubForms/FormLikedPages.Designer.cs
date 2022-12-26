
namespace BasicFacebookFeatures.SubForms
{
    partial class FormLikedPages
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
            this.labelPagePhone = new System.Windows.Forms.Label();
            this.panelGroupDetails = new System.Windows.Forms.Panel();
            this.flowLayoutPanelPageDetails = new System.Windows.Forms.FlowLayoutPanel();
            this.labelPageName = new System.Windows.Forms.Label();
            this.labelPageLocation = new System.Windows.Forms.Label();
            this.labelPagePosts = new System.Windows.Forms.Label();
            this.labelPageDescription = new System.Windows.Forms.Label();
            this.panelActions = new System.Windows.Forms.Panel();
            this.richTextBoxPage = new System.Windows.Forms.RichTextBox();
            this.buttonPostInPage = new System.Windows.Forms.Button();
            this.flowLayoutPanelPages = new System.Windows.Forms.FlowLayoutPanel();
            this.panelGroupDetails.SuspendLayout();
            this.flowLayoutPanelPageDetails.SuspendLayout();
            this.panelActions.SuspendLayout();
            this.SuspendLayout();
            // 
            // labelPagePhone
            // 
            this.labelPagePhone.AutoSize = true;
            this.labelPagePhone.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.labelPagePhone.Location = new System.Drawing.Point(2, 150);
            this.labelPagePhone.Margin = new System.Windows.Forms.Padding(0, 5, 0, 5);
            this.labelPagePhone.Name = "labelPagePhone";
            this.labelPagePhone.Size = new System.Drawing.Size(135, 25);
            this.labelPagePhone.TabIndex = 4;
            this.labelPagePhone.Text = "Page phone:";
            // 
            // panelGroupDetails
            // 
            this.panelGroupDetails.BackColor = System.Drawing.Color.Transparent;
            this.panelGroupDetails.Controls.Add(this.flowLayoutPanelPageDetails);
            this.panelGroupDetails.Controls.Add(this.panelActions);
            this.panelGroupDetails.Dock = System.Windows.Forms.DockStyle.Right;
            this.panelGroupDetails.Location = new System.Drawing.Point(412, 0);
            this.panelGroupDetails.Name = "panelGroupDetails";
            this.panelGroupDetails.Size = new System.Drawing.Size(388, 450);
            this.panelGroupDetails.TabIndex = 2;
            // 
            // flowLayoutPanelPageDetails
            // 
            this.flowLayoutPanelPageDetails.AutoScroll = true;
            this.flowLayoutPanelPageDetails.Controls.Add(this.labelPageName);
            this.flowLayoutPanelPageDetails.Controls.Add(this.labelPageLocation);
            this.flowLayoutPanelPageDetails.Controls.Add(this.labelPagePosts);
            this.flowLayoutPanelPageDetails.Controls.Add(this.labelPageDescription);
            this.flowLayoutPanelPageDetails.Controls.Add(this.labelPagePhone);
            this.flowLayoutPanelPageDetails.Dock = System.Windows.Forms.DockStyle.Fill;
            this.flowLayoutPanelPageDetails.FlowDirection = System.Windows.Forms.FlowDirection.TopDown;
            this.flowLayoutPanelPageDetails.Location = new System.Drawing.Point(0, 0);
            this.flowLayoutPanelPageDetails.Name = "flowLayoutPanelPageDetails";
            this.flowLayoutPanelPageDetails.Padding = new System.Windows.Forms.Padding(2, 5, 5, 5);
            this.flowLayoutPanelPageDetails.Size = new System.Drawing.Size(388, 205);
            this.flowLayoutPanelPageDetails.TabIndex = 3;
            // 
            // labelPageName
            // 
            this.labelPageName.AutoSize = true;
            this.labelPageName.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.labelPageName.Location = new System.Drawing.Point(2, 10);
            this.labelPageName.Margin = new System.Windows.Forms.Padding(0, 5, 0, 5);
            this.labelPageName.Name = "labelPageName";
            this.labelPageName.Size = new System.Drawing.Size(128, 25);
            this.labelPageName.TabIndex = 0;
            this.labelPageName.Text = "Page name:";
            // 
            // labelPageLocation
            // 
            this.labelPageLocation.AutoSize = true;
            this.labelPageLocation.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.labelPageLocation.Location = new System.Drawing.Point(2, 45);
            this.labelPageLocation.Margin = new System.Windows.Forms.Padding(0, 5, 0, 5);
            this.labelPageLocation.Name = "labelPageLocation";
            this.labelPageLocation.Size = new System.Drawing.Size(150, 25);
            this.labelPageLocation.TabIndex = 1;
            this.labelPageLocation.Text = "Page location:";
            // 
            // labelPagePosts
            // 
            this.labelPagePosts.AutoSize = true;
            this.labelPagePosts.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.labelPagePosts.Location = new System.Drawing.Point(2, 80);
            this.labelPagePosts.Margin = new System.Windows.Forms.Padding(0, 5, 0, 5);
            this.labelPagePosts.Name = "labelPagePosts";
            this.labelPagePosts.Size = new System.Drawing.Size(127, 25);
            this.labelPagePosts.TabIndex = 2;
            this.labelPagePosts.Text = "Page posts:";
            // 
            // labelPageDescription
            // 
            this.labelPageDescription.AutoSize = true;
            this.labelPageDescription.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.labelPageDescription.Location = new System.Drawing.Point(2, 115);
            this.labelPageDescription.Margin = new System.Windows.Forms.Padding(0, 5, 0, 5);
            this.labelPageDescription.Name = "labelPageDescription";
            this.labelPageDescription.Size = new System.Drawing.Size(183, 25);
            this.labelPageDescription.TabIndex = 3;
            this.labelPageDescription.Text = "Page Description:";
            // 
            // panelActions
            // 
            this.panelActions.Controls.Add(this.richTextBoxPage);
            this.panelActions.Controls.Add(this.buttonPostInPage);
            this.panelActions.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panelActions.Location = new System.Drawing.Point(0, 205);
            this.panelActions.Name = "panelActions";
            this.panelActions.Size = new System.Drawing.Size(388, 245);
            this.panelActions.TabIndex = 2;
            // 
            // richTextBoxPage
            // 
            this.richTextBoxPage.Enabled = false;
            this.richTextBoxPage.Location = new System.Drawing.Point(17, 63);
            this.richTextBoxPage.Name = "richTextBoxPage";
            this.richTextBoxPage.Size = new System.Drawing.Size(348, 170);
            this.richTextBoxPage.TabIndex = 6;
            this.richTextBoxPage.Text = "";
            // 
            // buttonPostInPage
            // 
            this.buttonPostInPage.Enabled = false;
            this.buttonPostInPage.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.buttonPostInPage.Location = new System.Drawing.Point(17, 27);
            this.buttonPostInPage.Name = "buttonPostInPage";
            this.buttonPostInPage.Size = new System.Drawing.Size(132, 30);
            this.buttonPostInPage.TabIndex = 5;
            this.buttonPostInPage.Text = "Post in page!";
            this.buttonPostInPage.UseVisualStyleBackColor = true;
            this.buttonPostInPage.Click += new System.EventHandler(this.buttonPostInPage_Click);
            // 
            // flowLayoutPanelPages
            // 
            this.flowLayoutPanelPages.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.flowLayoutPanelPages.AutoScroll = true;
            this.flowLayoutPanelPages.BackColor = System.Drawing.Color.Transparent;
            this.flowLayoutPanelPages.Location = new System.Drawing.Point(-2, 0);
            this.flowLayoutPanelPages.Name = "flowLayoutPanelPages";
            this.flowLayoutPanelPages.Size = new System.Drawing.Size(413, 450);
            this.flowLayoutPanelPages.TabIndex = 3;
            // 
            // FormLikedPages
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.panelGroupDetails);
            this.Controls.Add(this.flowLayoutPanelPages);
            this.Name = "FormLikedPages";
            this.Text = "FormLikedPages";
            this.panelGroupDetails.ResumeLayout(false);
            this.flowLayoutPanelPageDetails.ResumeLayout(false);
            this.flowLayoutPanelPageDetails.PerformLayout();
            this.panelActions.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label labelPagePhone;
        private System.Windows.Forms.Panel panelGroupDetails;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanelPageDetails;
        private System.Windows.Forms.Label labelPageName;
        private System.Windows.Forms.Label labelPageLocation;
        private System.Windows.Forms.Label labelPagePosts;
        private System.Windows.Forms.Label labelPageDescription;
        private System.Windows.Forms.Panel panelActions;
        private System.Windows.Forms.RichTextBox richTextBoxPage;
        private System.Windows.Forms.Button buttonPostInPage;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanelPages;
    }
}