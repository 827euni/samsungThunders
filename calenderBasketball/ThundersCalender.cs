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
            makeCalender(today.Year, today.Month);
        }

        private void makeCalender(int year, int month)
        {
            foreach (Control control in calender.Controls)
            {
                if (control is Button day)
                {
                    day.Text = "";
                }
            }

            monthText.Text = $"{month}월";
            DateTime firstDay = new DateTime(year, month, 1);
            int startDayIndex = ((int)firstDay.DayOfWeek + 6) % 7;

            int totalDays = DateTime.DaysInMonth(year, month);

            for (int day = totalDays; day >= 1; day--)
            {
                int index = startDayIndex + (totalDays - day);
                if (index < calender.Controls.Count)
                {
                    if (calender.Controls[index] is Button button)
                    {
                        button.Text = day.ToString();
                    }
                }
            }

            for (int i = startDayIndex + totalDays; i < calender.Controls.Count; i++)
            {
                if (calender.Controls[i] is Button button)
                {
                    button.Text = "";
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

        private void changeSize(int rowCount)
        {
            float size = 100 / (rowCount - 1);
            for (int i = 0; i <= rowCount; i++)
            {
                calender.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent,size));
            }
        }

    }
}
