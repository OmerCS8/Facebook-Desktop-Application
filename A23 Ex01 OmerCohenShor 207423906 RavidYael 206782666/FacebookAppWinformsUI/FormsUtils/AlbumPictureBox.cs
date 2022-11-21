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
    class AlbumPictureBox : PictureBox
    {
        private readonly int r_BorderSize = 10;
        private readonly int r_BorderTextHeight = 10;
        private readonly PictureBox r_PhotoPictureBox;
        private readonly Label r_NameLabel;
        public AlbumPictureBox(int i_Size, bool i_DoesHaveBorder)
        {
            setBorder(i_Size, i_DoesHaveBorder);
            r_PhotoPictureBox = createPhotoPictureBox(i_Size);
            r_NameLabel = createNameLabel();
            setBorderAsParent(r_PhotoPictureBox, r_NameLabel, i_DoesHaveBorder);
            addVisualEffects();
        }

        private void addVisualEffects()
        {
            this.Cursor = Cursors.Hand;
            this.MouseDown += new MouseEventHandler(this.albumPictureBox_MouseDown);
            r_NameLabel.MouseDown += new MouseEventHandler(this.albumPictureBox_MouseDown);
            r_PhotoPictureBox.MouseDown += new MouseEventHandler(this.albumPictureBox_MouseDown);
            this.MouseUp += new MouseEventHandler(this.albumPictureBox_MouseEnterAndUp);
            r_NameLabel.MouseUp += new MouseEventHandler(this.albumPictureBox_MouseEnterAndUp);
            r_PhotoPictureBox.MouseUp += new MouseEventHandler(this.albumPictureBox_MouseEnterAndUp);
            this.MouseEnter += new EventHandler(this.albumPictureBox_MouseEnterAndUp);
            r_NameLabel.MouseEnter += new EventHandler(this.albumPictureBox_MouseEnterAndUp);
            r_PhotoPictureBox.MouseEnter += new EventHandler(this.albumPictureBox_MouseEnterAndUp);
            this.MouseLeave += new EventHandler(this.albumPictureBox_MouseLeave);
            r_NameLabel.MouseLeave += new EventHandler(this.albumPictureBox_MouseLeave);
            r_PhotoPictureBox.MouseLeave += new EventHandler(this.albumPictureBox_MouseLeave);
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

        private void setBorderAsParent(PictureBox i_PhotoPictureBox, Label i_NameLabel, bool i_DoesHaveBorder)
        {
            this.Controls.Add(i_NameLabel);
            this.Controls.Add(i_PhotoPictureBox);
            i_NameLabel.Location = new Point(0, 0);
            Point photoLocation = i_DoesHaveBorder ? new Point(r_BorderSize, r_BorderSize + r_BorderTextHeight) 
                                      : new Point(0, r_BorderTextHeight);
            i_PhotoPictureBox.Location = photoLocation;
            i_NameLabel.BringToFront();
            i_PhotoPictureBox.BringToFront();
        }

        private void albumPictureBox_MouseLeave(object i_Sender, EventArgs i_E)
        {
            this.BackColor = ColorsUtils.sr_PictureBoxBorderDefault;
            r_NameLabel.Font = new Font(r_NameLabel.Font, FontStyle.Regular);
        }

        private void albumPictureBox_MouseEnterAndUp(object i_Sender, EventArgs i_E)
        {
            this.BackColor = ColorsUtils.sr_PictureBoxBorderHover;
            r_NameLabel.Font = new Font(r_NameLabel.Font, FontStyle.Bold);
        }

        private void albumPictureBox_MouseDown(object i_Sender, EventArgs i_E)
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

        private void setBorder(int i_Size, bool i_DoesHaveBorder)
        {
            int borderSize = i_DoesHaveBorder ? i_Size + (r_BorderSize * 2) : i_Size;
            this.Size = new Size(borderSize, borderSize + r_BorderTextHeight);
            this.BackColor = ColorsUtils.sr_PictureBoxBorderDefault;
            this.Visible = true;
        }

        public void AddOnClickAction(EventHandler i_EventHandler)
        {
            this.Click += i_EventHandler;
            r_NameLabel.Click += i_EventHandler;
            r_PhotoPictureBox.Click += i_EventHandler;
        }
    }
}
