using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

//======================================Changes =============================================//
//added code to create a new board and set up a came for every constructor that launches this form
//zpe




namespace CIS153_FinalProject_GroupA
{
    public partial class TwoPlayer : Form
    {
        private Welcome welcome;

        private Board gameBoard;

        bool column0Full = false;
        bool column1Full = false;
        bool column2Full = false;
        bool column3Full = false;
        bool column4Full = false;
        bool column5Full = false;
        bool column6Full = false;

        ////coded by brendan, i have these set at the board level
        //const int columncount = 7;
        //const int rowcount = 6;


        //int[,] board = new int[rowcount, columncount]; // bc: inits our board which we will store the user's moves in 
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
            gameBoard = new Board();
            setUpGame();
        }

        public void passedForm(Welcome wel)
        {
            welcome = wel;
            gameBoard = new Board();
            setUpGame();
        }

        private void TwoPlayer_FormClosed(object sender, FormClosedEventArgs e)
        {
            Application.Exit();
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
            foreach (var button in this.Controls.OfType<Button>())
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
            //    Graphics g = e.Graphics;
            //    Brush bluebrush = new SolidBrush(Color.Blue); // bc: just a brush
            //    Brush whitebrush = new SolidBrush(Color.White); // bc: another brush

            //    //rectangle toprect = new rectangle(0, 0, 800, 145); // bc: placeholder rectangle i will
            //    //g.fillrectangle(whitebrush, toprect);              //     finish up next week

            //    // bc: the size of the shapes are relative to the column and row
            //    // for example: row 1, column 3 would have
            //    // xpos = 101, ypos = 303
            //    for (int c = 0; c < columncount; c++)
            //    {
            //        for (int r = 0; r < rowcount; r++)
            //        {                                // xpos, ypos, width, height
            //            Rectangle rect = new Rectangle(c * 101 + 15, r * 101 + 151, 90, 90);
            //            g.FillRectangle(bluebrush, rect);
            //            g.FillEllipse(whitebrush, rect);
            //        }
            //    }
        }


        //==================================Column Button Clicks====================================//
        //   Each of these functions performs the btn_Click function given a column. The function starts
        //   at the top of the array (visually the bottom), checking all the buttons with the set Column
        //   variable, and with rows starting at 5 and decrementing till 0
        //================================================================================================

        private void btn_0_0_Click_1(object sender, EventArgs e)
        {
            btn_Click(0);
        }

        private void btn_0_1_Click_1(object sender, EventArgs e)
        {
            btn_Click(1);
        }

        private void btn_0_2_Click_1(object sender, EventArgs e)
        {
            btn_Click(2);
        }

        private void btn_0_3_Click(object sender, EventArgs e)
        {
            btn_Click(3);
        }

        private void btn_0_4_Click(object sender, EventArgs e)
        {
            btn_Click(4);
        }

        private void btn_0_5_Click(object sender, EventArgs e)
        {
            btn_Click(5);
         
        }

        private void btn_0_6_Click(object sender, EventArgs e)
        {
            btn_Click(6);
           
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

                    if (gameBoard.getTurn() == 0)
                    {
                        gameBoard.getCell(r, c).setPlayer(1);
                        gameBoard.getCell(r, c).getButton().BackColor = Color.Red;
                        Console.WriteLine("Button Row: " + gameBoard.getCell(r, c).getButton().Name[4]);

                        if(r == 0)
                        {
                            columnFull(c);
                        }
                    }
                    else
                    {
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

            

            gameBoard.horizontalRightCheck();
            //gameBoard.horizontalLeftCheck();
            gameBoard.verticalUpperCheck();
            //gameBoard.verticalLowerCheck();
            gameBoard.diagonalUpperRightCheck();
            gameBoard.diagonalLowerRightCheck();

        }


        public void columnFull(int c)
        {
            if( c == 0)
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


    }

}
