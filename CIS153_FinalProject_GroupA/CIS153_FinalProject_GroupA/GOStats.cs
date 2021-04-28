using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CIS153_FinalProject_GroupA
{
    class GOStats
    {
        int winner;
        int playerOneMoves;
        int playerSecondLabel;
        int playerSecondMoves;
        


        public GOStats(int w, int pm, int sl, int sm)
        {
            winner = w;
            playerOneMoves = pm;
            playerSecondLabel = sl;
            playerSecondMoves = sm;
        }

        public int getWinner()
        {
            return winner;
        }

        public int getPlayerOneMoves()
        {
            return playerOneMoves;
        }
        public int getPlayerSecondLabel()
        {
            return playerSecondLabel;
        }
        public int gePplayerSecondMoves()
        {
            return playerSecondLabel;
        }
    }
}
