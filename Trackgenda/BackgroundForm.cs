using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.Taskbar;

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
            DialogResult result = MessageBox.Show("Are you sure you want to reset your background?", "Confirmation", MessageBoxButtons.OKCancel);
            List<Form> forms = new List<Form>();
            if (result == DialogResult.OK)
            {
                if (dbConn.resetBackgroundImage(UID))
                {
                    MessageBox.Show("Successfully Reset Background!");
                    foreach (Form f in Application.OpenForms)
                        if (f.Name == "CalendarForm")
                            forms.Add(f);
                    foreach (Form f in forms)
                        f.Close();
                    CalendarForm calendarForm = new CalendarForm(UID);
                    calendarForm.Show();
                    this.Close();
                }
                else
                {
                    MessageBox.Show("Error Resetting Background", "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
            }
        }

        private void BackgroundForm_MouseDown(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                DraggeableForms.Drag(this.Handle);
            }
        }

        private void setBackground()
        {
            SaveFileDialog saveFileDialog = new SaveFileDialog();
            saveFileDialog.Filter = "Image Files(*.PNG;*.JPG;*.JPEG;*.GIF)|*.PNG;*.JPG;*.JPEG;*.GIF";
            List<Form> forms = new List<Form>();
            if (saveFileDialog.ShowDialog() == DialogResult.OK)
            {
                String fileName = saveFileDialog.FileName;
                fileName = fileName.Replace("\\", "\\\\");
                if (dbConn.insertBackgroundImage(UID, fileName))
                {
                    MessageBox.Show("Successfully Set Background!");
                    foreach (Form f in Application.OpenForms)
                        if (f.Name == "CalendarForm")
                            forms.Add(f);
                    foreach (Form f in forms)
                        f.Close();
                    CalendarForm calendarForm = new CalendarForm(UID);
                    calendarForm.Show();
                    this.Close();
                } else
                {
                    MessageBox.Show("Error Setting Background", "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
            }
        }

        private void imageButton_Click(object sender, EventArgs e)
        {
            setBackground();
        }

        private void gifButton_Click(object sender, EventArgs e)
        {
            setBackground();
        }

        private void BackgroundForm_Load(object sender, EventArgs e)
        {
            this.exitButton.Select();
            UID = uid;
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
            this.ForeColor = Color.Black;
            exitButton.BackColor = Color.White;
            exitButton.ForeColor = Color.Black;
            imageButton.BackColor = Color.White;
            imageButton.ForeColor = Color.Black;
            gifButton.BackColor = Color.White;
            gifButton.ForeColor = Color.Black;
            resetButton.BackColor = Color.White;
            resetButton.ForeColor = Color.Black;
        }

        private void changeDarkMode()
        {
            this.BackColor = Color.DarkGray;
            imageButton.BackColor = Color.FromArgb(179, 179, 179);
            imageButton.ForeColor = Color.Black;
            gifButton.BackColor = Color.FromArgb(179, 179, 179);
            gifButton.ForeColor = Color.Black;
            resetButton.BackColor = Color.FromArgb(179, 179, 179);
            resetButton.ForeColor = Color.Black;
            exitButton.BackColor = Color.FromArgb(179, 179, 179);
            exitButton.ForeColor = Color.Black;
        }
    }
}
