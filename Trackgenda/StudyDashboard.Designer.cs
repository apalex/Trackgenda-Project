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
            this.personalButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.personalButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.personalButton.Location = new System.Drawing.Point(12, 12);
            this.personalButton.Name = "personalButton";
            this.personalButton.Size = new System.Drawing.Size(209, 62);
            this.personalButton.TabIndex = 0;
            this.personalButton.Text = "Personal";
            this.personalButton.UseVisualStyleBackColor = false;
            // 
            // pomodoroButton
            // 
            this.pomodoroButton.BackColor = System.Drawing.Color.White;
            this.pomodoroButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.pomodoroButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.pomodoroButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.pomodoroButton.Location = new System.Drawing.Point(229, 12);
            this.pomodoroButton.Name = "pomodoroButton";
            this.pomodoroButton.Size = new System.Drawing.Size(209, 62);
            this.pomodoroButton.TabIndex = 1;
            this.pomodoroButton.Text = "Pomodoro";
            this.pomodoroButton.UseVisualStyleBackColor = false;
            // 
            // fiftyTwoSeventeenRuleButton
            // 
            this.fiftyTwoSeventeenRuleButton.BackColor = System.Drawing.Color.White;
            this.fiftyTwoSeventeenRuleButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.fiftyTwoSeventeenRuleButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.fiftyTwoSeventeenRuleButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.fiftyTwoSeventeenRuleButton.Location = new System.Drawing.Point(12, 80);
            this.fiftyTwoSeventeenRuleButton.Name = "fiftyTwoSeventeenRuleButton";
            this.fiftyTwoSeventeenRuleButton.Size = new System.Drawing.Size(209, 62);
            this.fiftyTwoSeventeenRuleButton.TabIndex = 2;
            this.fiftyTwoSeventeenRuleButton.Text = "52/17 Rule";
            this.fiftyTwoSeventeenRuleButton.UseVisualStyleBackColor = false;
            // 
            // exitButton
            // 
            this.exitButton.BackColor = System.Drawing.Color.White;
            this.exitButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.exitButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.exitButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.exitButton.Location = new System.Drawing.Point(229, 80);
            this.exitButton.Name = "exitButton";
            this.exitButton.Size = new System.Drawing.Size(209, 62);
            this.exitButton.TabIndex = 3;
            this.exitButton.Text = "Exit";
            this.exitButton.UseVisualStyleBackColor = false;
            this.exitButton.Click += new System.EventHandler(this.exitButton_Click);
            // 
            // StudyDashboard
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(144F, 144F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Dpi;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(450, 150);
            this.Controls.Add(this.exitButton);
            this.Controls.Add(this.fiftyTwoSeventeenRuleButton);
            this.Controls.Add(this.pomodoroButton);
            this.Controls.Add(this.personalButton);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "StudyDashboard";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button personalButton;
        private System.Windows.Forms.Button pomodoroButton;
        private System.Windows.Forms.Button fiftyTwoSeventeenRuleButton;
        private System.Windows.Forms.Button exitButton;
    }
}