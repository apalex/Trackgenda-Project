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
    public partial class CellWeekly : UserControl
    {
        private int uid,indexVal;
        private DatabaseConnection dbConn;
        private string date, theme;

        public CellWeekly(int uid, string date, int indexVal)
        {
            UID = uid;
            Date = date;
            IndexVal = indexVal;
            dbConn = new DatabaseConnection();
            dbConn.OpenConnection();
            InitializeComponent();
        }

        private int UID
        {
            get { return uid; }
            set { uid = value; }
        }

        private string Date
        {
            get { return date; }
            set { date = value; }
        }

        private void CellWeekly_MouseHover(object sender, EventArgs e)
        {
            this.BackColor = Color.Azure;
        }

        private void CellWeekly_MouseLeave(object sender, EventArgs e)
        {
            this.BackColor = Color.FromName(dbConn.getWeeklyBackground(uid));
        }

        private void CellWeekly_Click(object sender, EventArgs e)
        {
            EventWeeklyForm form = new EventWeeklyForm(uid);
            form.Show();
        }

        private int IndexVal
        {
            get { return indexVal; }
            set { indexVal = value; }
        }

        private void CellWeekly_Load(object sender, EventArgs e)
        {
            this.BackColor = Color.FromName(dbConn.getWeeklyBackground(uid));
        }
    }
}
