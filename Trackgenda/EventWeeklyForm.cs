using System;
using System.Collections.Generic;
using System.Drawing;
using System.Windows.Forms;

namespace Trackgenda
{
    public partial class EventWeeklyForm : Form
    {
        private int uid, indexVal;
        private DatabaseConnection dbConn;
        private string date;

        public EventWeeklyForm(int uid,string date, int indexVal)
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
            get
            {
                return indexVal;
            }
            set { indexVal = value; }
        }

        private void EventWeeklyForm_Load(object sender, EventArgs e)
        {
            dateLabel.Text = date;
            changeThemeMode();
            if (dbConn.checkExistWeeklyEvent(UID, date))
            {
                controlButton.Text = "Edit";
            }
        }

        private void exitButton_Click(object sender, EventArgs e)
        {
            dbConn.CloseConnection();
            this.Close();
        }

        private void EventWeeklyForm_MouseDown(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                DraggeableForms.Drag(this.Handle);
            }
        }

        private void controlButton_Click(object sender, EventArgs e)
        {
            List<Form> forms = new List<Form>();
            string color;
            if (colourComboBox.SelectedIndex == -1)
            {
                color = this.BackColor.Name;
            } else
            {
                color = (string)colourComboBox.SelectedItem.ToString();
            }
            if (controlButton.Text == "Edit")
            {
                if (dbConn.editWeeklyEvent(UID, descTextBox.Text, color, Date))
                {
                    MessageBox.Show("Event successfully edited!");
                } else
                {
                    MessageBox.Show("Error whilst saving the event!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
            } else
            {
                if (descTextBox.Text.Length == 0)
                {
                    MessageBox.Show("Please enter an event!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                } else
                {
                    if (dbConn.addWeeklyEvent(UID, Date, descTextBox.Text, color))
                    {
                        MessageBox.Show("Event successfully added!");
                    }
                    else
                    {
                        MessageBox.Show("Error whilst saving the event!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    }
                }
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
            this.BackColor = Color.White;
            exitButton.BackColor = Color.White;
            exitButton.ForeColor = Color.Black;
            controlButton.BackColor = Color.White;
            controlButton.ForeColor = Color.Black;
        }

        private void changeDarkMode()
        {
            this.BackColor = Color.Gray;
            exitButton.BackColor = Color.FromArgb(64, 64, 64);
            exitButton.ForeColor = Color.White;
            controlButton.BackColor = Color.FromArgb(64, 64, 64);
            controlButton.ForeColor = Color.White;
        }
    }
}
