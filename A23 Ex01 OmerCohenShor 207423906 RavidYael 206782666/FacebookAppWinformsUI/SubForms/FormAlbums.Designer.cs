
namespace BasicFacebookFeatures.SubForms
{
    partial class FormAlbums
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
            this.splitContainerAlbumsPhotos = new System.Windows.Forms.SplitContainer();
            this.flowLayoutPanelAlbums = new System.Windows.Forms.FlowLayoutPanel();
            this.panelAlbumName = new System.Windows.Forms.Panel();
            this.labelChosenAlbumName = new System.Windows.Forms.Label();
            this.panelPhotoName = new System.Windows.Forms.Panel();
            this.linkLabelPhotoLink = new System.Windows.Forms.LinkLabel();
            this.labelChosenPhotoName = new System.Windows.Forms.Label();
            this.panelPhotos = new System.Windows.Forms.Panel();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainerAlbumsPhotos)).BeginInit();
            this.splitContainerAlbumsPhotos.Panel1.SuspendLayout();
            this.splitContainerAlbumsPhotos.Panel2.SuspendLayout();
            this.splitContainerAlbumsPhotos.SuspendLayout();
            this.panelAlbumName.SuspendLayout();
            this.panelPhotoName.SuspendLayout();
            this.SuspendLayout();
            // 
            // splitContainerAlbumsPhotos
            // 
            this.splitContainerAlbumsPhotos.BackColor = System.Drawing.Color.Transparent;
            this.splitContainerAlbumsPhotos.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainerAlbumsPhotos.Location = new System.Drawing.Point(0, 0);
            this.splitContainerAlbumsPhotos.Name = "splitContainerAlbumsPhotos";
            // 
            // splitContainerAlbumsPhotos.Panel1
            // 
            this.splitContainerAlbumsPhotos.Panel1.Controls.Add(this.flowLayoutPanelAlbums);
            this.splitContainerAlbumsPhotos.Panel1.Controls.Add(this.panelAlbumName);
            this.splitContainerAlbumsPhotos.Panel1MinSize = 100;
            // 
            // splitContainerAlbumsPhotos.Panel2
            // 
            this.splitContainerAlbumsPhotos.Panel2.Controls.Add(this.panelPhotos);
            this.splitContainerAlbumsPhotos.Panel2.Controls.Add(this.panelPhotoName);
            this.splitContainerAlbumsPhotos.Panel2MinSize = 150;
            this.splitContainerAlbumsPhotos.Size = new System.Drawing.Size(1067, 554);
            this.splitContainerAlbumsPhotos.SplitterDistance = 500;
            this.splitContainerAlbumsPhotos.TabIndex = 0;
            // 
            // flowLayoutPanelAlbums
            // 
            this.flowLayoutPanelAlbums.AutoScroll = true;
            this.flowLayoutPanelAlbums.Dock = System.Windows.Forms.DockStyle.Fill;
            this.flowLayoutPanelAlbums.Location = new System.Drawing.Point(0, 91);
            this.flowLayoutPanelAlbums.Name = "flowLayoutPanelAlbums";
            this.flowLayoutPanelAlbums.Padding = new System.Windows.Forms.Padding(2);
            this.flowLayoutPanelAlbums.Size = new System.Drawing.Size(500, 463);
            this.flowLayoutPanelAlbums.TabIndex = 5;
            // 
            // panelAlbumName
            // 
            this.panelAlbumName.AutoScroll = true;
            this.panelAlbumName.Controls.Add(this.labelChosenAlbumName);
            this.panelAlbumName.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelAlbumName.Location = new System.Drawing.Point(0, 0);
            this.panelAlbumName.Margin = new System.Windows.Forms.Padding(4);
            this.panelAlbumName.Name = "panelAlbumName";
            this.panelAlbumName.Size = new System.Drawing.Size(500, 91);
            this.panelAlbumName.TabIndex = 4;
            // 
            // labelChosenAlbumName
            // 
            this.labelChosenAlbumName.AutoEllipsis = true;
            this.labelChosenAlbumName.AutoSize = true;
            this.labelChosenAlbumName.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.labelChosenAlbumName.Location = new System.Drawing.Point(4, 36);
            this.labelChosenAlbumName.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.labelChosenAlbumName.Name = "labelChosenAlbumName";
            this.labelChosenAlbumName.Size = new System.Drawing.Size(174, 25);
            this.labelChosenAlbumName.TabIndex = 0;
            this.labelChosenAlbumName.Text = "Selected album: ";
            // 
            // panelPhotoName
            // 
            this.panelPhotoName.AutoScroll = true;
            this.panelPhotoName.Controls.Add(this.linkLabelPhotoLink);
            this.panelPhotoName.Controls.Add(this.labelChosenPhotoName);
            this.panelPhotoName.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelPhotoName.Location = new System.Drawing.Point(0, 0);
            this.panelPhotoName.Margin = new System.Windows.Forms.Padding(4);
            this.panelPhotoName.Name = "panelPhotoName";
            this.panelPhotoName.Size = new System.Drawing.Size(563, 91);
            this.panelPhotoName.TabIndex = 2;
            // 
            // linkLabelPhotoLink
            // 
            this.linkLabelPhotoLink.AutoSize = true;
            this.linkLabelPhotoLink.LinkBehavior = System.Windows.Forms.LinkBehavior.HoverUnderline;
            this.linkLabelPhotoLink.Location = new System.Drawing.Point(184, 41);
            this.linkLabelPhotoLink.Name = "linkLabelPhotoLink";
            this.linkLabelPhotoLink.Size = new System.Drawing.Size(73, 16);
            this.linkLabelPhotoLink.TabIndex = 0;
            this.linkLabelPhotoLink.TabStop = true;
            this.linkLabelPhotoLink.Text = "Pohoto link";
            this.linkLabelPhotoLink.Visible = false;
            this.linkLabelPhotoLink.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.linkLabelPhotoLink_LinkClicked);
            // 
            // labelChosenPhotoName
            // 
            this.labelChosenPhotoName.AutoEllipsis = true;
            this.labelChosenPhotoName.AutoSize = true;
            this.labelChosenPhotoName.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.labelChosenPhotoName.Location = new System.Drawing.Point(4, 36);
            this.labelChosenPhotoName.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.labelChosenPhotoName.Name = "labelChosenPhotoName";
            this.labelChosenPhotoName.Size = new System.Drawing.Size(164, 25);
            this.labelChosenPhotoName.TabIndex = 0;
            this.labelChosenPhotoName.Text = "Selected photo:";
            // 
            // panelPhotos
            // 
            this.panelPhotos.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelPhotos.Location = new System.Drawing.Point(0, 91);
            this.panelPhotos.Name = "panelPhotos";
            this.panelPhotos.Size = new System.Drawing.Size(563, 463);
            this.panelPhotos.TabIndex = 3;
            // 
            // FormAlbums
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1067, 554);
            this.Controls.Add(this.splitContainerAlbumsPhotos);
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "FormAlbums";
            this.Text = "FormAlbums";
            this.splitContainerAlbumsPhotos.Panel1.ResumeLayout(false);
            this.splitContainerAlbumsPhotos.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.splitContainerAlbumsPhotos)).EndInit();
            this.splitContainerAlbumsPhotos.ResumeLayout(false);
            this.panelAlbumName.ResumeLayout(false);
            this.panelAlbumName.PerformLayout();
            this.panelPhotoName.ResumeLayout(false);
            this.panelPhotoName.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.SplitContainer splitContainerAlbumsPhotos;
        private System.Windows.Forms.Panel panelAlbumName;
        private System.Windows.Forms.Label labelChosenAlbumName;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanelAlbums;
        private System.Windows.Forms.Panel panelPhotoName;
        private System.Windows.Forms.Label labelChosenPhotoName;
        private System.Windows.Forms.LinkLabel linkLabelPhotoLink;
        private System.Windows.Forms.Panel panelPhotos;
    }
}