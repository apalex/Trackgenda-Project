using System;
using System.Drawing;
using System.Windows.Forms;

namespace Trackgenda
{
    public partial class ProgressBarForm : Form
    {
        private int uid;

        public ProgressBarForm(int uid)
        {
            this.uid = uid;
            InitializeComponent();
        }

        private void ProgressBarForm_Load(object sender, EventArgs e)
        {
            timer1.Start();
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            if(progressBar.Value < 100)
            {
                progressBar.Value++;
                timerLabel.Text = progressBar.Value.ToString() + "%";
            } else
            {
                timerLabel.Text = "100%";
                timer1.Stop();
                CalendarForm calendar = new CalendarForm(this.uid);
                calendar.Show();
                this.Hide();
            }
        }

    }
}
