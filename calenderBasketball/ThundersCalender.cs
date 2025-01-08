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
            calender.RowCount = 6;
            calender.ColumnCount = 7;

            string[] week = { "월", "화", "수", "목", "금", "토", "일" };
            for (int i = 0; i < week.Length; i++)
            {
                Label days = new Label
                {
                    Text = week[i],
                    TextAlign = ContentAlignment.MiddleCenter,
                    Font = new Font("Pretendard", 14, FontStyle.Regular),
                    BackColor = SystemColors.ButtonHighlight,
                    Dock = DockStyle.Fill
                };
                calender.Controls.Add(days, i, 0);
            }
            DateTime first = new DateTime(year, month, 1);
            int startDays = ((int)first.DayOfWeek + 6) % 7; // 일요일 시작이 아닌 월요일 시작이라서

            for (int i = 1; i <= DateTime.DaysInMonth(year, month); i++)
            {
                Label day = new Label
                {
                    Text = i.ToString(),
                    TextAlign = ContentAlignment.MiddleCenter,
                    Font = new Font("Pretendard", 12, FontStyle.Regular),
                    BackColor = SystemColors.ButtonHighlight,
                    Dock = DockStyle.Fill
                };
                int row = (i + startDays - 1) / 7 + 1;
                int column = (i + startDays - 1) % 7;

                if (column == 6)
                {
                    day.ForeColor = Color.IndianRed;
                }
                calender.Controls.Add(day, column, row);
            }
        }
    }
}
