using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CIS153_FinalProject_GroupA
{
    public class PTStats
    {
        int playerTwoMoves;
        int playerTwoGames;
        int playerTwoOutcome;

        public PTStats(int tm, int tg, int to)
        {
            playerTwoMoves = tm;
            playerTwoGames = tg;
            playerTwoOutcome = to;
            
        }

        public int getPlayertwoMoves()
        {
            return playerTwoMoves;
        }

        public int getPlayerTwoGames()
        {
            return playerTwoGames;
        }

        public int getPlayerTwoOutcome()
        {
            return playerTwoOutcome;
        }


    }
}
