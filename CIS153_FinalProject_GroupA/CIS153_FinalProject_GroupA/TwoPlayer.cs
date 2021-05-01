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

//======================================Changes =============================================//
//added code to create a new board and set up a came for every constructor that launches this form
//zpe




namespace CIS153_FinalProject_GroupA
{
    public partial class TwoPlayer : Form
    {
        private Welcome welcome;
        private Board gameBoard;
        private Cell cell;
        //private GameOverStats gameOverStats;
        //List<GameOverStats> GameOverList = new List<GameOverStats>();


        bool column0Full = false;
        bool column1Full = false;
        bool column2Full = false;
        bool column3Full = false;
        bool column4Full = false;
        bool column5Full = false;
        bool column6Full = false;
        public TwoPlayer()
        {
            InitializeComponent();
            gameBoard = new Board();
            setUpGame();

        }

        public new void CenterToScreen()
        {
            base.CenterToScreen();
        }

        public TwoPlayer(Welcome wel)
        {
            InitializeComponent();
            CenterToScreen();
            welcome = wel;
            txt_turn.Text = "Player 1's Turn";
            gameBoard = new Board();
            setUpGame();
        }

        public void passedForm(Welcome wel)
        {
            welcome = wel;
            gameBoard = new Board();
            setUpGame();
        }

        public void loadGameOverForm()
        {
            GameOver formToLoad = new GameOver(this);
            formToLoad.ShowDialog();
        }

        public void WriteToTextGO()
        {
            int gameWinner = gameBoard.getWinnerPlayer();
            int secondPlayerID = 1;

            string filePath = "../../Resources/GameOverStats.txt";

            StreamWriter sw = new StreamWriter(filePath, true);

            sw.WriteLineAsync(gameWinner + "," + secondPlayerID);

            sw.Close();
        }


        //I stole this part straight from zach, I included his comments to make for easier reading
        public void setUpGame()
        {
            Console.WriteLine("Setting up game.");
            string name;
            char delim = '_';
            int posDelim;
            int col;
            int row;
            Cell c;

            //Find all buttons on the form
            //Be careful becuase if you have other buttons besides the cells (restart, exit, etc) this could cause an issue
            //Might need an if statement to exclude those buttons
            foreach (var button in this.Controls.OfType<RoundButton>())
            {
                name = button.Name;
                posDelim = name.IndexOf(delim);
                //Look one place past where we found the delim and then read one character.  that is the row
                //If this was a two digit by two digit grid (10x10, 15x30, etc.) this would break.
                row = Int32.Parse(name.Substring(posDelim + 1, 1));
                //name is now only equal to everything after the row number we found.
                name = name.Substring(posDelim + 2);
                //Find the delim again
                posDelim = name.IndexOf(delim);
                col = Int32.Parse(name.Substring(posDelim + 1));

                //create a new cell
                c = new Cell(row, col, button);
                // Console.WriteLine(row.ToString(), col.ToString());
                //add that cell to the gameboard
                gameBoard.setGameBoardCell(c);



            }


        }






        //this is coded by brendan, needs column and row variables commented out earlier.
        //commented those out because I use them in the board class

        //// this may be used later on
        //private void createboard(int[,] board)
        //{
        //    for (int c = 0; c < columncount; c++)
        //    {
        //        for (int r = 0; r < rowcount; r++)
        //        {
        //            Console.WriteLine(board[r, c]);
        //        }
        //    }
        //}

        private void twoplayer_paint(object sender, PaintEventArgs e)
        {
        }


        //==================================Column Button Clicks====================================//
        //   Each of these functions performs the btn_Click function given a column. The function starts
        //   at the top of the array (visually the bottom), checking all the buttons with the set Column
        //   variable, and with rows starting at 5 and decrementing till 0
        //================================================================================================

        private void btn_0_0_Click(object sender, EventArgs e)
        {
            btn_Click(0);

            if (gameBoard.getGameOver() == true)
            {
                WriteToTextGO();
                loadGameOverForm();
            }
        }

