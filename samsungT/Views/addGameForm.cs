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
                HomePick.Items.Add(new {Text = team.TeamName, Value = team.TeamID });
            }

            HomePick.DisplayMember = "Text";
            HomePick.ValueMember = "Value";

            updateAwayPick(teams, homeID: null);

            HomePick.SelectedIndexChanged += (sender, e) =>
            {
                int homeID = (int)((dynamic)HomePick.SelectedItem).Value;
                if (homeID != 1)
                {
                    AwayPick.Items.Clear();
                    AwayPick.Items.Add(new { Text = "삼성 썬더스", Value = 1 });
                    AwayPick.DisplayMember = "Text";
                    AwayPick.ValueMember = "Value";
                    AwayPick.SelectedIndex = 0;
                }
                else
                {
                    updateAwayPick(teams, homeID);
                }
            };


        }

        private void updateAwayPick(List<Team> teams, int? homeID)
        {
            AwayPick.Items.Clear();

            foreach (Team team in teams)
            {
                if (homeID == 1 && team.TeamID == 1)
                {
                    continue;
                }

                AwayPick.Items.Add(new { Text = team.TeamName, Value = team.TeamID });
            }

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
                
                if (homescore > awayscore)
                {
                    db.UpdateTeamWin(homeTeam, true);
                    db.UpdateTeamWin(awayTeam, false);
                }
                else
                {
                    db.UpdateTeamWin(awayTeam, true);
                    db.UpdateTeamWin(homeTeam, false);
                }
                dateTime = DateTime.Now;
                HomePick.SelectedIndex = 0;
                AwayPick.SelectedIndex = 0;
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

    
