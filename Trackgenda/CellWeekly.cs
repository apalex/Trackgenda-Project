using System;
using System.Drawing;
using System.Windows.Forms;

namespace Trackgenda
{
    public partial class CellWeekly : UserControl
    {
        private int uid,indexVal;
        private DatabaseConnection dbConn;
        private string date, theme;

        public CellWeekly(int uid, string date, int indexVal)
        {
            UID = uid;
            Date = date;
            IndexVal = indexVal;
            dbConn = new DatabaseConnection();
            dbConn.OpenConnection();
            InitializeComponent();
        }

        private int UID
        {
            get { return uid; }
            set { uid = value; }
        }

        private string Date
        {
            get { return date; }
            set { date = value; }
        }

        private int IndexVal
        {
            get { return indexVal; }
            set { indexVal = value; }
        }

        private void CellWeekly_MouseHover(object sender, EventArgs e)
        {
            // Make a if else statement to check if exist in db, and if it does, then get the background color from db
            if (theme == "Light")
            {
                this.BackColor = Color.Azure;
            } else
            {
                this.BackColor = Color.FromArgb(179, 179, 179);
            }
        }

        private void CellWeekly_MouseLeave(object sender, EventArgs e)
        {
            if (theme == "Light")
            {
                this.BackColor = Color.White;
            } else
            {
                this.BackColor = Color.FromArgb(64, 64, 64);
            }
            //this.BackColor = Color.FromName(dbConn.getWeeklyBackground(uid));
        }

        private void CellWeekly_Click(object sender, EventArgs e)
        {
            EventWeeklyForm form = new EventWeeklyForm(uid, $"{Date} | {getTime()}", IndexVal);
            form.Show();
        }

        private void CellWeekly_Load(object sender, EventArgs e)
        {
            theme = checkThemeMode();
            changeThemeMode();
            if (dbConn.checkExistWeeklyEvent(UID,$"{date} | {getTime()}"))
            {
                eventDisplayLabel.Text = dbConn.getWeeklyEventDesc(uid,$"{date} | {getTime()}");
            } else
            {
                eventDisplayLabel.Text = "";
            }
            //this.BackColor = Color.FromName(dbConn.getWeeklyBackground(uid));
            dbConn.CloseConnection();
        }

        private string checkThemeMode()
        {
            return dbConn.getUserTheme(uid);
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

        private void eventDisplayLabel_Click(object sender, EventArgs e)
        {
            EventWeeklyForm form = new EventWeeklyForm(UID, $"{Date} | {getTime()}", IndexVal);
            form.Show();
        }

        private void eventDisplayLabel_MouseHover(object sender, EventArgs e)
        {
            // Make a if else statement to check if exist in db, and if it does, then get the background color from db
            if (theme == "Light")
            {
                this.BackColor = Color.Azure;
            }
            else
            {
                this.BackColor = Color.FromArgb(179, 179, 179);
            }
        }

        private void eventDisplayLabel_MouseLeave(object sender, EventArgs e)
        {
            if (theme == "Light")
            {
                this.BackColor = Color.White;
            }
            else
            {
                this.BackColor = Color.FromArgb(64, 64, 64);
            }
            //this.BackColor = Color.FromName(dbConn.getWeeklyBackground(uid));
        }

        private void changeLightMode()
        {
            this.BackColor = Color.White;
            eventDisplayLabel.ForeColor = Color.Black;
        }

        private void changeDarkMode()
        {
            this.BackColor = Color.FromArgb(64, 64, 64);
            eventDisplayLabel.ForeColor = Color.White;
        }

        private string getTime()
        {
            // 9 AM
            if (IndexVal >= 0 && IndexVal < 7)
            {
                return "9:00";
            }
            // 10 AM
            else if (IndexVal > 6 && IndexVal < 14)
            {
                return "10:00";
            }
            // 11 AM
            else if (IndexVal > 13 && IndexVal < 21)
            {
                return "11:00";
            }
            // 12 PM
            else if (IndexVal > 20 && IndexVal < 28)
            {
                return "12:00";
            }
            // 1 PM
            else if (IndexVal > 27 && IndexVal < 35)
            {
                return "13:00";
            }
            // 2 PM
            else if (IndexVal > 34 && IndexVal < 42)
            {
                return "14:00";
            }
            // 3 PM
            else if (IndexVal > 41 && IndexVal < 49)
            {
                return "15:00";
            }
            // 4 PM
            else if (IndexVal > 48 && IndexVal < 56)
            {
                return "16:00";
            }
            // 5 PM
            else if (IndexVal > 55 && IndexVal < 63)
            {
                return "17:00";
            }
            // 6 PM
            else if (IndexVal > 62 && IndexVal < 70)
            {
                return "18:00";
            }
            // 7 PM
            else
            {
                return "19:00";
            }
        }
    }
}
