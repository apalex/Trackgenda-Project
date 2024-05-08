using System;
using System.Windows.Forms;
using System.Diagnostics;
using System.Drawing;

namespace Trackgenda
{
    public partial class StopwatchForm : Form
    {
        private int uid;
        private Stopwatch stopWatch;
        private DatabaseConnection dbConn;
        private bool isStart = false;
        public StopwatchForm(int uid)
        {
            UID = uid;
            stopWatch = new Stopwatch();
            dbConn = new DatabaseConnection();
            dbConn.OpenConnection();
            InitializeComponent();
        }

        private int UID
        {
            get { return uid; }
            set { uid = value; }
        }

        private void StopwatchForm_MouseDown(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                DraggeableForms.Drag(this.Handle);
            }
        }

        private void minimizeButton_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void controlButton_Click(object sender, EventArgs e)
        {
            isStart = !isStart;
            if (isStart == true)
            {
                controlButton.Text = "Stop";
                stopWatch.Start();
                resetButton.Enabled = false;
            } else
            {
                controlButton.Text = "Resume";
                stopWatch.Stop();
                resetButton.Enabled = true;
            }
        }

        private void StopwatchForm_Load(object sender, EventArgs e)
        {
            this.Select();
            changeThemeMode();
        }

        private void resetButton_Click(object sender, EventArgs e)
        {
            controlButton.Text = "Start";
            stopWatch.Reset();
        }

        private void timerStopwatch_Tick(object sender, EventArgs e)
        {
            timerLabel.Text = stopWatch.Elapsed.ToString();
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
            displayLabel.ForeColor = Color.Black;
            seperatorLabel.ForeColor = Color.Black;
            closeButton.BackColor = Color.White;
            closeButton.ForeColor = Color.Black;
            timerLabel.ForeColor = Color.Black;
            controlButton.BackColor = Color.White;
            controlButton.ForeColor = Color.Black;
            resetButton.BackColor = Color.White;
            resetButton.ForeColor = Color.Black;
        }

        private void changeDarkMode()
        {
            this.BackColor = Color.Gray;
            displayLabel.ForeColor = Color.Black;
            seperatorLabel.ForeColor = Color.Black;
            closeButton.BackColor = Color.DarkGray;
            closeButton.ForeColor = Color.Black;
            timerLabel.ForeColor = Color.Black;
            controlButton.BackColor = Color.DarkGray;
            controlButton.ForeColor = Color.Black;
            resetButton.BackColor = Color.DarkGray;
            resetButton.ForeColor = Color.Black;
        }
    }
}
