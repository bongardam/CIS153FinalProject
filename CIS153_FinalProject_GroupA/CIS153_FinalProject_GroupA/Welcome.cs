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
        //class variables
        //stat array variables
        public List<PlayerStats> playerStats = new List<PlayerStats>();


        public Welcome()
        {
            InitializeComponent();
            CenterToScreen();
            readTextFiles();
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

        //load text files for stats

        public void readTextFiles()
        {
            string fileContent = "";
            playerStats = new List<PlayerStats>();

            
            try
            {
                fileContent = CIS153_FinalProject_GroupA.Properties.Resources.CompStats;
                Console.WriteLine("Success");
            }
            catch (Exception e)
            {
                Console.WriteLine("Error loading File: " + e.Message);
            }

            StreamReader file = new StreamReader("../../Resources/CompStats.txt");
            string line = file.ReadLine();
            //int statPlayerOneMoves;
            //int statPlayerOneGames;
            //int statPlayerOneOutcome;
            //int statPlayerTwoMoves;
            //int statPlayerTwoGames;
            //int statPlayerTwoOutcome;
            int statCompMoves;
            int statCompGames;
            int statCompOutcome;

            int comma;
            char delim = ',';

            Stats newPlayerStats;

            while (line != null)
            {
                comma = line.IndexOf(delim);
                statCompMoves = int.Parse(line.Substring(0, comma));
                line = line.Substring(comma + 1);
                statCompGames = int.Parse(line.Substring(0, comma));
                line = line.Substring(comma + 1);
                statCompOutcome = int.Parse(line.Substring(0, comma));

                newPlayerStats = new PlayerStats(statCompMoves, statCompGames, statCompOutcome);
                playerStats.Add(newPlayerStats);
                line = file.ReadLine();
            }

        }

    }
}
