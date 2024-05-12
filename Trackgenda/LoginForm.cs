using System;
using System.Windows.Forms;

namespace Trackgenda
{
    public partial class LoginForm : Form
    {
        private DatabaseConnection dbConn;

        public LoginForm()
        {
            dbConn = new DatabaseConnection();
            dbConn.OpenConnection();
            InitializeComponent();
        }

        private void LoginForm_MouseDown(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                DraggeableForms.Drag(this.Handle);
            }
        }

        private void XButton_Click(object sender, EventArgs e)
        {
            dbConn.CloseConnection();
            Application.Exit();
        }

        private void registerLabel_Click(object sender, EventArgs e)
        {
            dbConn.CloseConnection();
            RegisterForm registerForm = new RegisterForm();
            registerForm.Show();
            this.Hide();
        }

        private void forgotPasswordLabel_Click(object sender, EventArgs e)
        {
            dbConn.CloseConnection();
            ForgotPasswordForm forgotPasswordForm = new ForgotPasswordForm();
            forgotPasswordForm.Show();
            this.Hide();
        }

        private void loginButton_Click(object sender, EventArgs e)
        {
            if (usernameTextBox.TextLength == 0 || passwordTextBox.TextLength == 0)
            {
                MessageBox.Show("Username or Password missing", "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            } else
            {
                if (dbConn.IsLogin(usernameTextBox.Text,passwordTextBox.Text))
                {
                    int uid = dbConn.getUID(usernameTextBox.Text);
                    if (uid != 0)
                    {
                        dbConn.CloseConnection();
                        ProgressBarForm progressBarForm = new ProgressBarForm(uid);
                        progressBarForm.Show();
                        this.Hide();
                    } else
                    {
                        MessageBox.Show("An error has occured! Please try again", "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    }
                }
                else
                {
                    MessageBox.Show("Username or Password is wrong", "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
            }
        }

        private void LoginForm_Load(object sender, EventArgs e)
        {
            closeButton1.Select();
        }
    }
}
