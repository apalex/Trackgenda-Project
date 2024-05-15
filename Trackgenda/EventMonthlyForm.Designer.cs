namespace Trackgenda
{
    partial class EventMonthlyForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(EventMonthlyForm));
            this.exitButton = new System.Windows.Forms.Button();
            this.descTextBox = new System.Windows.Forms.TextBox();
            this.dateLabel = new System.Windows.Forms.Label();
            this.addButton = new System.Windows.Forms.Button();
            this.maximumLabel = new System.Windows.Forms.Label();
            this.editButton = new System.Windows.Forms.Button();
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
            // descTextBox
            // 
            resources.ApplyResources(this.descTextBox, "descTextBox");
            this.descTextBox.Name = "descTextBox";
            // 
            // dateLabel
            // 
            this.dateLabel.BackColor = System.Drawing.Color.Transparent;
            resources.ApplyResources(this.dateLabel, "dateLabel");
            this.dateLabel.ForeColor = System.Drawing.Color.Black;
            this.dateLabel.Name = "dateLabel";
            // 
            // addButton
            // 
            resources.ApplyResources(this.addButton, "addButton");
            this.addButton.BackColor = System.Drawing.Color.White;
            this.addButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.addButton.ForeColor = System.Drawing.Color.Black;
            this.addButton.Name = "addButton";
            this.addButton.UseVisualStyleBackColor = false;
            this.addButton.Click += new System.EventHandler(this.saveButton_Click);
            // 
            // maximumLabel
            // 
            resources.ApplyResources(this.maximumLabel, "maximumLabel");
            this.maximumLabel.BackColor = System.Drawing.Color.Transparent;
            this.maximumLabel.ForeColor = System.Drawing.Color.Red;
            this.maximumLabel.Name = "maximumLabel";
            // 
            // editButton
            // 
            resources.ApplyResources(this.editButton, "editButton");
            this.editButton.BackColor = System.Drawing.Color.White;
            this.editButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.editButton.ForeColor = System.Drawing.Color.Black;
            this.editButton.Name = "editButton";
            this.editButton.UseVisualStyleBackColor = false;
            this.editButton.Click += new System.EventHandler(this.editButton_Click);
            // 
            // colourComboBox
            // 
            this.colourComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
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
            resources.ApplyResources(this.colourComboBox, "colourComboBox");
            this.colourComboBox.Name = "colourComboBox";
            // 
            // EventMonthlyForm
            // 
            resources.ApplyResources(this, "$this");
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Dpi;
            this.BackColor = System.Drawing.Color.WhiteSmoke;
            this.Controls.Add(this.colourComboBox);
            this.Controls.Add(this.editButton);
            this.Controls.Add(this.maximumLabel);
            this.Controls.Add(this.addButton);
            this.Controls.Add(this.dateLabel);
            this.Controls.Add(this.descTextBox);
            this.Controls.Add(this.exitButton);
            this.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "EventMonthlyForm";
            this.Load += new System.EventHandler(this.EventMonthlyForm_Load);
            this.MouseDown += new System.Windows.Forms.MouseEventHandler(this.EventMonthlyForm_MouseDown);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button exitButton;
        private System.Windows.Forms.TextBox descTextBox;
        private System.Windows.Forms.Label dateLabel;
        private System.Windows.Forms.Button addButton;
        private System.Windows.Forms.Label maximumLabel;
        private System.Windows.Forms.Button editButton;
        private System.Windows.Forms.ComboBox colourComboBox;
    }
}