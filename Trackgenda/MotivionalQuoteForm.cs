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
            if (e.Button == MouseButtons.Left)
            {
                DraggeableForms.Drag(this.Handle);
            }
        }

        private void closeButton_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
