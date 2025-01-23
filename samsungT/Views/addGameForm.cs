using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using samsungT.Models;
using samsungT.ViewModels;

namespace samsungT
{
    public partial class addGameForm : Form
    {
        private DatabaseHelper db;
        private addGameViewModel viewModel;
        public addGameForm()
        {
            InitializeComponent();
            viewModel = new addGameViewModel();
            dateGame.DataBindings.Add("Value", viewModel, "Date", true, DataSourceUpdateMode.OnPropertyChanged);
            HomePick.DataBindings.Add("SelectedValue", viewModel, "HomeTeamID", true, DataSourceUpdateMode.OnPropertyChanged);
            HomePick.DataSource = viewModel.Teams; // 데이터 콤보박스에 데이터 추가 하기 위해서 작성
            HomePick.DisplayMember = "TeamName";
            HomePick.ValueMember = "TeamID";
            AwayPick.DataBindings.Add("DataSource", viewModel, "AwayLoad", true, DataSourceUpdateMode.OnPropertyChanged);
            AwayPick.DisplayMember = "TeamName";
            AwayPick.ValueMember = "TeamID";
            AwayPick.DataBindings.Add("SelectedValue", viewModel, "AwayTeamID", true, DataSourceUpdateMode.OnPropertyChanged);
            homeScore.DataBindings.Add("Text", viewModel, "HomeScore", true, DataSourceUpdateMode.OnPropertyChanged);
            awayScore.DataBindings.Add("Text", viewModel, "AwayScore", true, DataSourceUpdateMode.OnPropertyChanged);
        }
        private void resister_Click(object sender, EventArgs e)
        {
            try
            {
                viewModel.ResisterGame();
                MessageBox.Show("경기가 등록되었습니다.", "성공", MessageBoxButtons.OK, MessageBoxIcon.Information);

                dateGame.Value = DateTime.Now;
                HomePick.SelectedIndex = 0;
                AwayPick.SelectedIndex = 0;
                homeScore.Clear();
                awayScore.Clear();

                this.DialogResult = DialogResult.OK;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "오류", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        //private void addGame_Load(object sender, EventArgs e)
        //{
        //    //LoadPick();
        //}

        //private void LoadPick()
        //{
        //    List<Team> teams = db.GetTeams();

        //    foreach (Team team in teams)
        //    {
        //        HomePick.Items.Add(new {Text = team.TeamName, Value = team.TeamID });
        //    }

        //    HomePick.DisplayMember = "Text";
        //    HomePick.ValueMember = "Value";

        //    updateAwayPick(teams, null);

        //    HomePick.SelectedIndexChanged += (sender, e) =>
        //    {
        //        int homeID = (int)((dynamic)HomePick.SelectedItem).Value;
        //        if (homeID != 1)
        //        {
        //            AwayPick.Items.Clear();
        //            AwayPick.Items.Add(new { Text = "삼성 썬더스", Value = 1 });
        //            AwayPick.DisplayMember = "Text";
        //            AwayPick.ValueMember = "Value";
        //            AwayPick.SelectedIndex = 0;
        //        }
        //        else
        //        {
        //            updateAwayPick(teams, homeID);
        //        }
        //    };


        //}

        //private void updateAwayPick(List<Team> teams, int? homeID)
        //{
        //    AwayPick.Items.Clear();

        //    foreach (Team team in teams)
        //    {
        //        if (homeID == 1 && team.TeamID == 1)
        //        {
        //            continue;
        //        }

        //        AwayPick.Items.Add(new { Text = team.TeamName, Value = team.TeamID });
        //    }

        //    AwayPick.DisplayMember = "Text";
        //    AwayPick.ValueMember = "Value";
        //}

    }
}

    
