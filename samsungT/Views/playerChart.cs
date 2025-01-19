using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace samsungT.Views
{
    public partial class playerChart : Form
    {

        public playerChart(int playerID, string playerName)
        {
            InitializeComponent();
            int ID = playerID;
            string Name = playerName;

            Label_PlayerName.Text = $"{Name} 경기기록";

        }
    }
}
