using System;
using System.Windows.Forms;
using System.Net.Http;
using System.Security.Cryptography;
using System.Drawing;

namespace Trackgenda
{
    public partial class FactForm : Form
    {
        private int uid;
        private DatabaseConnection dbConn;
        private const string apiUrl = "http://numbersapi.com/{0}/{1}/date";
        private HttpClient httpClient;
        public FactForm(int uid)
        {
            UID = uid;
            dbConn = new DatabaseConnection();
            dbConn.OpenConnection();
            httpClient = new HttpClient();
            InitializeComponent();
        }

        private int UID
        {
            get { return uid; }
            set { uid = value; }
        }

        private void FactForm_MouseDown(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                DraggeableForms.Drag(this.Handle);
            }
        }

        private void closeButton_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private async void FactForm_Load(object sender, EventArgs e)
        {
            changeThemeMode();
            try
            {
                DateTime currentDate = DateTime.Now;
                string month = currentDate.Month.ToString();
                string day = currentDate.Day.ToString();

                string urlWithDate = string.Format(apiUrl, month, day);

                string funFact = await httpClient.GetStringAsync(urlWithDate);

                factLabel.Text = funFact;
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error fetching trivia: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
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
            this.BackColor = Color.Gainsboro;
            this.ForeColor = Color.Black;
            displayLabel.BackColor = Color.Gainsboro;
            displayLabel.ForeColor = Color.Black;
            factLabel.BackColor = Color.Gainsboro;
            factLabel.ForeColor = Color.Black;
            closeButton.BackColor = Color.LightCoral;
            closeButton.ForeColor = Color.White;
        }

        private void changeDarkMode()
        {
            this.BackColor = Color.Gray;
            this.ForeColor = Color.Black;
            displayLabel.BackColor = Color.Gray;
            displayLabel.ForeColor = Color.Black;
            factLabel.BackColor = Color.Gray;
            factLabel.ForeColor = Color.Black;
            closeButton.BackColor = Color.DarkGray;
            closeButton.ForeColor = Color.Black;
        }
    }
}
