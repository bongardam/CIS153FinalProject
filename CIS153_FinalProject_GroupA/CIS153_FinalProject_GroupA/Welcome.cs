using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;

namespace CIS153_FinalProject_GroupA
{
    // Brendan Czekaj
    public partial class Welcome : Form
    {
        private GameOver gameOver;
        private SinglePlayer singlePlayer;
        private TwoPlayer twoPlayer;
        private Stats stats;

        public Welcome()
        {
            InitializeComponent();
            CenterToScreen();
            pictureBox_logo.Parent = pictureBox_bg;
            pictureBox_logo.BackColor = Color.Transparent;
            
        }     

        public Welcome(SinglePlayer sp)
        {
            InitializeComponent();
            CenterToScreen();
            singlePlayer = sp;
        }

        public Welcome(TwoPlayer tp)
        {
            InitializeComponent();
            CenterToScreen();
            twoPlayer = tp;
        }
        public Welcome(Stats st)
        {
            InitializeComponent();
            CenterToScreen();
            stats = st;
        }
        public Welcome(GameOver go)
        {
            InitializeComponent();
            CenterToScreen();
            gameOver = go;
        }
        public void passedForm(SinglePlayer sp)
        {
            singlePlayer = sp;
        }

        public void passedForm(TwoPlayer tp)
        {
            twoPlayer = tp;
        }
        public void passedForm(Stats st)
        {
            stats = st;
        }
        public void passedForm(GameOver go)
        {
            gameOver = go;
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
            //Application.Exit();
            Environment.Exit(1);
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

        
        

    }
}
