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
    public partial class addPlayerForm : Form
    {
        private DatabaseHelper db;
        public addPlayerForm()
        {
            InitializeComponent();
            db = new DatabaseHelper();
        }

        private void resister_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(playerName.Text) ||
                string.IsNullOrWhiteSpace(playerId.Text) ||
                string.IsNullOrWhiteSpace(playerPosition.Text) ||
                string.IsNullOrWhiteSpace(playerHeight.Text))
            {
                MessageBox.Show("모든 텍스트를 입력해주세요.", "모든 텍스트를 입력해주세요.", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            try
            {
                // 선수 객체 추가
                Player newPlayer = new Player
                {
                    PlayerName = playerName.Text,
                    TeamID = 1, // 선수 등록으로 추가 되는 모든 선수는 반드시 삼성 썬더스임으로.
                    PlayerID = int.Parse(playerId.Text),
                    Position = playerPosition.Text,
                    Height = int.Parse(playerHeight.Text),
                };

                db.AddPlayer(newPlayer);
                MessageBox.Show("선수가 추가되었습니다.", "성공", MessageBoxButtons.OK, MessageBoxIcon.Information);

                playerName.Clear();
                playerId.Clear();
                playerPosition.Clear();
                playerHeight.Clear();

                this.DialogResult = DialogResult.OK;
                this.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show($"선수 추가 중 오류가 발생했습니다: {ex.Message}", "오류", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }




    }
}
