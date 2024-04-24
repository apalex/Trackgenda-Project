using System;
using System.Drawing;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.Window;

namespace Trackgenda
{
    public partial class EmptyCell : UserControl
    {
        private int uid;
        private DatabaseConnection dbConn;
        public EmptyCell(int uid)
        {
            this.uid = uid;
            dbConn = new DatabaseConnection();
            dbConn.OpenConnection();
            InitializeComponent();
        }

        public int UID
        {
            get { return uid; }
            set { this.uid = value; }
        }

        private void EmptyCell_Load(object sender, EventArgs e)
        {
            UID = uid;
            changeThemeMode();
            dbConn.CloseConnection();
        }

        private string checkThemeMode()
        {
            return dbConn.getUserTheme(uid);
        }

        private void changeThemeMode()
        {
            if (checkThemeMode() == "Light")
            {
                changeLightMode();
            }
            else
            {
                changeDarkMode();
            }
        }

        private void changeLightMode()
        {
            this.BackColor = Color.White;
            this.ForeColor = Color.White;
            panel4.BackColor = Color.White;
            panel4.ForeColor = Color.Black;
        }

        private void changeDarkMode()
        {
            this.BackColor = Color.FromArgb(64, 64, 64);
            this.ForeColor = Color.White;
            panel4.BackColor = Color.FromArgb(64, 64, 64);
            panel4.ForeColor = Color.Black;
        }
    }
}
