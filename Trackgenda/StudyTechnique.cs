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
    public partial class StudyTechnique : Form
    {
        private int uid, study, shortbreak, longbreak, totalSeconds, phaseCount;
        private string technique;
        private bool isStart = false;
        private DatabaseConnection dbConn;
        private TimeSpan studySeconds;
        private Phase currentPhase;
        private int cycleCounter = -1;

        private enum Phase
        {
            Study,
            ShortBreak,
            LongBreak
        }

        public StudyTechnique(int uid, string technique, int study, int shortbreak, int longbreak)
        {
            UID = uid;
            Study = study;
            Shortbreak = shortbreak;
            Longbreak = longbreak;
            Technique = technique;
            dbConn = new DatabaseConnection();
            dbConn.OpenConnection();
            InitializeComponent();
        }

        private int UID
        {
            get { return uid; }
            set { uid = value; }
        }

        private int Study
        {
            get { return study; }
            set { study = value; }
        }

        private int Shortbreak
        {
            get { return shortbreak; }
            set { shortbreak = value; }
        }

        private int Longbreak
        {
            get { return longbreak; }
            set { longbreak = value; }
        }

        private string Technique
        {
            get { return technique; }
            set { technique = value; }
        }


        private void StudyTechnique_Load(object sender, EventArgs e)
        {
            changeThemeMode();
            exitButton.Select();
            displayLabel.Text = $"{Technique}";
            SetPhase(Phase.Study);
            int temp = Study * 60;
            timeLabel.Text = string.Format("{0:D2}m:{1:D2}s",
                temp / 60,
                temp % 60
                );
            mainTimer.Enabled = false;
        }

        private void StudyTechnique_MouseDown(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                DraggeableForms.Drag(this.Handle);
            }
        }

        private void Pomodoro()
        {
            if (phaseCount % 8 == 0 && phaseCount != 0)
            {
                SetPhase(Phase.LongBreak);
                totalSeconds = Longbreak * 60;
            }
            else if (phaseCount % 2 == 0)
            {
                SetPhase(Phase.ShortBreak);
                totalSeconds = Shortbreak * 60;
            }
            else
            {
                SetPhase(Phase.Study);
                totalSeconds = Study * 60;
            }
        }

        private void FiftyTwoSeventeen()
        {
            if (cycleCounter % 2 == 0)
            {
                SetPhase(Phase.Study);
                totalSeconds = Study * 60;
            }
            else
            {
                SetPhase(Phase.LongBreak);
                totalSeconds = Longbreak * 60;
            }
        }

        private void exitButton_Click(object sender, EventArgs e)
        {
            this.Close();
            dbConn.CloseConnection();
        }

        private void resetButton_Click(object sender, EventArgs e)
        {
            controlButton.Text = "Start";
            studySeconds = TimeSpan.FromSeconds(Study * 60);
            totalSeconds = Study * 60;
            timeLabel.Text = string.Format("{0:D2}m:{1:D2}s",
                studySeconds.Minutes,
                studySeconds.Seconds
                );
            cycleCounter = 0;
        }

        private void mainTimer_Tick(object sender, EventArgs e)
        {
            --totalSeconds;
            if (totalSeconds < 0)
            {
                NextPhase();
            }
            updateTimeLabel();
        }

        private void NextPhase()
        {
            phaseCount++;
            cycleCounter++;

            if (Technique != "52/17")
            {
                Pomodoro();
            }
            else
            {
                FiftyTwoSeventeen();
            }
        }


        private void SetPhase(Phase phase)
        {
            currentPhase = phase;

            if (Technique != "52/17")
            {
                switch (currentPhase)
                {
                    case Phase.Study:
                        label1.Text = "Study";
                        break;
                    case Phase.ShortBreak:
                        label1.Text = "Short Break";
                        break;
                    case Phase.LongBreak:
                        label1.Text = "Long Break";
                        break;
                }
            } else
            {
                switch (currentPhase)
                {
                    case Phase.Study:
                        label1.Text = "Study";
                        break;
                    case Phase.LongBreak:
                        label1.Text = "Break";
                        break;
                }
            }
        }

        private void updateTimeLabel()
        {
            timeLabel.Text = string.Format("{0:D2}m:{1:D2}s", totalSeconds / 60, totalSeconds % 60);
        }

        private void controlButton_Click(object sender, EventArgs e)
        {
            isStart = !isStart;
            mainTimer.Enabled = true;
            if (isStart)
            {
                controlButton.Text = "Stop";
                mainTimer.Start();
                resetButton.Enabled = false;
            }
            else
            {
                controlButton.Text = "Resume";
                mainTimer.Stop();
                resetButton.Enabled = true;
            }
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
            timeLabel.ForeColor = Color.Black;
            label1.ForeColor = Color.Black;
            controlButton.BackColor = Color.White;
            controlButton.ForeColor = Color.Black;
            resetButton.BackColor = Color.White;
            resetButton.ForeColor = Color.Black;
            exitButton.BackColor = Color.White;
            exitButton.ForeColor = Color.Black;
        }

        private void changeDarkMode()
        {
            this.BackColor = Color.FromArgb(40, 40, 40);
            displayLabel.ForeColor = Color.White;
            timeLabel.ForeColor = Color.White;
            label1.ForeColor = Color.White;
            controlButton.BackColor = Color.FromArgb(64, 64, 64);
            controlButton.ForeColor = Color.White;
            resetButton.BackColor = Color.FromArgb(64, 64, 64);
            resetButton.ForeColor = Color.White;
            exitButton.BackColor = Color.FromArgb(64, 64, 64);
            exitButton.ForeColor = Color.White;
        }
    }
}
