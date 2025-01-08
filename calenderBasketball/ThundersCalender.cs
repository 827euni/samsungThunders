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
            for (int i = calender.Controls.Count - 1; i >= 0; i--)
            {
                if (calender.GetRow(calender.Controls[i]) > 0)
                {
                    calender.Controls.Remove(calender.Controls[i]);
                }
            }
            monthText.Text = $"{month}월";
            DateTime first = new DateTime(year, month, 1);
            int startDays = ((int)first.DayOfWeek + 6) % 7;

            for (int i = 1; i <= 35; i++)
            {
                int row = (i + startDays - 1) / 7 + 1;
                int column = (i + startDays - 1) % 7;

                //Button day = (Button)calender.Controls[button1]; 여기 버튼을 어떻게 하나하나 찾아야 할지 모르겠음.

                if (i <= DateTime.DaysInMonth(year, month))
                {
                    day.Text = i.ToString();
                    day.TextAlign = ContentAlignment.MiddleCenter;
                    day.Font = new Font("Pretendard", 20, FontStyle.Regular);
                    day.BackColor = SystemColors.ButtonHighlight;
                    day.Dock = DockStyle.Fill;

                    if (column == 6)
                    {
                        day.ForeColor = Color.IndianRed;
                    }

                    day.Click += (sender, e) =>
                    {
                        int dayId = i;
                        MessageBox.Show($"You clicked on day: {dayId}");
                    };
                }

                else
                {
                    day.Text = "";
                }

                if (calender.RowCount == 7)
                {
                    changeSize(7);
                }

                else if (calender.RowCount == 6)
                {
                    changeSize(6);
                }
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

        private void todayButton_Click(object sender, EventArgs e)
        {
            today = DateTime.Now;
            fillCalender(today.Year, today.Month);
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
