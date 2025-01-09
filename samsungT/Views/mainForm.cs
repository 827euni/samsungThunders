using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using calenderBasketball;
using samsungT.Models;
using samsungT.Views;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.TaskBand;

namespace samsungT
{
    public partial class mainForm : Form
    {

        private Models.DatabaseHelper db;
        public Button lastButton = null;
        public mainForm()
        {
            InitializeComponent();
            db = new Models.DatabaseHelper();
            loadPlayers();
            loadWinRateChart();
            loadRecentGame();
            loadStatus();
            thundersCalender.selectDate += thundersSelectDate;
        }
        // 리스트 뷰에 선수들을 나타내게 하는 함수
        private void loadPlayers()
        {
            listPlayers.Items.Clear();
            var players = db.GetPlayers();
            var playerStatus = db.GetPlayersStatus();

            var playerStats = new Dictionary<int, PlayerStatus>();

            foreach (var status in playerStatus)
            {
                if (!playerStats.ContainsKey(status.PlayerID))
                {
                    playerStats[status.PlayerID] = new PlayerStatus
                    {
                        PlayerID = status.PlayerID,
                        GameCount = 0
                    };
                }

                var current = playerStats[status.PlayerID];

                current.Rebound += status.Rebound;
                current.ThreePoint += status.ThreePoint;
                current.ThreePointA += status.ThreePointA;
                current.FreeThrow += status.FreeThrow;
                current.FreeThrowA += status.FreeThrowA;
                current.FieldGoal += status.FieldGoal;
                current.FieldGoalA += status.FieldGoalA;
                current.Assist += status.Assist;
                current.Score += status.Score;
                current.GameCount++;
            }

            foreach (var player in players)
            {
                var item = new ListViewItem(player.PlayerID.ToString());
                item.SubItems.Add(player.PlayerName);
                item.SubItems.Add(player.Position);

                if (playerStats.ContainsKey(player.PlayerID))
                {
                    var status = playerStats[player.PlayerID];
                    decimal gameCount = status.GameCount;

                    item.SubItems.Add(gameCount > 0 ? (status.Score / gameCount).ToString("F2") : "0");
                    item.SubItems.Add(gameCount > 0 && status.ThreePointA > 0 ? ((float)status.ThreePoint / status.ThreePointA * 100).ToString("F2")+"%" : "0");
                    item.SubItems.Add(gameCount > 0 && status.FreeThrowA > 0 ? ((float)status.FreeThrow / status.FreeThrowA * 100).ToString("F2")+"%" : "0");
                    item.SubItems.Add(gameCount > 0 && status.FieldGoalA > 0 ? ((float)status.FieldGoal / status.FieldGoalA * 100).ToString("F2")+"%" : "0");
                    item.SubItems.Add(gameCount > 0 ? (status.Rebound / gameCount).ToString("F2") : "0"); 
                    item.SubItems.Add(gameCount > 0 ? (status.Assist / gameCount).ToString("F2") : "0");
                }

                else
                {
                    item.SubItems.Add("0");
                    item.SubItems.Add("0%");
                    item.SubItems.Add("0%");
                    item.SubItems.Add("0%");
                    item.SubItems.Add("0");
                    item.SubItems.Add("0");
                }

                listPlayers.Items.Add(item);
            }
        }

