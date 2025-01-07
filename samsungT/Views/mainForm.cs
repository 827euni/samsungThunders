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
        }

        // 리스트 뷰에 선수들을 나타내게 하는 함수
        private void loadPlayers()
        {
            listPlayers.Items.Clear();
            var players = db.GetPlayers();
            var playerStatus = db.GetPlayersStatus();

            foreach (var player in players)
            {
                var item = new ListViewItem(player.PlayerID.ToString());
                item.SubItems.Add(player.PlayerName);
                item.SubItems.Add(player.Position);

                PlayerStatus status = null;

                foreach (var st in playerStatus)
                {
                    if (st.PlayerID == player.PlayerID)
                    {
                        status = st;
                        break;
                    }
                }

                if (status != null)
                {
                    item.SubItems.Add(status.Score.ToString());
                    item.SubItems.Add(status.Get3PointPercentage().ToString("F2") + "%");
                    item.SubItems.Add(status.GetFreeThrowPercentage().ToString("F2") + "%");
                    item.SubItems.Add(status.GetFieldGoalPercentage().ToString("F2") + "%");
                    item.SubItems.Add(status.Rebound.ToString());
                    item.SubItems.Add(status.Assist.ToString());
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
        private void resisterPlayer_Click(object sender, EventArgs e)
        {
            addPlayerForm addPlayer = new addPlayerForm();
            addPlayer.ShowDialog();
        }

        private void resisterTeam_Click(object sender, EventArgs e)
        {
            addTeamForm addTeam = new addTeamForm();
            addTeam.ShowDialog();

            if (addTeam.ShowDialog() == DialogResult.OK) 
            {
                loadPlayers();
            }
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

        private void setButtonColor(Button button)
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
