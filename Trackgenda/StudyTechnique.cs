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
        private int uid, study, shortbreak, longbreak, count;
        private string technique;
        private DatabaseConnection dbConn;

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

        private int Count
        {
            get { return count; }
            set { count = value; }
        }

        private void StudyTechnique_Load(object sender, EventArgs e)
        {
            changeThemeMode();
            exitButton.Select();
            displayLabel.Text = $"{Technique}";
            if (Technique == "Pomodoro")
            {
                Count = 4;
                Pomodoro();

            }
            else if (Technique == "52/17")
            {
                Count = 2;
                FiftyTwoSeventeen();
            }
            else
            {
                Count = 4;
                Personal();
            }
        }

        private void StudyTechnique_MouseDown(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                DraggeableForms.Drag(this.Handle);
            }
        }

        private string Technique
        {
            get { return technique; }
            set { technique = value; }
        }

        private void Pomodoro()
        {
            timeLabel.Text = $"{study}";
        }

        private void FiftyTwoSeventeen()
        {

        }

        private void Personal()
        {

        }

        private void exitButton_Click(object sender, EventArgs e)
        {
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
            displayLabel.ForeColor = Color.Black;
            timeLabel.ForeColor = Color.Black;
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
            controlButton.BackColor = Color.FromArgb(64, 64, 64);
            controlButton.ForeColor = Color.White;
            resetButton.BackColor = Color.FromArgb(64, 64, 64);
            resetButton.ForeColor = Color.White;
            exitButton.BackColor = Color.FromArgb(64, 64, 64);
            exitButton.ForeColor = Color.White;
        }
    }
}
