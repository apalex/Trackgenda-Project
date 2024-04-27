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
    public partial class EventWeeklyForm : Form
    {
        private int uid;

        public EventWeeklyForm(int uid)
        {
            UID = uid;
            InitializeComponent();
        }

        private int UID
        {
            get { return uid; }
            set { uid = value; }
        }
    }
}
