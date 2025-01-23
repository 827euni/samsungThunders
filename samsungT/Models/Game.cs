using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace samsungT.Models
{
    internal class Game
    {
        public int GameID { get; set; }
        public DateTime Date { get; set; }
        public int HomeTeamID { get; set; }
        public int AwayTeamID { get; set; }
        public int HomeScore { get; set; }
        public int AwayScore { get; set; }

        public static explicit operator Game(List<object> v)
        {
            throw new NotImplementedException();
        }

        public string DisplayText
        {
            get
            {
                var db = new DatabaseHelper();
                string teamName = db.GetTeamName(HomeTeamID) != "삼성 썬더스" ? db.GetTeamName(HomeTeamID) : db.GetTeamName(AwayTeamID);
                return $"{Date:yyyy년 M월 d일} {teamName}전";
            }
        }
    }
}
