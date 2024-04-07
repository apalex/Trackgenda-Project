using MySql.Data.MySqlClient;
using Mysqlx;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Trackgenda
{
    public partial class LoginForm : Form
    {
        private MySqlConnection conn;
        private string server;
        private string database;
        private string uid;
        private string password;
        private string query;
        public LoginForm()
        {
            server = "localhost";
            database = "trackgenda";
            uid = "root";
            password = "";
            string connString = $"server={server};database={database};uid={uid};password={password};";
            conn = new MySqlConnection(connString);
            InitializeComponent();
        }

        // Make Form Drag True
        [DllImport("user32.dll", EntryPoint = "ReleaseCapture")]
        private extern static void ReleaseCapture();
        [DllImport("user32.dll", EntryPoint = "SendMessage")]
        private extern static void SendMessage(System.IntPtr hWnd, int wMsg, int wParam, int lParam);

        private void LoginForm_MouseDown(object sender, MouseEventArgs e)
        {
            ReleaseCapture();
            SendMessage(this.Handle, 0x112, 0xf012, 0);
        }

        private void XButton_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void registerLabel_Click(object sender, EventArgs e)
        {
            conn.Close();
            RegisterForm registerForm = new RegisterForm();
            registerForm.Show();
            this.Hide();
        }

        private void forgotPasswordLabel_Click(object sender, EventArgs e)
        {
            conn.Close();
            ForgotPasswordForm forgotPasswordForm = new ForgotPasswordForm();
            forgotPasswordForm.Show();
            this.Hide();
        }
        private bool OpenConnection()
        {
            try
            {
                conn.Open();
                return true;
            }
            catch (MySqlException E)
            {
                switch (E.Number)
                {
                    case 0:
                        MessageBox.Show("Connection to server failed!");
                        break;
                    case 1045:
                        MessageBox.Show("Server username or password is inccorect!");
                        break;
                }
                return false;
            }
        }

        private void loginButton_Click(object sender, EventArgs e)
        {
            if (usernameTextBox.TextLength == 0 || passwordTextBox.TextLength == 0)
            {
                MessageBox.Show("Username or Password missing", "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            } else
            {
                if (IsLogin(usernameTextBox.Text,passwordTextBox.Text))
                {
                    // Redirect to calendar page here with calendar default constructor accepting parameters as uid
                }
                else
                {
                    MessageBox.Show("Username or Password is wrong", "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
            }
        }

        private bool IsLogin(string username, string password)
        {
            query = $"SELECT * FROM user_info WHERE username = '{username}' AND password = '{password}';";

            try
            {
                if (OpenConnection())
                {
                    MySqlCommand cmd = new MySqlCommand(query, conn);
                    MySqlDataReader reader = cmd.ExecuteReader();

                    if (reader.Read())
                    {
                        reader.Close();
                        conn.Close();
                        return true;
                    }
                }
            }
            catch (MySqlException E)
            {
            }
            return false;
        }
    }
}
