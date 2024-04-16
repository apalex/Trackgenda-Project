using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Trackgenda
{
    public partial class CalendarForm : Form
    {
        private int uid;
        private bool sidePanelShow = true;
        private bool stopWatchShow = false;
        private StopwatchForm stopWatchForm = new StopwatchForm();
        const int WS_MINIMIZEBOX = 0x20000;
        const int CS_DBLCLKS = 0x8;

        public CalendarForm(int uid)
        {
            this.uid = uid;
            InitializeComponent();
        }

        public bool StopWatchShow
        {
            get { return stopWatchShow;}
            set { stopWatchShow = value;}
        }

        protected override CreateParams CreateParams
        {
            get
            {
                CreateParams cp = base.CreateParams;
                cp.Style |= WS_MINIMIZEBOX;
                cp.ClassStyle |= CS_DBLCLKS;
                return cp;
            }
        }

        private void XButton_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void maximizeButton_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Maximized;
        }

        private void minimizeButton_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        private void CalendarForm_MouseDown(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                DraggeableForms.Drag(this.Handle);
            }
        }

        private void CalendarForm_Load(object sender, EventArgs e)
        {
            Controls.OfType<MdiClient>().FirstOrDefault().BackColor = Color.White;
            this.Select();
            currentTimeTimer.Start();
            stopWatchForm.MdiParent = this;
        }

        private void currentTimeTimer_Tick(object sender, EventArgs e)
        {
            currentTimeLabel.Text = DateTime.Now.ToLongTimeString();
        }

        private void XButton_MouseHover(object sender, EventArgs e)
        {
            XButton.BackColor = Color.LightCoral;
        }

        private void XButton_MouseLeave(object sender, EventArgs e)
        {
            XButton.BackColor = Color.White;
        }

        private void maximizeButton_MouseHover(object sender, EventArgs e)
        {
            maximizeButton.BackColor = Color.LightCoral;
        }

        private void maximizeButton_MouseLeave(object sender, EventArgs e)
        {
            maximizeButton.BackColor = Color.White;
        }

        private void minimizeButton_MouseHover(object sender, EventArgs e)
        {
            minimizeButton.BackColor = Color.LightCoral;
        }

        private void minimizeButton_MouseLeave(object sender, EventArgs e)
        {
            minimizeButton.BackColor = Color.White;
        }

        private void panel1_MouseDown(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                DraggeableForms.Drag(this.Handle);
            }
        }

        private void hamburgerPictureBox_Click(object sender, EventArgs e)
        {
            if (sidePanelShow)
            {
                sidePanel.Hide();
                sidePanelShow = !sidePanelShow;
            } else
            {
                sidePanel.Show();
                sidePanelShow = !sidePanelShow;
            }
        }

        private void stopwatchButton_Click(object sender, EventArgs e)
        {
            if (stopWatchShow == false)
            {
                stopWatchForm.Show();
                stopWatchShow = !stopWatchShow;
            }
            else
            {
                stopWatchForm.Hide();
                stopWatchShow = !stopWatchShow;
            }
        }

        private void factButton_Click(object sender, EventArgs e)
        {
            FactForm form = new FactForm();
            form.Show();
        }

        private void motivationalButton_Click(object sender, EventArgs e)
        {
            MotivionalQuoteForm form = new MotivionalQuoteForm();
            form.Show();
        }

        private void exitButton_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void logoutButton_Click(object sender, EventArgs e)
        {
            LoginForm form = new LoginForm();
            this.Close();
            form.Show();
        }
    }
}
