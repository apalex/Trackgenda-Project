using System;
using System.Windows.Forms;
using System.Diagnostics;

namespace Trackgenda
{
    public partial class StopwatchForm : Form
    {
        private Stopwatch stopWatch;
        private bool isStart = false;
        public StopwatchForm()
        {
            stopWatch = new Stopwatch();
            InitializeComponent();
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
    }
}
