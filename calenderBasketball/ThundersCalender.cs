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
        public event Action<int, int, int> selectDate;
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

            monthText.Text = $"{month}월";
            DateTime first = new DateTime(year, month, 1);
            int start = ((int)first.DayOfWeek + 6) % 7; // 월요일 시작

            int total = DateTime.DaysInMonth(year, month);

            for (int day = 1; day <= total; day++)
            {
                int index = start + (day - 1);
                if (index < calender.Controls.Count)
                {
                    if (calender.Controls[index] is Button btn)
                    {
                        btn.Text = day.ToString();
                        btn.Tag = day;
                        btn.Click += Day_Click;
                        btn.Visible = true;

                        if (calender.GetPositionFromControl(btn).Column == 6)
                        {
                            btn.ForeColor = Color.IndianRed;
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
