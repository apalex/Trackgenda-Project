using System;
using System.Collections.Generic;
using System.Drawing;
using System.Windows.Forms;
using System.Net.Http;
using Newtonsoft.Json;

namespace Trackgenda
{
    public partial class MotivionalQuoteForm : Form
    {
        private int uid;
        private DatabaseConnection dbConn;
        private const string apiUrl = "https://type.fit/api/quotes";
        private HttpClient httpClient;
        public MotivionalQuoteForm(int uid)
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

        private async void MotivionalQuoteForm_Load(object sender, EventArgs e)
        {
            changeThemeMode();
            try
            {
                string jsonResponse = await httpClient.GetStringAsync(apiUrl);
                var quotes = JsonConvert.DeserializeObject<List<Quote>>(jsonResponse);

                Random rnd = new Random();
                int index = rnd.Next(0, quotes.Count);

                quotelabel.Text = $"\"{quotes[index].text}\" - {quotes[index].author}";
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error fetching quote: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        public class Quote
        {
            public string text { get; set; }
            public string author { get; set; }
        }

        private void MotivionalQuoteForm_MouseDown(object sender, MouseEventArgs e)
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
            quotelabel.BackColor = Color.Gainsboro;
            quotelabel.ForeColor = Color.Black;
            closeButton.BackColor = Color.LightCoral;
            closeButton.ForeColor = Color.White;
        }

        private void changeDarkMode()
        {
            this.BackColor = Color.Gray;
            this.ForeColor = Color.Black;
            displayLabel.BackColor = Color.Gray;
            displayLabel.ForeColor = Color.Black;
            quotelabel.BackColor = Color.Gray;
            quotelabel.ForeColor = Color.Black;
            closeButton.BackColor = Color.DarkGray;
            closeButton.ForeColor = Color.Black;
        }
    }
}
