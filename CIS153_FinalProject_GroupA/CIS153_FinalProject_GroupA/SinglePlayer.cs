﻿using System;
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
    public partial class SinglePlayer : Form
    {
        Welcome welcome;
        private Board gameBoard;
        public SinglePlayer()
        {
            InitializeComponent();
        }

        public new void CenterToScreen()
        {
            base.CenterToScreen();
        }

        public SinglePlayer(Welcome wel)
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
        }

        private void SinglePlayer_FormClosed(object sender, FormClosedEventArgs e)
        {
            Application.Exit();
        }

        /// THIS MAY BE USED LATER ON
        //private void createBoard(int[,] board)
        //{
        //    for (int c = 0; c < columnCount; c++)
        //    {
        //        for (int r = 0; r < rowCount; r++)
        //        {
        //            Console.WriteLine(board[r, c]);
        //        }
        //    }

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

        private void SinglePlayer_Paint(object sender, PaintEventArgs e)
        {
        //    Graphics g = e.Graphics;
        //    Pen myPen = new Pen(Color.Black);
        //    Brush blueBrush = new SolidBrush(Color.Blue); // BC: a brush to fill in shapes
        //    Brush whiteBrush = new SolidBrush(Color.White); // BC: a brush to fill in shapes

        //    //Rectangle topRect = new Rectangle(0, 0, 800, 145);
        //    //g.FillRectangle(whiteBrush, topRect);

        //    // BC: The size of the shapes are relative to the column and row
        //    // For example: row 1, column 3 would have the values
        //    // xPos = 101, yPos = 303
        //    for (int c = 0; c < columnCount; c++)
        //    {
        //        for (int r = 0; r < rowCount; r++)
        //        {                                  //xPos, yPos, width, height
        //            Rectangle rect = new Rectangle(c*101+15, r*101+151, 90, 90);
        //            g.FillRectangle(blueBrush, rect);
        //            g.FillEllipse(whiteBrush, rect);
        //        }
        //    }
        }
        //==================================Column Button Clicks====================================//
        //   Each of these functions performs the btn_Click function given a column. The function starts
        //   at the top of the array (visually the bottom), checking all the buttons with the set Column
        //   variable, and with rows starting at 5 and decrementing till 0
        //================================================================================================

        

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
                    }
                    else
                    {
                        gameBoard.getCell(r, c).setPlayer(2);
                        gameBoard.getCell(r, c).getButton().BackColor = Color.Yellow;
                        Console.WriteLine("Button Row: " + gameBoard.getCell(r, c).getButton().Name[4]);
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

        private void btn_0_0_Click(object sender, EventArgs e)
        {
            btn_Click(0);
        }

        private void btn_0_1_Click(object sender, EventArgs e)
        {
            btn_Click(1);
        }

        private void btn_0_2_Click(object sender, EventArgs e)
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

    }

}
