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

            DateTime[] dateTimes = new DateTime[games.Count];
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

        }

        private void Button_Field_Click(object sender, EventArgs e)
        {

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
