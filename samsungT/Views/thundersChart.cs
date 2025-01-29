using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using samsungT.Models;
using samsungT.ViewModels;

namespace samsungT.Views
{
    public partial class thundersChart : Form
    {
        private DatabaseHelper db;
        private thundersChartViewModel viewModel;


        public thundersChart()
        {
            InitializeComponent();
            viewModel = new thundersChartViewModel(Chart_Thunders.Series[0]);
            db = new DatabaseHelper();
        }
        private void Button_Score_Click(object sender, EventArgs e)
        {
            viewModel.MakeDefaultScoreChart();
        }

        private void Button_3Point_Click(object sender, EventArgs e)
        {
            viewModel.Make3PointChart();
        }

        private void Button_Field_Click(object sender, EventArgs e)
        {
            viewModel.MakeFieldGoalChart();
        }

        private void Button_Free_Click(object sender, EventArgs e)
        {
            viewModel.MakeFreeThrowChart();
        }

        private void Button_Rebound_Click(object sender, EventArgs e)
        {
            viewModel.MakeReboundChart();
        }

        private void Button_Assist_Click(object sender, EventArgs e)
        {
            viewModel.MakeAssistChart();
        }
        //private void makeDefaultScoreChart()
        //{
        //    Chart_Thunders.Series[0].Points.Clear();

        //    List<Game> games = db.GetGames();
        //    int score;


        //    foreach (var game in games)
        //    {
        //        score = game.HomeTeamID == 1 ? game.HomeScore : game.AwayScore;
        //        Chart_Thunders.Series[0].Points.AddXY(game.Date, score);
        //    }

        //}

        //private void Button_Score_Click(object sender, EventArgs e)
        //{
        //   viewModel.MakeDefaultScoreChart();
        //}

        //private void Button_3Point_Click(object sender, EventArgs e)
        //{
        //    Chart_Thunders.Series[0].Points.Clear();
        //    var playerStatus = db.GetPlayersStatus();
        //    List<Game> games = db.GetGames();
        //    int[] gameIDs = new int[games.Count];
        //    for (int i = 0; i < games.Count; i++)
        //    {
        //        gameIDs[i] = db.GetSearchGame(games[i].Date).GameID;
        //    }
        //    Dictionary<DateTime, (int total3Point, int total3PointA)> dateStatus = new Dictionary<DateTime, (int, int)>();

        //    foreach (var status in playerStatus)
        //    {
        //        for (int i = 0; i < gameIDs.Length; i++)
        //        {
        //            if (status.GameID == gameIDs[i])
        //            {
        //                if (!dateStatus.ContainsKey(games[i].Date))
        //                {
        //                    dateStatus[games[i].Date] = (0, 0);
        //                }

        //                dateStatus[games[i].Date] = (dateStatus[games[i].Date].total3Point + status.ThreePoint,
        //                                                  dateStatus[games[i].Date].total3PointA + status.ThreePointA);
        //            }
        //        }
        //    }
        //    var sortStatus = dateStatus.OrderBy(k => k.Key);

        //    foreach (var sort in sortStatus)
        //    {
        //        var date = sort.Key;
        //        var (total3Point, total3PointA) = sort.Value;

        //        if (total3PointA > 0)
        //        {
        //            Chart_Thunders.Series[0].Points.AddXY(date, (double)total3Point/total3PointA * 100);
        //        }
        //    }
        //}


        //private void Button_Field_Click(object sender, EventArgs e)
        //{
        //    Chart_Thunders.Series[0].Points.Clear();
        //    var playerStatus = db.GetPlayersStatus();
        //    List<Game> games = db.GetGames();
        //    int[] gameIDs = new int[games.Count];
        //    for (int i = 0; i < games.Count; i++)
        //    {
        //        gameIDs[i] = db.GetSearchGame(games[i].Date).GameID;
        //    }
        //    Dictionary<DateTime, (int totalField, int totalFieldA)> dateStatus = new Dictionary<DateTime, (int, int)>();

        //    foreach (var status in playerStatus)
        //    {
        //        for (int i = 0; i < gameIDs.Length; i++)
        //        {
        //            if (status.GameID == gameIDs[i])
        //            {
        //                if (!dateStatus.ContainsKey(games[i].Date))
        //                {
        //                    dateStatus[games[i].Date] = (0, 0);
        //                }

        //                dateStatus[games[i].Date] = (dateStatus[games[i].Date].totalField + status.FieldGoal,
        //                                                  dateStatus[games[i].Date].totalFieldA + status.FieldGoalA);
        //            }
        //        }
        //    }
        //    var sortStatus = dateStatus.OrderBy(k => k.Key);

