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

namespace samsungT
{
    public partial class mainForm : Form
    {

        private Models.DatabaseHelper db;
        public mainForm()
        {
            InitializeComponent();
            db = new Models.DatabaseHelper();
            loadPlayers();
        }

        private void resisterPlayer_Click(object sender, EventArgs e)
        {
            addPlayer addPlayer = new addPlayer();
            addPlayer.ShowDialog();
        }

        private void resisterTeam_Click(object sender, EventArgs e)
        {
            addTeam addTeam = new addTeam();
            addTeam.ShowDialog();

            if (addTeam.ShowDialog() == DialogResult.OK) 
            {
                loadPlayers();
            }
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
                item.SubItems.Add(player.Height.ToString());

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
                    item.SubItems.Add(status.Get3PointPercentage().ToString("F2") + "%");
                    item.SubItems.Add(status.GetFreeThrowPercentage().ToString("F2") + "%");
                    item.SubItems.Add(status.Get2PointPercentage().ToString("F2") + "%");
                    item.SubItems.Add(status.Rebounds.ToString());
                }
                else
                {
                    item.SubItems.Add("0%");
                    item.SubItems.Add("0%");
                    item.SubItems.Add("0%");
                    item.SubItems.Add("0");
                }

                listPlayers.Items.Add(item);
            }
        }
    }
}
