using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CIS153_FinalProject_GroupA
{
    public class GameOverStats
    {
        int gameWinner;
        int gameMoves;
        int gameSecondPlayer;

        public GameOverStats(int gw, int gm, int gp)
        {
            gameWinner = gw;
            gameMoves = gm;
            gameSecondPlayer = gp;
        }

        public int getGameWinner()
        {
            return gameWinner;
        }

        public int getGameMoves()
        {
            return gameMoves;
        }

        public int getGameSecondPlayer()
        {
            return gameSecondPlayer;
        }


    }
}
