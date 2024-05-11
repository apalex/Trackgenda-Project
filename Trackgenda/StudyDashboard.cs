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
    public partial class StudyDashboard : Form
    {
        private int uid;
        private DatabaseConnection dbConn;

        public StudyDashboard(int uid)
        {
            UID = uid;
            dbConn = new DatabaseConnection();
            dbConn.OpenConnection();
            InitializeComponent();
        }

        private int UID
        {
            get { return uid; }
            set { uid = value; }
        }

        private void exitButton_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void fiftyTwoSeventeenRuleButton_Click(object sender, EventArgs e)
        {
            StudyTechnique form = new StudyTechnique(uid,"52/17", 52, 0, 17);
            this.Close();
            form.Show();
        }

        private void personalButton_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void pomodoroButton_Click(object sender, EventArgs e)
        {
            StudyTechnique form = new StudyTechnique(uid,"Pomodoro", 25, 5, 15);
            this.Close();
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
            }
            else
            {
                changeDarkMode();
            }
        }

        private void changeLightMode()
        {
            this.BackColor = Color.WhiteSmoke;
            personalButton.BackColor = Color.White;
            personalButton.ForeColor = Color.Black;
            pomodoroButton.BackColor = Color.White;
            pomodoroButton.ForeColor = Color.Black;
            fiftyTwoSeventeenRuleButton.BackColor = Color.White;
            fiftyTwoSeventeenRuleButton.ForeColor = Color.Black;
            exitButton.BackColor = Color.White;
            exitButton.ForeColor = Color.Black;
        }

        private void changeDarkMode()
        {
            this.BackColor = Color.FromArgb(40, 40, 40);
            personalButton.BackColor = Color.FromArgb(64, 64, 64);
            personalButton.ForeColor = Color.White;
            pomodoroButton.BackColor = Color.FromArgb(64, 64, 64);
            pomodoroButton.ForeColor = Color.White;
            fiftyTwoSeventeenRuleButton.BackColor = Color.FromArgb(64, 64, 64);
            fiftyTwoSeventeenRuleButton.ForeColor = Color.White;
            exitButton.BackColor = Color.FromArgb(64, 64, 64);
            exitButton.ForeColor = Color.White;
        }

        private void StudyDashboard_Load(object sender, EventArgs e)
        {
            changeThemeMode();
        }

        private void StudyDashboard_MouseDown(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                DraggeableForms.Drag(this.Handle);
            }
        }
    }
}