        //    foreach (var sort in sortStatus)
        //    {
        //        var date = sort.Key;
        //        var (totalField, totalFieldA) = sort.Value;

        //        if (totalFieldA > 0)
        //        {
        //            Chart_Thunders.Series[0].Points.AddXY(date, (double)totalField / totalFieldA * 100);
        //        }
        //    }
        //}

        //private void Button_Free_Click(object sender, EventArgs e)
        //{
        //    Chart_Thunders.Series[0].Points.Clear();
        //    var playerStatus = db.GetPlayersStatus();
        //    List<Game> games = db.GetGames();
        //    int[] gameIDs = new int[games.Count];
        //    for (int i = 0; i<games.Count; i++)
        //    {
        //        gameIDs[i] = db.GetSearchGame(games[i].Date).GameID;
        //    }

        //    Dictionary<DateTime, (int totalFree, int totalFreeA)> dateStatus = new Dictionary<DateTime, (int, int)>();

        //    foreach (var status in playerStatus)
        //    {
        //        for (int i = 0; i < gameIDs.Length; i++)
        //        {
        //            if (status.GameID == gameIDs[i])
        //            {
        //                if (!dateStatus.ContainsKey(games[i].Date))
        //                {
        //                    dateStatus[games[i].Date] = (0, 0);
        //                }

        //                dateStatus[games[i].Date] = (dateStatus[games[i].Date].totalFree + status.FreeThrow,
        //                                                  dateStatus[games[i].Date].totalFreeA + status.FreeThrowA);
        //            }
        //        }
        //    }
        //    var sortStatus = dateStatus.OrderBy(k => k.Key);

        //    foreach (var sort in sortStatus)
        //    {
        //        var date = sort.Key;
        //        var (totalFree, totalFreeA) = sort.Value;

        //        if (totalFreeA > 0)
        //        {
        //            Chart_Thunders.Series[0].Points.AddXY(date, (double)totalFree / totalFreeA * 100);
        //        }
        //    }
        //}

        //private void Button_Rebound_Click(object sender, EventArgs e)
        //{
        //    Chart_Thunders.Series[0].Points.Clear();
        //    var playerStatus = db.GetPlayersStatus();
        //    List<Game> games = db.GetGames();
        //    int[] gameIDs = new int[games.Count];
        //    for (int i = 0; i < games.Count; i++)
        //    {
        //        gameIDs[i] = db.GetSearchGame(games[i].Date).GameID;
        //    }

        //    Dictionary<DateTime, int> dateStatus = new Dictionary<DateTime, int>();


        //    foreach (var status in playerStatus)
        //    {
        //        for (int i = 0; i < gameIDs.Length; i++)
        //        {
        //            if (status.GameID == gameIDs[i])
        //            {
        //                if (!dateStatus.ContainsKey(games[i].Date))
        //                {
        //                    dateStatus[games[i].Date] = 0;
        //                }
        //                dateStatus[games[i].Date] += status.Rebound;
        //            }
        //        }
        //    }

        //    var sortStatus = dateStatus.OrderBy(k => k.Key);

        //    foreach (var sort in sortStatus)
        //    {
        //        var date = sort.Key;
        //        var rebounds = sort.Value;

        //        if (rebounds > 0)
        //        {
        //            Chart_Thunders.Series[0].Points.AddXY(date, rebounds);
        //        }
        //    }
        //}

        //private void Button_Assist_Click(object sender, EventArgs e)
        //{
        //    Chart_Thunders.Series[0].Points.Clear();
        //    var playerStatus = db.GetPlayersStatus();
        //    List<Game> games = db.GetGames();
        //    int[] gameIDs = new int[games.Count];
        //    for (int i = 0; i < games.Count; i++)
        //    {
        //        gameIDs[i] = db.GetSearchGame(games[i].Date).GameID;
        //    }

        //    Dictionary<DateTime, int> dateStatus = new Dictionary<DateTime, int>();


        //    foreach (var status in playerStatus)
        //    {
        //        for (int i = 0; i < gameIDs.Length; i++)
        //        {
        //            if (status.GameID == gameIDs[i])
        //            {
        //                if (!dateStatus.ContainsKey(games[i].Date))
        //                {
        //                    dateStatus[games[i].Date] = 0;
        //                }
        //                dateStatus[games[i].Date] += status.Assist;
        //            }
        //        }
        //    }

        //    var sortStatus = dateStatus.OrderBy(k => k.Key);

        //    foreach (var data in sortStatus)
        //    {
        //        var date = data.Key;
        //        var assists = data.Value;

        //        Chart_Thunders.Series[0].Points.AddXY(date, assists);
        //    }
        //}

    }
}
