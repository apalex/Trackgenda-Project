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
using System.Text.RegularExpressions;
using System.Net.Mail;

namespace Trackgenda
{
    public partial class RegisterForm : Form
    {
        public RegisterForm()
        {
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
                error += "\nTestEmailisValid";
            }
            if (isEmailInUse(emailTextBox.Text))
            {
                error += "\nTestEmailInUse";
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

            } else
            {
                MessageBox.Show(error, "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        public bool isValidEmailAddress(string email)
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

        public bool isEmailInUse(string email)
        {
            return true;
        }

        public bool isUsernameInUse(string username)
        {
            return true;
        }
    }
}
