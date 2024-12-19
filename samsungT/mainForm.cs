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
        public mainForm()
        {
            InitializeComponent();
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
        }
    }
}
