
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
            this.panelGroupDetails = new System.Windows.Forms.Panel();
            this.panel1 = new System.Windows.Forms.Panel();
            this.labelNewStatus = new System.Windows.Forms.Label();
            this.buttonNewStatus = new System.Windows.Forms.Button();
            this.richTextBoxNewStatus = new System.Windows.Forms.RichTextBox();
            this.panelComments = new System.Windows.Forms.Panel();
            this.listBoxComments = new System.Windows.Forms.ListBox();
            this.richTextBoxNewComment = new System.Windows.Forms.RichTextBox();
            this.buttonAddComment = new System.Windows.Forms.Button();
            this.labelComments = new System.Windows.Forms.Label();
            this.panelPosts = new System.Windows.Forms.Panel();
            this.listViewPosts = new System.Windows.Forms.ListView();
            this.columnTimeCreated = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnMessage = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnCaption = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnDescription = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnID = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.label1 = new System.Windows.Forms.Label();
            this.panelGroupDetails.SuspendLayout();
            this.panel1.SuspendLayout();
            this.panelComments.SuspendLayout();
            this.panelPosts.SuspendLayout();
            this.SuspendLayout();
            // 
            // panelGroupDetails
            // 
            this.panelGroupDetails.BackColor = System.Drawing.Color.Transparent;
            this.panelGroupDetails.Controls.Add(this.panel1);
            this.panelGroupDetails.Controls.Add(this.panelComments);
            this.panelGroupDetails.Dock = System.Windows.Forms.DockStyle.Right;
            this.panelGroupDetails.Location = new System.Drawing.Point(309, 0);
            this.panelGroupDetails.Margin = new System.Windows.Forms.Padding(2);
            this.panelGroupDetails.Name = "panelGroupDetails";
            this.panelGroupDetails.Size = new System.Drawing.Size(291, 366);
            this.panelGroupDetails.TabIndex = 2;
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.labelNewStatus);
            this.panel1.Controls.Add(this.buttonNewStatus);
            this.panel1.Controls.Add(this.richTextBoxNewStatus);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Margin = new System.Windows.Forms.Padding(2);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(291, 167);
            this.panel1.TabIndex = 3;
            // 
            // labelNewStatus
            // 
            this.labelNewStatus.AutoSize = true;
            this.labelNewStatus.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.labelNewStatus.Location = new System.Drawing.Point(2, 4);
            this.labelNewStatus.Margin = new System.Windows.Forms.Padding(0, 4, 0, 4);
            this.labelNewStatus.Name = "labelNewStatus";
            this.labelNewStatus.Size = new System.Drawing.Size(142, 20);
            this.labelNewStatus.TabIndex = 9;
            this.labelNewStatus.Text = "Post new status:";
            // 
            // buttonNewStatus
            // 
            this.buttonNewStatus.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.buttonNewStatus.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.buttonNewStatus.Location = new System.Drawing.Point(202, 31);
            this.buttonNewStatus.Margin = new System.Windows.Forms.Padding(2);
            this.buttonNewStatus.Name = "buttonNewStatus";
            this.buttonNewStatus.Size = new System.Drawing.Size(80, 131);
            this.buttonNewStatus.TabIndex = 7;
            this.buttonNewStatus.Text = "Post new status";
            this.buttonNewStatus.UseVisualStyleBackColor = true;
            this.buttonNewStatus.Click += new System.EventHandler(this.buttonNewStatus_Click);
            // 
            // richTextBoxNewStatus
            // 
            this.richTextBoxNewStatus.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.richTextBoxNewStatus.Location = new System.Drawing.Point(5, 31);
            this.richTextBoxNewStatus.Margin = new System.Windows.Forms.Padding(2);
            this.richTextBoxNewStatus.Name = "richTextBoxNewStatus";
            this.richTextBoxNewStatus.Size = new System.Drawing.Size(193, 132);
            this.richTextBoxNewStatus.TabIndex = 8;
            this.richTextBoxNewStatus.Text = "";
            // 
            // panelComments
            // 
            this.panelComments.Controls.Add(this.listBoxComments);
            this.panelComments.Controls.Add(this.richTextBoxNewComment);
            this.panelComments.Controls.Add(this.buttonAddComment);
            this.panelComments.Controls.Add(this.labelComments);
            this.panelComments.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panelComments.Location = new System.Drawing.Point(0, 167);
            this.panelComments.Margin = new System.Windows.Forms.Padding(2);
            this.panelComments.Name = "panelComments";
            this.panelComments.Size = new System.Drawing.Size(291, 199);
            this.panelComments.TabIndex = 2;
            // 
            // listBoxComments
            // 
            this.listBoxComments.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.listBoxComments.FormattingEnabled = true;
            this.listBoxComments.Location = new System.Drawing.Point(5, 33);
            this.listBoxComments.Margin = new System.Windows.Forms.Padding(2);
            this.listBoxComments.Name = "listBoxComments";
            this.listBoxComments.Size = new System.Drawing.Size(278, 108);
            this.listBoxComments.TabIndex = 7;
            // 
            // richTextBoxNewComment
            // 
            this.richTextBoxNewComment.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.richTextBoxNewComment.Enabled = false;
            this.richTextBoxNewComment.Location = new System.Drawing.Point(81, 145);
            this.richTextBoxNewComment.Margin = new System.Windows.Forms.Padding(2);
            this.richTextBoxNewComment.Name = "richTextBoxNewComment";
            this.richTextBoxNewComment.Size = new System.Drawing.Size(202, 45);
            this.richTextBoxNewComment.TabIndex = 6;
            this.richTextBoxNewComment.Text = "";
            // 
            // buttonAddComment
            // 
            this.buttonAddComment.Enabled = false;
            this.buttonAddComment.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.buttonAddComment.Location = new System.Drawing.Point(4, 145);
            this.buttonAddComment.Margin = new System.Windows.Forms.Padding(2);
            this.buttonAddComment.Name = "buttonAddComment";
            this.buttonAddComment.Size = new System.Drawing.Size(72, 44);
            this.buttonAddComment.TabIndex = 5;
            this.buttonAddComment.Text = "Add comment";
            this.buttonAddComment.UseVisualStyleBackColor = true;
            this.buttonAddComment.Click += new System.EventHandler(this.buttonAddComment_Click);
            // 
            // labelComments
            // 
            this.labelComments.AutoSize = true;
            this.labelComments.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.labelComments.Location = new System.Drawing.Point(2, 6);
            this.labelComments.Margin = new System.Windows.Forms.Padding(0, 4, 0, 4);
            this.labelComments.Name = "labelComments";
            this.labelComments.Size = new System.Drawing.Size(193, 20);
            this.labelComments.TabIndex = 5;
            this.labelComments.Text = "Chosen post omments:";
            // 
            // panelPosts
            // 
            this.panelPosts.BackColor = System.Drawing.Color.Transparent;
            this.panelPosts.Controls.Add(this.listViewPosts);
            this.panelPosts.Controls.Add(this.label1);
            this.panelPosts.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelPosts.Location = new System.Drawing.Point(0, 0);
            this.panelPosts.Margin = new System.Windows.Forms.Padding(2);
            this.panelPosts.Name = "panelPosts";
            this.panelPosts.Size = new System.Drawing.Size(309, 366);
            this.panelPosts.TabIndex = 3;
            // 
            // listViewPosts
            // 
            this.listViewPosts.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.listViewPosts.BackColor = System.Drawing.SystemColors.Window;
            this.listViewPosts.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnTimeCreated,
            this.columnMessage,
            this.columnCaption,
            this.columnDescription,
            this.columnID});
            this.listViewPosts.FullRowSelect = true;
            this.listViewPosts.GridLines = true;
            this.listViewPosts.HideSelection = false;
            this.listViewPosts.Location = new System.Drawing.Point(9, 31);
            this.listViewPosts.Margin = new System.Windows.Forms.Padding(2);
            this.listViewPosts.Name = "listViewPosts";
            this.listViewPosts.Size = new System.Drawing.Size(296, 326);
            this.listViewPosts.TabIndex = 11;
            this.listViewPosts.UseCompatibleStateImageBehavior = false;
            this.listViewPosts.View = System.Windows.Forms.View.Details;
            this.listViewPosts.SelectedIndexChanged += new System.EventHandler(this.listViewPosts_SelectedIndexChanged);
            // 
            // columnTimeCreated
            // 
            this.columnTimeCreated.Text = "Time created";
            this.columnTimeCreated.Width = 96;
            // 
            // columnMessage
            // 
            this.columnMessage.Text = "Message";
            this.columnMessage.Width = 100;
            // 
            // columnCaption
            // 
            this.columnCaption.Text = "Caption";
            this.columnCaption.Width = 65;
            // 
            // columnDescription
            // 
            this.columnDescription.Text = "Description";
            this.columnDescription.Width = 86;
            // 
            // columnID
            // 
            this.columnID.Text = "ID";
            this.columnID.Width = 97;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.label1.Location = new System.Drawing.Point(7, 4);
            this.label1.Margin = new System.Windows.Forms.Padding(0, 4, 0, 4);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(85, 20);
            this.label1.TabIndex = 10;
            this.label1.Text = "My posts:";
            // 
            // FormPosts
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(600, 366);
            this.Controls.Add(this.panelPosts);
            this.Controls.Add(this.panelGroupDetails);
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "FormPosts";
            this.Text = "FormPosts";
            this.panelGroupDetails.ResumeLayout(false);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panelComments.ResumeLayout(false);
            this.panelComments.PerformLayout();
            this.panelPosts.ResumeLayout(false);
            this.panelPosts.PerformLayout();
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
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ListView listViewPosts;
        private System.Windows.Forms.ColumnHeader columnTimeCreated;
        private System.Windows.Forms.ColumnHeader columnMessage;
        private System.Windows.Forms.ColumnHeader columnCaption;
        private System.Windows.Forms.ColumnHeader columnDescription;
        private System.Windows.Forms.ColumnHeader columnID;
    }
}