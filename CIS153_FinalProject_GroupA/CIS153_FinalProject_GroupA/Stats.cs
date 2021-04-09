using System;
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
    public partial class Stats : Form
    {
        private Welcome welcome;

        public Stats()
        {
            InitializeComponent();
            CenterToScreen();
        }

        public new void CenterToScreen()
        {
            base.CenterToScreen();
        }

        public Stats(Welcome wel)
        {
            InitializeComponent();
            CenterToScreen();
            welcome = wel;
        }

        public void passedForm(Welcome wel)
        {
            welcome = wel;
        }

        private void Stats_FormClosed(object sender, FormClosedEventArgs e)
        {
            Application.Exit();
        }
    }
}
