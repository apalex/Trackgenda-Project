using System;
using System.Drawing;
using System.Windows.Forms;
using System.Text.RegularExpressions;

namespace Trackgenda
{
    public partial class ForgotPasswordForm : Form
    {
        private DatabaseConnection dbConn;

        public ForgotPasswordForm()
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
            this.Hide();
        }

        private void confirmButton_Click(object sender, EventArgs e)
        {
            if (usernameTextBox.TextLength == 0 || emailTextBox.TextLength == 0 || newPasswordTextBox.TextLength == 0 || confirmTextBox.TextLength == 0)
            {
                MessageBox.Show("Please fill in all the cases", "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            } else
            {
                if (dbConn.checkExistInDB(usernameTextBox.Text, emailTextBox.Text))
                {
                    if (Regex.Match(newPasswordTextBox.Text, "^(?=.*[a-z])(?=.*[A-Z])(?=.*\\d)(?=.*[@$!%*?&])[A-Za-z\\d@$!%*?&]{8,}$").Success)
                    {
                        if (newPasswordTextBox.Text == confirmTextBox.Text)
                        {
                            if (dbConn.isPassChanged(usernameTextBox.Text, newPasswordTextBox.Text))
                            {
                                MessageBox.Show("Password has been successfully changed!");
                                dbConn.CloseConnection();
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
