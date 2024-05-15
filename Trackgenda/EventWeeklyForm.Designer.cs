namespace Trackgenda
{
    partial class EventWeeklyForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(EventWeeklyForm));
            this.exitButton = new System.Windows.Forms.Button();
            this.dateLabel = new System.Windows.Forms.Label();
            this.descTextBox = new System.Windows.Forms.TextBox();
            this.controlButton = new System.Windows.Forms.Button();
            this.colourComboBox = new System.Windows.Forms.ComboBox();
            this.SuspendLayout();
            // 
            // exitButton
            // 
            resources.ApplyResources(this.exitButton, "exitButton");
            this.exitButton.BackColor = System.Drawing.Color.White;
            this.exitButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.exitButton.ForeColor = System.Drawing.Color.Black;
            this.exitButton.Name = "exitButton";
            this.exitButton.UseVisualStyleBackColor = false;
            this.exitButton.Click += new System.EventHandler(this.exitButton_Click);
            // 
            // dateLabel
            // 
            this.dateLabel.BackColor = System.Drawing.Color.Transparent;
            resources.ApplyResources(this.dateLabel, "dateLabel");
            this.dateLabel.ForeColor = System.Drawing.Color.Black;
            this.dateLabel.Name = "dateLabel";
            // 
            // descTextBox
            // 
            this.descTextBox.ForeColor = System.Drawing.Color.Black;
            resources.ApplyResources(this.descTextBox, "descTextBox");
            this.descTextBox.Name = "descTextBox";
            // 
            // controlButton
            // 
            this.controlButton.BackColor = System.Drawing.Color.White;
            this.controlButton.Cursor = System.Windows.Forms.Cursors.Hand;
            resources.ApplyResources(this.controlButton, "controlButton");
            this.controlButton.ForeColor = System.Drawing.Color.Black;
            this.controlButton.Name = "controlButton";
            this.controlButton.UseVisualStyleBackColor = false;
            this.controlButton.Click += new System.EventHandler(this.controlButton_Click);
            // 
            // colourComboBox
            // 
            this.colourComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            resources.ApplyResources(this.colourComboBox, "colourComboBox");
            this.colourComboBox.ForeColor = System.Drawing.Color.Black;
            this.colourComboBox.FormattingEnabled = true;
            this.colourComboBox.Items.AddRange(new object[] {
            resources.GetString("colourComboBox.Items"),
            resources.GetString("colourComboBox.Items1"),
            resources.GetString("colourComboBox.Items2"),
            resources.GetString("colourComboBox.Items3"),
            resources.GetString("colourComboBox.Items4"),
            resources.GetString("colourComboBox.Items5"),
            resources.GetString("colourComboBox.Items6"),
            resources.GetString("colourComboBox.Items7"),
            resources.GetString("colourComboBox.Items8"),
            resources.GetString("colourComboBox.Items9"),
            resources.GetString("colourComboBox.Items10"),
            resources.GetString("colourComboBox.Items11"),
            resources.GetString("colourComboBox.Items12")});
            this.colourComboBox.Name = "colourComboBox";
            // 
            // EventWeeklyForm
            // 
            resources.ApplyResources(this, "$this");
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Dpi;
            this.AutoValidate = System.Windows.Forms.AutoValidate.EnablePreventFocusChange;
            this.BackColor = System.Drawing.Color.White;
            this.Controls.Add(this.colourComboBox);
            this.Controls.Add(this.controlButton);
            this.Controls.Add(this.descTextBox);
            this.Controls.Add(this.dateLabel);
            this.Controls.Add(this.exitButton);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "EventWeeklyForm";
            this.Load += new System.EventHandler(this.EventWeeklyForm_Load);
            this.MouseDown += new System.Windows.Forms.MouseEventHandler(this.EventWeeklyForm_MouseDown);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button exitButton;
        private System.Windows.Forms.Label dateLabel;
        private System.Windows.Forms.TextBox descTextBox;
        private System.Windows.Forms.Button controlButton;
        private System.Windows.Forms.ComboBox colourComboBox;
    }
}