        private void changePlayers(Game searchGame)
        {
            listPlayers.Items.Clear();
            var players = db.GetPlayers();
            var playerStatus = db.GetPlayersStatus();
            int gameID = searchGame.GameID;
            string homeCityName = db.GetCityName(searchGame.HomeTeamID);
            string awayCityName = db.GetCityName(searchGame.AwayTeamID);

            var playerStats = new Dictionary<int, PlayerStatus>();

            foreach (var status in playerStatus)
            {
                if (!playerStats.ContainsKey(status.PlayerID))
                {
                    playerStats[status.PlayerID] = new PlayerStatus
                    {
                        PlayerID = status.PlayerID,
                    };
                }

                var current = playerStats[status.PlayerID];
                if (db.GetGamePlayer(gameID, status.PlayerID) != null)
                {
                    current.Rebound = db.GetGamePlayer(gameID, status.PlayerID).Rebound;
                    current.ThreePoint = db.GetGamePlayer(gameID, status.PlayerID).ThreePoint;
                    current.ThreePointA = db.GetGamePlayer(gameID, status.PlayerID).ThreePointA;
                    current.FreeThrow = db.GetGamePlayer(gameID, status.PlayerID).FreeThrow;
                    current.FreeThrowA = db.GetGamePlayer(gameID, status.PlayerID).FreeThrowA;
                    current.FieldGoal = db.GetGamePlayer(gameID, status.PlayerID).FieldGoal;
                    current.FieldGoalA = db.GetGamePlayer(gameID, status.PlayerID).FieldGoalA;
                    current.Assist = db.GetGamePlayer(gameID, status.PlayerID).Assist;
                    current.Score = db.GetGamePlayer(gameID, status.PlayerID).Score;
                }
                else
                {
                    current.Rebound = 0;
                    current.ThreePoint = 0;
                    current.ThreePointA = 0;
                    current.FreeThrow = 0;
                    current.FreeThrowA = 0;
                    current.FieldGoal = 0;
                    current.FieldGoalA = 0;
                    current.Assist = 0;
                    current.Score = 0;
                }
            }

            foreach(var player in players)
            {
                var item = new ListViewItem(player.PlayerID.ToString());
                item.SubItems.Add(player.PlayerName);
                item.SubItems.Add(player.Position);

                if (playerStats.ContainsKey(player.PlayerID))
                {
                    var status = playerStats[player.PlayerID];

                    item.SubItems.Add(status.Score > 0 ? (status.Score).ToString() : "0");
                    item.SubItems.Add(status.ThreePointA > 0 ? ((float)status.ThreePoint / status.ThreePointA * 100).ToString("F2") + "%" : "0");
                    item.SubItems.Add(status.FreeThrowA > 0 ? ((float)status.FreeThrow / status.FreeThrowA * 100).ToString("F2") + "%" : "0");
                    item.SubItems.Add(status.FieldGoalA > 0 ? ((float)status.FieldGoal / status.FieldGoalA * 100).ToString("F2") + "%" : "0");
                    item.SubItems.Add(status.Rebound > 0 ? (status.Rebound).ToString() : "0");
                    item.SubItems.Add(status.Assist > 0 ? (status.Assist).ToString() : "0");
                }

                else
                {
                    item.SubItems.Add("0");
                    item.SubItems.Add("0%");
                    item.SubItems.Add("0%");
                    item.SubItems.Add("0%");
                    item.SubItems.Add("0");
                    item.SubItems.Add("0");
                }

                listPlayers.Items.Add(item);
            }

        }

        //승률 차트 바꾸고, 기본 값이 삼성썬더스로 보이게 하는 함수
        private void loadWinRateChart(int teamID = 1)
        {
            winRateChart.Series[0].Points.Clear();

            List<Team> teams = db.GetTeams();

            Team TeamID = null;

            foreach (Team team in teams)
            {
                if (team.TeamID == teamID)
                {
                    TeamID = team;
                    break;
                };
            }

            if (TeamID != null)
            {
                int totalGames = TeamID.Wins + TeamID.Losses;
                double winRate = totalGames > 0 ? (double)TeamID.Wins / totalGames * 100 : 0;

                winRateChart.Series[0].Points.AddXY("승리",TeamID.Wins);
                winRateChart.Series[0].Points.AddXY("패배",TeamID.Losses);

                string WinRateText = $"{winRate:F2}%";
                winRateText.Text = WinRateText; 
            }
            else
            {
                winRateText.Text = $"팀 ID가 {TeamID}인 팀을 찾을 수 없습니다.";
            }
        }
        
