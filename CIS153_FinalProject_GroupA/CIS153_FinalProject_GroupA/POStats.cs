using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CIS153_FinalProject_GroupA
{
    public class POStats
    {
        //int playerOneMoves;        
        static int playerOneOutcome;
        int playerOneTie;
        

        public POStats(int po, int pt)
        {
            //playerOneMoves = pm;
            playerOneOutcome = po;
            playerOneTie = pt;
            if (playerOneOutcome == 2)
            {

            }
        }

        //public int getPlayerOneMoves()
        //{
        //    return playerOneMoves;
        //}     

        public int getPlayerOneOutcome()
        {
            if (playerOneOutcome == 2)
            {
                playerOneOutcome = 0;
                return playerOneOutcome;
            }

            return playerOneOutcome++;
        }

        public int getPlayerOneTie()
        {
            return playerOneTie;
        }
    }
}
