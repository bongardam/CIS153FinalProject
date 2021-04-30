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
    public partial class GameOver : Form
    {

        //class variables

        public List<GameOverStats> gameOverStats = new List<GameOverStats>();
        private Welcome welcome;
        private SinglePlayer singlePlayer;
        private TwoPlayer twoPlayer;

        public GameOver(Welcome wel)
        {
            InitializeComponent();
            readTextFileGOS();
            fillLabels();
            CenterToScreen();

            welcome = wel;
        }
        public GameOver(SinglePlayer sp)
        {
            InitializeComponent();
            readTextFileGOS();
            fillLabels();
            CenterToScreen();
            singlePlayer = sp;

        }

        public GameOver(TwoPlayer tp)
        {
            InitializeComponent();
            readTextFileGOS();
            fillLabels();
            CenterToScreen();
            twoPlayer = tp;
        }

        public void passedForm(SinglePlayer sp)
        {
            singlePlayer = sp;
        }

        public void passedForm(TwoPlayer tp)
        {
            twoPlayer = tp;
        }
        public new void CenterToScreen()
        {
            base.CenterToScreen();
        }
       
        public void readTextFileGOS()
        {
            string fileContent = "";
            gameOverStats = new List<GameOverStats>();


            try
            {
                fileContent = CIS153_FinalProject_GroupA.Properties.Resources.GameOverStats;
                Console.WriteLine("Success");
            }
            catch (Exception e)
            {
                Console.WriteLine("Error loading File: " + e.Message);
            }

            StreamReader file = new StreamReader("../../Resources/GameOverStats.txt");
            string line = file.ReadLine();
            int statGameWinner;
            //int statGameMoves;
            int statGameSecondPlayer;            

            int comma;
            char delim = ',';

            GameOverStats newGameOverStats;

            while (line != null)
            {
                comma = line.IndexOf(delim);
                statGameWinner = Int32.Parse(line.Substring(0, comma));
                line = line.Substring(comma + 1);
                //statGameMoves = Int32.Parse(line.Substring(0, comma));
                //line = line.Substring(comma + 1);
                statGameSecondPlayer = Int32.Parse(line.Substring(0, comma));
                

                newGameOverStats = new GameOverStats(statGameWinner, statGameSecondPlayer);               
                gameOverStats.Add(newGameOverStats);
                line = file.ReadLine();
                Console.WriteLine(statGameWinner + " = " + statGameSecondPlayer);
            }
            
        }

        

        private void btn_mainMenu_Click(object sender, EventArgs e)
        {
            welcomeLoadForm();
        }

        private void welcomeLoadForm()
        {
            Welcome wel = new Welcome(this);
            wel.Show();
            this.Hide();
            if (twoPlayer == null)
            {
                singlePlayer.Hide();
            }    
            else if (singlePlayer == null)
            {
                twoPlayer.Hide();
            }
        }

        private void btn_exit_Click(object sender, EventArgs e)
        {           
            Environment.Exit(1);
        }        

        private void btn_showBoard_Click(object sender, EventArgs e)
        {
            //move left and show board on right?
            this.Location = new Point(165, 125);
        }

        public void fillLabels()
        {
            int i = gameOverStats.Count-1;
            int gameWinner = gameOverStats[i].getGameWinner();
            //int moves = gameOverStats[i].getGameMoves();
            int gameSecondPlayer = gameOverStats[i].getGameSecondPlayer();
            string winner;
            string player;

            if (gameSecondPlayer == 0)
            {
                player = "COMPUTER";
                lbl_secondPlayer.Text = player.ToString();
            }

            else if (gameSecondPlayer == 1)
            {
                player = "PLAYER 2";
                lbl_secondPlayer.Text = player.ToString();
            }

            if (gameWinner == 3)
            {
                winner = "Tie";
                lbl_winner.Text = winner.ToString();
            }

            if (gameWinner == 1)
            {
                winner = "Player   1";
                lbl_winner.ForeColor = Color.Red;
                lbl_winner.Text = winner.ToString();
            }

            if (gameWinner == 2)
            {
                if (gameSecondPlayer == 0)
                {
                    winner = "Computer";
                    lbl_winner.ForeColor = Color.Yellow;
                    lbl_winner.Text = winner.ToString();
                }
                else if (gameSecondPlayer == 1)
                {
                    winner = "Player   2";
                    lbl_winner.ForeColor = Color.Yellow;
                    lbl_winner.Text = winner.ToString();
                }
            }

            //lbl_winner.Text = winner.ToString();
            //lbl_movesTotal.Text = moves.ToString();

            Console.WriteLine(gameOverStats[i].getGameWinner() + " = " +  gameOverStats[i].getGameSecondPlayer());
            Console.WriteLine(gameWinner + " = " + gameSecondPlayer);
        }
    }
}
