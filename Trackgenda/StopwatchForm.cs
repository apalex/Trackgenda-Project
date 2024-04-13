﻿using System;
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
    public partial class StopwatchForm : Form
    {
        public StopwatchForm()
        {
            InitializeComponent();
        }
        
        // Make Form Drag True
        [DllImport("user32.dll", EntryPoint = "ReleaseCapture")]
        private extern static void ReleaseCapture();
        [DllImport("user32.dll", EntryPoint = "SendMessage")]
        private extern static void SendMessage(System.IntPtr hWnd, int wMsg, int wParam, int lParam);

        private void StopwatchForm_MouseDown(object sender, MouseEventArgs e)
        {
            ReleaseCapture();
            SendMessage(this.Handle, 0x112, 0xf012, 0);
        }

        private void minimizeButton_Click(object sender, EventArgs e)
        {
            ((CalendarForm)MdiParent).StopWatchShow = false;
            this.Hide();
        }

        private void controlButton_Click(object sender, EventArgs e)
        {

        }

        private void StopwatchForm_Load(object sender, EventArgs e)
        {
            this.Select();
        }
    }
}