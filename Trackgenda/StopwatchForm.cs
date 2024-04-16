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
    public partial class StopwatchForm : Form
    {
        public StopwatchForm()
        {
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
