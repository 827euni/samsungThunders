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
    internal class addTeamViewModel:INotifyPropertyChanged
    {
        private string teamName;
        private string city;
        private DatabaseHelper db;
        public event PropertyChangedEventHandler PropertyChanged;

        public addTeamViewModel()
        {
            db = new DatabaseHelper();
        }

        public string TeamName
        {
            get 
            {
                return teamName; 
            }
            set 
            { 
                teamName = value;
                OnPropertyChanged("TeamName");
            }
        }

        public string City
        {
            get
            {
                return city;
            }
            set
            {
                city = value;
                OnPropertyChanged("City");
            }
        }

        public void ResisterTeam()
        {
            if (string.IsNullOrWhiteSpace(TeamName) ||
                string.IsNullOrWhiteSpace(City))
            {
                throw new Exception("모든 텍스트를 입력해주세요.");
            }

            try
            {
                Team team = new Team
                {
                    TeamName = TeamName,
                    City = City
                };

                db.AddTeam(team);
            }

            catch (Exception ex)
            {
                throw new Exception($"팀 추가 중 오류가 발생했습니다: {ex.Message}");
            }
        }

        public void OnPropertyChanged([CallerMemberName] string propertyName = null)
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));
        }

    }
}
