namespace Trackgenda
{
    partial class StudyDashboard
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(StudyDashboard));
            this.personalButton = new System.Windows.Forms.Button();
            this.pomodoroButton = new System.Windows.Forms.Button();
            this.fiftyTwoSeventeenRuleButton = new System.Windows.Forms.Button();
            this.exitButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // personalButton
            // 
            this.personalButton.BackColor = System.Drawing.Color.White;
            this.personalButton.Cursor = System.Windows.Forms.Cursors.Hand;
            resources.ApplyResources(this.personalButton, "personalButton");
            this.personalButton.Name = "personalButton";
            this.personalButton.UseVisualStyleBackColor = false;
            this.personalButton.Click += new System.EventHandler(this.personalButton_Click);
            // 
            // pomodoroButton
            // 
            this.pomodoroButton.BackColor = System.Drawing.Color.White;
            this.pomodoroButton.Cursor = System.Windows.Forms.Cursors.Hand;
            resources.ApplyResources(this.pomodoroButton, "pomodoroButton");
            this.pomodoroButton.Name = "pomodoroButton";
            this.pomodoroButton.UseVisualStyleBackColor = false;
            this.pomodoroButton.Click += new System.EventHandler(this.pomodoroButton_Click);
            // 
            // fiftyTwoSeventeenRuleButton
            // 
            this.fiftyTwoSeventeenRuleButton.BackColor = System.Drawing.Color.White;
            this.fiftyTwoSeventeenRuleButton.Cursor = System.Windows.Forms.Cursors.Hand;
            resources.ApplyResources(this.fiftyTwoSeventeenRuleButton, "fiftyTwoSeventeenRuleButton");
            this.fiftyTwoSeventeenRuleButton.Name = "fiftyTwoSeventeenRuleButton";
            this.fiftyTwoSeventeenRuleButton.UseVisualStyleBackColor = false;
            this.fiftyTwoSeventeenRuleButton.Click += new System.EventHandler(this.fiftyTwoSeventeenRuleButton_Click);
            // 
            // exitButton
            // 
            this.exitButton.BackColor = System.Drawing.Color.White;
            this.exitButton.Cursor = System.Windows.Forms.Cursors.Hand;
            resources.ApplyResources(this.exitButton, "exitButton");
            this.exitButton.Name = "exitButton";
            this.exitButton.UseVisualStyleBackColor = false;
            this.exitButton.Click += new System.EventHandler(this.exitButton_Click);
            // 
            // StudyDashboard
            // 
            resources.ApplyResources(this, "$this");
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Dpi;
            this.BackColor = System.Drawing.Color.Gainsboro;
            this.Controls.Add(this.exitButton);
            this.Controls.Add(this.fiftyTwoSeventeenRuleButton);
            this.Controls.Add(this.pomodoroButton);
            this.Controls.Add(this.personalButton);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "StudyDashboard";
            this.Load += new System.EventHandler(this.StudyDashboard_Load);
            this.MouseDown += new System.Windows.Forms.MouseEventHandler(this.StudyDashboard_MouseDown);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button personalButton;
        private System.Windows.Forms.Button pomodoroButton;
        private System.Windows.Forms.Button fiftyTwoSeventeenRuleButton;
        private System.Windows.Forms.Button exitButton;
    }
}