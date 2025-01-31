using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using samsungT.Models;
using System.Windows.Forms.DataVisualization.Charting;
using System.Runtime.CompilerServices;

namespace samsungT.ViewModels
{
    internal class playerChartViewModel:INotifyPropertyChanged
    {
        private readonly DatabaseHelper db;
        private List<Game> games;
        private int playerID;
        private string playerName;
        private Series playerChart;

        public event PropertyChangedEventHandler PropertyChanged;

        public playerChartViewModel(int playerID, string playerName, Series series)
        {
            db = new DatabaseHelper();
            playerChart = series;
            PlayerID = playerID;
            PlayerName = playerName;
            Games = db.GetGames();
            MakeScoreChart();
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

        public int PlayerID
        {
            get
            {
                return playerID;
            }
            set
            {
                playerID = value;
                OnPropertyChanged();
            }
        }

        public string PlayerName
        {
            get
            {
                return playerName;
            }
            set
            {
                playerName = value;
                OnPropertyChanged();
            }
        }

        //점수를 사용하여 그래프를 그리고 해당 그래프로 변경
        public void MakeScoreChart()
        {
            playerChart.Points.Clear();
            int score;
            foreach (Game game in Games)
            {
                if (db.GetGamePlayer(game.GameID, PlayerID) != null)
                {
                    score = db.GetGamePlayer(game.GameID, PlayerID).Score;
                    playerChart.Points.AddXY(game.Date, score);
                }
            }
        }

        //3점슛 확률을 사용하여 그래프를 그리고 해당 그래프로 변경
        public void Make3PointChart()
        {
            playerChart.Points.Clear();
            int ThreePoint;
            int ThreePointA;
            foreach (Game game in Games)
            {

                if (db.GetGamePlayer(game.GameID, PlayerID) != null)
                {
                    ThreePoint = db.GetGamePlayer(game.GameID, PlayerID).ThreePoint;
                    ThreePointA = db.GetGamePlayer(game.GameID, PlayerID).ThreePointA;

                    if (ThreePointA > 0)
                    {
                        playerChart.Points.AddXY(game.Date, (double)ThreePoint / ThreePointA * 100);
                    }
                }
            }
        }


        //야투 확률을 사용하여 그래프를 그리고 해당 그래프로 변경
        public void MakeFieldGoalChart()
        {
            playerChart.Points.Clear();
            int Field;
            int FieldA;
            foreach (Game game in Games)
            {

                if (db.GetGamePlayer(game.GameID, PlayerID) != null)
                {
                    Field = db.GetGamePlayer(game.GameID, PlayerID).FieldGoal;
                    FieldA = db.GetGamePlayer(game.GameID, PlayerID).FieldGoalA;

                    if (FieldA > 0)
                    {
                        playerChart.Points.AddXY(game.Date, (double)Field / FieldA * 100);
                    }
                }
            }
        }

        //자유투 확률을 사용하여 그래프를 그리고 해당 그래프로 변경
        public void MakeFreeThrowChart()
        {
            playerChart.Points.Clear();
            int Free;
            int FreeA;
            foreach (Game game in Games)
            {
                if (db.GetGamePlayer(game.GameID, PlayerID) != null)
                {
                    Free = db.GetGamePlayer(game.GameID, PlayerID).FreeThrow;
                    FreeA = db.GetGamePlayer(game.GameID, PlayerID).FreeThrowA;

                    if (FreeA > 0)
                    {
                        playerChart.Points.AddXY(game.Date, (double)Free / FreeA * 100);
                    }

                }
            }
        }

        //리바운드를 사용하여 그래프를 그리고 해당 그래프로 변경
        public void MakeReboundChart()
        {
            playerChart.Points.Clear();
            int rebound;
            foreach (Game game in Games)
            {
                if (db.GetGamePlayer(game.GameID, PlayerID) != null)
                {
                    rebound = db.GetGamePlayer(game.GameID, PlayerID).Rebound;
                    playerChart.Points.AddXY(game.Date, rebound);
                }
                
            }
        }

        //어시스트를 사용하여 그래프를 그리고 해당 그래프로 변경
        public void MakeAssistChart()
        {
            playerChart.Points.Clear();
            int assist;
            foreach (Game game in Games)
            {
                if (db.GetGamePlayer(game.GameID, PlayerID) != null)
                {
                    assist = db.GetGamePlayer(game.GameID, PlayerID).Assist;
                    playerChart.Points.AddXY(game.Date, assist);
                }
            }
        }


        //뷰모델 변경시 뷰에 알림
        protected void OnPropertyChanged([CallerMemberName] string propertyName = null)
        {
            if (PropertyChanged != null)
            {
                PropertyChanged(this, new PropertyChangedEventArgs(propertyName));
            }
        }
    }
}
