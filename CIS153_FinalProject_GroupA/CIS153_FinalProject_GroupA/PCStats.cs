using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CIS153_FinalProject_GroupA
{
    class PCStats
    {
        int compMoves;
        int compGames;
        int compOutcome;

        public PCStats(int cm, int cg, int co)
        {            
            compMoves = cm;
            compGames = cg;
            compOutcome = co;
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
