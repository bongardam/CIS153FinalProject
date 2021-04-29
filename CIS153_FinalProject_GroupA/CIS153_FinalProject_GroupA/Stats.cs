﻿using System;
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
        //public List<PTStats> playerTwoStats = new List<PTStats>();
        public List<PCStats> playerCompStats = new List<PCStats>();

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
            //readTextFilePT();
            readTextFilePC();
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
            int statPlayerOneMoves;
            int statPlayerOneGames;
            int statPlayerOneOutcome;
            int statPlayerOneTie;

            int comma;
            char delim = ',';

            POStats newPlayerOneStats;

            while (line != null)
            {
                comma = line.IndexOf(delim);
                statPlayerOneMoves = Int32.Parse(line.Substring(0, comma));
                line = line.Substring(comma + 1);
                statPlayerOneGames = Int32.Parse(line.Substring(0, comma));
                line = line.Substring(comma + 1);
                statPlayerOneOutcome = Int32.Parse(line.Substring(0, comma));
                line = line.Substring(comma + 1);
                statPlayerOneTie = Int32.Parse(line.Substring(0, comma));

                newPlayerOneStats = new POStats(statPlayerOneMoves, statPlayerOneGames, statPlayerOneOutcome, statPlayerOneTie);
                playerOneStats.Add(newPlayerOneStats);
                line = file.ReadLine();
            }
            
        }
        

        //public void readTextFilePT()
        //{
        //    string fileContent = "";
        //    playerTwoStats = new List<PTStats>();


        //    try
        //    {
        //        fileContent = CIS153_FinalProject_GroupA.Properties.Resources.PlayerTwoStats;
        //        Console.WriteLine("Success");
        //    }
        //    catch (Exception e)
        //    {
        //        Console.WriteLine("Error loading File: " + e.Message);
        //    }

        //    StreamReader file = new StreamReader("../../Resources/PlayerTwoStats.txt");
        //    string line = file.ReadLine();
        //    int statPlayerTwoMoves;
        //    int statPlayerTwoGames;
        //    int statPlayerTwoOutcome;

        //    int comma;
        //    char delim = ',';

        //    PTStats newPlayerTwoStats;

        //    while (line != null)
        //    {
        //        comma = line.IndexOf(delim);
        //        statPlayerTwoMoves = Int32.Parse(line.Substring(0, comma));
        //        line = line.Substring(comma + 1);
        //        statPlayerTwoGames = Int32.Parse(line.Substring(0, comma));
        //        line = line.Substring(comma + 1);
        //        statPlayerTwoOutcome = Int32.Parse(line.Substring(0, comma));

        //        newPlayerTwoStats = new PTStats(statPlayerTwoMoves, statPlayerTwoGames, statPlayerTwoOutcome);
        //        playerTwoStats.Add(newPlayerTwoStats);
        //        line = file.ReadLine();
        //    }

        //}

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
            int statCompMoves;
            int statCompGames;
            int statCompOutcome;
            int statCompTie;

            int comma;
            char delim = ',';

            PCStats newPlayerCompStats;

            while (line != null)
            {
                comma = line.IndexOf(delim);
                statCompMoves = Int32.Parse(line.Substring(0, comma));
                line = line.Substring(comma + 1);
                statCompGames = Int32.Parse(line.Substring(0, comma));
                line = line.Substring(comma + 1);
                statCompOutcome = Int32.Parse(line.Substring(0, comma));
                line = line.Substring(comma + 1);
                statCompTie = Int32.Parse(line.Substring(0, comma));

                newPlayerCompStats = new PCStats(statCompMoves, statCompGames, statCompOutcome, statCompTie);
                playerCompStats.Add(newPlayerCompStats);
                line = file.ReadLine();
            }

        }

        public void fillLabels()
        {
            int count = playerOneStats.Count;
            int POWins = playerOneStats.Sum(item => item.getPlayerOneOutcome());
            int POTies = playerOneStats.Sum(item => item.getPlayerOneTie());
            int PCWins = playerCompStats.Sum(item => item.getCompOutcome());
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
