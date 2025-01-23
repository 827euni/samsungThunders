using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Net.NetworkInformation;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using samsungT.Models;
using samsungT.ViewModels;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace samsungT.Views
{
    public partial class addPlayerStatusForm : Form
    {

        private DatabaseHelper db;
        private addPlayerStatusViewModel viewModel;
        public addPlayerStatusForm()
        {
            InitializeComponent();
            db = new DatabaseHelper();
            viewModel = new addPlayerStatusViewModel();
            GamePick.DataBindings.Add("DataSource", viewModel, "Games", true, DataSourceUpdateMode.OnPropertyChanged);
            GamePick.DisplayMember = "Text";
            GamePick.ValueMember = "Value";
            GamePick.DataBindings.Add("SelectedValue", viewModel, "GameID", true, DataSourceUpdateMode.OnPropertyChanged);
            PlayerPick.DataBindings.Add("DataSource", viewModel, "Players", true, DataSourceUpdateMode.OnPropertyChanged);
            PlayerPick.DisplayMember = "PlayerName";
            PlayerPick.ValueMember = "PlayerID";
            PlayerPick.DataBindings.Add("SelectedValue", viewModel, "PlayerID", true, DataSourceUpdateMode.OnPropertyChanged);

            Rebound.DataBindings.Add("Text", viewModel, "Rebound", true, DataSourceUpdateMode.OnPropertyChanged);
            ThreePoint.DataBindings.Add("Text", viewModel, "ThreePoint", true, DataSourceUpdateMode.OnPropertyChanged);
            ThreePointA.DataBindings.Add("Text", viewModel, "ThreePointA", true, DataSourceUpdateMode.OnPropertyChanged);
            FreeThrow.DataBindings.Add("Text", viewModel, "FreeThrow", true, DataSourceUpdateMode.OnPropertyChanged);
            FreeThrowA.DataBindings.Add("Text", viewModel, "FreeThrowA", true, DataSourceUpdateMode.OnPropertyChanged);
            FieldGoal.DataBindings.Add("Text", viewModel, "FieldGoal", true, DataSourceUpdateMode.OnPropertyChanged);
            FieldGoalA.DataBindings.Add("Text", viewModel, "FieldGoalA", true, DataSourceUpdateMode.OnPropertyChanged);
            Assist.DataBindings.Add("Text", viewModel, "Assist", true, DataSourceUpdateMode.OnPropertyChanged);
            Score.DataBindings.Add("Text", viewModel, "Score", true, DataSourceUpdateMode.OnPropertyChanged);
        }

        private void addPlayerStatusForm_Load(object sender, EventArgs e)
        {
            LoadPickGame();
            LoadPickPlayer();
        }

        private void LoadPickGame()
        {
            List<Game> games = db.GetGames();

            foreach (Game game in games)
            {
                string teamName = "";
                if (db.GetTeamName(game.HomeTeamID) != "삼성 썬더스")
                {
                    teamName = db.GetTeamName(game.HomeTeamID);
                }
                else
                {
                    teamName = db.GetTeamName(game.AwayTeamID);
                }
                GamePick.Items.Add(new {Text = $"{game.Date.Date.ToString("yyyy년 M월 d일")} {teamName}전", Value = game.GameID});
            }
            GamePick.DisplayMember = "Text";
            GamePick.ValueMember = "value";
            GamePick.SelectedIndex = 0;
        }

        private void LoadPickPlayer()
        {
            List<Player> players = db.GetPlayers();

            foreach (Player player in players)
            {
                PlayerPick.Items.Add(new {Text = db.GetPlayerName(player.PlayerID), Value = player.PlayerID});
            }

            PlayerPick.DisplayMember = "Text";
            PlayerPick.ValueMember = "value";

        }

        private void resisterPlayerStatus_Click(object sender, EventArgs e)
        {
            if (GamePick.SelectedItem == null || 
                PlayerPick.SelectedItem == null ||
                string.IsNullOrWhiteSpace(Score.Text) ||
                string.IsNullOrWhiteSpace(ThreePoint.Text) ||
                string.IsNullOrWhiteSpace(ThreePointA.Text) ||
                string.IsNullOrWhiteSpace(FieldGoal.Text) ||
                string.IsNullOrWhiteSpace(FieldGoalA.Text) ||
                string.IsNullOrWhiteSpace(FreeThrow.Text) ||
                string.IsNullOrWhiteSpace(FreeThrowA.Text) ||
                string.IsNullOrWhiteSpace(Rebound.Text) ||
                string.IsNullOrWhiteSpace(Assist.Text))
            {
                MessageBox.Show("모든 필드를 입력해주세요.", "경기 등록 오류", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }


            try
            {
                int gameID = (int)((dynamic)GamePick.SelectedItem).Value; // 다이나믹을 쓰면 해당 컴파일 타임에 타입을 정확히 알고 있지 않아도 됨.
                int playerID = (int)((dynamic)PlayerPick.SelectedItem).Value;
                int rebound = int.Parse(Rebound.Text);
                int threePoint = int.Parse(ThreePoint.Text);
                int threePointA = int.Parse(ThreePointA.Text);
                int freeThrow = int.Parse(FreeThrow.Text);
                int freeThrowA = int.Parse(FreeThrowA.Text);
                int fieldGoal = int.Parse(FieldGoal.Text);
                int fieldGoalA = int.Parse(FieldGoalA.Text);
                int assist = int.Parse(Assist.Text);
                int score = int.Parse(Score.Text);

                PlayerStatus playerStatus = new PlayerStatus
                {
                    GameID = gameID,
                    PlayerID = playerID,
                    Rebound = rebound,
                    ThreePoint = threePoint,
                    ThreePointA = threePointA,
                    FreeThrow = freeThrow,
                    FreeThrowA = freeThrowA,
                    FieldGoal = fieldGoal,
                    FieldGoalA = fieldGoalA,
                    Assist = assist,
                    Score = score
                };

                db.AddPlayerStat(playerStatus);
                MessageBox.Show("선수 기록이 추가되었습니다.", "성공", MessageBoxButtons.OK, MessageBoxIcon.Information);
                GamePick.SelectedIndex = 0;
                PlayerPick.SelectedIndex = 0;
                Rebound.Clear();
                ThreePoint.Clear();
                ThreePointA.Clear();
                FreeThrow.Clear();
                FreeThrowA.Clear();
                FieldGoal.Clear();
                FieldGoalA.Clear();
                Assist.Clear();
                Score.Clear();

                this.DialogResult = DialogResult.OK;
            }
            catch (Exception ex) 
            {
                MessageBox.Show($"선수 기록 추가 중 오류가 발생했습니다: {ex.Message}", "오류", MessageBoxButtons.OK, MessageBoxIcon.Error);

            }

        }
    }
}
