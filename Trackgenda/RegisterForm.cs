﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Text.RegularExpressions;
using System.Net.Mail;
using MySql.Data.MySqlClient;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.ListView;

namespace Trackgenda
{
    public partial class RegisterForm : Form
    {
        private MySqlConnection conn;
        private string server;
        private string database;
        private string uid;
        private string password;
        private string query;
        public RegisterForm()
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

        private void registerButton_Click(object sender, EventArgs e)
        {
            string error = "";
            // First Name
            if (!Regex.Match(firstNameTextBox.Text, "^[\\w'\\-,.][^0-9_!¡?÷?¿/\\\\+=@#$%ˆ&*(){}|~<>;:[\\]]{1,}$").Success)
            {
                if (firstNameTextBox.TextLength == 0)
                {
                    error += "First Name is required";
                }
                else
                {
                    error += "Please enter first name with no special unsupported characters";
                }
            }
            // Last Name
            if (!Regex.Match(lastNameTextBox.Text, "^[\\w'\\-,.][^0-9_!¡?÷?¿/\\\\+=@#$%ˆ&*(){}|~<>;:[\\]]{1,}$").Success)
            {
                if (lastNameTextBox.TextLength == 0)
                {
                    error += "\nLast Name is required";
                }
                else
                {
                    error += "\nPlease enter last name with no special unsupported characters";
                }
            }
            // Email
            if (!isValidEmailAddress(emailTextBox.Text))
            {
                error += "\nEmail Address is invalid";
            }
            if (isEmailInUse(emailTextBox.Text))
            {
                error += "\nEmail is already in use";
            }
            // Username
            if (!Regex.Match(usernameTextBox.Text, "^[a-zA-Z0-9]+([._]?[a-zA-Z0-9]+){1,}$").Success)
            {
                if (usernameTextBox.TextLength == 0)
                {
                    error += "\nUsername is required";
                } else if (usernameTextBox.TextLength < 3)
                {
                    error += "\nUsername must be a minimum of 4 characters long";
                } else if (isUsernameInUse(usernameTextBox.Text))
                {
                    error += "\nUsername is already in use";
                } else if (!Regex.Match(usernameTextBox.Text, "^[a-zA-Z0-9]+([._]?[a-zA-Z0-9]+){1,}$").Success)
                {
                    error += "\nUsername minimum 2 characters, no special characters,\nonly '_' and '.' are allowed";
                }
            }
            // Password
            if (!Regex.Match(passwordTextBox.Text, "^(?=.*[a-z])(?=.*[A-Z])(?=.*\\d)(?=.*[@$!%*?&])[A-Za-z\\d@$!%*?&]{8,}$").Success)
            {
                if (passwordTextBox.TextLength == 0)
                {
                    error += "\nPassword is required";
                } else
                {
                    error += "\nPassword minimum eight characters, at least one uppercase \nletter, one lowercase letter, one number \nand one special character";
                }
            }
            // Confirm Password
            if (passwordTextBox.Text != confirmTextBox.Text)
            {
                error += "\nPasswords must match";
            }
            // Registration
            if (error.Length == 0)
            {
                query = $"INSERT INTO user_info (first_name,last_name,u_email,username,u_password) VALUES ('{firstNameTextBox.Text}','{lastNameTextBox.Text}','{emailTextBox.Text}','{usernameTextBox.Text}','{passwordTextBox.Text}');";
                try
                {
                    MySqlCommand cmd = new MySqlCommand(query,conn);
                    try
                    {
                        cmd.ExecuteNonQuery();
                        MessageBox.Show("Account has been successfully made!");
                        conn.Close();
                        LoginForm loginForm = new LoginForm();
                        loginForm.Show();
                        this.Hide();
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
            } else
            {
                MessageBox.Show(error, "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private bool isValidEmailAddress(string email)
        {
            try
            {
                MailAddress mailAddress = new MailAddress(email);
                return true;
            }
            catch
            {
                return false;
            }
        }

        private bool isEmailInUse(string email)
        {
            query = $"SELECT * FROM user_info WHERE u_email = '{email}'";
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

        private bool isUsernameInUse(string username)
        {
            query = $"SELECT * FROM user_info WHERE username = '{username}'";
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

        private bool OpenConnection()
        {
            try
            {
                conn.Open();
                return true;
            }
            catch (MySqlException E)
            {
                switch(E.Number)
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
    }
}