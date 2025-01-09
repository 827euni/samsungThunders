using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace samsungT.DTO
{
    internal class GameDTO
    {
        public int GameID { get; set; }
        public DateTime Date { get; set; }
        public int HomeTeamID { get; set; }
        public int AwayTeamID { get; set; }
        public int HomeScore { get; set; }
        public int AwayScore { get; set; }
    }
}