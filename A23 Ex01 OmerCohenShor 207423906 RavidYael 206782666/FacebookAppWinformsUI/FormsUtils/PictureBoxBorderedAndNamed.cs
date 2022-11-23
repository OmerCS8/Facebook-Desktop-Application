using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using CefSharp.DevTools.Debugger;

namespace BasicFacebookFeatures.FormsUtils
{
    class PictureBoxBorderedAndNamed : PictureBox
    {
        private readonly int r_BorderSize;
        private readonly int r_BorderTextHeight;
        private readonly PictureBox r_PhotoPictureBox;
        private readonly Label r_NameLabel;
        public PictureBoxBorderedAndNamed(int i_Size, bool i_DoesHaveBorder)
        {
            r_BorderSize = i_DoesHaveBorder ? 10 : 1;
            r_BorderTextHeight = i_DoesHaveBorder ? 10 : 20;
            setBorder(i_Size);
            r_PhotoPictureBox = createPhotoPictureBox(i_Size);
            r_NameLabel = createNameLabel();
            setBorderAsParent(r_PhotoPictureBox, r_NameLabel);
            addVisualEffects();
        }

        private void addVisualEffects()
        {
            this.Cursor = Cursors.Hand;
            this.MouseDown += new MouseEventHandler(this.pictureBoxBorderedAndNamed_MouseDown);
            r_NameLabel.MouseDown += new MouseEventHandler(this.pictureBoxBorderedAndNamed_MouseDown);
            r_PhotoPictureBox.MouseDown += new MouseEventHandler(this.pictureBoxBorderedAndNamed_MouseDown);
            this.MouseUp += new MouseEventHandler(this.pictureBoxBorderedAndNamed_MouseEnterAndUp);
            r_NameLabel.MouseUp += new MouseEventHandler(this.pictureBoxBorderedAndNamed_MouseEnterAndUp);
            r_PhotoPictureBox.MouseUp += new MouseEventHandler(this.pictureBoxBorderedAndNamed_MouseEnterAndUp);
            this.MouseEnter += new EventHandler(this.pictureBoxBorderedAndNamed_MouseEnterAndUp);
            r_NameLabel.MouseEnter += new EventHandler(this.pictureBoxBorderedAndNamed_MouseEnterAndUp);
            r_PhotoPictureBox.MouseEnter += new EventHandler(this.pictureBoxBorderedAndNamed_MouseEnterAndUp);
            this.MouseLeave += new EventHandler(this.pictureBoxBorderedAndNamed_MouseLeave);
            r_NameLabel.MouseLeave += new EventHandler(this.pictureBoxBorderedAndNamed_MouseLeave);
            r_PhotoPictureBox.MouseLeave += new EventHandler(this.pictureBoxBorderedAndNamed_MouseLeave);
        }

        public string PictureName
        {
            get
            {
                return r_NameLabel.Text;
            }
            set
            {
                r_NameLabel.Text = value;
            }
        }     
        
        public Image PictureBackgroundImage
        {
            get
            {
                return r_PhotoPictureBox.BackgroundImage;
            }
            set
            {
                r_PhotoPictureBox.BackgroundImage = value;
            }
        }

        private void setBorderAsParent(PictureBox i_PhotoPictureBox, Label i_NameLabel)
        {
            this.Controls.Add(i_NameLabel);
            this.Controls.Add(i_PhotoPictureBox);
            i_NameLabel.Location = new Point(0, 0);
            Point photoLocation = new Point(r_BorderSize, r_BorderSize + r_BorderTextHeight);
            i_PhotoPictureBox.Location = photoLocation;
            i_NameLabel.BringToFront();
            i_PhotoPictureBox.BringToFront();
        }

        private void pictureBoxBorderedAndNamed_MouseLeave(object i_Sender, EventArgs i_E)
        {
            this.BackColor = ColorsUtils.sr_PictureBoxBorderDefault;
            r_NameLabel.Font = new Font(r_NameLabel.Font, FontStyle.Regular);
        }

        private void pictureBoxBorderedAndNamed_MouseEnterAndUp(object i_Sender, EventArgs i_E)
        {
            this.BackColor = ColorsUtils.sr_PictureBoxBorderHover;
            r_NameLabel.Font = new Font(r_NameLabel.Font, FontStyle.Bold);
        }

        private void pictureBoxBorderedAndNamed_MouseDown(object i_Sender, EventArgs i_E)
        {
            this.BackColor = ColorsUtils.sr_PictureBoxBorderChosen;
        }

        private Label createNameLabel()
        {
            Label nameLabel = new Label();
            nameLabel.AutoEllipsis = true;
            nameLabel.Visible = true;
            return nameLabel;
        }

        private PictureBox createPhotoPictureBox(int i_Size)
        {
            PictureBox photoPictureBox = new PictureBox();
            photoPictureBox.Size = new Size(i_Size, i_Size);
            photoPictureBox.BackgroundImageLayout = ImageLayout.Stretch;
            photoPictureBox.Visible = true;
            return photoPictureBox;
        }

        private void setBorder(int i_Size)
        {
            int borderSize = i_Size + (r_BorderSize * 2);
            this.Size = new Size(borderSize, borderSize + r_BorderTextHeight);
            this.BackColor = ColorsUtils.sr_PictureBoxBorderDefault;
            this.Visible = true;
        }

        public void AddOnClickAction(EventHandler i_EventHandler)
        {
            this.Click += i_EventHandler;
            r_NameLabel.Click += triggerPictureBoxClick;
            r_PhotoPictureBox.Click += triggerPictureBoxClick;
        }

        private void triggerPictureBoxClick(object i_Sender, EventArgs i_EventArgs)
        {
            this.OnClick(i_EventArgs);
        }
    }
}
