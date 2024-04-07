namespace Trackgenda
{
    partial class LoginForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.usernameLabel = new System.Windows.Forms.Label();
            this.passwordLabel = new System.Windows.Forms.Label();
            this.passwordTextBox = new System.Windows.Forms.TextBox();
            this.usernameTextBox = new System.Windows.Forms.TextBox();
            this.loginButton = new System.Windows.Forms.Button();
            this.XButton = new System.Windows.Forms.Button();
            this.registerLabel = new System.Windows.Forms.Label();
            this.forgotPasswordLabel = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.userPictureBox = new System.Windows.Forms.PictureBox();
            this.lockPictureBox = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.userPictureBox)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.lockPictureBox)).BeginInit();
            this.SuspendLayout();
            // 
            // usernameLabel
            // 
            this.usernameLabel.AutoSize = true;
            this.usernameLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.usernameLabel.Location = new System.Drawing.Point(38, 195);
            this.usernameLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.usernameLabel.Name = "usernameLabel";
            this.usernameLabel.Size = new System.Drawing.Size(150, 33);
            this.usernameLabel.TabIndex = 0;
            this.usernameLabel.Text = "Username";
            // 
            // passwordLabel
            // 
            this.passwordLabel.AutoSize = true;
            this.passwordLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.passwordLabel.Location = new System.Drawing.Point(38, 291);
            this.passwordLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.passwordLabel.Name = "passwordLabel";
            this.passwordLabel.Size = new System.Drawing.Size(143, 33);
            this.passwordLabel.TabIndex = 1;
            this.passwordLabel.Text = "Password";
            // 
            // passwordTextBox
            // 
            this.passwordTextBox.Location = new System.Drawing.Point(44, 332);
            this.passwordTextBox.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.passwordTextBox.Name = "passwordTextBox";
            this.passwordTextBox.Size = new System.Drawing.Size(332, 26);
            this.passwordTextBox.TabIndex = 2;
            // 
            // usernameTextBox
            // 
            this.usernameTextBox.Location = new System.Drawing.Point(44, 237);
            this.usernameTextBox.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.usernameTextBox.Name = "usernameTextBox";
            this.usernameTextBox.Size = new System.Drawing.Size(332, 26);
            this.usernameTextBox.TabIndex = 3;
            // 
            // loginButton
            // 
            this.loginButton.Location = new System.Drawing.Point(44, 389);
            this.loginButton.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.loginButton.Name = "loginButton";
            this.loginButton.Size = new System.Drawing.Size(334, 38);
            this.loginButton.TabIndex = 4;
            this.loginButton.Text = "Login";
            this.loginButton.UseVisualStyleBackColor = true;
            this.loginButton.Click += new System.EventHandler(this.loginButton_Click);
            // 
            // XButton
            // 
            this.XButton.BackColor = System.Drawing.Color.LightCoral;
            this.XButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.XButton.ForeColor = System.Drawing.Color.Snow;
            this.XButton.Location = new System.Drawing.Point(382, -2);
            this.XButton.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.XButton.Name = "XButton";
            this.XButton.Size = new System.Drawing.Size(68, 40);
            this.XButton.TabIndex = 9;
            this.XButton.Text = "X";
            this.XButton.UseVisualStyleBackColor = false;
            this.XButton.Click += new System.EventHandler(this.XButton_Click);
            // 
            // registerLabel
            // 
            this.registerLabel.AutoSize = true;
            this.registerLabel.Cursor = System.Windows.Forms.Cursors.Hand;
            this.registerLabel.Location = new System.Drawing.Point(72, 489);
            this.registerLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.registerLabel.Name = "registerLabel";
            this.registerLabel.Size = new System.Drawing.Size(284, 20);
            this.registerLabel.TabIndex = 8;
            this.registerLabel.Text = "Don\'t have an account? Register Here!";
            this.registerLabel.Click += new System.EventHandler(this.registerLabel_Click);
            // 
            // forgotPasswordLabel
            // 
            this.forgotPasswordLabel.AutoSize = true;
            this.forgotPasswordLabel.Cursor = System.Windows.Forms.Cursors.Hand;
            this.forgotPasswordLabel.Location = new System.Drawing.Point(105, 454);
            this.forgotPasswordLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.forgotPasswordLabel.Name = "forgotPasswordLabel";
            this.forgotPasswordLabel.Size = new System.Drawing.Size(218, 20);
            this.forgotPasswordLabel.TabIndex = 7;
            this.forgotPasswordLabel.Text = "Forgot Password? Click Here!";
            this.forgotPasswordLabel.Click += new System.EventHandler(this.forgotPasswordLabel_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::Trackgenda.Properties.Resources.TG;
            this.pictureBox1.Location = new System.Drawing.Point(109, 31);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(212, 124);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 10;
            this.pictureBox1.TabStop = false;
            // 
            // userPictureBox
            // 
            this.userPictureBox.BackColor = System.Drawing.Color.Transparent;
            this.userPictureBox.Image = global::Trackgenda.Properties.Resources.Sample_User_Icon;
            this.userPictureBox.Location = new System.Drawing.Point(185, 197);
            this.userPictureBox.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.userPictureBox.Name = "userPictureBox";
            this.userPictureBox.Size = new System.Drawing.Size(45, 31);
            this.userPictureBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.userPictureBox.TabIndex = 6;
            this.userPictureBox.TabStop = false;
            // 
            // lockPictureBox
            // 
            this.lockPictureBox.BackColor = System.Drawing.Color.Transparent;
            this.lockPictureBox.Image = global::Trackgenda.Properties.Resources.Lock_icon;
            this.lockPictureBox.Location = new System.Drawing.Point(185, 293);
            this.lockPictureBox.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.lockPictureBox.Name = "lockPictureBox";
            this.lockPictureBox.Size = new System.Drawing.Size(45, 31);
            this.lockPictureBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.lockPictureBox.TabIndex = 5;
            this.lockPictureBox.TabStop = false;
            // 
            // LoginForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(450, 615);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.XButton);
            this.Controls.Add(this.registerLabel);
            this.Controls.Add(this.forgotPasswordLabel);
            this.Controls.Add(this.userPictureBox);
            this.Controls.Add(this.lockPictureBox);
            this.Controls.Add(this.loginButton);
            this.Controls.Add(this.usernameTextBox);
            this.Controls.Add(this.passwordTextBox);
            this.Controls.Add(this.passwordLabel);
            this.Controls.Add(this.usernameLabel);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "LoginForm";
            this.MouseDown += new System.Windows.Forms.MouseEventHandler(this.LoginForm_MouseDown);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.userPictureBox)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.lockPictureBox)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label usernameLabel;
        private System.Windows.Forms.Label passwordLabel;
        private System.Windows.Forms.TextBox passwordTextBox;
        private System.Windows.Forms.TextBox usernameTextBox;
        private System.Windows.Forms.Button loginButton;
        private System.Windows.Forms.PictureBox lockPictureBox;
        private System.Windows.Forms.PictureBox userPictureBox;
        private System.Windows.Forms.Button XButton;
        private System.Windows.Forms.Label registerLabel;
        private System.Windows.Forms.Label forgotPasswordLabel;
        private System.Windows.Forms.PictureBox pictureBox1;
    }
}

