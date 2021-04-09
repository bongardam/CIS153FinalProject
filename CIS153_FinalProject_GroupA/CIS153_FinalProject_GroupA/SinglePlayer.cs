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
    public partial class SinglePlayer : Form
    {
        Welcome welcome;
        const int columnCount = 7;
        const int rowCount = 6;
        int[,] board = new int[rowCount, columnCount];
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

        private void SinglePlayer_Paint(object sender, PaintEventArgs e)
        {
            Graphics g = e.Graphics;
            Pen myPen = new Pen(Color.Black);
            Brush blueBrush = new SolidBrush(Color.Blue); // BC: a brush to fill in shapes
            Brush whiteBrush = new SolidBrush(Color.White); // BC: a brush to fill in shapes

            Rectangle topRect = new Rectangle(0, 0, 700, 145);
            g.FillRectangle(whiteBrush, topRect);

            // BC: The size of the shapes are relative to the column and row
            // For example: row 1, column 3 would have the values
            // xPos = 101, yPos = 303
            for (int c = 0; c < columnCount; c++)
            {
                for (int r = 0; r < rowCount; r++)
                {                                  //xPos, yPos, width, height
                    Rectangle rect = new Rectangle(c*101, r*101+151, 90, 90);
                    g.FillRectangle(blueBrush, rect);
                    g.FillEllipse(whiteBrush, rect);
                }
            }
        }
    }
}