        private void btn_0_1_Click(object sender, EventArgs e)
        {
            btn_Click(1);

            if (gameBoard.getGameOver() == true)
            {
                WriteToTextGO();
                loadGameOverForm();
            }
        }

        private void btn_0_2_Click(object sender, EventArgs e)
        {
            btn_Click(2);

            if (gameBoard.getGameOver() == true)
            {
                WriteToTextGO();
                loadGameOverForm();
            }
        }

        private void btn_0_3_Click_1(object sender, EventArgs e)
        {
            btn_Click(3);

            if (gameBoard.getGameOver() == true)
            {
                WriteToTextGO();
                loadGameOverForm();
            }
        }

        private void btn_0_4_Click_1(object sender, EventArgs e)
        {
            btn_Click(4);

            if (gameBoard.getGameOver() == true)
            {
                WriteToTextGO();
                loadGameOverForm();
            }
        }

        private void btn_0_5_Click_1(object sender, EventArgs e)
        {
            btn_Click(5);

            if (gameBoard.getGameOver() == true)
            {
                WriteToTextGO();
                loadGameOverForm();
            }
        }

        private void btn_0_6_Click_1(object sender, EventArgs e)
        {
            btn_Click(6);

            if (gameBoard.getGameOver() == true)
            {
                WriteToTextGO();
                loadGameOverForm();
            }
        }


        //Sets a boolean named Falling as true. 
        //Runs a for loop for the variable numRows in the gameboard minus 1, which
        //lets the function check all the variables in the first coordinate of a column.
        //
        //If the player value in that cell is 0, meaning empty, and the boolean Falling is true
        //the player value of that cell will be set as the current value of the player cell, and the
        //color of that button will be changed. The loop will execute until a piece is placed.

        // STILL NEED TO ADD FUNCTION TO CHECK IF THE BOARD IS FULL DUE TO STALEMATE


        private void btn_Click(int c)
        {

            bool falling = true;

            for (int r = gameBoard.getNumRows() - 1; r >= 0; r--)
            {
                if (gameBoard.getCell(r, c).getPlayer() == 0 & falling == true)
                {
                    txt_turn.Text = "Player 2's Turn";
                    txt_turn.ForeColor = Color.Yellow;
                    rndbtn_p1.BackColor = Color.LightGray;
                    rndbtn_p2.BackColor = Color.Yellow;
                    rndbtn_p2.FlatAppearance.MouseDownBackColor = Color.Yellow;
                    rndbtn_p2.FlatAppearance.MouseOverBackColor = Color.Yellow;
                    rndbtn_p1.FlatAppearance.MouseDownBackColor = Color.LightGray;
                    rndbtn_p1.FlatAppearance.MouseOverBackColor = Color.LightGray;
                    if (gameBoard.getTurn() == 0)
                    {
                        gameBoard.getCell(r, c).setPlayer(1);
                        gameBoard.getCell(r, c).getButton().BackColor = Color.Red;
                        Console.WriteLine("Button Row: " + gameBoard.getCell(r, c).getButton().Name[4]);
                        if (r == 0)
                        {
                            columnFull(c);
                        }
                    }
                    else
                    {
                        txt_turn.Text = "Player 1's Turn";
                        txt_turn.ForeColor = Color.Red;
                        rndbtn_p1.BackColor = Color.Red;
                        rndbtn_p2.BackColor = Color.LightGray;
                        rndbtn_p2.FlatAppearance.MouseDownBackColor = Color.LightGray;
                        rndbtn_p2.FlatAppearance.MouseOverBackColor = Color.LightGray;
                        rndbtn_p1.FlatAppearance.MouseDownBackColor = Color.Red;
                        rndbtn_p1.FlatAppearance.MouseOverBackColor = Color.Red;
                        gameBoard.getCell(r, c).setPlayer(2);
                        gameBoard.getCell(r, c).getButton().BackColor = Color.Yellow;
                        Console.WriteLine("Button Row: " + gameBoard.getCell(r, c).getButton().Name[4]);
                        if (r == 0)
                        {
                            columnFull(c);
                        }
                    }

                    falling = false;
                    gameBoard.changeTurn();


                }

            }


            gameBoard.checkForTie();
            gameBoard.horizontalRightCheck();
            //gameBoard.horizontalLeftCheck();
            gameBoard.verticalUpperCheck();
            //gameBoard.verticalLowerCheck();
            gameBoard.diagonalUpperRightCheck();
            gameBoard.diagonalLowerRightCheck();

        }

