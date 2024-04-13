using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Net.Http;
using Newtonsoft.Json;
using System.Runtime.InteropServices;

namespace Trackgenda
{
    public partial class MotivionalQuoteForm : Form
    {
        private const string apiUrl = "https://type.fit/api/quotes";
        private HttpClient httpClient;
        public MotivionalQuoteForm()
        {
            httpClient = new HttpClient();
            InitializeComponent();
        }

        // Make Form Drag True
        [DllImport("user32.dll", EntryPoint = "ReleaseCapture")]
        private extern static void ReleaseCapture();
        [DllImport("user32.dll", EntryPoint = "SendMessage")]
        private extern static void SendMessage(System.IntPtr hWnd, int wMsg, int wParam, int lParam);

        private async void MotivionalQuoteForm_Load(object sender, EventArgs e)
        {
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
            ReleaseCapture();
            SendMessage(this.Handle, 0x112, 0xf012, 0);
        }

        private void closeButton_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
