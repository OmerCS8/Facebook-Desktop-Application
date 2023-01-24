﻿using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BasicFacebookFeatures.FormsUtils
{
    class PictureBoxBordered : PictureBoxDecorator
    {
        public int BorderSize { set; get; }

        public PictureBoxBordered(PictureBox i_InnerPicture, int i_BorderSize = 10) : base(i_InnerPicture)
        {
            (this as PictureBox).Size = new Size(this.Size.Width + i_BorderSize, this.Size.Height + i_BorderSize);
            this.m_InnerPictureBox.Location = new Point(i_BorderSize / 2, i_BorderSize / 2);
        }
    }
}
