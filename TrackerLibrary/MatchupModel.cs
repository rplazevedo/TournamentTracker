using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TrackerLibrary
{
    public class MatchupModel
    {
        public List<MatchuppEntryModel> Entries { get; set; } = new List<MatchuppEntryModel> ();
        public TeamModel Winner { get; set; }
        public int MatchupRound { get; set; }
    }
}
