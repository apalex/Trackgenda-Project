using System;
using System.Drawing;
using System.Windows.Forms;

namespace Trackgenda
{
    public partial class TODOForm : Form
    {
        private int uid;
        private DatabaseConnection dbConn;
        public TODOForm(int uid)
        {
            UID = uid;
            dbConn = new DatabaseConnection();
            dbConn.OpenConnection();
            InitializeComponent();
        }

        private int UID
        {
            get { return uid; }
            set { uid = value; }
        }

        private void exitButton_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void TODOForm_MouseDown(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                DraggeableForms.Drag(this.Handle);
            }
        }

        private void TODOForm_Load(object sender, EventArgs e)
        {
            changeThemeMode();
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
            this.BackColor = Color.WhiteSmoke;
            todoLabel.ForeColor = Color.Black;
            textBox1.BackColor = Color.White;
            textBox1.ForeColor = Color.Black;
            exitButton.BackColor = Color.White;
            exitButton.ForeColor = Color.Black;
        }

        private void changeDarkMode()
        {
            this.BackColor = Color.Gray;
            todoLabel.ForeColor = Color.Black;
            textBox1.BackColor = Color.DarkGray;
            textBox1.ForeColor = Color.Black;
            exitButton.BackColor = Color.DarkGray;
            exitButton.ForeColor = Color.Black;
        }
    }
}
