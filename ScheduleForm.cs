using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MyLoginForm
{
    public partial class ScheduleForm : Form
    {
        int month, year;
        private clsUser objUser; //create a clsUser object
        private HomePage hPage;

        public ScheduleForm()
        {
            InitializeComponent();
        }

        public ScheduleForm(clsUser user, HomePage h)
        {
            objUser = user;
            hPage = h;
            InitializeComponent();
        }

        private void ScheduleForm_Load(object sender, EventArgs e)
        {
            displayDays();
        }

        private void displayDays()
        {
            DateTime now = DateTime.Now;
            month = now.Month;
            year = now.Year;


            // Update the monthName and year 
            String monthName = DateTimeFormatInfo.CurrentInfo.GetMonthName(month);
            lblMonthDate.Text = monthName + " " + year;

            // Find the first day of the month
            DateTime startOfTheMonth = new DateTime(year, month, 1);

            // Find the amount of days in the month
            int days = DateTime.DaysInMonth(year, month);

            int dayOfTheWeek = Convert.ToInt32(startOfTheMonth.DayOfWeek.ToString("d")) + 1;

            // Create a blank userControl
            for(int i = 1; i < dayOfTheWeek; i++)
            {
                // Create an instance
                UserControlBlank UCBlank = new UserControlBlank();

                // Fill the calendar with days
                flpDayContainer.Controls.Add(UCBlank);
            }

            // Create a userControl for days
            for(int i = 1; i <= days; i++)
            {
                UserControlDays UCDays = new UserControlDays();
                UCDays.days(i);
                flpDayContainer.Controls.Add(UCDays);
            }

        }

        private void picPrevious_Click(object sender, EventArgs e)
        {
            // clear the previous calender month
            flpDayContainer.Controls.Clear();

            // When previous is clicked, go to the previous month(decerement)
            month--;

            // Check for jump to previous year
            if (month < 1)
            {
                month = 12;
                year--;
            }

            // Update the monthName and year 
            String monthName = DateTimeFormatInfo.CurrentInfo.GetMonthName(month);
            lblMonthDate.Text = monthName + " " + year;

            DateTime startOfTheMonth = new DateTime(year, month, 1);

            // Find the amount of days in the month
            int days = DateTime.DaysInMonth(year, month);

            int dayOfTheWeek = Convert.ToInt32(startOfTheMonth.DayOfWeek.ToString("d")) + 1;

            // Create a blank userControl
            for (int i = 1; i < dayOfTheWeek; i++)
            {
                // Create an instance
                UserControlBlank UCBlank = new UserControlBlank();

                // Fill the calendar with days
                flpDayContainer.Controls.Add(UCBlank);
            }

            // Create a userControl for days
            for (int i = 1; i <= days; i++)
            {
                UserControlDays UCDays = new UserControlDays();
                UCDays.days(i);
                flpDayContainer.Controls.Add(UCDays);
            }
        }

        private void picNext_Click(object sender, EventArgs e)
        {
            // clear the previous calender month
            flpDayContainer.Controls.Clear();

            // When next is clicked, go to the next month(increment)
            month++;

            // Check for jump to next year
            if(month > 12)
            {
                month = 1;
                year++;
            }

            // Update the monthName and year 
            String monthName = DateTimeFormatInfo.CurrentInfo.GetMonthName(month);
            lblMonthDate.Text = monthName + " " + year;

            DateTime startOfTheMonth = new DateTime(year, month, 1);

            // Find the amount of days in the month
            int days = DateTime.DaysInMonth(year, month);

            int dayOfTheWeek = Convert.ToInt32(startOfTheMonth.DayOfWeek.ToString("d")) + 1;

            // Create a blank userControl
            for (int i = 1; i < dayOfTheWeek; i++)
            {
                // Create an instance
                UserControlBlank UCBlank = new UserControlBlank();

                // Fill the calendar with days
                flpDayContainer.Controls.Add(UCBlank);
            }

            // Create a userControl for days
            for (int i = 1; i <= days; i++)
            {
                UserControlDays UCDays = new UserControlDays();
                UCDays.days(i);
                flpDayContainer.Controls.Add(UCDays);
            }
        }
    }
}
