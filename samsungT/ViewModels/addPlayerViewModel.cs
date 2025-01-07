using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace samsungT.ViewModels
{
    internal class addPlayerViewModel:INotifyPropertyChanged
    {
        private string playerName;
        private string playerId;
        private string playerPosition; // 프로퍼티임으로 구분해야함.
        private string playerHeight;
        private DatabaseHelper db;

        public event PropertyChangedEventHandler PropertyChanged;

        public string PlayerName
        {
            get
            {
                return playerName;
            }
            set
            {
                playerName = value;
                OnPropertyChanged("PlayerName");
            }
        }

        public string PlayerID
        {
            get
            {
                return playerId;
            }
            set
            {
                playerId = value;
                OnPropertyChanged("PlayerID");
            }
        }

        public string PlayerPosition
        {
            get
            {
                return playerPosition;
            }
            set
            {
                playerPosition = value;
                OnPropertyChanged("PlayerPosition"); // 명시적으로 속성 이름 전달
            }
        }

        public string PlayerHeight
        {
            get
            {
                return playerHeight;
            }
            set
            {
                playerHeight = value;
                OnPropertyChanged("PlayerHeight"); // 명시적으로 속성 이름 전달
            }
        }

        public PlayerViewModel()
        {
            db = new DatabaseHelper();
        }

        public void RegisterPlayer()
        {
            if (string.IsNullOrWhiteSpace(PlayerName) ||
                string.IsNullOrWhiteSpace(PlayerID) ||
                string.IsNullOrWhiteSpace(PlayerPosition) ||
                string.IsNullOrWhiteSpace(PlayerHeight))
            {
                throw new Exception("모든 텍스트를 입력해주세요.");
            }

            try
            {
                Player newPlayer = new Player
                {
                    PlayerName = PlayerName,
                    TeamID = 1,
                    PlayerID = int.Parse(PlayerID),
                    Position = PlayerPosition,
                    Height = int.Parse(PlayerHeight),
                };

                db.AddPlayer(newPlayer);
            }
            catch (Exception ex)
            {
                throw new Exception($"선수 추가 중 오류가 발생했습니다: {ex.Message}");
            }
        }

        public void OnPropertyChanged([CallerMemberName] string propertyName = null)
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));
        }
    }
}
}
