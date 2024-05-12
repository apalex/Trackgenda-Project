using Mysqlx;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Globalization;
using System.Linq;
using System.Net.Mail;
using System.Runtime.InteropServices;
using System.Text;
using System.IO;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Trackgenda
{
    public partial class CalendarForm : Form
    {
        private int uid;
        private bool sidePanelShow = true;
        private BackgroundForm backgroundForm;
        private NotesForm notesForm;
        private DatabaseConnection dbConn;
        const int WS_MINIMIZEBOX = 0x20000;
        const int CS_DBLCLKS = 0x8;
        private static DateTime currentDT = DateTime.Now;
        private static int currentYear = currentDT.Year;
        private static int currentMonth = currentDT.Month;
        // Add Size Gripper to Form
        private const int WM_NCHITTEST = 0x84;
        private const int HTLEFT = 10;
        private const int HTRIGHT = 11;
        private const int HTTOP = 12;
        private const int HTTOPLEFT = 13;
        private const int HTTOPRIGHT = 14;
        private const int HTBOTTOM = 15;
        private const int HTBOTTOMLEFT = 16;
        private const int HTBOTTOMRIGHT = 17;
        // Bitmap Emoji's
        private Bitmap monthImage;
        private Bitmap weekImage;
        // Get Start of Week DateTime's
        private static DateTime sunday = DateTime.Today.AddDays(-(int)DateTime.Today.DayOfWeek);
        private static DateTime monday = DateTime.Today.AddDays(-(int)DateTime.Today.DayOfWeek + (int)DayOfWeek.Monday);
        private static DateTime tuesday = DateTime.Today.AddDays(-(int)DateTime.Today.DayOfWeek + (int)DayOfWeek.Tuesday);
        private static DateTime wednesday = DateTime.Today.AddDays(-(int)DateTime.Today.DayOfWeek + (int)DayOfWeek.Wednesday);
        private static DateTime thursday = DateTime.Today.AddDays(-(int)DateTime.Today.DayOfWeek + (int)DayOfWeek.Thursday);
        private static DateTime friday = DateTime.Today.AddDays(-(int)DateTime.Today.DayOfWeek + (int)DayOfWeek.Friday);
        private static DateTime saturday = DateTime.Today.AddDays(-(int)DateTime.Today.DayOfWeek + (int)DayOfWeek.Saturday);

        public CalendarForm(int uid)
        {
            this.uid = uid;
            this.DoubleBuffered = true;
            this.SetStyle(ControlStyles.ResizeRedraw, true);
            dbConn = new DatabaseConnection();
            dbConn.OpenConnection();
            InitializeComponent();
        }

        protected override CreateParams CreateParams
        {
            get
            {
                CreateParams cp = base.CreateParams;
                cp.Style |= WS_MINIMIZEBOX;
                cp.ClassStyle |= CS_DBLCLKS;
                return cp;
            }
        }

        private void XButton_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void maximizeButton_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Maximized;
        }

        private void minimizeButton_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        private void CalendarForm_MouseDown(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                DraggeableForms.Drag(this.Handle);
            }
        }

        private void CalendarForm_Load(object sender, EventArgs e)
        {
            Controls.OfType<MdiClient>().FirstOrDefault().BackColor = Color.White;
            this.Select();
            currentTimeTimer.Start();
            tabControl1.SelectedTab = calendarWeeklyTab;
            displayDays();
            displayWeekly();
            changeThemeMode();
        }

        private void currentTimeTimer_Tick(object sender, EventArgs e)
        {
            currentTimeLabel.Text = DateTime.Now.ToLongTimeString();
        }

        private void XButton_MouseHover(object sender, EventArgs e)
        {
            XButton.BackColor = Color.LightCoral;
        }

        private void XButton_MouseLeave(object sender, EventArgs e)
        {
            if (checkThemeMode() == "Light")
            {
                XButton.BackColor = Color.White;
            }
            else
            {
                XButton.BackColor = Color.FromArgb(179, 179, 179);
            }
        }

        private void maximizeButton_MouseHover(object sender, EventArgs e)
        {
            maximizeButton.BackColor = Color.LightCoral;
        }

        private void maximizeButton_MouseLeave(object sender, EventArgs e)
        {
            if (checkThemeMode() == "Light")
            {
                maximizeButton.BackColor = Color.White;
            }
            else
            {
                maximizeButton.BackColor = Color.FromArgb(179, 179, 179);
            }
        }

        private void minimizeButton_MouseHover(object sender, EventArgs e)
        {
            minimizeButton.BackColor = Color.LightCoral;
        }

        private void minimizeButton_MouseLeave(object sender, EventArgs e)
        {
            if (checkThemeMode() == "Light")
            {
                minimizeButton.BackColor = Color.White;
            }
            else
            {
                minimizeButton.BackColor = Color.FromArgb(179,179,179);
            }
        }

        private void panel1_MouseDown(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                DraggeableForms.Drag(this.Handle);
            }
        }

        private void hamburgerPictureBox_Click(object sender, EventArgs e)
        {
            if (sidePanelShow)
            {
                sidePanel.Hide();
                sidePanelShow = !sidePanelShow;
            } else
            {
                sidePanel.Show();
                sidePanelShow = !sidePanelShow;
            }
        }

        private void stopwatchButton_Click(object sender, EventArgs e)
        {
            StopwatchForm form = new StopwatchForm(uid);
            form.Show();
        }

        private void factButton_Click(object sender, EventArgs e)
        {
            FactForm form = new FactForm(uid);
            form.Show();
        }

        private void motivationalButton_Click(object sender, EventArgs e)
        {
            MotivionalQuoteForm form = new MotivionalQuoteForm(uid);
            form.Show();
        }

        private void exitButton_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void logoutButton_Click(object sender, EventArgs e)
        {
            LoginForm form = new LoginForm();
            this.Close();
            form.Show();
        }

        private void studyButton_Click(object sender, EventArgs e)
        {
            StudyDashboard form = new StudyDashboard(uid);
            form.Show();
        }

        protected override void WndProc(ref Message m)
        {
            base.WndProc(ref m);

            if (m.Msg == WM_NCHITTEST)
            {
                Point cursor = this.PointToClient(Cursor.Position);

                if (cursor.X <= 5)
                {
                    if (cursor.Y <= 5)
                        m.Result = (IntPtr)HTTOPLEFT;
                    else if (cursor.Y >= this.ClientSize.Height - 5)
                        m.Result = (IntPtr)HTBOTTOMLEFT;
                    else
                        m.Result = (IntPtr)HTLEFT;
                }
                else if (cursor.X >= this.ClientSize.Width - 5)
                {
                    if (cursor.Y <= 5)
                        m.Result = (IntPtr)HTTOPRIGHT;
                    else if (cursor.Y >= this.ClientSize.Height - 5)
                        m.Result = (IntPtr)HTBOTTOMRIGHT;
                    else
                        m.Result = (IntPtr)HTRIGHT;
                }
                else if (cursor.Y <= 5)
                {
                    m.Result = (IntPtr)HTTOP;
                }
                else if (cursor.Y >= this.ClientSize.Height - 5)
                {
                    m.Result = (IntPtr)HTBOTTOM;
                }
            }
        }

        private void dashboardButton_Click(object sender, EventArgs e)
        {
            tabControl1.SelectedTab = calendarWeeklyTab;
        }

        private void displayDays()
        {
            DateTime startMonth = new DateTime(currentYear, currentMonth, 1);
            int amtDays = DateTime.DaysInMonth(currentYear, currentMonth);
            int dayOfWeek = Convert.ToInt32(startMonth.DayOfWeek.ToString("d")) + 1;
            dateLabel.Text = $"{DateTimeFormatInfo.CurrentInfo.GetMonthName(currentMonth)} {currentYear}";
            changeImage(currentMonth);

            int cellsUsed = 0;
            for (int i = 1; i < dayOfWeek; i++)
            {
                cellsUsed++;
                EmptyCell cd = new EmptyCell(uid);
                monthlyPanel.Controls.Add(cd);
            }

            for (int i = 1; i <= amtDays; i++)
            {
                cellsUsed++;
                CellDay ucd = new CellDay(uid,currentMonth,i,currentYear);
                ucd.days(i);
                monthlyPanel.Controls.Add(ucd);
            }

            for (int i = 0; i < 42 - cellsUsed; i++)
            {
                EmptyCell cd = new EmptyCell(uid);
                cd.Width = 202;
                monthlyPanel.Controls.Add(cd);
            }
        }

        private void changeImage(int month)
        {
            switch (month)
            {
                case 1:
                    monthImage = Properties.Resources.january;
                    break;
                case  2:
                    monthImage = Properties.Resources.february;
                    break;
                case 3:
                    monthImage = Properties.Resources.march;
                    break;
                case 4:
                    monthImage = Properties.Resources.april;
                    break;
                case 5:
                    monthImage = Properties.Resources.may;
                    break;
                case 6:
                    monthImage = Properties.Resources.june;
                    break;
                case 7:
                    monthImage = Properties.Resources.july;
                    break;
                case 8:
                    monthImage = Properties.Resources.august;
                    break;
                case 9:
                    monthImage = Properties.Resources.september;
                    break;
                case 10:
                    monthImage = Properties.Resources.october;
                    break;
                case 11:
                    monthImage = Properties.Resources.november;
                    break;
                case 12:
                    monthImage = Properties.Resources.december;
                    break;
            }
            monthPictureBox.Image = monthImage;
        }

        private void nextButton_Click(object sender, EventArgs e)
        {
            monthlyPanel.Controls.Clear();
            currentMonth = ++currentMonth;
            if (currentMonth > 12)
            {
                currentMonth = 1;
                currentYear++;
            }
            displayDays();
        }

        private void previousButton_Click(object sender, EventArgs e)
        {
            monthlyPanel.Controls.Clear();
            currentMonth = --currentMonth;
            if (currentMonth == 0)
            {
                currentMonth = 12;
                currentYear--;
            }
            displayDays();
        }

        private void backgroundButton_Click(object sender, EventArgs e)
        {
            backgroundForm = new BackgroundForm(uid);
            backgroundForm.Show();
        }

        private void todoButton_Click(object sender, EventArgs e)
        {
            TODOForm form = new TODOForm(uid);
            form.Show();
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
            } else
            {
                changeDarkMode();
            }
        }

        private void changeLightMode()
        {
            // Upper Bar
            hamburgerPictureBox.BackColor = Color.White;
            logoLabel.ForeColor = Color.Black;
            upperBar.BackColor = Color.White;
            upperBar.ForeColor = Color.Black;
            currentTimeLabel.ForeColor = Color.Black;
            minimizeButton.BackColor = Color.White;
            minimizeButton.ForeColor = Color.Black;
            maximizeButton.BackColor = Color.White;
            maximizeButton.ForeColor = Color.Black;
            XButton.BackColor = Color.White;
            XButton.ForeColor = Color.Black;
            // Side Panel
            sidePanel.ForeColor = Color.Black;
            sidePanel.BackColor = Color.White;
            sideLogoPicture.BackColor = Color.White;
            dashboardButton.BackColor = Color.White;
            dashboardButton.ForeColor = Color.Black;
            todoButton.BackColor = Color.White;
            todoButton.ForeColor = Color.Black;
            studyButton.ForeColor = Color.Black;
            studyButton.BackColor = Color.White;
            stopwatchButton.BackColor = Color.White;
            stopwatchButton.ForeColor = Color.Black;
            notesButton.BackColor = Color.White;
            notesButton.ForeColor = Color.Black;
            motivationalButton.BackColor = Color.White;
            motivationalButton.ForeColor = Color.Black;
            factButton.BackColor = Color.White;
            factButton.ForeColor = Color.Black;
            backgroundButton.ForeColor = Color.Black;
            backgroundButton.BackColor = Color.White;
            settingsButton.BackColor = Color.White;
            settingsButton.ForeColor = Color.Black;
            logoutButton.ForeColor = Color.Black;
            logoutButton.BackColor = Color.White;
            exitButton.BackColor = Color.White;
            exitButton.ForeColor = Color.Black;
            // Background Tabs
            checkFileBackground();
        }

        private void changeDarkMode()
        {
            // Upper Bar
            hamburgerPictureBox.BackColor = Color.FromArgb(18, 18, 18);
            logoLabel.ForeColor = Color.White;
            upperBar.BackColor = Color.FromArgb(18, 18, 18);
            upperBar.ForeColor = Color.Black;
            currentTimeLabel.ForeColor = Color.White;
            minimizeButton.BackColor = Color.FromArgb(179, 179, 179);
            minimizeButton.ForeColor = Color.White;
            maximizeButton.BackColor = Color.FromArgb(179, 179, 179);
            maximizeButton.ForeColor = Color.White;
            XButton.BackColor = Color.FromArgb(179, 179, 179);
            XButton.ForeColor = Color.White;
            // Side Panel
            sidePanel.ForeColor = Color.Black;
            sidePanel.BackColor = Color.FromArgb(18, 18, 18);
            sideLogoPicture.BackColor = Color.FromArgb(18, 18, 18);
            dashboardButton.BackColor = Color.FromArgb(33, 33, 33);
            dashboardButton.ForeColor = Color.White;
            todoButton.BackColor = Color.FromArgb(33, 33, 33);
            todoButton.ForeColor = Color.White;
            studyButton.ForeColor = Color.White;
            studyButton.BackColor = Color.FromArgb(33, 33, 33);
            stopwatchButton.BackColor = Color.FromArgb(33, 33, 33);
            stopwatchButton.ForeColor = Color.White;
            notesButton.BackColor = Color.FromArgb(33, 33, 33);
            notesButton.ForeColor = Color.White;
            motivationalButton.BackColor = Color.FromArgb(33, 33, 33);
            motivationalButton.ForeColor = Color.White;
            factButton.BackColor = Color.FromArgb(33, 33, 33);
            factButton.ForeColor = Color.White;
            backgroundButton.ForeColor = Color.White;
            backgroundButton.BackColor = Color.FromArgb(33, 33, 33);
            settingsButton.BackColor = Color.FromArgb(33, 33, 33);
            settingsButton.ForeColor = Color.White;
            logoutButton.ForeColor = Color.White;
            logoutButton.BackColor = Color.FromArgb(33, 33, 33);
            exitButton.BackColor = Color.FromArgb(33, 33, 33);
            exitButton.ForeColor = Color.White;
            // Background Tabs
            checkFileBackground();
        }

        private void checkFileBackground()
        {
            string path = dbConn.getBackgroundPath(uid);
            if (path.Length > 0)
            {
                if (File.Exists(path))
                {
                    Bitmap image = (Bitmap)Image.FromFile(path);
                    image = new Bitmap(image, monthlyCalendarTab.Width, monthlyCalendarTab.Height);
                    monthlyCalendarTab.BackgroundImage = image;
                    monthlyCalendarTab.BackColor = Color.Transparent;
                    settingsTab.BackgroundImage = image;
                    settingsTab.BackColor = Color.Transparent;
                    calendarWeeklyTab.BackgroundImage = image;
                    calendarWeeklyTab.BackColor = Color.Transparent;
                } else
                {
                    changeTabsTheme();
                }
            } else
            {
                changeTabsTheme();
            }
        }

        private void changeTabsTheme()
        {
            if (checkThemeMode() == "Light")
            {
                // Monthly
                monthlyCalendarTab.BackColor = Color.White;
                nextButton.BackColor = Color.White;
                nextButton.ForeColor = Color.Black;
                previousButton.BackColor = Color.White;
                previousButton.ForeColor = Color.Black;
                weeklyButton.BackColor = Color.White;
                weeklyButton.ForeColor = Color.Black;
                dateLabel.ForeColor = Color.Black;
                label1.ForeColor = Color.Black;
                label2.ForeColor = Color.Black;
                label4.ForeColor = Color.Black;
                label5.ForeColor = Color.Black;
                label6.ForeColor = Color.Black;
                label7.ForeColor = Color.Black;
                label8.ForeColor = Color.Black;
                // Settings
                settingsTab.BackColor = Color.White;
                label9.ForeColor = Color.Black;
                label21.ForeColor = Color.Black;
                label22.ForeColor = Color.Black;
                label23.ForeColor = Color.Black;
                lightRadioButton.ForeColor = Color.Black;
                darkRadioButton.ForeColor = Color.Black;
                // Weekly
                calendarWeeklyTab.BackColor = Color.White;
                nextWeeklyButton.BackColor = Color.White;
                nextWeeklyButton.ForeColor = Color.Black;
                previousWeeklyButton.BackColor = Color.White;
                previousWeeklyButton.ForeColor = Color.Black;
                monthlyButton.BackColor = Color.White;
                monthlyButton.ForeColor = Color.Black;
                weeklyDisplayLabel.ForeColor = Color.Black;
                sundayLabel.ForeColor = Color.Black;
                sundayDateLabel.ForeColor = Color.Black;
                mondayLabel.ForeColor = Color.Black;
                mondayDateLabel.ForeColor = Color.Black;
                tuesdayLabel.ForeColor = Color.Black;
                tuesdayDateLabel.ForeColor = Color.Black;
                wednesdayLabel.ForeColor = Color.Black;
                wednesdayDateLabel.ForeColor = Color.Black;
                thursdayLabel.ForeColor = Color.Black;
                thursdayDateLabel.ForeColor = Color.Black;
                fridayLabel.ForeColor = Color.Black;
                fridayDateLabel.ForeColor = Color.Black;
                saturdayLabel.ForeColor = Color.Black;
                saturdayDateLabel.ForeColor = Color.Black;
                label10.ForeColor = Color.Black;
                label11.ForeColor = Color.Black;
                label12.ForeColor = Color.Black;
                label13.ForeColor = Color.Black;
                label14.ForeColor = Color.Black;
                label15.ForeColor = Color.Black;
                label16.ForeColor = Color.Black;
                label17.ForeColor = Color.Black;
                label18.ForeColor = Color.Black;
                label19.ForeColor = Color.Black;
                label20.ForeColor = Color.Black;
            } else
            {
                // Monthly
                monthlyCalendarTab.BackColor = Color.FromArgb(24, 24, 24);
                nextButton.BackColor = Color.FromArgb(33, 33, 33);
                nextButton.ForeColor = Color.White;
                previousButton.BackColor = Color.FromArgb(33, 33, 33);
                previousButton.ForeColor = Color.White;
                weeklyButton.BackColor = Color.FromArgb(33, 33, 33);
                weeklyButton.ForeColor = Color.White;
                dateLabel.ForeColor = Color.White;
                label1.ForeColor = Color.White;
                label2.ForeColor = Color.White;
                label4.ForeColor = Color.White;
                label5.ForeColor = Color.White;
                label6.ForeColor = Color.White;
                label7.ForeColor = Color.White;
                label8.ForeColor = Color.White;
                // Settings
                settingsTab.BackColor = Color.FromArgb(24, 24, 24);
                label9.ForeColor = Color.White;
                label21.ForeColor = Color.White;
                label22.ForeColor = Color.White;
                label23.ForeColor = Color.White;
                lightRadioButton.ForeColor = Color.White;
                darkRadioButton.ForeColor = Color.White;
                // Weekly
                calendarWeeklyTab.BackColor = Color.FromArgb(24, 24, 24);
                nextWeeklyButton.BackColor = Color.FromArgb(33, 33, 33);
                nextWeeklyButton.ForeColor = Color.White;
                previousWeeklyButton.BackColor = Color.FromArgb(33, 33, 33);
                previousWeeklyButton.ForeColor = Color.White;
                monthlyButton.BackColor = Color.FromArgb(33, 33, 33);
                monthlyButton.ForeColor = Color.White;
                weeklyDisplayLabel.ForeColor = Color.White;
                sundayLabel.ForeColor = Color.White;
                sundayDateLabel.ForeColor = Color.White;
                mondayLabel.ForeColor = Color.White;
                mondayDateLabel.ForeColor = Color.White;
                tuesdayLabel.ForeColor = Color.White;
                tuesdayDateLabel.ForeColor = Color.White;
                wednesdayLabel.ForeColor = Color.White;
                wednesdayDateLabel.ForeColor = Color.White;
                thursdayLabel.ForeColor = Color.White;
                thursdayDateLabel.ForeColor = Color.White;
                fridayLabel.ForeColor = Color.White;
                fridayDateLabel.ForeColor = Color.White;
                saturdayLabel.ForeColor = Color.White;
                saturdayDateLabel.ForeColor = Color.White;
                label10.ForeColor = Color.White;
                label11.ForeColor = Color.White;
                label12.ForeColor = Color.White;
                label13.ForeColor = Color.White;
                label14.ForeColor = Color.White;
                label15.ForeColor = Color.White;
                label16.ForeColor = Color.White;
                label17.ForeColor = Color.White;
                label18.ForeColor = Color.White;
                label19.ForeColor = Color.White;
                label20.ForeColor = Color.White;
            }
        }

        private void displayWeekly()
        {
            updateDateLabels();
            changeImageWeekly();
            int cellsUsed = 0;
            DateTime[] daysOfWeek = { sunday, monday, tuesday, wednesday, thursday, friday, saturday };
            for (int i = 0; i < 77; i++)
            {
                cellsUsed++;
                string date;
                int dayIndex = i % 7;
                date = dateAssign(daysOfWeek[dayIndex].Month, daysOfWeek[dayIndex].Day, daysOfWeek[dayIndex].Year);
                CellWeekly cw = new CellWeekly(uid, date, i);
                weeklyPanel.Controls.Add(cw);
            }
        }

        private string dateAssign(int month, int day, int year)
        {
            string formattedMonth = (month < 10) ? $"0{month}" : $"{month}";
            string formattedDay = (day < 10) ? $"0{day}" : $"{day}";
            return $"{formattedMonth}/{formattedDay}/{year}";
        }

        private void changeImageWeekly()
        {
            switch (sunday.Month)
            {
                case 1:
                    weekImage = Properties.Resources.january;
                    break;
                case 2:
                    weekImage = Properties.Resources.february;
                    break;
                case 3:
                    weekImage = Properties.Resources.march;
                    break;
                case 4:
                    weekImage = Properties.Resources.april;
                    break;
                case 5:
                    weekImage = Properties.Resources.may;
                    break;
                case 6:
                    weekImage = Properties.Resources.june;
                    break;
                case 7:
                    weekImage = Properties.Resources.july;
                    break;
                case 8:
                    weekImage = Properties.Resources.august;
                    break;
                case 9:
                    weekImage = Properties.Resources.september;
                    break;
                case 10:
                    weekImage = Properties.Resources.october;
                    break;
                case 11:
                    weekImage = Properties.Resources.november;
                    break;
                case 12:
                    weekImage = Properties.Resources.december;
                    break;
            }
            weekPictureBox.Image = weekImage;
        }

        private void monthlyButton_Click(object sender, EventArgs e)
        {
            tabControl1.SelectedTab = monthlyCalendarTab;
        }

        private void weeklyButton_Click(object sender, EventArgs e)
        {
            tabControl1.SelectedTab = calendarWeeklyTab;
        }

        private void nextWeeklyButton_Click(object sender, EventArgs e)
        {
            weeklyPanel.Controls.Clear();
            sunday = sunday.AddDays(7);
            monday = monday.AddDays(7);
            tuesday = tuesday.AddDays(7);
            wednesday = wednesday.AddDays(7);
            thursday = thursday.AddDays(7);
            friday = friday.AddDays(7);
            saturday = saturday.AddDays(7);
            displayWeekly();
        }

        private void previousWeeklyButton_Click(object sender, EventArgs e)
        {
            weeklyPanel.Controls.Clear();
            sunday = sunday.AddDays(-7);
            monday = monday.AddDays(-7);
            tuesday = tuesday.AddDays(-7);
            wednesday = wednesday.AddDays(-7);
            thursday = thursday.AddDays(-7);
            friday = friday.AddDays(-7);
            saturday = saturday.AddDays(-7);
            displayWeekly();
        }
    
        private void updateDateLabels()
        {
            sundayDateLabel.Text = $"{sunday.Month:00}/{sunday.Day:00}/{sunday.Year}";
            mondayDateLabel.Text = $"{monday.Month:00}/{monday.Day:00}/{monday.Year}";
            tuesdayDateLabel.Text = $"{tuesday.Month:00}/{tuesday.Day:00}/{tuesday.Year}";
            wednesdayDateLabel.Text = $"{wednesday.Month:00}/{wednesday.Day:00}/{wednesday.Year}";
            thursdayDateLabel.Text = $"{thursday.Month:00}/{thursday.Day:00}/{thursday.Year}";
            fridayDateLabel.Text = $"{friday.Month:00}/{friday.Day:00}/{friday.Year}";
            saturdayDateLabel.Text = $"{saturday.Month:00}/{saturday.Day:00}/{saturday.Year}";
            weeklyDisplayLabel.Text = $"{DateTimeFormatInfo.CurrentInfo.GetMonthName(sunday.Month)} {sunday.Year}";
        }

        private void currentEmailTextBox_Enter(object sender, EventArgs e)
        {
            if (currentEmailTextBox.Text == "Current Email")
            {
                currentEmailTextBox.Text = "";
                currentEmailTextBox.ForeColor = Color.Black;
            }
        }

        private void currentEmailTextBox_Leave(object sender, EventArgs e)
        {
            if (currentEmailTextBox.Text == "")
            {
                currentEmailTextBox.Text = "Current Email";
                currentEmailTextBox.ForeColor = Color.DarkGray;
            }
        }

        private void newEmailTextBox_Enter(object sender, EventArgs e)
        {
            if (newEmailTextBox.Text == "New Email")
            {
                newEmailTextBox.Text = "";
                newEmailTextBox.ForeColor = Color.Black;
            }
        }

        private void newEmailTextBox_Leave(object sender, EventArgs e)
        {
            if (newEmailTextBox.Text == "")
            {
                newEmailTextBox.Text = "New Email";
                newEmailTextBox.ForeColor = Color.DarkGray;
            }
        }

        private void currentPasswordTextBox_Enter(object sender, EventArgs e)
        {
            if (currentPasswordTextBox.Text == "Current Password")
            {
                currentPasswordTextBox.Text = "";
                currentPasswordTextBox.ForeColor = Color.Black;
                currentPasswordTextBox.PasswordChar = '*';
            }
        }

        private void currentPasswordTextBox_Leave(object sender, EventArgs e)
        {
            if (currentPasswordTextBox.Text == "")
            {
                currentPasswordTextBox.Text = "Current Password";
                currentPasswordTextBox.ForeColor = Color.DarkGray;
                currentPasswordTextBox.PasswordChar = '\0';
            }
        }

        private void newPasswordTextBox_Enter(object sender, EventArgs e)
        {
            if (newPasswordTextBox.Text == "New Password")
            {
                newPasswordTextBox.Text = "";
                newPasswordTextBox.ForeColor = Color.Black;
                newPasswordTextBox.PasswordChar = '*';
            }
        }

        private void newPasswordTextBox_Leave(object sender, EventArgs e)
        {
            if (newPasswordTextBox.Text == "")
            {
                newPasswordTextBox.Text = "New Password";
                newPasswordTextBox.ForeColor = Color.DarkGray;
                newPasswordTextBox.PasswordChar = '\0';
            }
        }

        private void updateEmailButton_Click(object sender, EventArgs e)
        {
            string error = "";
            if (!dbConn.checkExistEmail(uid,currentEmailTextBox.Text))
            {
                error += "Please enter your current Email!";
            }
            if (!isValidEmailAddress(newEmailTextBox.Text))
            {
                error += "\nPlease enter a valid new Email!";
            }
            if (error.Length == 0)
            {
                if (dbConn.updateEmail(uid,newEmailTextBox.Text))
                {
                    MessageBox.Show("Email has been successfully updated!");
                    CalendarForm form = new CalendarForm(uid);
                    form.Show();
                    dbConn.CloseConnection();
                    this.Close();
                }
            } else
            {
                MessageBox.Show(error, "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private bool isValidEmailAddress(string email)
        {
            try
            {
                MailAddress mailAddress = new MailAddress(email);
                return true;
            }
            catch
            {
                return false;
            }
        }

        private void confirmPasswordTextBox_Click(object sender, EventArgs e)
        {
            string error = "";
            if (!dbConn.checkPassword(uid, currentPasswordTextBox.Text))
            {
                error += "Please enter your current Password correctly";
            }
            if (!Regex.Match(newPasswordTextBox.Text, "^(?=.*[a-z])(?=.*[A-Z])(?=.*\\d)(?=.*[@$!%*?&])[A-Za-z\\d@$!%*?&]{8,}$").Success)
            {
                if (newPasswordTextBox.TextLength == 0)
                {
                    error += "\nNew Password is required";
                }
                else
                {
                    error += "\nPassword minimum eight characters, at least one uppercase \nletter, one lowercase letter, one number \nand one special character";
                }
            }
            if (error.Length == 0)
            {
                if (dbConn.updatePassword(uid, newPasswordTextBox.Text))
                {
                    MessageBox.Show("Password has been successfully updated!");
                    CalendarForm form = new CalendarForm(uid);
                    form.Show();
                    dbConn.CloseConnection();
                    this.Close();
                }
            } else
            {
                MessageBox.Show(error, "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void changeThemeButton_Click(object sender, EventArgs e)
        {
            if (lightRadioButton.Checked)
            {
                dbConn.changeTheme(uid, "Light");
                dbConn.CloseConnection();
                CalendarForm form = new CalendarForm(uid);
                form.Show();
                this.Close();
            } else if (darkRadioButton.Checked)
            {
                dbConn.changeTheme(uid, "Dark");
                dbConn.CloseConnection();
                CalendarForm form = new CalendarForm(uid);
                form.Show();
                this.Close();

            } else
            {
                MessageBox.Show("Please select a theme!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void settingsButton_Click(object sender, EventArgs e)
        {
            tabControl1.SelectedTab = settingsTab;
            exitButton.Select();
        }

        private void notesButton_Click(object sender, EventArgs e)
        {
            notesForm = new NotesForm(uid);
            notesForm.Show();
        }

        private void studyTextBox_Enter(object sender, EventArgs e)
        {
            if (studyTextBox.Text == "Study Time")
            {
                studyTextBox.Text = "";
                studyTextBox.ForeColor = Color.Black;
            }
        }

        private void studyTextBox_Leave(object sender, EventArgs e)
        {
            if (studyTextBox.Text == "")
            {
                studyTextBox.Text = "Study Time";
                studyTextBox.ForeColor = Color.DarkGray;
            }
        }

        private void shortTextBox_Enter(object sender, EventArgs e)
        {
            if (shortTextBox.Text == "Short Break")
            {
                shortTextBox.Text = "";
                shortTextBox.ForeColor = Color.Black;
            }
        }

        private void shortTextBox_Leave(object sender, EventArgs e)
        {
            if (shortTextBox.Text == "")
            {
                shortTextBox.Text = "Study Time";
                shortTextBox.ForeColor = Color.DarkGray;
            }
        }

        private void longTextBox_Leave(object sender, EventArgs e)
        {
            if (longTextBox.Text == "")
            {
                longTextBox.Text = "Study Time";
                longTextBox.ForeColor = Color.DarkGray;
            }
        }

        private void longTextBox_Enter(object sender, EventArgs e)
        {
            if (longTextBox.Text == "Long Break")
            {
                longTextBox.Text = "";
                longTextBox.ForeColor = Color.Black;
            }
        }

        private void confirmStudyButton_Click(object sender, EventArgs e)
        {
            if (studyTextBox.TextLength > 0 && shortTextBox.TextLength > 0 && longTextBox.TextLength > 0)
            {
                if (int.TryParse(studyTextBox.Text, out _) && int.TryParse(shortTextBox.Text, out _) && int.TryParse(longTextBox.Text, out _))
                {
                    // Insert New Record if not Exist
                    if (!dbConn.checkExistStudy(uid))
                    {
                        if (dbConn.addPersonalStudy(uid,Int32.Parse(studyTextBox.Text),Int32.Parse(shortTextBox.Text),Int32.Parse(longTextBox.Text)))
                        {
                            MessageBox.Show("Personal Study Time Successfully Set!");
                        }
                    }
                    // Update existing Record if Exist
                    else
                    {
                        if (dbConn.updatePersonalStudy(uid, Int32.Parse(studyTextBox.Text), Int32.Parse(shortTextBox.Text), Int32.Parse(longTextBox.Text)))
                        {
                            MessageBox.Show("Personal Study Time Successfully Set!");
                        }
                    }
                } else
                {
                    MessageBox.Show("Please make sure to enter only number's with no decimal's!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
            } else
            {
                MessageBox.Show("Please enter all times for personal study!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }
    }
}
