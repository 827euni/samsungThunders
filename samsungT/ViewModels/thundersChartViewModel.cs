using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;
using samsungT.Models;
using System.Windows.Forms.DataVisualization.Charting;

namespace samsungT.ViewModels
{
    internal class thundersChartViewModel:INotifyPropertyChanged
    {
        private DatabaseHelper db;
        private List<Game> games;
        private List<PlayerStatus> playerStatus;
        private Series thundersChart;

        public event PropertyChangedEventHandler PropertyChanged;

        public thundersChartViewModel(Series series)
        {
            db = new DatabaseHelper();
            thundersChart = series;
            Games = db.GetGames();
            PlayerStatus = db.GetPlayersStatus();
            MakeDefaultScoreChart();
        }

        public List<Game> Games
        {
            get 
            {
                return games;
            }
            set
            {
                games = value;
                OnPropertyChanged();
            }
        }

        public List<PlayerStatus> PlayerStatus
        {
            get
            {
                return playerStatus;
            }
            set
            {
                playerStatus = value;
                OnPropertyChanged();
            }
        }


        public void MakeDefaultScoreChart()
        {
            thundersChart.Points.Clear();
            int score;
            foreach (var game in Games)
            {
                score = game.HomeTeamID == 1 ? game.HomeScore : game.AwayScore;
                thundersChart.Points.AddXY(game.Date, score);
            }
        }

        public void Make3PointChart()
        {
            thundersChart.Points.Clear();
            var playerStatus = PlayerStatus;
            List<Game> games = Games; 
            int[] gameIDs = new int[games.Count];

            for (int i = 0; i < games.Count; i++)
            {
                gameIDs[i] = db.GetSearchGame(games[i].Date).GameID;
            }

            Dictionary<DateTime, (int total3Point, int total3PointA)> dateStatus = new Dictionary<DateTime, (int, int)>();

            foreach (var status in playerStatus)
            {
                for (int i = 0; i < gameIDs.Length; i++)
                {
                    if (status.GameID == gameIDs[i])
                    {
                        if (!dateStatus.ContainsKey(games[i].Date))
                        {
                            dateStatus[games[i].Date] = (0, 0);
                        }

                        dateStatus[games[i].Date] = (
                            dateStatus[games[i].Date].total3Point + status.ThreePoint,
                            dateStatus[games[i].Date].total3PointA + status.ThreePointA
                        );
                    }
                }
            }

            var sortStatus = dateStatus.OrderBy(k => k.Key);

            foreach (var sort in sortStatus)
            {
                var date = sort.Key;
                var (total3Point, total3PointA) = sort.Value;

                if (total3PointA > 0)
                {
                    thundersChart.Points.AddXY(date, (double)total3Point / total3PointA * 100);
                }
            }
        }


        public void MakeFieldGoalChart()
        {
            thundersChart.Points.Clear();
            List<Game> games = Games;
            int[] gameIDs = new int[games.Count];

            for (int i = 0; i < games.Count; i++)
            {
                gameIDs[i] = games[i].GameID;
            }

            Dictionary<DateTime, (int totalField, int totalFieldA)> dateStatus = new Dictionary<DateTime, (int, int)>();

            foreach (var status in PlayerStatus)
            {
                for (int i = 0; i < gameIDs.Length; i++)
                {
                    if (status.GameID == gameIDs[i])
                    {
                        if (!dateStatus.ContainsKey(games[i].Date))
                        {
                            dateStatus[games[i].Date] = (0, 0);
                        }

                        dateStatus[games[i].Date] = (
                            dateStatus[games[i].Date].totalField + status.FieldGoal,
                            dateStatus[games[i].Date].totalFieldA + status.FieldGoalA
                        );
                    }
                }
            }

            foreach (var sort in dateStatus.OrderBy(k => k.Key))
            {
                if (sort.Value.totalFieldA > 0)
                {
                    thundersChart.Points.AddXY(sort.Key, (double)sort.Value.totalField / sort.Value.totalFieldA * 100);
                }
            }
        }


        public void MakeFreeThrowChart()
        {
            thundersChart.Points.Clear();
            List<Game> games = Games;
            int[] gameIDs = new int[games.Count];

            for (int i = 0; i < games.Count; i++)
            {
                gameIDs[i] = games[i].GameID;
            }

            Dictionary<DateTime, (int totalFree, int totalFreeA)> dateStatus = new Dictionary<DateTime, (int, int)>();

            foreach (var status in PlayerStatus)
            {
                for (int i = 0; i < gameIDs.Length; i++)
                {
                    if (status.GameID == gameIDs[i])
                    {
                        if (!dateStatus.ContainsKey(games[i].Date))
                        {
                            dateStatus[games[i].Date] = (0, 0);
                        }

                        dateStatus[games[i].Date] = (
                            dateStatus[games[i].Date].totalFree + status.FreeThrow,
                            dateStatus[games[i].Date].totalFreeA + status.FreeThrowA
                        );
                    }
                }
            }

            foreach (var sort in dateStatus.OrderBy(k => k.Key))
            {
                if (sort.Value.totalFreeA > 0)
                {
                    thundersChart.Points.AddXY(sort.Key, (double)sort.Value.totalFree / sort.Value.totalFreeA * 100);
                }
            }
        }


        public void MakeReboundChart()
        {
            thundersChart.Points.Clear();
            List<Game> games = Games;
            int[] gameIDs = new int[games.Count];

            for (int i = 0; i < games.Count; i++)
            {
                gameIDs[i] = games[i].GameID;
            }

            Dictionary<DateTime, int> dateStatus = new Dictionary<DateTime, int>();

            foreach (var status in PlayerStatus)
            {
                for (int i = 0; i < gameIDs.Length; i++)
                {
                    if (status.GameID == gameIDs[i])
                    {
                        if (!dateStatus.ContainsKey(games[i].Date))
                        {
                            dateStatus[games[i].Date] = 0;
                        }

                        dateStatus[games[i].Date] += status.Rebound;
                    }
                }
            }

            foreach (var sort in dateStatus.OrderBy(k => k.Key))
            {
                thundersChart.Points.AddXY(sort.Key, sort.Value);
            }
        }


        public void MakeAssistChart()
        {
            thundersChart.Points.Clear();
            List<Game> games = Games;
            int[] gameIDs = new int[games.Count];

            for (int i = 0; i < games.Count; i++)
            {
                gameIDs[i] = games[i].GameID;
            }

            Dictionary<DateTime, int> dateStatus = new Dictionary<DateTime, int>();

            foreach (var status in PlayerStatus)
            {
                for (int i = 0; i < gameIDs.Length; i++)
                {
                    if (status.GameID == gameIDs[i])
                    {
                        if (!dateStatus.ContainsKey(games[i].Date))
                        {
                            dateStatus[games[i].Date] = 0;
                        }

                        dateStatus[games[i].Date] += status.Assist;
                    }
                }
            }

            foreach (var sort in dateStatus.OrderBy(k => k.Key))
            {
                thundersChart.Points.AddXY(sort.Key, sort.Value);
            }
        }


        protected void OnPropertyChanged([CallerMemberName] string propertyName = null)
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));
        }
    }
}
