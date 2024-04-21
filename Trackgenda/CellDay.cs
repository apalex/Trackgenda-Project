using System;
using System.Drawing;
using System.Windows.Forms;

namespace Trackgenda
{
    public partial class CellDay : UserControl
    {
        private int uid,month,day,year;
        private DatabaseConnection dbConn;
        private string date;
        public CellDay(int uid, int month, int day, int year)
        {
            UID = uid;
            Month = month;
            Day = day;
            Year = year;
            dbConn = new DatabaseConnection();
            dbConn.OpenConnection();
            InitializeComponent();
        }

        private int UID
        {
            get { return uid; }
            set { uid = value; }
        }

        private int Month
        {
            get { return month; }
            set { month = value; }
        }

        private int Day
        {
            get { return day; }
            set { day = value; }
        }

        private int Year
        {
            get { return year; }
            set { year = value; }
        }

        private void CellDay_MouseHover(object sender, EventArgs e)
        {
            this.BackColor = Color.Azure;
        }

        private void CellDay_MouseLeave(object sender, EventArgs e)
        {
            this.BackColor = Color.White;
        }

        private void CellDay_Load(object sender, EventArgs e)
        {
            if (month > 9)
            {
                date = $"{Month}/{Day}/{Year}";
            }
            else
            {
                date = $"0{Month}/{Day}/{Year}";
            }

            if (dbConn.getEventLength(uid,date) == 1)
            {
                event1Label.Text = dbConn.getEventDesc(uid, 0,date);
            }
            if (dbConn.getEventLength(uid,date) == 2)
            {
                event1Label.Text = dbConn.getEventDesc(uid, 0, date);
                event2Label.Text = dbConn.getEventDesc(uid, 1, date);
            }
            if (dbConn.getEventLength(uid, date) == 3)
            {
                event1Label.Text = dbConn.getEventDesc(uid, 0, date);
                event2Label.Text = dbConn.getEventDesc(uid, 1, date);
                event3Label.Text = dbConn.getEventDesc(uid, 2, date);
            }
        }

        public void days(int amtDay)
        {
            indexDay.Text = amtDay.ToString();
        }

        private void CellDay_Click(object sender, EventArgs e)
        {
            EventMonthlyForm form = new EventMonthlyForm(UID,Month,Day,Year);
            form.Show();
        }
    }
}
