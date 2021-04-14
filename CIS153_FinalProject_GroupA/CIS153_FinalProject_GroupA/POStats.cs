using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CIS153_FinalProject_GroupA
{
    public class POStats
    {
        int playerOneMoves;
        int playerOneGames;
        int playerOneOutcome;
        

        public POStats(int pm, int pg, int po)
        {
            playerOneMoves = pm;
            playerOneGames = pg;
            playerOneOutcome = po;
        }

        public int getPlayerOneMoves()
        {
            return playerOneMoves;
        }

        public int getPlayerOneGames()
        {
            return playerOneGames;
        }

        public int getPlayerOneOutcome()
        {
            return playerOneOutcome;
        }
    }
}
