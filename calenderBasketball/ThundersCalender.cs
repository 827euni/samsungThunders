using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Diagnostics;

namespace calenderBasketball
{
    public partial class ThundersCalender : UserControl
    {
        public List<DateTime> dates = new List<DateTime>();
        public DateTime today;
        public event Action<int, int, int> selectDate;

        public class GameDTO
        {
            public int GameID { get; set; }
            public DateTime Date { get; set; }
            public int HomeTeamID { get; set; }
            public int AwayTeamID { get; set; }
            public int HomeScore { get; set; }
            public int AwayScore { get; set; }
        }
        public event Func<DateTime, GameDTO> RequestGame;

        public ThundersCalender()
        {
            InitializeComponent();
            today = DateTime.Now;
            int year = today.Year;
            int month = today.Month;
            makeCalender(year, month);
        }

        private void makeCalender(int year, int month)
        {
            foreach (Control control in calender.Controls)
            {
                if (control is Button day)
                {
                    day.Text = "";
                    day.Click -= Day_Click;
                    day.Visible = false;
                }
            }

            monthText.Text = $"{year}년 {month}월";
            DateTime first = new DateTime(year, month, 1);
            int start = ((int)first.DayOfWeek + 6) % 7; // 월요일 시작
            int total = DateTime.DaysInMonth(year, month);
            int index;

            Button[] buttons = new Button[42]
            {
                button1, button2, button3, button4, button5, button6, button7, button8, button9, button10, button11, button12, button13, button14, button15, button16, button17, button18, button19, button20, button21, button22, button23, button24, button25, button26, button27, button28, button29, button30, button31, button32, button33, button34, button35, button36, button37, button38, button39, button40, button41, button42 
            };
        

            for (int day = 1; day <= total; day++)
            {
                index = start + (day - 1);

                if (index < calender.Controls.Count)
                {
                    if (buttons[index] != null)
                    {
                        buttons[index].Text = day.ToString();
                        buttons[index].Tag = day;
                        buttons[index].Click += Day_Click;
                        buttons[index].Visible = true;

                        DateTime targetDate = new DateTime(year, month, day);
                        GameDTO searchGame = RequestGame?.Invoke(targetDate);

                        if (searchGame != null)
                        {
                            buttons[index].BackColor = searchGame.HomeScore > searchGame.AwayScore ? Color.LightBlue : Color.LightCoral;
                            buttons[index].Enabled = true;
                        }
                        else
                        {
                            buttons[index].Enabled = false;
                        }

                        if (calender.GetPositionFromControl(buttons[index]).Column == 6)
                        {
                            buttons[index].ForeColor = Color.IndianRed;
                        }
                    }
                }
            }

        }

        private void Day_Click(object sender, EventArgs e)
        {
            if (sender is Button btn)
            {
                int day = (int)btn.Tag;
                if (selectDate != null)
                {
                    selectDate.Invoke(today.Year, today.Month, day);
                }
            }
        }

        private void nextButton_Click(object sender, EventArgs e)
        {
            today = today.AddMonths(1);
            makeCalender(today.Year, today.Month);
        }

        private void prevButton_Click(object sender, EventArgs e)
        {
            today = today.AddMonths(-1);
            makeCalender(today.Year, today.Month);
        }

        private void todayButton_Click(object sender, EventArgs e)
        {
            today = DateTime.Now;
            makeCalender(today.Year, today.Month);
        }

        //private void changeSize(int rowCount)
        //{
        //    float size = 100 / (rowCount - 1);
        //    for (int i = 0; i <= rowCount; i++)
        //    {
        //        calender.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent,size));
        //    }
        //}


    }
}
