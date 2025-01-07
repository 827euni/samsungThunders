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
        public int FieldGoal { get; set; }
        public int FieldGoalA { get; set; }
        public int Assist { get; set; }
        public int Score { get; set; }

        public decimal Get3PointPercentage()
        {
            return ThreePointsA > 0 ? (decimal)ThreePoints / ThreePointsA * 100 : 0;
        }

        public decimal GetFreeThrowPercentage()
        {
            return FreeThrowA > 0 ? (decimal)FreeThrow / FreeThrowA * 100 : 0;
        }

        public decimal GetFieldGoalPercentage()
        {
            return FieldGoalA > 0 ? (decimal)FieldGoal / FieldGoalA * 100 : 0;
        }
    }
}
