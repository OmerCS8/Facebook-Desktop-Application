﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BasicFacebookFeatures.sub_forms
{
    public partial class FormProfile : Form
    {
        public FormProfile()
        {
            this.BackColor = this.Parent.BackColor;
            InitializeComponent();
        }
    }
}