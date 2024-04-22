using Mysqlx;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Trackgenda
{
    public partial class EventMonthlyForm : Form
    {
        private int uid, month, day, year;
        private string date;
        private DatabaseConnection dbConn;
        public EventMonthlyForm(int uid, int month,int day,int year)
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

        private void EventMonthlyForm_MouseDown(object sender, MouseEventArgs e)
        {

        }

        private void exitButton_Click(object sender, EventArgs e)
        {
            dbConn.CloseConnection();
            this.Close();
        }

        private void EventMonthlyForm_Load(object sender, EventArgs e)
        {
            uid = UID;
            if (month > 9)
            {
                date = $"{Month}/{Day}/{Year}";
            } else
            {
                date = $"0{Month}/{Day}/{Year}";
            }
            dateLabel.Text = date;

            // Set a maximum of 3 events that can be saved in one cell
            if (dbConn.getEventLength(uid, date) > 2)
            {
                descTextBox.ReadOnly = true;
                addButton.Enabled = false;
            }
        }

        private void saveButton_Click(object sender, EventArgs e)
        {
            if (dbConn.addMonthlyEvent(uid,date,descTextBox.Text))
            {
                dbConn.CloseConnection();
                MessageBox.Show("Event successfully added!");
                this.Close();
            } else
            {
                MessageBox.Show("Error whilst saving the event!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }
    }
}
