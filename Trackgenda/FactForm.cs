using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Runtime.InteropServices;
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

        // Make Form Drag True
        [DllImport("user32.dll", EntryPoint = "ReleaseCapture")]
        private extern static void ReleaseCapture();
        [DllImport("user32.dll", EntryPoint = "SendMessage")]
        private extern static void SendMessage(System.IntPtr hWnd, int wMsg, int wParam, int lParam);

        private void FactForm_MouseDown(object sender, MouseEventArgs e)
        {
            ReleaseCapture();
            SendMessage(this.Handle, 0x112, 0xf012, 0);
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
