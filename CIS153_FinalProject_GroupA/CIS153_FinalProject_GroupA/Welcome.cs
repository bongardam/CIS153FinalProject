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
    // Brendan Czekaj
    public partial class Welcome : Form
    {
        //class variables
        //stat array variables


        public Welcome()
        {
            InitializeComponent();
            CenterToScreen();
        }

        public new void CenterToScreen()
        {
            base.CenterToScreen();
        }

        private void btn_onePlayer_Click(object sender, EventArgs e)
        {
            loadOneForm();
        }

        private void btn_twoPlayer_Click(object sender, EventArgs e)
        {
            loadTwoForm();
        }

        private void btn_stats_Click(object sender, EventArgs e)
        {
            loadStatForm();
        }

        private void btn_exit_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        public void loadOneForm()
        {
            SinglePlayer formToLoad = new SinglePlayer(this);
            formToLoad.Show();
            this.Hide();
        }

        public void loadTwoForm()
        {
            TwoPlayer formToLoad = new TwoPlayer(this);
            formToLoad.Show();
            this.Hide();
        }

        public void loadStatForm()
        {
            Stats formToLoad = new Stats(this);
            formToLoad.Show();
            this.Hide();
        }

        //load text files for stats data?



    }
}
