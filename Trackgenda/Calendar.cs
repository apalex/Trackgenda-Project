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
    public partial class CalendarForm : Form
    {
        private int uid;
        public CalendarForm(int uid)
        {
            this.uid = uid;
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            label1.Text = this.uid.ToString();
        }
    }
}
