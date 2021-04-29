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
    public partial class Stats : Form
    {
        private Welcome welcome;

        public List<POStats> playerOneStats = new List<POStats>();
       
        public Stats()
        {
            InitializeComponent();
            
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
            CenterToScreen();
            readTextFilePO();           
            fillLabels();
        }

        public void passedForm(Welcome wel)
        {
            welcome = wel;
        }
        
        private void Stats_FormClosing(object sender, FormClosingEventArgs e)
        {
            loadWelcomeForm();
        }

        public void loadWelcomeForm()
        {
            Welcome formToLoad = new Welcome(this);
            formToLoad.Show();
            this.Hide();
        }

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
            //int statPlayerOneMoves;
            int statPlayerOneOutcome;
            int statPlayerOneTie;

            int comma;
            char delim = ',';

            POStats newPlayerOneStats;

            while (line != null)
            {
                comma = line.IndexOf(delim);
                //statPlayerOneMoves = Int32.Parse(line.Substring(0, comma));
                //line = line.Substring(comma + 1);
                statPlayerOneOutcome = Int32.Parse(line.Substring(0, comma));
                line = line.Substring(comma + 1);
                statPlayerOneTie = Int32.Parse(line.Substring(0, comma));

                newPlayerOneStats = new POStats(statPlayerOneOutcome, statPlayerOneTie);
                playerOneStats.Add(newPlayerOneStats);
                line = file.ReadLine();
                Console.WriteLine(statPlayerOneOutcome + " = " + statPlayerOneTie);
            }
            
        }
        

        public void fillLabels()
        {
            int count = playerOneStats.Count;
            int POWins = playerOneStats.Sum(item => item.getPlayerOneOutcome());
            int POTies = playerOneStats.Sum(item => item.getPlayerOneTie());
            int PCWins = playerOneStats.Count - POWins;
            double POPercent = ((float)POWins / count) * 100;


            lbl_gamesPlayedDisplay.Text = count.ToString();
            lbl_gamesWonDisplay.Text = POWins.ToString();
            lbl_gamesTiedDisplay.Text = POTies.ToString();
            lbl_gamesPercentDisplay.Text = POPercent.ToString("0") + "%";
        }

        private void btn_mainMenu_Click(object sender, EventArgs e)
        {
            loadWelcomeForm();
        }
    }
}
