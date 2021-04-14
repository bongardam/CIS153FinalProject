using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CIS153_FinalProject_GroupA
{
    public class PCStats
    {
        int compMoves;
        int compGames;
        int compOutcome;
        int compTie;

        public PCStats(int cm, int cg, int co, int ct)
        {            
            compMoves = cm;
            compGames = cg;
            compOutcome = co;
            compTie = ct;
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
        public int getPlayerCompTie()
        {
            return compTie;
        }

    }
}
