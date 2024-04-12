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
        public CalendarForm(int uid)
        {
            this.uid = uid;
            InitializeComponent();
        }

        // Make Form Drag True
        [DllImport("user32.dll", EntryPoint = "ReleaseCapture")]
        private extern static void ReleaseCapture();
        [DllImport("user32.dll", EntryPoint = "SendMessage")]
        private extern static void SendMessage(System.IntPtr hWnd, int wMsg, int wParam, int lParam);

        private void button1_Click(object sender, EventArgs e)
        {
            label1.Text = this.uid.ToString();
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
            ReleaseCapture();
            SendMessage(this.Handle, 0x112, 0xf012, 0);
        }

        private void CalendarForm_Load(object sender, EventArgs e)
        {
            currentTimeTimer.Start();
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
            ReleaseCapture();
            SendMessage(this.Handle, 0x112, 0xf012, 0);
        }

        private void hamburgerPictureBox_Click(object sender, EventArgs e)
        {
            if (sidePanelShow)
            {
                sidePanel.Hide();
                sidePanelShow = false;
            } else
            {
                sidePanel.Show();
                sidePanelShow = true;
            }
        }
    }
}