        // 최근 경기의 결과를 볼 수 있게 하는 함수
        private void loadRecentGame()
        {
            var playerStatus = db.GetPlayersStatus();
            var recentGame = db.GetRecentGame();

            if (recentGame != null) 
            {
                int gameID = recentGame.GameID;
                string homeCityName = db.GetCityName(recentGame.HomeTeamID);
                string awayCityName = db.GetCityName(recentGame.AwayTeamID);

                int total3Point = 0;
                int total3PointA = 0;
                int totalField = 0;
                int totalFieldA = 0;
                int totalFree = 0;
                int totalFreeA = 0;
                int totalRebound = 0;
                int totalAssist = 0;

                foreach (var status in playerStatus)
                {
                    if (status.GameID == gameID)
                    {
                        total3Point += status.ThreePoint;
                        total3PointA += status.ThreePointA;
                        totalField += status.FieldGoal;
                        totalFieldA += status.FieldGoalA;
                        totalFree += status.FreeThrow;
                        totalFreeA += status.FreeThrowA;
                        totalRebound += status.Rebound;
                        totalAssist += status.Assist;
                    }

                }
                recentHomeScore.Text = recentGame.HomeScore.ToString();
                recentAwayScore.Text = recentGame.AwayScore.ToString();
                recentCity.Text = $"{homeCityName}  :  {awayCityName}";
                recent3.Text = $"{total3Point}/{total3PointA}";
                recentField.Text = $"{totalField}/{totalFieldA}";
                recentFree.Text = $"{totalFree}/{totalFreeA}";
                recentRebound.Text = totalRebound.ToString();
                recentAssist.Text = totalAssist.ToString();

                if (recentGame.HomeTeamID == 1)
                {
                    recentHomeScore.ForeColor = Color.RoyalBlue;
                }
                else
                {
                    recentAwayScore.ForeColor = Color.RoyalBlue;
                }
            }
        }

        private void loadStatus()
        {
            var games = db.GetGames();
            var playerStatus = db.GetPlayersStatus();
            var players = db.GetPlayers();

            int totalScore = 0;
            int total3Point = 0;
            int total3PointA = 0;
            int totalField = 0;
            int totalFieldA = 0;
            int totalFree = 0;
            int totalFreeA = 0;
            int totalRebound = 0;
            int totalAssist = 0;

            foreach (var player in playerStatus)
            {
                totalScore += player.Score;
                total3Point += player.ThreePoint;
                total3PointA += player.ThreePointA;
                totalField += player.FieldGoal;
                totalFieldA += player.FieldGoalA;
                totalFree += player.FreeThrow;
                totalFreeA += player.FreeThrowA;
                totalRebound += player.Rebound;
                totalAssist += player.Assist;
            }

            clickScore.Text = totalScore.ToString();
            click3.Text = total3PointA > 0 ? ((float)total3Point / total3PointA * 100).ToString("F2") + "%" : 0.ToString();
            clickField.Text = totalFieldA > 0 ? ((float)totalField / totalFieldA * 100).ToString("F2") + "%" : 0.ToString();
            clickFree.Text = totalFreeA > 0 ? ((float)totalFree / totalFreeA * 100).ToString("F2") + "%" : 0.ToString();
            clickRebound.Text = totalRebound.ToString();
            clickAssist.Text = totalAssist.ToString();

        }

        private void changeStatus(Game searchGame)
        {
            var playerStatus = db.GetPlayersStatus();
            int gameID = searchGame.GameID;
            string homeCityName = db.GetCityName(searchGame.HomeTeamID);
            string awayCityName = db.GetCityName(searchGame.AwayTeamID);

            int total3Point = 0;
            int total3PointA = 0;
            int totalField = 0;
            int totalFieldA = 0;
            int totalFree = 0;
            int totalFreeA = 0;
            int totalRebound = 0;
            int totalAssist = 0;

            foreach (var status in playerStatus)
            {
                if (status.GameID == gameID)
                {
                    total3Point += status.ThreePoint;
                    total3PointA += status.ThreePointA;
                    totalField += status.FieldGoal;
                    totalFieldA += status.FieldGoalA;
                    totalFree += status.FreeThrow;
                    totalFreeA += status.FreeThrowA;
                    totalRebound += status.Rebound;
                    totalAssist += status.Assist;
                }
            }

            if (searchGame.HomeScore > searchGame.AwayScore)
            {
                clickChangeTitle.Text = searchGame.HomeTeamID == 1 ? "WIN" : "LOSE";
            }

            else
            {
                clickChangeTitle.Text = searchGame.HomeTeamID == 1 ? "LOSE" : "WiN";
            }

            clickHomeScore.Text = searchGame.HomeScore.ToString();
            label3.Text = ":";
            clickAwayScore.Text = searchGame.AwayScore.ToString();
            clickCity.Text = $"{homeCityName}  :  {awayCityName}";
            click3.Text = $"{total3Point}/{total3PointA}";
            clickField.Text = $"{totalField}/{totalFieldA}";
            clickFree.Text = $"{totalFree}/{totalFreeA}";
            clickRebound.Text = totalRebound.ToString();
            clickAssist.Text = totalAssist.ToString();


            if (searchGame.HomeTeamID == 1)
            {
                clickHomeScore.ForeColor = Color.RoyalBlue;
            }
            else
            {
                clickAwayScore.ForeColor = Color.RoyalBlue;
            }
        }

