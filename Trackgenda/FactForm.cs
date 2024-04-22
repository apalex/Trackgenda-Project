using System;
using System.Windows.Forms;
using System.Net.Http;

namespace Trackgenda
{
    public partial class FactForm : Form
    {
        private const string apiUrl = "http://numbersapi.com/{0}/{1}/date";
        private HttpClient httpClient;
        public FactForm()
        {
            httpClient = new HttpClient();
            InitializeComponent();
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
    }
}
