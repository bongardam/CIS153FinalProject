using System;
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
    public partial class TwoPlayer : Form
    {
        private Welcome welcome;
        const int columnCount = 7;
        const int rowCount = 6;
        int[,] board = new int[rowCount, columnCount]; // BC: inits our board which we will store the user's moves in 
        public TwoPlayer()
        {
            InitializeComponent();
            CenterToScreen();
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
        }

        public void passedForm(Welcome wel)
        {
            welcome = wel;
        }

        private void TwoPlayer_FormClosed(object sender, FormClosedEventArgs e)
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

        private void TwoPlayer_Paint(object sender, PaintEventArgs e)
        {
            Graphics g = e.Graphics;
            Brush blueBrush = new SolidBrush(Color.Blue); // BC: just a brush
            Brush whiteBrush = new SolidBrush(Color.White); // BC: another brush

            //Rectangle topRect = new Rectangle(0, 0, 800, 145); // BC: placeholder rectangle I will
            //g.FillRectangle(whiteBrush, topRect);              //     finish up next week

            // BC: The size of the shapes are relative to the column and row
            // For example: row 1, column 3 would have
            // xPos = 101, yPos = 303
            for (int c = 0; c < columnCount; c++)
            {
                for (int r = 0; r < rowCount; r++)
                {                                // xPos, yPos, width, height
                    Rectangle rect = new Rectangle(c*101+15, r*101+151, 90, 90);
                    g.FillRectangle(blueBrush, rect);
                    g.FillEllipse(whiteBrush, rect);
                }
            }
        }
    }
}
