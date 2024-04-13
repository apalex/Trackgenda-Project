using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Runtime.InteropServices;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MySql.Data.MySqlClient;
using Mysqlx;
using System.Text.RegularExpressions;

namespace Trackgenda
{
    public partial class ForgotPasswordForm : Form
    {
        private MySqlConnection conn;
        private string server;
        private string database;
        private string uid;
        private string password;
        private string query;
        public ForgotPasswordForm()
        {
            server = "localhost";
            database = "trackgenda";
            uid = "root";
            password = "";
            string connString = $"server={server};database={database};uid={uid};password={password};";
            conn = new MySqlConnection(connString);
            OpenConnection();
            InitializeComponent();
        }

        // Make Form Drag True
        [DllImport("user32.dll", EntryPoint = "ReleaseCapture")]
        private extern static void ReleaseCapture();
        [DllImport("user32.dll", EntryPoint = "SendMessage")]
        private extern static void SendMessage(System.IntPtr hWnd, int wMsg, int wParam, int lParam);

        private void RegisterForm_MouseDown(object sender, MouseEventArgs e)
        {
            ReleaseCapture();
            SendMessage(this.Handle, 0x112, 0xf012, 0);
        }

        private void XButton_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void backButton_Click(object sender, EventArgs e)
        {
            LoginForm loginForm = new LoginForm();
            loginForm.Show();
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
                        MessageBox.Show("Server username or password is incorrect!");
                        break;
                }
                return false;
            }
        }

        private void confirmButton_Click(object sender, EventArgs e)
        {
            if (usernameTextBox.TextLength == 0 || emailTextBox.TextLength == 0 || newPasswordTextBox.TextLength == 0 || confirmTextBox.TextLength == 0)
            {
                MessageBox.Show("Please fill in all the cases", "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            } else
            {
                if (checkExistInDB(usernameTextBox.Text, emailTextBox.Text))
                {
                    if (Regex.Match(newPasswordTextBox.Text, "^(?=.*[a-z])(?=.*[A-Z])(?=.*\\d)(?=.*[@$!%*?&])[A-Za-z\\d@$!%*?&]{8,}$").Success)
                    {
                        if (newPasswordTextBox.Text == confirmTextBox.Text)
                        {
                            if (isPassChanged(usernameTextBox.Text, newPasswordTextBox.Text))
                            {
                                MessageBox.Show("Password has been successfully changed!");
                                conn.Close();
                                LoginForm loginForm = new LoginForm();
                                loginForm.Show();
                                this.Hide();
                            }
                            else
                            {
                                MessageBox.Show("An error has occured!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                            }
                        }
                        else
                        {
                            MessageBox.Show("Please make sure your password and confirm password are the same", "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                        }
                    }
                    else
                    {
                        MessageBox.Show("Password minimum eight characters, at least one uppercase \nletter, one lowercase letter, one number \nand one special character", "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    }
                }
                else
                {
                    MessageBox.Show("Please verify your username or email spelling", "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
            }
        }

        private bool checkExistInDB(string username, string u_email)
        {
            query = $"SELECT * FROM user_info WHERE username = '{username}' AND u_email = '{u_email}';";
            MySqlCommand cmd = new MySqlCommand(query, conn);
            MySqlDataReader reader = cmd.ExecuteReader();
            if (reader.Read())
            {
                reader.Close();
                return true;
            }
            reader.Close();
            return false;
        }

        private bool isPassChanged(string username, string password)
        {
            query = $"UPDATE user_info SET u_password = '{password}' WHERE username = '{username}';";
            try
            {
                MySqlCommand cmd = new MySqlCommand(query, conn);
                try
                {
                    cmd.ExecuteNonQuery();
                    return true;
                }
                catch (Exception E)
                {
                    MessageBox.Show(E.ToString());
                }
            }
            catch (Exception E)
            {
                MessageBox.Show(E.ToString());
            }
            return false;
        }

        private void usernameTextBox_Enter(object sender, EventArgs e)
        {
            if (usernameTextBox.Text == "Username")
            {
                usernameTextBox.Text = "";
                usernameTextBox.ForeColor = Color.Black;
            }
        }

        private void emailTextBox_Enter(object sender, EventArgs e)
        {
            if (emailTextBox.Text == "email@gmail.com")
            {
                emailTextBox.Text = "";
                emailTextBox.ForeColor = Color.Black;
            }
        }

        private void newPasswordTextBox_Enter(object sender, EventArgs e)
        {
            if (newPasswordTextBox.Text == "New Password")
            {
                newPasswordTextBox.Text = "";
                newPasswordTextBox.ForeColor = Color.Black;
            }
        }

        private void confirmTextBox_Enter(object sender, EventArgs e)
        {
            if (confirmTextBox.Text == "New Password")
            {
                confirmTextBox.Text = "";
                confirmTextBox.ForeColor = Color.Black;
            }
        }

        private void usernameTextBox_Leave(object sender, EventArgs e)
        {
            if (usernameTextBox.Text == "")
            {
                usernameTextBox.Text = "Username";
                usernameTextBox.ForeColor = Color.DarkGray;
            }
        }

        private void emailTextBox_Leave(object sender, EventArgs e)
        {
            if (emailTextBox.Text == "")
            {
                emailTextBox.Text = "email@gmail.com";
                emailTextBox.ForeColor = Color.DarkGray;
            }
        }

        private void newPasswordTextBox_Leave(object sender, EventArgs e)
        {
            if (newPasswordTextBox.Text == "")
            {
                newPasswordTextBox.Text = "New Password";
                newPasswordTextBox.ForeColor = Color.DarkGray;
            }
        }

        private void confirmTextBox_Leave(object sender, EventArgs e)
        {
            if (confirmTextBox.Text == "")
            {
                confirmTextBox.Text = "New Password";
                confirmTextBox.ForeColor = Color.DarkGray;
            }
        }

        private void ForgotPasswordForm_Load(object sender, EventArgs e)
        {
            this.Select();
        }
    }
}