        private void btn_Hover(int c)
        {
            for (int r = gameBoard.getNumRows() - 1; r >= 0; r--)
            {
                if (gameBoard.getCell(r, c).getPlayer() == 0)
                {
                    gameBoard.getCell(r, c).getButton().BackColor = Color.PaleTurquoise;
                    break;
                }
            }
        }

        private void btn_Leave(int c)
        {
            for (int r = gameBoard.getNumRows() - 1; r >= 0; r--)
            {
                if (gameBoard.getCell(r, c).getPlayer() == 0)
                {
                    gameBoard.getCell(r, c).getButton().BackColor = Color.CornflowerBlue;
                    break;
                }
            }
        }

        public void columnFull(int c)
        {
            if (c == 0)
            {
                column0Full = true;
                Console.WriteLine("Collumn " + c + " full");
            }

            if (c == 1)
            {
                column1Full = true;
                Console.WriteLine("Collumn " + c + " full");
            }
            if (c == 2)
            {

                column2Full = true;
                Console.WriteLine("Collumn " + c + " full");
            }
            if (c == 3)
            {
                column3Full = true;
                Console.WriteLine("Collumn " + c + " full");
            }
            if (c == 4)
            {
                column4Full = true;
                Console.WriteLine("Collumn " + c + " full");
            }
            if (c == 5)
            {
                column5Full = true;
                Console.WriteLine("Collumn " + c + " full");
            }
            if (c == 6)
            {
                column6Full = true;
                Console.WriteLine("Collumn " + c + " full");
            }

            for (int r = gameBoard.getNumRows() - 1; r >= 0; r--)
            {
                gameBoard.getCell(r, c).getButton().Enabled = false;
            }
        }

        private void btn_exit_Click(object sender, EventArgs e)
        {
            Environment.Exit(1);
        }

        private void btn_0_0_MouseHover(object sender, EventArgs e)
        {
            btn_Hover(0);
        }

        private void btn_0_1_MouseHover(object sender, EventArgs e)
        {
            btn_Hover(1);
        }

        private void btn_0_2_MouseHover(object sender, EventArgs e)
        {
            btn_Hover(2);
        }

        private void btn_0_3_MouseHover(object sender, EventArgs e)
        {
            btn_Hover(3);
        }

        private void btn_0_4_MouseHover(object sender, EventArgs e)
        {
            btn_Hover(4);
        }

        private void btn_0_5_MouseHover(object sender, EventArgs e)
        {
            btn_Hover(5);
        }

        private void btn_0_6_MouseHover(object sender, EventArgs e)
        {
            btn_Hover(6);
        }

        private void btn_0_0_MouseLeave(object sender, EventArgs e)
        {
            btn_Leave(0);
        }

        private void btn_0_1_MouseLeave(object sender, EventArgs e)
        {
            btn_Leave(1);
        }

        private void btn_0_2_MouseLeave(object sender, EventArgs e)
        {
            btn_Leave(2);
        }

        private void btn_0_3_MouseLeave(object sender, EventArgs e)
        {
            btn_Leave(3);
        }

        private void btn_0_4_MouseLeave(object sender, EventArgs e)
        {
            btn_Leave(4);
        }

        private void btn_0_5_MouseLeave(object sender, EventArgs e)
        {
            btn_Leave(5);
        }

        private void btn_0_6_MouseLeave(object sender, EventArgs e)
        {
            btn_Leave(6);
        }
    }
}