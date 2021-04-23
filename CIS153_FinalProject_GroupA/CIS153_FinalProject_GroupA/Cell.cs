using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CIS153_FinalProject_GroupA
{
    class Cell
    {
        int row;
        int col;
        Button btn;
        int player;

        //Default Constructor
        public Cell()
        {
        }

        //Overloaded consturctor might be nice


        //this constructor should only be used in the setUpGame function
        //it sets player value in cell to 0
        public Cell(int r, int c, Button button)
        {
            row = r;
            col = c;
            btn = button;
            player = 0;

        }


        public Cell(int r, int c, Button button, int p)
        {
            row = r;
            col = c;
            btn = button;
            player = p;
        }



        //getters
        public int getRow()
        {
            return row;
        }



        public int getCol()
        {
            return col;
        }



        public Button getButton()
        {
            return btn;
        }



        public int getPlayer()
        {
            return player;
        }

        //setters

        public void setRow(int r)
        {
            row = r;
        }

        public void setCol(int c)
        {
            col = c;
        }


        public void setBtn(Button b)
        {
            btn = b;
        }

        public void setPlayer(int p)
        {
            player = p;
        }

        public void setBtnColor(Button b)
        {

        }





        public void setPlayer(bool p)
        {
            //if the bool variable sent to this function is true, it sets the player to 1
            //else sets it to 2
            if (p)
            {
                player = 1;
            }
            else
            {
                player = 2;
            }
        }



    }
}

