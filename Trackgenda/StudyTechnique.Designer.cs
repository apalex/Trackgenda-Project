namespace Trackgenda
{
    partial class StudyTechnique
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(StudyTechnique));
            this.seperatorLabel = new System.Windows.Forms.Label();
            this.resetButton = new System.Windows.Forms.Button();
            this.controlButton = new System.Windows.Forms.Button();
            this.timeLabel = new System.Windows.Forms.Label();
            this.exitButton = new System.Windows.Forms.Button();
            this.displayLabel = new System.Windows.Forms.Label();
            this.mainTimer = new System.Windows.Forms.Timer(this.components);
            this.label1 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // seperatorLabel
            // 
            resources.ApplyResources(this.seperatorLabel, "seperatorLabel");
            this.seperatorLabel.BackColor = System.Drawing.Color.Transparent;
            this.seperatorLabel.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.seperatorLabel.Name = "seperatorLabel";
            // 
            // resetButton
            // 
            this.resetButton.BackColor = System.Drawing.Color.White;
            this.resetButton.Cursor = System.Windows.Forms.Cursors.Hand;
            resources.ApplyResources(this.resetButton, "resetButton");
            this.resetButton.Name = "resetButton";
            this.resetButton.UseVisualStyleBackColor = false;
            this.resetButton.Click += new System.EventHandler(this.resetButton_Click);
            // 
            // controlButton
            // 
            this.controlButton.BackColor = System.Drawing.Color.White;
            this.controlButton.Cursor = System.Windows.Forms.Cursors.Hand;
            resources.ApplyResources(this.controlButton, "controlButton");
            this.controlButton.Name = "controlButton";
            this.controlButton.UseVisualStyleBackColor = false;
            this.controlButton.Click += new System.EventHandler(this.controlButton_Click);
            // 
            // timeLabel
            // 
            this.timeLabel.BackColor = System.Drawing.Color.Transparent;
            resources.ApplyResources(this.timeLabel, "timeLabel");
            this.timeLabel.Name = "timeLabel";
            // 
            // exitButton
            // 
            resources.ApplyResources(this.exitButton, "exitButton");
            this.exitButton.BackColor = System.Drawing.Color.White;
            this.exitButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.exitButton.Name = "exitButton";
            this.exitButton.UseVisualStyleBackColor = false;
            this.exitButton.Click += new System.EventHandler(this.exitButton_Click);
            // 
            // displayLabel
            // 
            this.displayLabel.BackColor = System.Drawing.Color.Transparent;
            resources.ApplyResources(this.displayLabel, "displayLabel");
            this.displayLabel.Name = "displayLabel";
            // 
            // mainTimer
            // 
            this.mainTimer.Enabled = true;
            this.mainTimer.Interval = 1000;
            this.mainTimer.Tick += new System.EventHandler(this.mainTimer_Tick);
            // 
            // label1
            // 
            resources.ApplyResources(this.label1, "label1");
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Name = "label1";
            // 
            // StudyTechnique
            // 
            resources.ApplyResources(this, "$this");
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Dpi;
            this.BackColor = System.Drawing.Color.WhiteSmoke;
            this.Controls.Add(this.label1);
            this.Controls.Add(this.seperatorLabel);
            this.Controls.Add(this.resetButton);
            this.Controls.Add(this.controlButton);
            this.Controls.Add(this.timeLabel);
            this.Controls.Add(this.exitButton);
            this.Controls.Add(this.displayLabel);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "StudyTechnique";
            this.Load += new System.EventHandler(this.StudyTechnique_Load);
            this.MouseDown += new System.Windows.Forms.MouseEventHandler(this.StudyTechnique_MouseDown);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label seperatorLabel;
        private System.Windows.Forms.Button resetButton;
        private System.Windows.Forms.Button controlButton;
        private System.Windows.Forms.Label timeLabel;
        private System.Windows.Forms.Button exitButton;
        private System.Windows.Forms.Label displayLabel;
        private System.Windows.Forms.Timer mainTimer;
        private System.Windows.Forms.Label label1;
    }
}