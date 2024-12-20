using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

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

        private void loadPlayers()
        {
            listPlayers.Items.Clear();
            var players = db.GetPlayers();

            foreach (var player in players)
            {
                var item = new ListViewItem(player.PlayerID.ToString());
                item.SubItems.Add(player.PlayerName);
                item.SubItems.Add(player.TeamID.ToString());
                item.SubItems.Add(player.Position);
                item.SubItems.Add(player.Height.ToString());
                listPlayers.Items.Add(item);
            }
        }
    }
}
