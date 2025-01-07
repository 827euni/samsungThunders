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
                GamePick.Items.Add(new {Text = $"{game.Date.Date.ToString("yyyy년 M월 d일")} {teamName}전", value = game.GameID});
            }
            GamePick.DisplayMember = "Text";
            GamePick.ValueMember = "value";
        }

        private void LoadPickPlayer()
        {
            List<Player> players = db.GetPlayers();

            foreach (Player player in players)
            {
                PlayerPick.Items.Add(new {Text = db.GetPlayerName(player.PlayerID), value = player.PlayerID});
            }

            PlayerPick.DisplayMember = "Text";
            PlayerPick.ValueMember = "value";

        }
    }
}
