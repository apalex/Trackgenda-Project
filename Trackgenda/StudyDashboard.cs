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
    public partial class StudyDashboard : Form
    {
        public StudyDashboard()
        {
            InitializeComponent();
        }

        private void exitButton_Click(object sender, EventArgs e)
        {
            ((CalendarForm)MdiParent).StudyDashboardShow = false;
            this.Close();
        }

        private void fiftyTwoSeventeenRuleButton_Click(object sender, EventArgs e)
        {

        }

        private void personalButton_Click(object sender, EventArgs e)
        {

        }

        private void pomodoroButton_Click(object sender, EventArgs e)
        {

        }
    }
}
