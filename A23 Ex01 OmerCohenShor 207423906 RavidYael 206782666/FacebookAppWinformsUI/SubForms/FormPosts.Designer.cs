
namespace BasicFacebookFeatures.SubForms
{
    partial class FormPosts
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
            System.Windows.Forms.ListViewItem listViewItem1 = new System.Windows.Forms.ListViewItem(new string[] {
            "",
            ""}, -1, System.Drawing.Color.Empty, System.Drawing.Color.Transparent, new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(177))));
            this.panelGroupDetails = new System.Windows.Forms.Panel();
            this.panelComments = new System.Windows.Forms.Panel();
            this.richTextBoxNewComment = new System.Windows.Forms.RichTextBox();
            this.buttonAddComment = new System.Windows.Forms.Button();
            this.listBoxComments = new System.Windows.Forms.ListBox();
            this.panelPosts = new System.Windows.Forms.Panel();
            this.labelComments = new System.Windows.Forms.Label();
            this.richTextBoxNewStatus = new System.Windows.Forms.RichTextBox();
            this.buttonNewStatus = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.labelNewStatus = new System.Windows.Forms.Label();
            this.listViewPosts = new System.Windows.Forms.ListView();
            this.label1 = new System.Windows.Forms.Label();
            this.ID = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.postContent = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.PostDate = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.panelGroupDetails.SuspendLayout();
            this.panelComments.SuspendLayout();
            this.panelPosts.SuspendLayout();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // panelGroupDetails
            // 
            this.panelGroupDetails.BackColor = System.Drawing.Color.Transparent;
            this.panelGroupDetails.Controls.Add(this.panel1);
            this.panelGroupDetails.Controls.Add(this.panelComments);
            this.panelGroupDetails.Dock = System.Windows.Forms.DockStyle.Right;
            this.panelGroupDetails.Location = new System.Drawing.Point(412, 0);
            this.panelGroupDetails.Name = "panelGroupDetails";
            this.panelGroupDetails.Size = new System.Drawing.Size(388, 450);
            this.panelGroupDetails.TabIndex = 2;
            // 
            // panelComments
            // 
            this.panelComments.Controls.Add(this.listBoxComments);
            this.panelComments.Controls.Add(this.richTextBoxNewComment);
            this.panelComments.Controls.Add(this.buttonAddComment);
            this.panelComments.Controls.Add(this.labelComments);
            this.panelComments.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panelComments.Location = new System.Drawing.Point(0, 205);
            this.panelComments.Name = "panelComments";
            this.panelComments.Size = new System.Drawing.Size(388, 245);
            this.panelComments.TabIndex = 2;
            // 
            // richTextBoxNewComment
            // 
            this.richTextBoxNewComment.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.richTextBoxNewComment.Enabled = false;
            this.richTextBoxNewComment.Location = new System.Drawing.Point(108, 179);
            this.richTextBoxNewComment.Name = "richTextBoxNewComment";
            this.richTextBoxNewComment.Size = new System.Drawing.Size(268, 54);
            this.richTextBoxNewComment.TabIndex = 6;
            this.richTextBoxNewComment.Text = "";
            // 
            // buttonAddComment
            // 
            this.buttonAddComment.Enabled = false;
            this.buttonAddComment.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.buttonAddComment.Location = new System.Drawing.Point(6, 179);
            this.buttonAddComment.Name = "buttonAddComment";
            this.buttonAddComment.Size = new System.Drawing.Size(96, 54);
            this.buttonAddComment.TabIndex = 5;
            this.buttonAddComment.Text = "Add comment";
            this.buttonAddComment.UseVisualStyleBackColor = true;
            // 
            // listBoxComments
            // 
            this.listBoxComments.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.listBoxComments.FormattingEnabled = true;
            this.listBoxComments.ItemHeight = 16;
            this.listBoxComments.Location = new System.Drawing.Point(7, 41);
            this.listBoxComments.Name = "listBoxComments";
            this.listBoxComments.Size = new System.Drawing.Size(369, 132);
            this.listBoxComments.TabIndex = 7;
            // 
            // panelPosts
            // 
            this.panelPosts.BackColor = System.Drawing.Color.Transparent;
            this.panelPosts.Controls.Add(this.label1);
            this.panelPosts.Controls.Add(this.listViewPosts);
            this.panelPosts.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelPosts.Location = new System.Drawing.Point(0, 0);
            this.panelPosts.Name = "panelPosts";
            this.panelPosts.Size = new System.Drawing.Size(412, 450);
            this.panelPosts.TabIndex = 3;
            // 
            // labelComments
            // 
            this.labelComments.AutoSize = true;
            this.labelComments.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.labelComments.Location = new System.Drawing.Point(3, 8);
            this.labelComments.Margin = new System.Windows.Forms.Padding(0, 5, 0, 5);
            this.labelComments.Name = "labelComments";
            this.labelComments.Size = new System.Drawing.Size(117, 25);
            this.labelComments.TabIndex = 5;
            this.labelComments.Text = "comments:";
            // 
            // richTextBoxNewStatus
            // 
            this.richTextBoxNewStatus.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.richTextBoxNewStatus.Enabled = false;
            this.richTextBoxNewStatus.Location = new System.Drawing.Point(7, 38);
            this.richTextBoxNewStatus.Name = "richTextBoxNewStatus";
            this.richTextBoxNewStatus.Size = new System.Drawing.Size(299, 161);
            this.richTextBoxNewStatus.TabIndex = 8;
            this.richTextBoxNewStatus.Text = "";
            // 
            // buttonNewStatus
            // 
            this.buttonNewStatus.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.buttonNewStatus.Enabled = false;
            this.buttonNewStatus.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.buttonNewStatus.Location = new System.Drawing.Point(312, 38);
            this.buttonNewStatus.Name = "buttonNewStatus";
            this.buttonNewStatus.Size = new System.Drawing.Size(64, 161);
            this.buttonNewStatus.TabIndex = 7;
            this.buttonNewStatus.Text = "Post new status";
            this.buttonNewStatus.UseVisualStyleBackColor = true;
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.labelNewStatus);
            this.panel1.Controls.Add(this.buttonNewStatus);
            this.panel1.Controls.Add(this.richTextBoxNewStatus);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(388, 205);
            this.panel1.TabIndex = 3;
            // 
            // labelNewStatus
            // 
            this.labelNewStatus.AutoSize = true;
            this.labelNewStatus.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.labelNewStatus.Location = new System.Drawing.Point(3, 5);
            this.labelNewStatus.Margin = new System.Windows.Forms.Padding(0, 5, 0, 5);
            this.labelNewStatus.Name = "labelNewStatus";
            this.labelNewStatus.Size = new System.Drawing.Size(171, 25);
            this.labelNewStatus.TabIndex = 9;
            this.labelNewStatus.Text = "Post new status:";
            // 
            // listViewPosts
            // 
            this.listViewPosts.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.ID,
            this.postContent,
            this.PostDate});
            this.listViewPosts.HideSelection = false;
            this.listViewPosts.Items.AddRange(new System.Windows.Forms.ListViewItem[] {
            listViewItem1});
            this.listViewPosts.Location = new System.Drawing.Point(12, 38);
            this.listViewPosts.Name = "listViewPosts";
            this.listViewPosts.Size = new System.Drawing.Size(394, 400);
            this.listViewPosts.TabIndex = 0;
            this.listViewPosts.UseCompatibleStateImageBehavior = false;
            this.listViewPosts.View = System.Windows.Forms.View.Details;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.label1.Location = new System.Drawing.Point(9, 5);
            this.label1.Margin = new System.Windows.Forms.Padding(0, 5, 0, 5);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(106, 25);
            this.label1.TabIndex = 10;
            this.label1.Text = "My posts:";
            // 
            // ID
            // 
            this.ID.Text = "Post ID";
            // 
            // postContent
            // 
            this.postContent.Text = "Content";
            this.postContent.Width = 200;
            // 
            // PostDate
            // 
            this.PostDate.Text = "Date";
            // 
            // FormPosts
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.panelPosts);
            this.Controls.Add(this.panelGroupDetails);
            this.Name = "FormPosts";
            this.Text = "FormPosts";
            this.panelGroupDetails.ResumeLayout(false);
            this.panelComments.ResumeLayout(false);
            this.panelComments.PerformLayout();
            this.panelPosts.ResumeLayout(false);
            this.panelPosts.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Panel panelGroupDetails;
        private System.Windows.Forms.Panel panelComments;
        private System.Windows.Forms.RichTextBox richTextBoxNewComment;
        private System.Windows.Forms.Button buttonAddComment;
        private System.Windows.Forms.ListBox listBoxComments;
        private System.Windows.Forms.Panel panelPosts;
        private System.Windows.Forms.Label labelComments;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label labelNewStatus;
        private System.Windows.Forms.Button buttonNewStatus;
        private System.Windows.Forms.RichTextBox richTextBoxNewStatus;
        private System.Windows.Forms.ListView listViewPosts;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ColumnHeader ID;
        private System.Windows.Forms.ColumnHeader postContent;
        private System.Windows.Forms.ColumnHeader PostDate;
    }
}