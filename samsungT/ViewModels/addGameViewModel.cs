using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;
using samsungT.Models;

namespace samsungT.ViewModels
{
    internal class addGameViewModel
    {
        private DateTime date;
        private int homeTeamID;
        private int awayTeamID;
        private int homeScore;
        private int awayScore;
        private List<Team> teams;
        private DatabaseHelper db;

        public event PropertyChangedEventHandler PropertyChanged;

        public addGameViewModel()
        {
            db = new DatabaseHelper();
        }

        public DateTime Date
        {
            get { return date; }
            set
            {
                date = value;
                OnPropertyChanged("Date");
            }
        }

        public int HomeTeamID
        {
            get { return homeTeamID; }
            set
            {
                homeTeamID = value;
                OnPropertyChanged("HomeTeamID");
            } 
        }

        public int AwayTeamID
        {
            get { return awayTeamID; }
            set
            {
                awayTeamID = value;
                OnPropertyChanged("AwayTeamID");
            }
        }

        public int HomeScore
        {
            get { return homeScore; }
            set
            {
                homeScore = value;
                OnPropertyChanged("HomeScore");
            }
        }

        public int AwayScore
        {
            get { return awayScore; }
            set
            {
                awayScore = value;
                OnPropertyChanged("AwayScore");
            }
        }

        public List<Team> Teams
        {
            get { return teams; }
            set
            {
                teams = value;
                OnPropertyChanged("Teams");
            }
        }

        public void ResisterGame()
        {
            if (string.IsNullOrEmpty(HomeTeamID.ToString())
                || string.IsNullOrWhiteSpace(AwayTeamID.ToString())
                || string.IsNullOrWhiteSpace(HomeScore.ToString()) 
                || string.IsNullOrWhiteSpace(AwayScore.ToString()))
            {
                throw new Exception("모든 필드를 입력해주세요.");
            }

            if (HomeTeamID == AwayTeamID)
            {
                throw new Exception("홈 팀과 원정팀이 같을 수 없습니다.");
            }

            if(HomeScore < 0 || AwayScore < 0)
            {
                throw new Exception("각 점수는 0보다 작을 수 없습니다.");
            }

            try
            {
                Game game = new Game
                {
                    Date = Date,
                    HomeTeamID = HomeTeamID,
                    AwayTeamID = AwayTeamID,
                    HomeScore = HomeScore,
                    AwayScore = AwayScore
                };

                db.AddGame(game);

                if (HomeScore > AwayScore)
                {
                    db.UpdateTeamWin(HomeTeamID, true);
                    db.UpdateTeamWin(AwayTeamID, false);
                }
                else
                {
                    db.UpdateTeamWin(AwayTeamID, true);
                    db.UpdateTeamWin(HomeTeamID, false);
                }

            }
            catch (Exception ex)
            {
                throw new Exception($"경기 추가 중 오류가 발생했습니다: {ex.Message}");
            }

        }
        public void OnPropertyChanged([CallerMemberName] string propertyName = null)
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));
        }
    }
}