        private void thundersSelectDate(int year, int month, int day)
        {

            DateTime targetDate = new DateTime(year, month, day);
            Game searchGame = db.GetSearchGame(targetDate);

            if (searchGame == null)
            {
                
            }
            else
            {
                changeStatus(searchGame);
                changePlayers(searchGame);
            }
        }

        private void resisterPlayer_Click(object sender, EventArgs e)
        {
            addPlayerForm addPlayer = new addPlayerForm();
            addPlayer.ShowDialog();
        }

        private void resisterTeam_Click(object sender, EventArgs e)
        {
            addTeamForm addTeam = new addTeamForm();
            addTeam.ShowDialog();
        }

        private void resisterGame_Click(object sender, EventArgs e)
        {
            addGameForm addGame = new addGameForm();
            addGame.ShowDialog();

        }

        private void resisterGamePlayer_Click(object sender, EventArgs e)
        {
            addPlayerStatusForm addPlayerStatus = new addPlayerStatusForm();
            addPlayerStatus.ShowDialog();
        }

        // 승률 버튼
        private void setButtonColor(System.Windows.Forms.Button button)
        {
            DBButton.BackColor = SystemColors.ButtonHighlight;
            SONOButton.BackColor = SystemColors.ButtonHighlight;
            SKButton.BackColor = SystemColors.ButtonHighlight;
            LGButton.BackColor = SystemColors.ButtonHighlight;
            KGCButton.BackColor = SystemColors.ButtonHighlight;
            KCCButton.BackColor = SystemColors.ButtonHighlight;
            KTButton.BackColor = SystemColors.ButtonHighlight;
            KOGASButton.BackColor = SystemColors.ButtonHighlight;
            MOBISButton.BackColor = SystemColors.ButtonHighlight;


            if (button != null)
            {
                button.BackColor = Color.AliceBlue;
            }
        }

        private void ResetButtonColor(Button button)
        {

            if (button != null)
            {
                button.BackColor = SystemColors.ButtonHighlight;
            }
        }

        private void oneMoreClickButton(Button clickButton, int chartType)
        {
            if (lastButton == clickButton)
            {
                ResetButtonColor(lastButton);
                lastButton = null;
                loadWinRateChart(1);
            }
            else
            {
                if (lastButton != null)
                {
                    ResetButtonColor(lastButton);
                }

                setButtonColor(clickButton);
                lastButton = clickButton;
                loadWinRateChart(chartType);
            }
        }


        private void DBButton_Click(object sender, EventArgs e)
        {
            oneMoreClickButton(DBButton, 2);
        }

        private void SONOButton_Click(object sender, EventArgs e)
        {
            oneMoreClickButton(SONOButton, 3);
        }

        private void SKButton_Click(object sender, EventArgs e)
        {
            oneMoreClickButton(SKButton, 4);
        }

        private void LGButton_Click(object sender, EventArgs e)
        {
            oneMoreClickButton(LGButton, 5);
        }

        private void KGCButton_Click(object sender, EventArgs e)
        {
            oneMoreClickButton(KGCButton, 6);
        }

        private void KCCButton_Click(object sender, EventArgs e)
        {
            oneMoreClickButton(KCCButton, 7);
        }

        private void KTButton_Click(object sender, EventArgs e)
        {
            oneMoreClickButton(KTButton, 8);
        }

        private void KOGASButton_Click(object sender, EventArgs e)
        {
            oneMoreClickButton(KOGASButton, 9);
        }

        private void MOBISButton_Click(object sender, EventArgs e)
        {
            oneMoreClickButton(MOBISButton, 10);
        }

    }
}
