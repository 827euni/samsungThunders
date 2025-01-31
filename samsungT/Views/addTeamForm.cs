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
    public partial class addTeamForm : Form
    {
        private addTeamViewModel viewModel;
        private DatabaseHelper db;
        public addTeamForm()
        {
            InitializeComponent();
            db = new DatabaseHelper();
            viewModel = new addTeamViewModel();
            //데이터 바인딩
            teamName.DataBindings.Add("Text", viewModel, "TeamName", true, DataSourceUpdateMode.OnPropertyChanged);
            teamCity.DataBindings.Add("Text", viewModel, "City", true, DataSourceUpdateMode.OnPropertyChanged);
        }

        //등록 버튼 클릭시 초기화 및 뷰모델과 연결하여 저장
        private void resister_Click(object sender, EventArgs e)
        {
            try
            {
                viewModel.ResisterTeam();
                MessageBox.Show("팀이 추가되었습니다.", "성공", MessageBoxButtons.OK, MessageBoxIcon.Information);

                teamName.Clear();
                teamCity.Clear();

                this.DialogResult = DialogResult.OK;
            }

            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "오류", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }


    }
}
