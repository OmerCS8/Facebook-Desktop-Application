
namespace BasicFacebookFeatures.SubForms
{
    partial class FormGroups
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
            this.components = new System.ComponentModel.Container();
            System.Windows.Forms.Label updateTimeLabel;
            System.Windows.Forms.Label privacyLabel;
            System.Windows.Forms.Label nameLabel;
            System.Windows.Forms.Label linkLabel;
            System.Windows.Forms.Label descriptionLabel;
            this.panelGroupDetails = new System.Windows.Forms.Panel();
            this.panel1 = new System.Windows.Forms.Panel();
            this.descriptionRichTextBox = new System.Windows.Forms.RichTextBox();
            this.groupBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.linkLabel1 = new System.Windows.Forms.Label();
            this.nameLabel1 = new System.Windows.Forms.Label();
            this.privacyLabel1 = new System.Windows.Forms.Label();
            this.updateTimeLabel1 = new System.Windows.Forms.Label();
            this.panelActions = new System.Windows.Forms.Panel();
            this.richTextBoxPost = new System.Windows.Forms.RichTextBox();
            this.buttonPostInGroup = new System.Windows.Forms.Button();
            this.flowLayoutPanelGroups = new System.Windows.Forms.FlowLayoutPanel();
            updateTimeLabel = new System.Windows.Forms.Label();
            privacyLabel = new System.Windows.Forms.Label();
            nameLabel = new System.Windows.Forms.Label();
            linkLabel = new System.Windows.Forms.Label();
            descriptionLabel = new System.Windows.Forms.Label();
            this.panelGroupDetails.SuspendLayout();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.groupBindingSource)).BeginInit();
            this.panelActions.SuspendLayout();
            this.SuspendLayout();
            // 
            // updateTimeLabel
            // 
            updateTimeLabel.AutoSize = true;
            updateTimeLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            updateTimeLabel.Location = new System.Drawing.Point(12, 89);
            updateTimeLabel.Name = "updateTimeLabel";
            updateTimeLabel.Size = new System.Drawing.Size(142, 25);
            updateTimeLabel.TabIndex = 8;
            updateTimeLabel.Text = "Update Time:";
            // 
            // privacyLabel
            // 
            privacyLabel.AutoSize = true;
            privacyLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            privacyLabel.Location = new System.Drawing.Point(12, 62);
            privacyLabel.Name = "privacyLabel";
            privacyLabel.Size = new System.Drawing.Size(90, 25);
            privacyLabel.TabIndex = 6;
            privacyLabel.Text = "Privacy:";
            // 
            // nameLabel
            // 
            nameLabel.AutoSize = true;
            nameLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            nameLabel.Location = new System.Drawing.Point(12, 7);
            nameLabel.Name = "nameLabel";
            nameLabel.Size = new System.Drawing.Size(75, 25);
            nameLabel.TabIndex = 4;
            nameLabel.Text = "Name:";
            // 
            // linkLabel
            // 
            linkLabel.AutoSize = true;
            linkLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            linkLabel.Location = new System.Drawing.Point(12, 34);
            linkLabel.Name = "linkLabel";
            linkLabel.Size = new System.Drawing.Size(59, 25);
            linkLabel.TabIndex = 2;
            linkLabel.Text = "Link:";
            // 
            // descriptionLabel
            // 
            descriptionLabel.AutoSize = true;
            descriptionLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            descriptionLabel.Location = new System.Drawing.Point(12, 114);
            descriptionLabel.Name = "descriptionLabel";
            descriptionLabel.Size = new System.Drawing.Size(127, 25);
            descriptionLabel.TabIndex = 0;
            descriptionLabel.Text = "Description:";
            // 
            // panelGroupDetails
            // 
            this.panelGroupDetails.BackColor = System.Drawing.Color.Transparent;
            this.panelGroupDetails.Controls.Add(this.panel1);
            this.panelGroupDetails.Controls.Add(this.panelActions);
            this.panelGroupDetails.Dock = System.Windows.Forms.DockStyle.Right;
            this.panelGroupDetails.Location = new System.Drawing.Point(439, 0);
            this.panelGroupDetails.Name = "panelGroupDetails";
            this.panelGroupDetails.Size = new System.Drawing.Size(388, 471);
            this.panelGroupDetails.TabIndex = 0;
            // 
            // panel1
            // 
            this.panel1.AutoScroll = true;
            this.panel1.Controls.Add(descriptionLabel);
            this.panel1.Controls.Add(this.descriptionRichTextBox);
            this.panel1.Controls.Add(linkLabel);
            this.panel1.Controls.Add(this.linkLabel1);
            this.panel1.Controls.Add(nameLabel);
            this.panel1.Controls.Add(this.nameLabel1);
            this.panel1.Controls.Add(privacyLabel);
            this.panel1.Controls.Add(this.privacyLabel1);
            this.panel1.Controls.Add(updateTimeLabel);
            this.panel1.Controls.Add(this.updateTimeLabel1);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(388, 226);
            this.panel1.TabIndex = 3;
            // 
            // descriptionRichTextBox
            // 
            this.descriptionRichTextBox.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.descriptionRichTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.groupBindingSource, "Description", true, System.Windows.Forms.DataSourceUpdateMode.Never, "None"));
            this.descriptionRichTextBox.Location = new System.Drawing.Point(17, 140);
            this.descriptionRichTextBox.Name = "descriptionRichTextBox";
            this.descriptionRichTextBox.Size = new System.Drawing.Size(359, 74);
            this.descriptionRichTextBox.TabIndex = 1;
            this.descriptionRichTextBox.Text = "";
            // 
            // groupBindingSource
            // 
            this.groupBindingSource.DataSource = typeof(FacebookWrapper.ObjectModel.Group);
            // 
            // linkLabel1
            // 
            this.linkLabel1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.linkLabel1.AutoEllipsis = true;
            this.linkLabel1.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.groupBindingSource, "Link", true, System.Windows.Forms.DataSourceUpdateMode.OnValidation, "None"));
            this.linkLabel1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.linkLabel1.Location = new System.Drawing.Point(77, 36);
            this.linkLabel1.Name = "linkLabel1";
            this.linkLabel1.Size = new System.Drawing.Size(299, 23);
            this.linkLabel1.TabIndex = 3;
            this.linkLabel1.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // nameLabel1
            // 
            this.nameLabel1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.nameLabel1.AutoEllipsis = true;
            this.nameLabel1.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.groupBindingSource, "Name", true, System.Windows.Forms.DataSourceUpdateMode.OnValidation, "None"));
            this.nameLabel1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.nameLabel1.Location = new System.Drawing.Point(93, 9);
            this.nameLabel1.Name = "nameLabel1";
            this.nameLabel1.Size = new System.Drawing.Size(283, 23);
            this.nameLabel1.TabIndex = 5;
            this.nameLabel1.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // privacyLabel1
            // 
            this.privacyLabel1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.privacyLabel1.AutoEllipsis = true;
            this.privacyLabel1.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.groupBindingSource, "Privacy", true, System.Windows.Forms.DataSourceUpdateMode.OnValidation, "None"));
            this.privacyLabel1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.privacyLabel1.Location = new System.Drawing.Point(108, 63);
            this.privacyLabel1.Name = "privacyLabel1";
            this.privacyLabel1.Size = new System.Drawing.Size(268, 23);
            this.privacyLabel1.TabIndex = 7;
            this.privacyLabel1.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // updateTimeLabel1
            // 
            this.updateTimeLabel1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.updateTimeLabel1.AutoEllipsis = true;
            this.updateTimeLabel1.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.groupBindingSource, "UpdateTime", true, System.Windows.Forms.DataSourceUpdateMode.OnValidation, "None"));
            this.updateTimeLabel1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.updateTimeLabel1.Location = new System.Drawing.Point(160, 90);
            this.updateTimeLabel1.Name = "updateTimeLabel1";
            this.updateTimeLabel1.Size = new System.Drawing.Size(216, 23);
            this.updateTimeLabel1.TabIndex = 9;
            this.updateTimeLabel1.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // panelActions
            // 
            this.panelActions.Controls.Add(this.richTextBoxPost);
            this.panelActions.Controls.Add(this.buttonPostInGroup);
            this.panelActions.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panelActions.Location = new System.Drawing.Point(0, 226);
            this.panelActions.Name = "panelActions";
            this.panelActions.Size = new System.Drawing.Size(388, 245);
            this.panelActions.TabIndex = 2;
            // 
            // richTextBoxPost
            // 
            this.richTextBoxPost.Enabled = false;
            this.richTextBoxPost.Location = new System.Drawing.Point(17, 63);
            this.richTextBoxPost.Name = "richTextBoxPost";
            this.richTextBoxPost.Size = new System.Drawing.Size(359, 170);
            this.richTextBoxPost.TabIndex = 6;
            this.richTextBoxPost.Text = "";
            // 
            // buttonPostInGroup
            // 
            this.buttonPostInGroup.Enabled = false;
            this.buttonPostInGroup.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.buttonPostInGroup.Location = new System.Drawing.Point(17, 27);
            this.buttonPostInGroup.Name = "buttonPostInGroup";
            this.buttonPostInGroup.Size = new System.Drawing.Size(132, 30);
            this.buttonPostInGroup.TabIndex = 5;
            this.buttonPostInGroup.Text = "Post in group!";
            this.buttonPostInGroup.UseVisualStyleBackColor = true;
            this.buttonPostInGroup.Click += new System.EventHandler(this.buttonPostInGroup_Click);
            // 
            // flowLayoutPanelGroups
            // 
            this.flowLayoutPanelGroups.AutoScroll = true;
            this.flowLayoutPanelGroups.BackColor = System.Drawing.Color.Transparent;
            this.flowLayoutPanelGroups.Dock = System.Windows.Forms.DockStyle.Fill;
            this.flowLayoutPanelGroups.Location = new System.Drawing.Point(0, 0);
            this.flowLayoutPanelGroups.Name = "flowLayoutPanelGroups";
            this.flowLayoutPanelGroups.Size = new System.Drawing.Size(439, 471);
            this.flowLayoutPanelGroups.TabIndex = 1;
            // 
            // FormGroups
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoScroll = true;
            this.ClientSize = new System.Drawing.Size(827, 471);
            this.Controls.Add(this.flowLayoutPanelGroups);
            this.Controls.Add(this.panelGroupDetails);
            this.Name = "FormGroups";
            this.Text = "FormGroups";
            this.panelGroupDetails.ResumeLayout(false);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.groupBindingSource)).EndInit();
            this.panelActions.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panelGroupDetails;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanelGroups;
        private System.Windows.Forms.Panel panelActions;
        private System.Windows.Forms.RichTextBox richTextBoxPost;
        private System.Windows.Forms.Button buttonPostInGroup;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.BindingSource groupBindingSource;
        private System.Windows.Forms.RichTextBox descriptionRichTextBox;
        private System.Windows.Forms.Label linkLabel1;
        private System.Windows.Forms.Label nameLabel1;
        private System.Windows.Forms.Label privacyLabel1;
        private System.Windows.Forms.Label updateTimeLabel1;
    }
}