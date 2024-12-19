using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace samsungT.Models
{
    internal class PlayerStatus
    {
        public int StatID { get; set; }
        public int GameID { get; set; }
        public int PlayerID { get; set; }
        public int Points { get; set; }
        public int Rebounds { get; set; }
        public int Assists { get; set; }
        public int ThreePoints { get; set; }
        public int ThreePointsA { get; set; }
        public int FreeThrow { get; set; }
        public int FreeThrowA { get; set; }
        public int TwoPoints { get; set; }  
        public int TwoPointsA { get; set; }
    }
}
