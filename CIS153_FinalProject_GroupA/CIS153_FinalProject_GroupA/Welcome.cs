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
        public List<POStats> playerOneStats = new List<POStats>();
        public List<PTStats> playerTwoStats = new List<PTStats>();
        public List<PCStats> playerCompStats = new List<PCStats>();


        public Welcome()
        {
            InitializeComponent();
            CenterToScreen();
            readTextFilePO();
            readTextFilePT();
            readTextFilePC();
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

        public void readTextFilePO()
        {
            string fileContent = "";
            playerOneStats = new List<POStats>();

            
            try
            {
                fileContent = CIS153_FinalProject_GroupA.Properties.Resources.PlayerOneStats;
                Console.WriteLine("Success");
            }
            catch (Exception e)
            {
                Console.WriteLine("Error loading File: " + e.Message);
            }

            StreamReader file = new StreamReader("../../Resources/PlayerOneStats.txt");
            string line = file.ReadLine();
            int statPlayerOneMoves;
            int statPlayerOneGames;
            int statPlayerOneOutcome;
            
            int comma;
            char delim = ',';

            Stats newPlayerOneStats;

            while (line != null)
            {
                comma = line.IndexOf(delim);
                statPlayerOneMoves = int.Parse(line.Substring(0, comma));
                line = line.Substring(comma + 1);
                statPlayerOneGames = int.Parse(line.Substring(0, comma));
                line = line.Substring(comma + 1);
                statPlayerOneOutcome = int.Parse(line.Substring(0, comma));

                //newPlayerOneStats = new POStats(statPlayerOneMoves, statPlayerOneGames, statPlayerOneOutcome);
                //playerOneStats.Add(newPlayerOneStats);
                //line = file.ReadLine();
            }

        }

        public void readTextFilePT()
        {
            string fileContent = "";
            playerTwoStats = new List<PTStats>();


            try
            {
                fileContent = CIS153_FinalProject_GroupA.Properties.Resources.PlayerTwoStats;
                Console.WriteLine("Success");
            }
            catch (Exception e)
            {
                Console.WriteLine("Error loading File: " + e.Message);
            }

            StreamReader file = new StreamReader("../../Resources/PlayerTwoStats.txt");
            string line = file.ReadLine();
            int statPlayerTwoMoves;
            int statPlayerTwoGames;
            int statPlayerTwoOutcome;

            int comma;
            char delim = ',';

            Stats newPlayerTwoStats;

            while (line != null)
            {
                comma = line.IndexOf(delim);
                statPlayerTwoMoves = int.Parse(line.Substring(0, comma));
                line = line.Substring(comma + 1);
                statPlayerTwoGames = int.Parse(line.Substring(0, comma));
                line = line.Substring(comma + 1);
                statPlayerTwoOutcome = int.Parse(line.Substring(0, comma));

                //newPlayerTwoStats = new PTStats(statPlayerTwoMoves, statPlayerTwoGames, statPlayerTwoOutcome);
                //playerOneStats.Add(newPlayerTwoStats);
                //line = file.ReadLine();
            }

        }

        public void readTextFilePC()
        {
            string fileContent = "";
            playerCompStats = new List<PCStats>();


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
            int statPlayerCompMoves;
            int statPlayerCompGames;
            int statPlayerCompOutcome;

            int comma;
            char delim = ',';

            Stats newPlayerCompStats;

            while (line != null)
            {
                comma = line.IndexOf(delim);
                statPlayerCompMoves = Convert.ToInt32(line.Substring(0, comma));
                line = line.Substring(comma + 1);
                statPlayerCompGames = Convert.ToInt32(line.Substring(0, comma));
                line = line.Substring(comma + 1);
                statPlayerCompOutcome = Convert.ToInt32(line.Substring(0, comma));

                //newPlayerCompStats = new PCStats(statPlayerCompMoves, statPlayerCompGames, statPlayerCompOutcome);
                //playerOneStats.Add(newPlayerCompStats);
                //line = file.ReadLine();
            }

        }

    }
}
