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
        int compOutcome;
        int compTie;

        public int statCompOutcome { get; internal set; }

        public PCStats(int cm, int co, int ct)
        {            
            compMoves = cm;
            compOutcome = co;
            compTie = ct;
        }

        public int getCompMoves()
        {
            return compMoves;
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
