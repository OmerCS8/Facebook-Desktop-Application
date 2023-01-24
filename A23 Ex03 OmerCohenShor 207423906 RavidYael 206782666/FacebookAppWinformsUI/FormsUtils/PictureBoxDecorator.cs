using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BasicFacebookFeatures.FormsUtils
{
    class PictureBoxDecorator : PictureBox
    {
        protected PictureBox m_InnerPictureBox;

        protected PictureBoxDecorator(PictureBox i_InnerPictureBox)
        {
            this.ControlAdded += this.pictureBox_ControlAdded;
            this.Size = new Size(100, 100);
            InnerPictureBox = i_InnerPictureBox;
            addVisualEffects();
        }

        protected PictureBoxDecorator() : this(new PictureBox()) {}

        public new Size Size
        {
            get => base.Size;
            set
            {
                Size oldSize = this.Size;

                base.Size = value;
                if(m_InnerPictureBox != null)
                {
                    int newInnerWidth = Math.Max(m_InnerPictureBox.Size.Width + (value.Width - oldSize.Width), 0);
                    int newInnerHeight = Math.Max(m_InnerPictureBox.Size.Height + (value.Width - oldSize.Height), 0);
                    m_InnerPictureBox.Size = new Size(newInnerWidth, newInnerHeight);
                }
            }
        }
        
        public PictureBox InnerPictureBox
        {
            get => m_InnerPictureBox;
            set
            {
                if(m_InnerPictureBox != null)
                {
                    this.Controls.Remove(m_InnerPictureBox);
                }

                m_InnerPictureBox = value;
                if(value != null)
                {
                    this.Controls.Add(m_InnerPictureBox);
                    m_InnerPictureBox.Location = this.Location;
                    m_InnerPictureBox.Size = this.Size;
                    m_InnerPictureBox.BackgroundImageLayout = ImageLayout.Stretch;
                }
            }
        }

        private void pictureBox_ControlAdded(object i_Sender, ControlEventArgs i_E)
        {
            if(i_E.Control is Control addedControl)
            {
                addedControl.MouseDown += (i_NewSender, i_Args) => this.OnMouseDown(i_Args);
                addedControl.MouseUp += (i_NewSender, i_Args) => this.OnMouseUp(i_Args);
                addedControl.MouseEnter += (i_NewSender, i_Args) => this.OnMouseEnter(i_Args);
                addedControl.MouseLeave += (i_NewSender, i_Args) => this.OnMouseLeave(i_Args);
                addedControl.Click += (i_NewSender, i_Args) => this.OnClick(i_Args);
                if(addedControl is PictureBoxDecorator addedPictureBoxDecorator)
                {
                    this.MouseDown += addedPictureBoxDecorator.pictureBox_MouseDown;
                    this.MouseUp += addedPictureBoxDecorator.pictureBox_MouseEnterAndUp;
                    this.MouseEnter += addedPictureBoxDecorator.pictureBox_MouseEnterAndUp;
                    this.MouseLeave += addedPictureBoxDecorator.pictureBox_MouseLeave;
                }
            }
        }

        private void pictureBox_MouseLeave(object i_Sender, EventArgs i_E)
        {
            this.BackColor = ColorsUtils.sr_PictureBoxBorderDefault;
        }

        private void pictureBox_MouseEnterAndUp(object i_Sender, EventArgs i_E)
        {
            this.BackColor = ColorsUtils.sr_PictureBoxBorderHover;
        }

        private void pictureBox_MouseDown(object i_Sender, EventArgs i_E)
        {
            this.BackColor = ColorsUtils.sr_PictureBoxBorderChosen;
        }

        private void addVisualEffects()
        {
            this.BackColor = ColorsUtils.sr_PictureBoxBorderDefault;
            this.Cursor = Cursors.Hand;
            this.MouseDown += this.pictureBox_MouseDown;
            this.MouseUp += this.pictureBox_MouseEnterAndUp;
            this.MouseEnter += this.pictureBox_MouseEnterAndUp;
            this.MouseLeave += this.pictureBox_MouseLeave;
        }
    }
}
