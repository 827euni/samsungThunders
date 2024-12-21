using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using samsungT.Models;

namespace samsungT
{
    public partial class addGameForm : Form
    {
        private DatabaseHelper db;
        public addGameForm()
        {
            InitializeComponent();
            db = new DatabaseHelper();
        }

        private void LoadPick()
        {
            List<Team> teams = db.GetTeams();

            foreach (Team team in teams)
            {
                HomePick.Items.Add(new { Text = team.TeamName, Value = team.TeamID });
                AwayPick.Items.Add(new { Text = team.TeamName, Value = team.TeamID });
            }

            HomePick.DisplayMember = "Text";
            HomePick.ValueMember = "Value";

            AwayPick.DisplayMember = "Text";
            AwayPick.ValueMember = "Value";

        }

        private void resister_Click(object sender, EventArgs e)
        {

            if (HomePick.SelectedItem == null ||
                AwayPick.SelectedItem == null ||
                string.IsNullOrWhiteSpace(homeScore.Text) ||
                string.IsNullOrWhiteSpace(awayScore.Text))
            {
                MessageBox.Show("모든 필드를 입력해주세요.", "경기 등록 오류", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            try
            {
                DateTime dateTime = dateGame.Value;
                int homeTeam = (int)((dynamic)HomePick.SelectedItem).Value;
                int awayTeam = (int)((dynamic)AwayPick.SelectedItem).Value;
                int homescore = int.Parse(homeScore.Text);
                int awayscore = int.Parse(awayScore.Text);

                Game game = new Game
                {
                    Date = dateTime,
                    HomeTeamID = homeTeam,
                    AwayTeamID = awayTeam,
                    HomeScore = homescore,
                    AwayScore = awayscore
                };

                db.AddGame(game);
                MessageBox.Show("경기가 추가되었습니다.", "성공", MessageBoxButtons.OK, MessageBoxIcon.Information);

                homeScore.Clear();
                awayScore.Clear();
            }
            catch (Exception ex)
            {
                MessageBox.Show($"경기 추가 중 오류가 발생했습니다: {ex.Message}", "오류", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void addGame_Load(object sender, EventArgs e)
        {
            LoadPick();
        }
    }
}

    
