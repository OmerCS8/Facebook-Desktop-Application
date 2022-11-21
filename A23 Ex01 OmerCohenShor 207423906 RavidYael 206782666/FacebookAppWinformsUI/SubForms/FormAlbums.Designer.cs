
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
            this.panelAlbums = new System.Windows.Forms.Panel();
            this.flowLayoutPanelAlbums = new System.Windows.Forms.FlowLayoutPanel();
            this.panelAlbumName = new System.Windows.Forms.Panel();
            this.labelChosenAlbumName = new System.Windows.Forms.Label();
            this.panelPhotos = new System.Windows.Forms.Panel();
            this.flowLayoutPanelPhotos = new System.Windows.Forms.FlowLayoutPanel();
            this.panelPhotoName = new System.Windows.Forms.Panel();
            this.labelChosenPhotoName = new System.Windows.Forms.Label();
            this.panelAlbums.SuspendLayout();
            this.panelAlbumName.SuspendLayout();
            this.panelPhotos.SuspendLayout();
            this.panelPhotoName.SuspendLayout();
            this.SuspendLayout();
            // 
            // panelAlbums
            // 
            this.panelAlbums.BackColor = System.Drawing.Color.Transparent;
            this.panelAlbums.Controls.Add(this.flowLayoutPanelAlbums);
            this.panelAlbums.Controls.Add(this.panelAlbumName);
            this.panelAlbums.Dock = System.Windows.Forms.DockStyle.Left;
            this.panelAlbums.Location = new System.Drawing.Point(0, 0);
            this.panelAlbums.Name = "panelAlbums";
            this.panelAlbums.Size = new System.Drawing.Size(340, 450);
            this.panelAlbums.TabIndex = 0;
            // 
            // flowLayoutPanelAlbums
            // 
            this.flowLayoutPanelAlbums.AutoScroll = true;
            this.flowLayoutPanelAlbums.Dock = System.Windows.Forms.DockStyle.Fill;
            this.flowLayoutPanelAlbums.Location = new System.Drawing.Point(0, 74);
            this.flowLayoutPanelAlbums.Margin = new System.Windows.Forms.Padding(10);
            this.flowLayoutPanelAlbums.Name = "flowLayoutPanelAlbums";
            this.flowLayoutPanelAlbums.Padding = new System.Windows.Forms.Padding(10);
            this.flowLayoutPanelAlbums.Size = new System.Drawing.Size(340, 376);
            this.flowLayoutPanelAlbums.TabIndex = 0;
            // 
            // panelAlbumName
            // 
            this.panelAlbumName.Controls.Add(this.labelChosenAlbumName);
            this.panelAlbumName.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelAlbumName.Location = new System.Drawing.Point(0, 0);
            this.panelAlbumName.Name = "panelAlbumName";
            this.panelAlbumName.Size = new System.Drawing.Size(340, 74);
            this.panelAlbumName.TabIndex = 0;
            // 
            // labelChosenAlbumName
            // 
            this.labelChosenAlbumName.AutoSize = true;
            this.labelChosenAlbumName.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.labelChosenAlbumName.Location = new System.Drawing.Point(12, 29);
            this.labelChosenAlbumName.Name = "labelChosenAlbumName";
            this.labelChosenAlbumName.Size = new System.Drawing.Size(135, 20);
            this.labelChosenAlbumName.TabIndex = 0;
            this.labelChosenAlbumName.Text = "Chosen Album: ";
            // 
            // panelPhotos
            // 
            this.panelPhotos.BackColor = System.Drawing.Color.Transparent;
            this.panelPhotos.Controls.Add(this.flowLayoutPanelPhotos);
            this.panelPhotos.Controls.Add(this.panelPhotoName);
            this.panelPhotos.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelPhotos.Location = new System.Drawing.Point(340, 0);
            this.panelPhotos.Name = "panelPhotos";
            this.panelPhotos.Size = new System.Drawing.Size(460, 450);
            this.panelPhotos.TabIndex = 1;
            // 
            // flowLayoutPanelPhotos
            // 
            this.flowLayoutPanelPhotos.AutoScroll = true;
            this.flowLayoutPanelPhotos.Dock = System.Windows.Forms.DockStyle.Fill;
            this.flowLayoutPanelPhotos.Location = new System.Drawing.Point(0, 74);
            this.flowLayoutPanelPhotos.Margin = new System.Windows.Forms.Padding(10);
            this.flowLayoutPanelPhotos.Name = "flowLayoutPanelPhotos";
            this.flowLayoutPanelPhotos.Padding = new System.Windows.Forms.Padding(10);
            this.flowLayoutPanelPhotos.Size = new System.Drawing.Size(460, 376);
            this.flowLayoutPanelPhotos.TabIndex = 1;
            // 
            // panelPhotoName
            // 
            this.panelPhotoName.Controls.Add(this.labelChosenPhotoName);
            this.panelPhotoName.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelPhotoName.Location = new System.Drawing.Point(0, 0);
            this.panelPhotoName.Name = "panelPhotoName";
            this.panelPhotoName.Size = new System.Drawing.Size(460, 74);
            this.panelPhotoName.TabIndex = 0;
            // 
            // labelChosenPhotoName
            // 
            this.labelChosenPhotoName.AutoSize = true;
            this.labelChosenPhotoName.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.labelChosenPhotoName.Location = new System.Drawing.Point(16, 29);
            this.labelChosenPhotoName.Name = "labelChosenPhotoName";
            this.labelChosenPhotoName.Size = new System.Drawing.Size(126, 20);
            this.labelChosenPhotoName.TabIndex = 0;
            this.labelChosenPhotoName.Text = "Chosen photo:";
            // 
            // FormAlbums
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.panelPhotos);
            this.Controls.Add(this.panelAlbums);
            this.Name = "FormAlbums";
            this.Text = "FormAlbums";
            this.panelAlbums.ResumeLayout(false);
            this.panelAlbumName.ResumeLayout(false);
            this.panelAlbumName.PerformLayout();
            this.panelPhotos.ResumeLayout(false);
            this.panelPhotoName.ResumeLayout(false);
            this.panelPhotoName.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panelAlbums;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanelAlbums;
        private System.Windows.Forms.Panel panelAlbumName;
        private System.Windows.Forms.Label labelChosenAlbumName;
        private System.Windows.Forms.Panel panelPhotos;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanelPhotos;
        private System.Windows.Forms.Panel panelPhotoName;
        private System.Windows.Forms.Label labelChosenPhotoName;
    }
}