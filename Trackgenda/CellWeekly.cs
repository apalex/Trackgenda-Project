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
        private int uid;
        private DatabaseConnection dbConn;
        private string date;

        public CellWeekly(int uid, string date, int index)
        {
            UID = uid;
            Date = date;
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
    }
}
