﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CIS153_FinalProject_GroupA
{
    public partial class SinglePlayer : Form
    {
        Welcome welcome;

        public SinglePlayer()
        {
            InitializeComponent();
        }

        public new void CenterToScreen()
        {
            base.CenterToScreen();
        }

        public SinglePlayer(Welcome wel)
        {
            InitializeComponent();
            CenterToScreen();
            welcome = wel;
        }

        public void passedForm(Welcome wel)
        {
            welcome = wel;
        }
    }
}
