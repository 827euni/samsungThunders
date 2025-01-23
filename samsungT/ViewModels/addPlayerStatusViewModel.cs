using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using samsungT.Models;

namespace samsungT.ViewModels
{
    internal class addPlayerStatusViewModel
    {
        private int gameID;
        private int playerID;
        private int rebound;
        private int threePoint;
        private int threePointA;
        private int freeThrow;
        private int freeThrowA;
        private int fieldGoal;
        private int fieldGoalA;
        private int assist;
        private int score;
        private List<Game> games;
        private List<Player> players;
        private DatabaseHelper db;

        public event PropertyChangedEventHandler PropertyChanged;

        public addPlayerStatusViewModel()
        {
            db = new DatabaseHelper();
            Players = db.GetPlayers();
            Games = db.GetGames();
            OnPropertyChanged(nameof(Games));
        }


        public int GameID
        {
            get { return gameID; }
            set
            {
                gameID = value;
                OnPropertyChanged("GameID");
            }
        }

        public int PlayerID
        {
            get { return playerID; }
            set
            {
                playerID = value;
                OnPropertyChanged("PlayerID");
            }
        }

        public int Rebound
        {
            get { return rebound; }
            set
            {
                rebound = value;
                OnPropertyChanged("Rebound");
            }
        }

        public int ThreePoint
        {
            get { return threePoint; }
            set
            {
                threePoint = value;
                OnPropertyChanged("ThreePoint");
            }
        }

        public int ThreePointA
        {
            get { return threePointA; }
            set
            {
                threePointA = value;
                OnPropertyChanged("ThreePointA");
            }
        }

        public int FreeThrow
        {
            get { return freeThrow; }
            set
            {
                freeThrow = value;
                OnPropertyChanged("FreeThrow");
            }
        }

        public int FreeThrowA
        {
            get { return freeThrowA; }
            set
            {
                freeThrowA = value;
                OnPropertyChanged("FreeThrowA");
            }
        }

        public int FieldGoal
        {
            get { return fieldGoal; }
            set
            {
                fieldGoal = value;
                OnPropertyChanged("FieldGoal");
            }
        }

        public int FieldGoalA
        {
            get { return fieldGoalA; }
            set
            {
                fieldGoalA = value;
                OnPropertyChanged("FieldGoalA");
            }
        }

        public int Assist
        {
            get { return assist; }
            set
            {
                assist = value;
                OnPropertyChanged("Assist");
            }
        }

        public int Score
        {
            get { return score; }
            set
            {
                score = value;
                OnPropertyChanged("Score");
            }
        }

        public List<Game> GameLoad
        {
            get;
            set;
        }

        public List<Player> PlayerLoad
        {
            get;
            set;
        }

        public List<Game> Games
        {
            get { return games; }
            set
            {
                games = value;
                OnPropertyChanged("Games");
            }
        }

        public List<Player> Players
        {
            get { return players; }
            set
            {
                players = value;
                OnPropertyChanged("Players");
            }
        }

        public void RegisterPlayerStatus()
        {
            if (string.IsNullOrEmpty(GameID.ToString()) ||
                string.IsNullOrEmpty(PlayerID.ToString()) ||
                string.IsNullOrWhiteSpace(Score.ToString()) ||
                string.IsNullOrWhiteSpace(ThreePoint.ToString()) ||
                string.IsNullOrWhiteSpace(ThreePointA.ToString()) ||
                string.IsNullOrWhiteSpace(FieldGoal.ToString()) ||
                string.IsNullOrWhiteSpace(FieldGoalA.ToString()) ||
                string.IsNullOrWhiteSpace(FreeThrow.ToString()) ||
                string.IsNullOrWhiteSpace(FreeThrowA.ToString()) ||
                string.IsNullOrWhiteSpace(Rebound.ToString()) ||
                string.IsNullOrWhiteSpace(Assist.ToString()))
            {
                throw new Exception("모든 필드를 입력해주세요.");
            }

            try
            {
                PlayerStatus playerStatus = new PlayerStatus
                {
                    GameID = GameID,
                    PlayerID = PlayerID,
                    Rebound = Rebound,
                    ThreePoint = ThreePoint,
                    ThreePointA = ThreePointA,
                    FreeThrow = FreeThrow,
                    FreeThrowA = FreeThrowA,
                    FieldGoal = FieldGoal,
                    FieldGoalA = FieldGoalA,
                    Assist = Assist,
                    Score = Score
                };

                db.AddPlayerStat(playerStatus);
            }
            catch (Exception ex) 
            {
                throw new Exception($"선수 기록 추가 중 오류가 발생하였습니다: {ex.Message}");
            }

            
        }

        public void OnPropertyChanged([CallerMemberName] string propertyName = null)
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));
        }
    }
}
