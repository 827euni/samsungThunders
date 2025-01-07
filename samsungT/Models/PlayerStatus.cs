namespace samsungT.Models
{
    internal class PlayerStatus
    {
        public int StatID { get; set; }
        public int GameID { get; set; }
        public int PlayerID { get; set; }
        public int Rebound { get; set; }
        public int ThreePoint { get; set; }
        public int ThreePointA { get; set; }
        public int FreeThrow { get; set; }
        public int FreeThrowA { get; set; }
        public int FieldGoal { get; set; }
        public int FieldGoalA { get; set; }
        public int Assist { get; set; }
        public int Score { get; set; }

        public decimal Get3PointPercentage()
        {
            return ThreePointA > 0 ? (decimal)ThreePoint / ThreePointA * 100 : 0;
        }

        public decimal GetFreeThrowPercentage()
        {
            return FreeThrowA > 0 ? (decimal)FreeThrow / FreeThrowA * 100 : 0;
        }

        public decimal GetFieldGoalPercentage()
        {
            return FieldGoalA > 0 ? (decimal)FieldGoal / FieldGoalA * 100 : 0;
        }

        public int GameCount { get; set; }
    }
}
