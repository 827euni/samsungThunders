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
    public partial class addTeamForm : Form
    {
        private DatabaseHelper db;
        public addTeamForm()
        {
            InitializeComponent();
            db = new DatabaseHelper();
        }

        private void resister_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(teamName.Text) ||
                string.IsNullOrWhiteSpace(teamCity.Text))
            {
                MessageBox.Show("모든 텍스트를 입력해주세요.", "모든 텍스트를 입력해주세요.", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            try
            {
                Team team = new Team
                {
                    TeamName = teamName.Text,
                    City = teamCity.Text
                };

                db.AddTeam(team);
                MessageBox.Show("팀이 추가되었습니다.", "성공", MessageBoxButtons.OK, MessageBoxIcon.Information);
                teamName.Clear();
                teamCity.Clear();
            }

            catch (Exception ex)
            {
                MessageBox.Show($"팀 추가 중 오류가 발생했습니다: {ex.Message}", "오류", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
