using System;
using System.Drawing;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.Taskbar;

namespace Trackgenda
{
    public partial class CellDay : UserControl
    {
        private int uid,month,day,year;
        private DatabaseConnection dbConn;
        private string date;
        private string theme;
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
            if (theme == "Light")
            {
                this.BackColor = Color.Azure;
            }
            else
            {
                this.BackColor = Color.FromArgb(179, 179, 179);
            }
        }

        private void CellDay_MouseLeave(object sender, EventArgs e)
        {
            if (theme == "Light")
            {
                this.BackColor = Color.Azure;
            }
            else
            {
                this.BackColor = Color.FromArgb(64, 64, 64);
            }
        }

        private void CellDay_Load(object sender, EventArgs e)
        {
            theme = checkThemeMode();
            changeThemeMode();
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
            dbConn.CloseConnection();
        }

        public void days(int amtDay)
        {
            indexDay.Text = amtDay.ToString();
        }

        private void CellDay_Click(object sender, EventArgs e)
        {
            EventMonthlyForm form = new EventMonthlyForm(UID,Month,Day,Year,false,-1);
            form.Show();
        }

        private string checkThemeMode()
        {
            return dbConn.getUserTheme(uid);
        }

        private void event1Label_Click(object sender, EventArgs e)
        {
            if (event1Label.Text.Length == 0)
            {
                EventMonthlyForm form = new EventMonthlyForm(UID, Month, Day, Year, false, -1);
                form.Show();
            } else
            {
                EventMonthlyForm form = new EventMonthlyForm(UID, Month, Day, Year, true, 0);
                form.Show();
            }
        }

        private void event2Label_Click(object sender, EventArgs e)
        {
            if (event2Label.Text.Length == 0)
            {
                EventMonthlyForm form = new EventMonthlyForm(UID, Month, Day, Year, false, -1);
                form.Show();
            }
            else
            {
                EventMonthlyForm form = new EventMonthlyForm(UID, Month, Day, Year, true, 1);
                form.Show();
            }
        }

        private void event3Label_Click(object sender, EventArgs e)
        {
            if (event3Label.Text.Length == 0)
            {
                EventMonthlyForm form = new EventMonthlyForm(UID, Month, Day, Year, false, -1);
                form.Show();
            }
            else
            {
                EventMonthlyForm form = new EventMonthlyForm(UID, Month, Day, Year, true, 2);
                form.Show();
            }
        }

        private void changeThemeMode()
        {
            if (checkThemeMode() == "Light")
            {
                changeLightMode();
            }
            else
            {
                changeDarkMode();
            }
        }

        private void changeLightMode()
        {
            this.BackColor = Color.White;
            indexDay.BackColor = Color.White;
            indexDay.ForeColor = Color.Black;
            event1Label.BackColor = Color.White;
            event1Label.ForeColor = Color.Black;
            event2Label.BackColor = Color.White;
            event2Label.ForeColor = Color.Black;
            event3Label.BackColor = Color.White;
            event3Label.ForeColor = Color.Black;
        }

        private void changeDarkMode()
        {
            this.BackColor = Color.FromArgb(64, 64, 64);
            indexDay.BackColor = Color.FromArgb(64, 64, 64);
            indexDay.ForeColor = Color.White;
            event1Label.BackColor = Color.FromArgb(64, 64, 64); ;
            event1Label.ForeColor = Color.White;
            event2Label.BackColor = Color.FromArgb(64, 64, 64); ;
            event2Label.ForeColor = Color.White;
            event3Label.BackColor = Color.FromArgb(64, 64, 64); ;
            event3Label.ForeColor = Color.White;
        }
    }
}
