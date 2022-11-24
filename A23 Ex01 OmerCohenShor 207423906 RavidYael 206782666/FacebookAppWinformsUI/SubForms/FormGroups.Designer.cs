
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
            this.panelGroupDetails = new System.Windows.Forms.Panel();
            this.flowLayoutPanelGroupDetails = new System.Windows.Forms.FlowLayoutPanel();
            this.labelGroupName = new System.Windows.Forms.Label();
            this.labelGroupMembers = new System.Windows.Forms.Label();
            this.labelGroupPosts = new System.Windows.Forms.Label();
            this.labelGroupDescription = new System.Windows.Forms.Label();
            this.labelOwner = new System.Windows.Forms.Label();
            this.panelActions = new System.Windows.Forms.Panel();
            this.richTextBoxPost = new System.Windows.Forms.RichTextBox();
            this.buttonPostInGroup = new System.Windows.Forms.Button();
            this.flowLayoutPanelGroups = new System.Windows.Forms.FlowLayoutPanel();
            this.panelGroupDetails.SuspendLayout();
            this.flowLayoutPanelGroupDetails.SuspendLayout();
            this.panelActions.SuspendLayout();
            this.SuspendLayout();
            // 
            // panelGroupDetails
            // 
            this.panelGroupDetails.BackColor = System.Drawing.Color.Transparent;
            this.panelGroupDetails.Controls.Add(this.flowLayoutPanelGroupDetails);
            this.panelGroupDetails.Controls.Add(this.panelActions);
            this.panelGroupDetails.Dock = System.Windows.Forms.DockStyle.Right;
            this.panelGroupDetails.Location = new System.Drawing.Point(412, 0);
            this.panelGroupDetails.Name = "panelGroupDetails";
            this.panelGroupDetails.Size = new System.Drawing.Size(388, 450);
            this.panelGroupDetails.TabIndex = 0;
            // 
            // flowLayoutPanelGroupDetails
            // 
            this.flowLayoutPanelGroupDetails.AutoScroll = true;
            this.flowLayoutPanelGroupDetails.Controls.Add(this.labelGroupName);
            this.flowLayoutPanelGroupDetails.Controls.Add(this.labelGroupMembers);
            this.flowLayoutPanelGroupDetails.Controls.Add(this.labelGroupPosts);
            this.flowLayoutPanelGroupDetails.Controls.Add(this.labelGroupDescription);
            this.flowLayoutPanelGroupDetails.Controls.Add(this.labelOwner);
            this.flowLayoutPanelGroupDetails.Dock = System.Windows.Forms.DockStyle.Fill;
            this.flowLayoutPanelGroupDetails.FlowDirection = System.Windows.Forms.FlowDirection.TopDown;
            this.flowLayoutPanelGroupDetails.Location = new System.Drawing.Point(0, 0);
            this.flowLayoutPanelGroupDetails.Name = "flowLayoutPanelGroupDetails";
            this.flowLayoutPanelGroupDetails.Padding = new System.Windows.Forms.Padding(2, 5, 5, 5);
            this.flowLayoutPanelGroupDetails.Size = new System.Drawing.Size(388, 205);
            this.flowLayoutPanelGroupDetails.TabIndex = 3; // 
            // labelGroupName
            // 
            this.labelGroupName.AutoSize = true;
            this.labelGroupName.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.labelGroupName.Location = new System.Drawing.Point(2, 10);
            this.labelGroupName.Margin = new System.Windows.Forms.Padding(0, 5, 0, 5);
            this.labelGroupName.Name = "labelGroupName";
            this.labelGroupName.Size = new System.Drawing.Size(137, 25);
            this.labelGroupName.TabIndex = 0;
            this.labelGroupName.Text = "Group name:";
            // 
            // labelGroupMembers
            // 
            this.labelGroupMembers.AutoSize = true;
            this.labelGroupMembers.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.labelGroupMembers.Location = new System.Drawing.Point(2, 45);
            this.labelGroupMembers.Margin = new System.Windows.Forms.Padding(0, 5, 0, 5);
            this.labelGroupMembers.Name = "labelGroupMembers";
            this.labelGroupMembers.Size = new System.Drawing.Size(172, 25);
            this.labelGroupMembers.TabIndex = 1;
            this.labelGroupMembers.Text = "Group members:";
            // 
            // labelGroupPosts
            // 
            this.labelGroupPosts.AutoSize = true;
            this.labelGroupPosts.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.labelGroupPosts.Location = new System.Drawing.Point(2, 80);
            this.labelGroupPosts.Margin = new System.Windows.Forms.Padding(0, 5, 0, 5);
            this.labelGroupPosts.Name = "labelGroupPosts";
            this.labelGroupPosts.Size = new System.Drawing.Size(136, 25);
            this.labelGroupPosts.TabIndex = 2;
            this.labelGroupPosts.Text = "Group posts:";
            // 
            // labelGroupDescription
            // 
            this.labelGroupDescription.AutoSize = true;
            this.labelGroupDescription.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.labelGroupDescription.Location = new System.Drawing.Point(2, 115);
            this.labelGroupDescription.Margin = new System.Windows.Forms.Padding(0, 5, 0, 5);
            this.labelGroupDescription.Name = "labelGroupDescription";
            this.labelGroupDescription.Size = new System.Drawing.Size(192, 25);
            this.labelGroupDescription.TabIndex = 3;
            this.labelGroupDescription.Text = "Group Description:";
            // 
            // labelOwner
            // 
            this.labelOwner.AutoSize = true;
            this.labelOwner.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.labelOwner.Location = new System.Drawing.Point(2, 150);
            this.labelOwner.Margin = new System.Windows.Forms.Padding(0, 5, 0, 5);
            this.labelOwner.Name = "labelOwner";
            this.labelOwner.Size = new System.Drawing.Size(147, 25);
            this.labelOwner.TabIndex = 4;
            this.labelOwner.Text = "Group Owner:";
            // 
            // panelActions
            // 
            this.panelActions.Controls.Add(this.richTextBoxPost);
            this.panelActions.Controls.Add(this.buttonPostInGroup);
            this.panelActions.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panelActions.Location = new System.Drawing.Point(0, 205);
            this.panelActions.Name = "panelActions";
            this.panelActions.Size = new System.Drawing.Size(388, 245);
            this.panelActions.TabIndex = 2;
            // 
            // richTextBoxPost
            // 
            this.richTextBoxPost.Enabled = false;
            this.richTextBoxPost.Location = new System.Drawing.Point(17, 63);
            this.richTextBoxPost.Name = "richTextBoxPost";
            this.richTextBoxPost.Size = new System.Drawing.Size(348, 170);
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
            this.flowLayoutPanelGroups.Size = new System.Drawing.Size(412, 450);
            this.flowLayoutPanelGroups.TabIndex = 1;
            // 
            // FormGroups
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.flowLayoutPanelGroups);
            this.Controls.Add(this.panelGroupDetails);
            this.Name = "FormGroups";
            this.Text = "FormGroups";
            this.panelGroupDetails.ResumeLayout(false);
            this.flowLayoutPanelGroupDetails.ResumeLayout(false);
            this.flowLayoutPanelGroupDetails.PerformLayout();
            this.panelActions.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panelGroupDetails;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanelGroups;
        private System.Windows.Forms.Label labelGroupName;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanelGroupDetails;
        private System.Windows.Forms.Panel panelActions;
        private System.Windows.Forms.Label labelGroupMembers;
        private System.Windows.Forms.Label labelGroupPosts;
        private System.Windows.Forms.Label labelGroupDescription;
        private System.Windows.Forms.Label labelOwner;
        private System.Windows.Forms.RichTextBox richTextBoxPost;
        private System.Windows.Forms.Button buttonPostInGroup;
    }
}