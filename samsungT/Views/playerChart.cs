using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Management.Instrumentation;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using samsungT.Models;
using samsungT.ViewModels;

namespace samsungT.Views
{
    public partial class playerChart : Form
    {
        private DatabaseHelper db;
        private playerChartViewModel viewModel;
        int PlayerID;
        string PlayerName;

        public playerChart(int playerID, string playerName)
        {
            InitializeComponent();
            viewModel = new playerChartViewModel(playerID, playerName, Chart_Players.Series[0]);
            Label_PlayerName.Text = $"{playerName} 경기 기록";
            viewModel.MakeScoreChart();
        }



        private void Button_Score_Click(object sender, EventArgs e)
        {
            viewModel.MakeScoreChart();
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

        //private void makeScoreChart(int PlayerID)
        //{
        //    Chart_Players.Series[0].Points.Clear();

        //    List<Game> games = db.GetGames();
        //    int score;


        //    foreach (var game in games)
        //    {
        //        if (db.GetGamePlayer(game.GameID, PlayerID) != null)
        //        {
        //            score = db.GetGamePlayer(game.GameID, PlayerID).Score;
        //            Chart_Players.Series[0].Points.AddXY(game.Date, score);
        //        }
        //        else
        //        {
        //            Chart_Players.Series[0].Points.AddXY(game.Date, 0);
        //        }
        //    }

        //}

        //private void make3PointChart(int PlayerID)
        //{
        //    Chart_Players.Series[0].Points.Clear();
        //    List<Game> games = db.GetGames();
        //    int ThreePoint;
        //    int ThreePointA;

        //    foreach (var game in games)
        //    {
        //        if (db.GetGamePlayer(game.GameID, PlayerID) != null)
        //        {
        //            ThreePoint = db.GetGamePlayer(game.GameID, PlayerID).ThreePoint;
        //            ThreePointA = db.GetGamePlayer(game.GameID, PlayerID).ThreePointA;
        //            Chart_Players.Series[0].Points.AddXY(game.Date, (double)ThreePoint / ThreePointA * 100);
        //        }
        //        else
        //        {
        //            Chart_Players.Series[0].Points.AddXY(game.Date, 0);
        //        }
        //    }
        //}

        //private void makeFieldGoalChart(int PlayerID) 
        //{ 
        //    Chart_Players.Series[0].Points.Clear();
        //    List<Game> games = db.GetGames();
        //    int Field;
        //    int FieldA;

        //    foreach (var game in games)
        //    {
        //        if (db.GetGamePlayer(game.GameID, PlayerID) != null)
        //        {
        //            Field = db.GetGamePlayer(game.GameID, PlayerID).FieldGoal;
        //            FieldA = db.GetGamePlayer(game.GameID, PlayerID).FieldGoalA;
        //            Chart_Players.Series[0].Points.AddXY(game.Date, (double)Field / FieldA * 100);
        //        }
        //        else
        //        {
        //            Chart_Players.Series[0].Points.AddXY(game.Date, 0);
        //        }
        //    }
        //}
        //private void makeFreeThrowChart(int PlayerID) 
        //{
        //    Chart_Players.Series[0].Points.Clear();
        //    List<Game> games = db.GetGames();
        //    int Free;
        //    int FreeA;

        //    foreach (var game in games)
        //    {
        //        if (db.GetGamePlayer(game.GameID, PlayerID) != null)
        //        {
        //            Free = db.GetGamePlayer(game.GameID, PlayerID).FreeThrow;
        //            FreeA = db.GetGamePlayer(game.GameID, PlayerID).FreeThrowA;
        //            Chart_Players.Series[0].Points.AddXY(game.Date, (double)Free / FreeA * 100);
        //        }
        //        else
        //        {
        //            Chart_Players.Series[0].Points.AddXY(game.Date, 0);
        //        }
        //    }
        //}
        //private void makeReboundChart(int PlayerID) 
        //{
        //    Chart_Players.Series[0].Points.Clear();

        //    List<Game> games = db.GetGames();
        //    int rebound;


        //    foreach (var game in games)
        //    {
        //        if (db.GetGamePlayer(game.GameID, PlayerID) != null)
        //        {
        //            rebound = db.GetGamePlayer(game.GameID, PlayerID).Rebound;
        //            Chart_Players.Series[0].Points.AddXY(game.Date, rebound);
        //        }
        //        else
        //        {
        //            Chart_Players.Series[0].Points.AddXY(game.Date, 0);
        //        }
        //    }
        //}
        //private void makeAssistChart(int PlayerID) 
        //{
        //    Chart_Players.Series[0].Points.Clear();

        //    List<Game> games = db.GetGames();
        //    int assist;


        //    foreach (var game in games)
        //    {
        //        if (db.GetGamePlayer(game.GameID, PlayerID) != null)
        //        {
        //            assist = db.GetGamePlayer(game.GameID, PlayerID).Assist;
        //            Chart_Players.Series[0].Points.AddXY(game.Date, assist);
        //        }
        //        else
        //        {
        //            Chart_Players.Series[0].Points.AddXY(game.Date, 0);
        //        }
        //    }
        //}
    }
}
