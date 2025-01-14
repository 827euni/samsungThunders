﻿using System;
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

namespace samsungT.Views
{
    public partial class addPlayerStatusForm : Form
    {

        private DatabaseHelper db;
        public addPlayerStatusForm()
        {
            InitializeComponent();
            db = new DatabaseHelper();
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
            }
            catch (Exception ex) 
            {
                MessageBox.Show($"선수 기록 추가 중 오류가 발생했습니다: {ex.Message}", "오류", MessageBoxButtons.OK, MessageBoxIcon.Error);

            }

        }
    }
}
