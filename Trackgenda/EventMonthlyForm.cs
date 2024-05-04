using Mysqlx;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Windows.Forms;

namespace Trackgenda
{
    public partial class EventMonthlyForm : Form
    {
        private int uid, month, day, year, indexDay;
        private string date;
        private bool empty;
        private DatabaseConnection dbConn;
        public EventMonthlyForm(int uid, int month,int day,int year,bool empty,int indexDay)
        {
            UID = uid;
            Month = month;
            Day = day;
            Year = year;
            Empty = empty;
            IndexDay = indexDay;
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

        private bool Empty
        {
            get { return empty; }
            set { empty = value; }
        }

        private int IndexDay
        {
            get { return indexDay; }
            set { indexDay = value; }
        }

        private void editButton_Click(object sender, EventArgs e)
        {
            List<Form> forms = new List<Form>();
            string color = (string)colourComboBox.SelectedItem.ToString();
            if (dbConn.setEventDesc(UID,IndexDay,date,descTextBox.Text, color) && descTextBox.Text.Length > 0)
            {
                dbConn.CloseConnection();
                MessageBox.Show("Event successfully edited!");
                foreach (Form f in Application.OpenForms)
                    if (f.Name == "CalendarForm")
                        forms.Add(f);
                foreach (Form f in forms)
                    f.Close();
                CalendarForm calendarForm = new CalendarForm(UID);
                calendarForm.Show();
                this.Close();
            } else
            {
                MessageBox.Show("Please enter an event!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void EventMonthlyForm_MouseDown(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                DraggeableForms.Drag(this.Handle);
            }
        }

        private void exitButton_Click(object sender, EventArgs e)
        {
            dbConn.CloseConnection();
            this.Close();
        }

        private void EventMonthlyForm_Load(object sender, EventArgs e)
        {
            uid = UID;
            date = $"{Month:00}/{Day:00}/{Year}";
            dateLabel.Text = date;
            changeThemeMode();
            colourComboBox.SelectedIndex = 0;

            // Set a maximum of 3 events that can be saved in one cell
            if (dbConn.getEventLength(uid, date) > 2 && empty == false)
            {
                maximumLabel.Visible = true;
                descTextBox.ReadOnly = true;
                addButton.Enabled = false;
            } else
            {
                maximumLabel.Visible = false;
            }

            // If User clicks on label to edit/remove
            if (empty == true)
            {
                editButton.Visible = true;
                addButton.Visible = false;
                descTextBox.Text = dbConn.getEventDesc(uid, IndexDay, date);
            }
        }

        private void saveButton_Click(object sender, EventArgs e)
        {
            List<Form> forms = new List<Form>();
            string color = (string)colourComboBox.SelectedItem.ToString();
            if (dbConn.addMonthlyEvent(uid,date,descTextBox.Text,color))
            {
                MessageBox.Show("Event successfully added!");
            } else
            {
                MessageBox.Show("Error whilst saving the event!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            dbConn.CloseConnection();
            foreach (Form f in Application.OpenForms)
                if (f.Name == "CalendarForm")
                    forms.Add(f);
            foreach (Form f in forms)
                f.Close();
            CalendarForm calendarForm = new CalendarForm(UID);
            calendarForm.Show();
            this.Close();
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

        private void changeLightMode()
        {
            this.BackColor = Color.WhiteSmoke;
            dateLabel.ForeColor = Color.Black;
            exitButton.BackColor = Color.White;
            exitButton.ForeColor = Color.Black;
            editButton.BackColor = Color.White;
            editButton.ForeColor = Color.Black;
        }

        private void changeDarkMode()
        {
            this.BackColor = Color.FromArgb(40, 40, 40);
            dateLabel.ForeColor = Color.White;
            exitButton.BackColor = Color.FromArgb(64, 64, 64);
            exitButton.ForeColor = Color.White;
            editButton.BackColor = Color.FromArgb(64, 64, 64);
            editButton.ForeColor = Color.White;
        }
    }
}
