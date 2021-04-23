using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CIS153_FinalProject_GroupA
{
    class Board
    {
        
        private const int numRows = 6;
        private const int numCols = 7;
        Cell[,] gameBoard = new Cell[numRows, numCols];
    
        bool gameOver;

        //bool playerTurn;
        int playerTurn = 0;

        int playerColor;
        int aiColor;

        //getters
        public int getNumRows()
        {
            return numRows;
        }
        public int getNumCols()
        {
            return numCols;
        }



        public Cell getCell(int r, int c)
        {
            return gameBoard[r, c];
        }

        public Cell[,] getGameBoard()
        {
            return gameBoard;
        }


        public void setGameBoardCell(Cell cell)

        {

           
            gameBoard[cell.getRow(), cell.getCol()] = cell;
        }

        public void changeTurn()
        {
            playerTurn++;
            //Console.WriteLine("PlayerTurn: " + playerTurn);
            //Console.WriteLine("PlayerTurn % 2: " + playerTurn % 2);
        }

        public int getTurn()
        {
            return playerTurn % 2;
        }

        //======================== Win Checks ==================================


        //Creates variables out of the cell's Row, Column, and Player
        //Runs first if statement so the horizontal right check will only
        //execute if there are three or more cells to the right of the array
        //
        // checks if the player variable is equal to the cell in the same row
        // and column plus 1, plus 2, and plus 3. Will not execute if a cell's
        // player is set to 0

        public void horizontalRightCheck()
        {
            foreach(Cell Cell in gameBoard)
            {
                int r = Cell.getRow();
                int c = Cell.getCol();
                int p = Cell.getPlayer();

                if( c <= numCols - 4)
                {
                    if( 
                        p == gameBoard[r, c+ 1].getPlayer() &&
                        gameBoard[r, c + 1].getPlayer() == gameBoard[r, c + 2].getPlayer() &&
                        gameBoard[r, c + 2].getPlayer() == gameBoard[r, c + 3].getPlayer() &&
                        p != 0
                        )
                         
                    {
                        MessageBox.Show("Player " + p + "Wins!");
                        Console.WriteLine("Player : " + p + " Wins!");
                    }
                }

            }
        }

        //Same logic as horizontal right check, but only executes if there are three or more cells to the left
        //and subtracts numbers from the column variable in the nested if statement
        public void horizontalLeftCheck()
        {
            foreach (Cell Cell in gameBoard)
            {
                int r = Cell.getRow();
                int c = Cell.getCol();
                int p = Cell.getPlayer();

                if (c >= numCols - 4)
                {
                    if (
                        p == gameBoard[r, c - 1].getPlayer() &&
                        gameBoard[r, c - 1].getPlayer() == gameBoard[r, c - 2].getPlayer() &&
                        gameBoard[r, c - 2].getPlayer() == gameBoard[r, c - 3].getPlayer() &&
                        p != 0
                        )

                    {
                        Console.WriteLine("Player : " + p + " Wins!");
                    }
                }

            }
        }

        //same logic as horizontal check, but addition and subtraction are done to r rather than c
        public void verticalUpperCheck()
        {
            foreach (Cell Cell in gameBoard)
            {
                int r = Cell.getRow();
                int c = Cell.getCol();
                int p = Cell.getPlayer();

                if (r <= numRows - 4)
                {
                    if (
                        p == gameBoard[r + 1, c].getPlayer() &&
                        gameBoard[r + 1, c].getPlayer() == gameBoard[r + 2, c].getPlayer() &&
                        gameBoard[r + 2, c].getPlayer() == gameBoard[r + 3, c].getPlayer() &&
                        p != 0
                        )
                    {
                        MessageBox.Show("Player " + p + "Wins!");
                        Console.WriteLine("Player : " + p + " Wins!");
                    }
                }

            }

        }

        public void verticalLowerCheck()
        {
            foreach (Cell Cell in gameBoard)
            {
                int r = Cell.getRow();
                int c = Cell.getCol();
                int p = Cell.getPlayer();

                if (r >= numRows - 3)
                {
                    if (
                        p == gameBoard[r - 1, c].getPlayer() &&
                        gameBoard[r - 1, c].getPlayer() == gameBoard[r - 2, c].getPlayer() &&
                        gameBoard[r - 2, c].getPlayer() == gameBoard[r - 3, c].getPlayer() &&
                        p != 0
                        )
                    {
                        MessageBox.Show("Player " + p + "Wins!");
                        Console.WriteLine("Player : " + p + " Wins!");
                    }
                }

            }

        }

        //same logic as previous, but uses an parent if statement with controls for the limit of r and c
        //and the nested if statement uses a combination of addition and subtraction to get the diagonal behavior
        public void diagonalUpperRightCheck()
        {
            foreach (Cell Cell in gameBoard)
            {
                int r = Cell.getRow();
                int c = Cell.getCol();
                int p = Cell.getPlayer();

                if (r >= numRows - 3 && c <= numCols - 4 )
                {
                    if (
                        p == gameBoard[r - 1 , c + 1].getPlayer() &&
                        gameBoard[r - 1, c + 1].getPlayer() == gameBoard[r - 2 , c + 2].getPlayer() &&
                        gameBoard[r - 2, c + 2].getPlayer() == gameBoard[r - 3, c + 3].getPlayer() &&
                        p != 0
                        )
                    {
                        MessageBox.Show("Player " + p + "Wins!");
                        Console.WriteLine("Player : " + p + " Wins!");
                    }
                      


                }

            }
        }

        public void diagonalLowerRightCheck()
        {
            foreach (Cell Cell in gameBoard)
            {
                int r = Cell.getRow();
                int c = Cell.getCol();
                int p = Cell.getPlayer();

                if (r <= numRows - 4 && c <= numCols - 4)
                {
                    if (
                        p == gameBoard[r + 1, c + 1].getPlayer() &&
                        gameBoard[r + 1, c + 1].getPlayer() == gameBoard[r + 2, c + 2].getPlayer() &&
                        gameBoard[r + 2, c + 2].getPlayer() == gameBoard[r + 3, c + 3].getPlayer() &&
                        p != 0
                        )
                    {
                        MessageBox.Show("Player " + p + "Wins!");
                        Console.WriteLine("Player : " + p + " Wins!");
                    }

                }

            }
        }




    }
}

