namespace Trackgenda
{
    partial class ForgotPasswordForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ForgotPasswordForm));
            this.backButton = new System.Windows.Forms.Button();
            this.usernameLabel = new System.Windows.Forms.Label();
            this.newPasswordLabel = new System.Windows.Forms.Label();
            this.emailLabel = new System.Windows.Forms.Label();
            this.confirmLabel = new System.Windows.Forms.Label();
            this.usernameTextBox = new System.Windows.Forms.TextBox();
            this.emailTextBox = new System.Windows.Forms.TextBox();
            this.confirmTextBox = new System.Windows.Forms.TextBox();
            this.newPasswordTextBox = new System.Windows.Forms.TextBox();
            this.confirmButton = new System.Windows.Forms.Button();
            this.closeButton1 = new Trackgenda.CloseButton();
            this.SuspendLayout();
            // 
            // backButton
            // 
            this.backButton.Cursor = System.Windows.Forms.Cursors.Hand;
            resources.ApplyResources(this.backButton, "backButton");
            this.backButton.Name = "backButton";
            this.backButton.UseVisualStyleBackColor = true;
            this.backButton.Click += new System.EventHandler(this.backButton_Click);
            // 
            // usernameLabel
            // 
            resources.ApplyResources(this.usernameLabel, "usernameLabel");
            this.usernameLabel.Name = "usernameLabel";
            // 
            // newPasswordLabel
            // 
            resources.ApplyResources(this.newPasswordLabel, "newPasswordLabel");
            this.newPasswordLabel.Name = "newPasswordLabel";
            // 
            // emailLabel
            // 
            resources.ApplyResources(this.emailLabel, "emailLabel");
            this.emailLabel.Name = "emailLabel";
            // 
            // confirmLabel
            // 
            resources.ApplyResources(this.confirmLabel, "confirmLabel");
            this.confirmLabel.Name = "confirmLabel";
            // 
            // usernameTextBox
            // 
            resources.ApplyResources(this.usernameTextBox, "usernameTextBox");
            this.usernameTextBox.ForeColor = System.Drawing.Color.DarkGray;
            this.usernameTextBox.Name = "usernameTextBox";
            this.usernameTextBox.Enter += new System.EventHandler(this.usernameTextBox_Enter);
            this.usernameTextBox.Leave += new System.EventHandler(this.usernameTextBox_Leave);
            // 
            // emailTextBox
            // 
            resources.ApplyResources(this.emailTextBox, "emailTextBox");
            this.emailTextBox.ForeColor = System.Drawing.Color.DarkGray;
            this.emailTextBox.Name = "emailTextBox";
            this.emailTextBox.Enter += new System.EventHandler(this.emailTextBox_Enter);
            this.emailTextBox.Leave += new System.EventHandler(this.emailTextBox_Leave);
            // 
            // confirmTextBox
            // 
            resources.ApplyResources(this.confirmTextBox, "confirmTextBox");
            this.confirmTextBox.ForeColor = System.Drawing.Color.DarkGray;
            this.confirmTextBox.Name = "confirmTextBox";
            this.confirmTextBox.Enter += new System.EventHandler(this.confirmTextBox_Enter);
            this.confirmTextBox.Leave += new System.EventHandler(this.confirmTextBox_Leave);
            // 
            // newPasswordTextBox
            // 
            resources.ApplyResources(this.newPasswordTextBox, "newPasswordTextBox");
            this.newPasswordTextBox.ForeColor = System.Drawing.Color.DarkGray;
            this.newPasswordTextBox.Name = "newPasswordTextBox";
            this.newPasswordTextBox.Enter += new System.EventHandler(this.newPasswordTextBox_Enter);
            this.newPasswordTextBox.Leave += new System.EventHandler(this.newPasswordTextBox_Leave);
            // 
            // confirmButton
            // 
            this.confirmButton.Cursor = System.Windows.Forms.Cursors.Hand;
            resources.ApplyResources(this.confirmButton, "confirmButton");
            this.confirmButton.Name = "confirmButton";
            this.confirmButton.UseVisualStyleBackColor = true;
            this.confirmButton.Click += new System.EventHandler(this.confirmButton_Click);
            // 
            // closeButton1
            // 
            resources.ApplyResources(this.closeButton1, "closeButton1");
            this.closeButton1.Name = "closeButton1";
            // 
            // ForgotPasswordForm
            // 
            resources.ApplyResources(this, "$this");
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.Controls.Add(this.closeButton1);
            this.Controls.Add(this.confirmButton);
            this.Controls.Add(this.newPasswordTextBox);
            this.Controls.Add(this.confirmTextBox);
            this.Controls.Add(this.emailTextBox);
            this.Controls.Add(this.usernameTextBox);
            this.Controls.Add(this.confirmLabel);
            this.Controls.Add(this.emailLabel);
            this.Controls.Add(this.newPasswordLabel);
            this.Controls.Add(this.usernameLabel);
            this.Controls.Add(this.backButton);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "ForgotPasswordForm";
            this.Load += new System.EventHandler(this.ForgotPasswordForm_Load);
            this.MouseDown += new System.Windows.Forms.MouseEventHandler(this.RegisterForm_MouseDown);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button backButton;
        private System.Windows.Forms.Label usernameLabel;
        private System.Windows.Forms.Label newPasswordLabel;
        private System.Windows.Forms.Label emailLabel;
        private System.Windows.Forms.Label confirmLabel;
        private System.Windows.Forms.TextBox usernameTextBox;
        private System.Windows.Forms.TextBox emailTextBox;
        private System.Windows.Forms.TextBox confirmTextBox;
        private System.Windows.Forms.TextBox newPasswordTextBox;
        private System.Windows.Forms.Button confirmButton;
        private CloseButton closeButton1;
    }
}