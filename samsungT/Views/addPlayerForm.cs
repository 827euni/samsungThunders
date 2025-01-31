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
using samsungT.ViewModels;

namespace samsungT
{
    public partial class addPlayerForm : Form
    {
        private addPlayerViewModel viewModel;
        private DatabaseHelper db;
        public addPlayerForm()
        {
            InitializeComponent();
            viewModel = new addPlayerViewModel();
            //데이터 바인딩
            playerName.DataBindings.Add("Text", viewModel, "PlayerName", true, DataSourceUpdateMode.OnPropertyChanged);
            playerId.DataBindings.Add("Text", viewModel, "PlayerID", true, DataSourceUpdateMode.OnPropertyChanged);
            playerPosition.DataBindings.Add("Text", viewModel, "PlayerPosition", true, DataSourceUpdateMode.OnPropertyChanged);
            playerHeight.DataBindings.Add("Text", viewModel, "PlayerHeight", true, DataSourceUpdateMode.OnPropertyChanged);

        }
        //등록 버튼 클릭시 초기화 및 뷰모델과 연결하여 저장
        private void resister_Click(object sender, EventArgs e)
        {
            try
            {
                viewModel.RegisterPlayer();
                MessageBox.Show("선수가 추가되었습니다.", "성공", MessageBoxButtons.OK, MessageBoxIcon.Information);

                playerName.Clear();
                playerId.Clear();
                playerPosition.Clear();
                playerHeight.Clear();

                this.DialogResult = DialogResult.OK;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "오류", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
