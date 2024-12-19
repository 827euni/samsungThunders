using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace samsungT.Models
{
    internal class TeamStatus
    {
        public int TeamStatID { get; set; }
        public int TeamID { get; set; }
        public int GameID { get; set; }
        public int Wins { get; set; }
        public int Losses { get; set; }
        public decimal WinRate { get; set; }
    }
}
