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
    public partial class BackgroundForm : Form
    {
        private int uid;
        private DatabaseConnection dbConn;
        public BackgroundForm(int uid)
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

        private void exitButton_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void resetButton_Click(object sender, EventArgs e)
        {
            if (dbConn.resetBackgroundImage(UID))
            {
                MessageBox.Show("Successfully Reset Background");
            } else
            {
                MessageBox.Show("Error Resetting Background", "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void BackgroundForm_MouseDown(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                DraggeableForms.Drag(this.Handle);
            }
        }

        private void imageButton_Click(object sender, EventArgs e)
        {

        }

        private void gifButton_Click(object sender, EventArgs e)
        {

        }

        private void BackgroundForm_Load(object sender, EventArgs e)
        {
            UID = uid;
        }
    }
}
