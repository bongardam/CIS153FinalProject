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

        //Function checking to place a piece adjacent to another one
        public void compSingleCheck()
        {
            //if it's not player 1's turn
            if (getTurn() != 0)
            {

                bool compTurn = true;

                foreach (Cell Cell in gameBoard)
                {
                    //get the row, column, and player for each cell
                    int r = Cell.getRow();
                    int c = Cell.getCol();
                    int p = Cell.getPlayer();

                    // if it's the computer's turn, and a cell is claimed by player 1
                    if (compTurn == true && p == 1)
                    {

                        //check right
                        try
                        {
                            //if the cell in the same row, and column plus one is not taken
                            if (gameBoard[r, c + 1].getPlayer() == 0)
                            {
                                bool looking = true;

                                int col = gameBoard[r, c + 1].getCol();

                                for (int row = numRows - 1; row >= gameBoard[r, c + 1].getRow(); row--)
                                {
                                    if (gameBoard[row, c + 1].getPlayer() == 0 && looking == true)
                                    {
                                        gameBoard[row, c + 1].setPlayer(2);
                                        Console.WriteLine("Placed By Comp Single Check Right");
                                        //changes turn on victory
                                        changeTurn();
                                        looking = false;
                                    }
                                }


                                compTurn = false;
                                Console.WriteLine("Success!");


                            }
                        }

                        catch
                        {
                            Console.WriteLine("Referenced cell does not exist");

                        }

                        //check left
                        try
                        {
                            if (gameBoard[r, c - 1].getPlayer() == 0 && compTurn == true)
                            {
                                bool looking = true;

                                int col = gameBoard[r, c - 1].getCol();

                                for (int row = numRows - 1; row >= gameBoard[r, c - 1].getRow(); row--)
                                {
                                    if (gameBoard[row, c - 1].getPlayer() == 0 && looking == true)
                                    {
                                        gameBoard[row, c - 1].setPlayer(2);
                                        Console.WriteLine("Placed by Comp Single Check Left");
                                        looking = false;
                                        changeTurn();
                                    }
                                }


                                compTurn = false;
                                Console.WriteLine("Success");

                            }
                        }

                        catch
                        {
                            Console.WriteLine("Referenced cell does not exist");

                        }

                        //check up
                        try
                        {
                            if (gameBoard[r + 1, c].getPlayer() == 0 && compTurn == true)
                            {
                                gameBoard[r + 1, c].setPlayer(2);
                                Console.WriteLine("Set By Comp Single Check Up");
                                compTurn = false;
                                changeTurn();
                                Console.WriteLine("Success!");

                            }
                        }

                        catch
                        {
                            Console.WriteLine("Referenced cell does not exist");

                        }

                    }

                    if (compTurn == true)
                    {

                    }


                }

            }

        }

        public void compDoubleCheck()
        {
            if (getTurn() != 0)
            {
                bool compTurn = true;

                foreach (Cell Cell in gameBoard)
                {
                    int r = Cell.getRow();
                    int c = Cell.getCol();
                    int p = Cell.getPlayer();

                    //if it's the computer's turn and it's player 1
                    if (compTurn == true && p == 1)
                    {
                        //check right
                        try
                        {
                            if (gameBoard[r, c + 1].getPlayer() == 1)
                            {
                                bool looking = true;

                                int col = gameBoard[r, c + 2].getCol();

                                for (int row = numRows - 1; row >= gameBoard[r, c + 2].getRow(); row--)
                                {
                                    if (gameBoard[row, c + 2].getPlayer() == 0 && looking == true)
                                    {
                                        
                                        gameBoard[row, c + 2].setPlayer(2);
                                        changeTurn();
                                        looking = false;
                                    }
                                }


                                compTurn = false;
                                Console.WriteLine("Success!");


                            }
                        }

                        catch
                        {
                            Console.WriteLine("Referenced cell does not exist");

                        }

                        //check left
                        try
                        {
                            if (gameBoard[r, c - 1].getPlayer() == 1 && compTurn == true)
                            {
                                bool looking = true;

                                int col = gameBoard[r, c - 2].getCol();

                                for (int row = numRows - 1; row >= gameBoard[r, c - 2].getRow(); row--)
                                {
                                    if (gameBoard[row, c - 2].getPlayer() == 0 && looking == true)
                                    {
                                        gameBoard[row, c - 2].setPlayer(2);
                                        changeTurn();
                                        looking = false;
                                    }
                                }


                                compTurn = false;
                                Console.WriteLine("Success");

                            }
                        }

                        catch
                        {
                            Console.WriteLine("Referenced cell does not exist");

                        }

                        try
                        {
                            if (
                                gameBoard[r + 1, c].getPlayer() == 1 &&
                                gameBoard[r + 2, c].getPlayer() == 0 && 
                                compTurn == true)
                            {
                                gameBoard[r + 2, c].setPlayer(2);
                                compTurn = false;
                                changeTurn();
                                Console.WriteLine("Success!");

                            }
                        }

                        catch
                        {
                            Console.WriteLine("Referenced cell does not exist");

                        }

                    }

                    if (compTurn == true)
                    {

                    }

                }

            }

        }

        public void finalCompCheckAgainstPlayer()
        {
            
            if(getTurn() != 0)
            {
                bool compTurn = true;
            

              
                foreach (Cell Cell in gameBoard)
              {
                int r = Cell.getRow();
                int c = Cell.getCol();
                int p = Cell.getPlayer();

                    //check Horizontal Right  
                    try
                    {
                        if (compTurn == true &&
                    p == gameBoard[r, c + 1].getPlayer() &&
                    gameBoard[r, c + 1].getPlayer() == gameBoard[r, c + 2].getPlayer() &&
                    gameBoard[r, c + 3].getPlayer() == 0 &&
                    gameBoard[r - 1, c + 3].getPlayer() != 0 &&
                    p == 1
                    )

                        {
                            gameBoard[r, c + 3].setPlayer(2);
                            Console.WriteLine("Placed By Final Check Against Player Horizontal Right");
                            compTurn = false;
                            changeTurn();
                        }
                    }
                    
                    catch
                    {
                        Console.WriteLine("Referenced Cell Does Not Exist");
                    }

                    //check horizontal left
                    try
                    {
                        if (compTurn == true &&
                    p == gameBoard[r, c - 1].getPlayer() &&
                    gameBoard[r, c - 1].getPlayer() == gameBoard[r, c - 2].getPlayer() &&
                    gameBoard[r, c - 3].getPlayer() == 0 &&
                    gameBoard[r - 1, c - 3].getPlayer() != 0 &&
                    p == 1
                    )

                        {
                            gameBoard[r, c - 3].setPlayer(2);
                            Console.WriteLine("Placed By Final Check Against Player Horizontal Left");
                            compTurn = false;
                            changeTurn();
                        }
                    }

                    catch
                    {
                        Console.WriteLine("Referenced Cell Does Not Exist");
                    }


                }

             }

        }

        public void compTripleCheckFightPlayer()
        {


            if (getTurn() != 0)
            {
                bool compTurn = true;

                foreach (Cell Cell in gameBoard)
                {
                    int r = Cell.getRow();
                    int c = Cell.getCol();
                    int p = Cell.getPlayer();

                    //if it's the computer's turn and it's player 1
                    if (compTurn == true && p == 1)
                    {
                        //check right
                        try
                        {
                            if (
                                gameBoard[r, c + 1].getPlayer() == 1 &&
                                gameBoard[r, c + 1].getPlayer() == gameBoard[r, c + 2].getPlayer()
                                )

                            {
                                bool looking = true;

                                int col = gameBoard[r, c + 3].getCol();

                                for (int row = numRows - 1; row >= gameBoard[r, c + 3].getRow(); row--)
                                {
                                    if (gameBoard[row, c + 3].getPlayer() == 0 && looking == true)
                                    {

                                        gameBoard[row, c + 3].setPlayer(2);
                                        changeTurn();
                                        looking = false;
                                    }
                                }


                                compTurn = false;
                                Console.WriteLine("Success!");


                            }
                        }

                        catch
                        {
                            Console.WriteLine("Referenced cell does not exist");

                        }

                        //check left
                        try
                        {
                            if (
                                gameBoard[r, c - 1].getPlayer() == 1 &&
                                gameBoard[r, c - 1].getPlayer() == gameBoard[r, c - 2].getPlayer() && 
                                compTurn == true
                                )
                            {
                                bool looking = true;

                                int col = gameBoard[r, c - 3].getCol();

                                for (int row = numRows - 1; row >= gameBoard[r, c - 3].getRow(); row--)
                                {
                                    if (gameBoard[row, c - 3].getPlayer() == 0 && looking == true)
                                    {
                                        gameBoard[row, c - 3].setPlayer(2);
                                        changeTurn();
                                        looking = false;
                                    }
                                }


                                compTurn = false;
                                Console.WriteLine("Success");

                            }
                        }

                        catch
                        {
                            Console.WriteLine("Referenced cell does not exist");

                        }

                        //check up
                        try
                        {
                            if (
                                gameBoard[r + 1, c].getPlayer() == 1 &&
                                gameBoard[r + 1, c].getPlayer() ==  gameBoard[r + 2, c].getPlayer()  &&
                                gameBoard[r + 3, c].getPlayer() == 0 &&
                                compTurn == true)
                            {
                                gameBoard[r + 3, c].setPlayer(2);
                                compTurn = false;
                                changeTurn();
                                Console.WriteLine("Success!");

                            }
                        }

                        catch
                        {
                            Console.WriteLine("Referenced cell does not exist");

                        }

                    }

                    if (compTurn == true)
                    {

                    }

                }

            }

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
                        //lowercase call of Cell because of uppercase used earlier
                        foreach (Cell cell in gameBoard)
                        {
                            Button b = cell.getButton();
                            b.Enabled = false;
                        }
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
                        //lowercase call of Cell because of uppercase used earlier
                        foreach(Cell cell in gameBoard)
                        {
                            Button b = cell.getButton();
                            b.Enabled = false;
                        }

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
                        //lowercase call of Cell because of uppercase used earlier
                        foreach (Cell cell in gameBoard)
                        {
                            Button b = cell.getButton();
                            b.Enabled = false;
                        }
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
                        //lowercase call of Cell because of uppercase used earlier
                        foreach (Cell cell in gameBoard)
                        {
                            Button b = cell.getButton();
                            b.Enabled = false;
                        }
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
                        //lowercase call of Cell because of uppercase used earlier
                        foreach (Cell cell in gameBoard)
                        {
                            Button b = cell.getButton();
                            b.Enabled = false;
                        }
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
                        //lowercase call of Cell because of uppercase used earlier
                        foreach (Cell cell in gameBoard)
                        {
                            Button b = cell.getButton();
                            b.Enabled = false;
                        }
                        MessageBox.Show("Player " + p + "Wins!");
                        Console.WriteLine("Player : " + p + " Wins!");
                    }

                }

            }
        }




    }
}

