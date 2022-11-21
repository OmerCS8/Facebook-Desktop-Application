
namespace BasicFacebookFeatures.SubForms
{
    partial class FormProfile
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
            this.pictureBoxCoverPhoto = new System.Windows.Forms.PictureBox();
            this.pictureBoxProfilePic = new System.Windows.Forms.PictureBox();
            this.panelMain = new System.Windows.Forms.Panel();
            this.labelAge = new System.Windows.Forms.Label();
            this.labelName = new System.Windows.Forms.Label();
            this.labelGender = new System.Windows.Forms.Label();
            this.labelBirthday = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxCoverPhoto)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxProfilePic)).BeginInit();
            this.panelMain.SuspendLayout();
            this.SuspendLayout();
            // 
            // pictureBoxCoverPhoto
            // 
            this.pictureBoxCoverPhoto.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.pictureBoxCoverPhoto.BackgroundImage = global::BasicFacebookFeatures.Properties.Resources.cover_deafult;
            this.pictureBoxCoverPhoto.Location = new System.Drawing.Point(0, 0);
            this.pictureBoxCoverPhoto.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.pictureBoxCoverPhoto.Name = "pictureBoxCoverPhoto";
            this.pictureBoxCoverPhoto.Size = new System.Drawing.Size(918, 150);
            this.pictureBoxCoverPhoto.TabIndex = 0;
            this.pictureBoxCoverPhoto.TabStop = false;
            // 
            // pictureBoxProfilePic
            // 
            this.pictureBoxProfilePic.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.pictureBoxProfilePic.BackgroundImage = global::BasicFacebookFeatures.Properties.Resources.guest;
            this.pictureBoxProfilePic.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pictureBoxProfilePic.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.pictureBoxProfilePic.Location = new System.Drawing.Point(240, 89);
            this.pictureBoxProfilePic.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.pictureBoxProfilePic.Name = "pictureBoxProfilePic";
            this.pictureBoxProfilePic.Size = new System.Drawing.Size(117, 123);
            this.pictureBoxProfilePic.TabIndex = 1;
            this.pictureBoxProfilePic.TabStop = false;
            // 
            // panelMain
            // 
            this.panelMain.BackColor = System.Drawing.Color.Transparent;
            this.panelMain.Controls.Add(this.labelBirthday);
            this.panelMain.Controls.Add(this.labelGender);
            this.panelMain.Controls.Add(this.labelName);
            this.panelMain.Controls.Add(this.labelAge);
            this.panelMain.Controls.Add(this.pictureBoxProfilePic);
            this.panelMain.Controls.Add(this.pictureBoxCoverPhoto);
            this.panelMain.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelMain.Location = new System.Drawing.Point(0, 0);
            this.panelMain.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.panelMain.Name = "panelMain";
            this.panelMain.Size = new System.Drawing.Size(600, 366);
            this.panelMain.TabIndex = 2;
            // 
            // labelAge
            // 
            this.labelAge.AutoSize = true;
            this.labelAge.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.labelAge.Location = new System.Drawing.Point(259, 274);
            this.labelAge.Name = "labelAge";
            this.labelAge.Size = new System.Drawing.Size(60, 24);
            this.labelAge.TabIndex = 2;
            this.labelAge.Text = "Age: ";
            // 
            // labelName
            // 
            this.labelName.AutoSize = true;
            this.labelName.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.labelName.Location = new System.Drawing.Point(259, 226);
            this.labelName.Name = "labelName";
            this.labelName.Size = new System.Drawing.Size(77, 24);
            this.labelName.TabIndex = 3;
            this.labelName.Text = "Name: ";
            // 
            // labelGender
            // 
            this.labelGender.AutoSize = true;
            this.labelGender.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.labelGender.Location = new System.Drawing.Point(259, 250);
            this.labelGender.Name = "labelGender";
            this.labelGender.Size = new System.Drawing.Size(92, 24);
            this.labelGender.TabIndex = 4;
            this.labelGender.Text = "Gender: ";
            // 
            // labelBirthday
            // 
            this.labelBirthday.AutoSize = true;
            this.labelBirthday.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.labelBirthday.Location = new System.Drawing.Point(259, 298);
            this.labelBirthday.Name = "labelBirthday";
            this.labelBirthday.Size = new System.Drawing.Size(97, 24);
            this.labelBirthday.TabIndex = 5;
            this.labelBirthday.Text = "Birthday: ";
            // 
            // FormProfile
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Control;
            this.ClientSize = new System.Drawing.Size(600, 366);
            this.Controls.Add(this.panelMain);
            this.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.Name = "FormProfile";
            this.Text = "FormProfile";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxCoverPhoto)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxProfilePic)).EndInit();
            this.panelMain.ResumeLayout(false);
            this.panelMain.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBoxCoverPhoto;
        private System.Windows.Forms.PictureBox pictureBoxProfilePic;
        private System.Windows.Forms.Panel panelMain;
        private System.Windows.Forms.Label labelBirthday;
        private System.Windows.Forms.Label labelGender;
        private System.Windows.Forms.Label labelName;
        private System.Windows.Forms.Label labelAge;
    }
}