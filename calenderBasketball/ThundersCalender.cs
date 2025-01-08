using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace calenderBasketball
{
    public partial class ThundersCalender : UserControl
    {
        public List<DateTime> dates = new List<DateTime>();
        public DateTime today;
        public ThundersCalender()
        {
            InitializeComponent();
            today = DateTime.Now;
            fillCalender(today.Year, today.Month);
        }

        private void fillCalender(int year, int month)
        {
            calender.Controls.Clear();
            calender.RowCount = 6;
            calender.ColumnCount = 7;
            monthText.Text = $"{month}월";

            string[] week = {"월요일","화요일","수요일","목요일","금요일","토요일","일요일"};
            for (int i = 0; i < week.Length; i++)
            {
                Label days = new Label
                {
                    Text = week[i],
                    TextAlign = ContentAlignment.MiddleCenter,
                    Font = new Font("Pretendard Variable", 12, FontStyle.Bold),
                    BackColor = SystemColors.ButtonHighlight,
                    Dock = DockStyle.Fill
                };
                calender.Controls.Add(days, i, 0);
            }
            DateTime first = new DateTime(year, month, 1);
            int startDays = ((int)first.DayOfWeek + 6) % 7; // 일요일 시작이 아닌 월요일 시작이라서

            for (int i = 1; i <= DateTime.DaysInMonth(year, month); i++)
            {
                int row = (i + startDays - 1) / 7 + 1;
                int column = (i + startDays - 1) % 7;
                Label day = new Label
                {
                    Text = i.ToString(),
                    TextAlign = ContentAlignment.MiddleCenter,
                    Font = new Font("Pretendard", 20, FontStyle.Regular),
                    BackColor = SystemColors.ButtonHighlight,
                    Dock = DockStyle.Fill
                };

                if (column == 6)
                {
                    day.ForeColor = Color.IndianRed;
                }
                calender.Controls.Add(day, column, row);
            }
        }
        

        private void nextButton_Click(object sender, EventArgs e)
        {
            today = today.AddMonths(1);
            fillCalender(today.Year, today.Month);
        }

        private void prevButton_Click(object sender, EventArgs e)
        {
            today = today.AddMonths(-1);
            fillCalender(today.Year, today.Month);
        }
    }
}
