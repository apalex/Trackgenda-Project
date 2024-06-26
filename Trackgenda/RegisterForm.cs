﻿using System;
using System.Drawing;
using System.Windows.Forms;
using System.Text.RegularExpressions;
using System.Net.Mail;

namespace Trackgenda
{
    public partial class RegisterForm : Form
    {
        private DatabaseConnection dbConn;

        public RegisterForm()
        {
            dbConn = new DatabaseConnection();
            dbConn.OpenConnection();
            InitializeComponent();
        }

        private void RegisterForm_MouseDown(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                DraggeableForms.Drag(this.Handle);
            }
        }

        private void XButton_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void backButton_Click(object sender, EventArgs e)
        {
            dbConn.CloseConnection();
            LoginForm loginForm = new LoginForm();
            loginForm.Show();
            this.Close();
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
            if (dbConn.isEmailInUse(emailTextBox.Text))
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
                } else if (dbConn.isUsernameInUse(usernameTextBox.Text))
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
                if (dbConn.InsertUser(firstNameTextBox.Text,lastNameTextBox.Text,emailTextBox.Text,usernameTextBox.Text,passwordTextBox.Text) && 
                    dbConn.InsertDefaultSettings(dbConn.getUID(usernameTextBox.Text)))
                {
                    MessageBox.Show("Account has been successfully made!");
                    LoginForm loginForm = new LoginForm();
                    loginForm.Show();
                    dbConn.CloseConnection();
                    this.Close();
                } else
                {
                    MessageBox.Show("An error has occured, please try again!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
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

        private void firstNameTextBox_Enter(object sender, EventArgs e)
        {
            if (firstNameTextBox.Text == "John")
            {
                firstNameTextBox.Text = "";
                firstNameTextBox.ForeColor = Color.Black;
            }
        }

        private void lastNameTextBox_Enter(object sender, EventArgs e)
        {
            if (lastNameTextBox.Text == "Doe")
            {
                lastNameTextBox.Text = "";
                lastNameTextBox.ForeColor = Color.Black;
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

        private void usernameTextBox_Enter(object sender, EventArgs e)
        {
            if (usernameTextBox.Text == "Username")
            {
                usernameTextBox.Text = "";
                usernameTextBox.ForeColor = Color.Black;
            }
        }

        private void passwordTextBox_Enter(object sender, EventArgs e)
        {
            if (passwordTextBox.Text == "Password")
            {
                passwordTextBox.Text = "";
                passwordTextBox.ForeColor = Color.Black;
                passwordTextBox.PasswordChar = '*';
            }
        }

        private void confirmTextBox_Enter(object sender, EventArgs e)
        {
            if (confirmTextBox.Text == "Password")
            {
                confirmTextBox.Text = "";
                confirmTextBox.ForeColor = Color.Black;
                confirmTextBox.PasswordChar = '*';
            }
        }

        private void firstNameTextBox_Leave(object sender, EventArgs e)
        {
            if (firstNameTextBox.Text == "")
            {
                firstNameTextBox.Text = "John";
                firstNameTextBox.ForeColor = Color.DarkGray;
            }
        }

        private void lastNameTextBox_Leave(object sender, EventArgs e)
        {
            if (lastNameTextBox.Text == "")
            {
                lastNameTextBox.Text = "Doe";
                lastNameTextBox.ForeColor = Color.DarkGray;
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

        private void usernameTextBox_Leave(object sender, EventArgs e)
        {
            if (usernameTextBox.Text == "")
            {
                usernameTextBox.Text = "Username";
                usernameTextBox.ForeColor = Color.DarkGray;
            }
        }

        private void passwordTextBox_Leave(object sender, EventArgs e)
        {
            if (passwordTextBox.Text == "")
            {
                passwordTextBox.Text = "Password";
                passwordTextBox.ForeColor = Color.DarkGray;
                passwordTextBox.PasswordChar = '\0';
            }
        }

        private void confirmTextBox_Leave(object sender, EventArgs e)
        {
            if (confirmTextBox.Text == "")
            {
                confirmTextBox.Text = "Password";
                confirmTextBox.ForeColor = Color.DarkGray;
                confirmTextBox.PasswordChar = '\0';
            }
        }

        private void RegisterForm_Load(object sender, EventArgs e)
        {
            closeButton1.Select();
        }
    }
}
