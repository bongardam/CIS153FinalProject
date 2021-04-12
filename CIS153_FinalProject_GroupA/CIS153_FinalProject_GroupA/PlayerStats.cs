using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CIS153_FinalProject_GroupA
{
    public class PlayerStats
    {
        int playerOneMoves;
        int playerOneGames;
        int playerOneOutcome;
        int playerTwoMoves;
        int playerTwoGames;
        int playerTwoOutcome;
        int compMoves;
        int compGames;
        int compOutcome;

        public PlayerStats(int pm, int pg, int po, int tm, int tg, int to, int cm, int cg, int co)
        {
            playerOneMoves = pm;
            playerOneGames = pg;
            playerOneOutcome = po;
            playerTwoMoves = tm;
            playerTwoGames = tg;
            playerTwoOutcome = to;
            compMoves = cm;
            compGames = cg;
            compOutcome = co;
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

        public int getCompMoves()
        {
            return compMoves;
        }

        public int getCompGames()
        {
            return compGames;
        }

        public int getCompOutcome()
        {
            return compOutcome;
        }




    }
}
