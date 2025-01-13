using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using samsungT.Models;

namespace samsungT.Views
{
    public partial class thundersChart : Form
    {
        private DatabaseHelper db;


        public thundersChart()
        {
            InitializeComponent();
            db = new DatabaseHelper();
            makeDefaultScoreChart();
        }

        private void makeDefaultScoreChart()
        {
            Chart_Thunders.Series[0].Points.Clear();

            List<Game> games = db.GetGames();
            int score;

            foreach (Game game in games)
            {
                score = game.HomeTeamID == 1 ? game.HomeScore : game.AwayScore;
                Chart_Thunders.Series[0].Points.AddXY(game.Date, score);
            }
        }

        private void Button_Score_Click(object sender, EventArgs e)
        {
            makeDefaultScoreChart();
        }

        private void Button_3Point_Click(object sender, EventArgs e)
        {
            Chart_Thunders.Series[0].Points.Clear();
            var playerStatus = db.GetPlayersStatus();
            List<Game> games = db.GetGames();
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

                        dateStatus[games[i].Date] = (dateStatus[games[i].Date].total3Point + status.ThreePoint,
                                                          dateStatus[games[i].Date].total3PointA + status.ThreePointA);
                    }
                }
            }
            var sortStatus = dateStatus.OrderBy(k => k.Key);
            var filteredData = sortStatus.Where(entry => entry.Value.total3PointA > 0);

            foreach (var filter in filteredData)
            {
                var date = filter.Key;
                var (total3Point, total3PointA) = filter.Value;

                if (total3PointA > 0)
                {
                    Chart_Thunders.Series[0].Points.AddXY(date, (double)total3Point/total3PointA * 100);
                }
            }
        }


        private void Button_Field_Click(object sender, EventArgs e)
        {
            Chart_Thunders.Series[0].Points.Clear();
            var playerStatus = db.GetPlayersStatus();
            List<Game> games = db.GetGames();
            int[] gameIDs = new int[games.Count];
            for (int i = 0; i < games.Count; i++)
            {
                gameIDs[i] = db.GetSearchGame(games[i].Date).GameID;
            }
            Dictionary<DateTime, (int totalField, int totalFieldA)> dateStatus = new Dictionary<DateTime, (int, int)>();

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

                        dateStatus[games[i].Date] = (dateStatus[games[i].Date].totalField + status.FieldGoal,
                                                          dateStatus[games[i].Date].totalFieldA + status.FieldGoalA);
                    }
                }
            }
            var sortStatus = dateStatus.OrderBy(k => k.Key);
            var filteredData = sortStatus.Where(entry => entry.Value.totalFieldA > 0);

            foreach (var filter in filteredData)
            {
                var date = filter.Key;
                var (totalField, totalFieldA) = filter.Value;

                if (totalFieldA > 0)
                {
                    Chart_Thunders.Series[0].Points.AddXY(date, (double)totalField / totalFieldA * 100);
                }
            }
        }

        private void Button_Free_Click(object sender, EventArgs e)
        {

        }

        private void Button_Rebound_Click(object sender, EventArgs e)
        {

        }

        private void Button_Assist_Click(object sender, EventArgs e)
        {

        }
    }
}
