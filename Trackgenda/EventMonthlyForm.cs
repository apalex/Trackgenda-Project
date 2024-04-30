using Mysqlx;
using System;
using System.Collections.Generic;
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
            if (dbConn.setEventDesc(UID,IndexDay,date,descTextBox.Text) && descTextBox.Text.Length > 0)
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
            date = $"{Month:D2}/{Day:D2}/{Year}";
            dateLabel.Text = date;

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
            if (dbConn.addMonthlyEvent(uid,date,descTextBox.Text))
            {
                dbConn.CloseConnection();
                MessageBox.Show("Event successfully added!");
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
                MessageBox.Show("Error whilst saving the event!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }
    }
}
