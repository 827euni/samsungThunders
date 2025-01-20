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
        public void OnPropertyChanged([CallerMemberName] string propertyName = null)
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));
        }
    }
}
