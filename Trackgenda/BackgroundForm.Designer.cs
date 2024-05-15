namespace Trackgenda
{
    partial class BackgroundForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(BackgroundForm));
            this.imageButton = new System.Windows.Forms.Button();
            this.exitButton = new System.Windows.Forms.Button();
            this.gifButton = new System.Windows.Forms.Button();
            this.resetButton = new System.Windows.Forms.Button();
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            this.SuspendLayout();
            // 
            // imageButton
            // 
            resources.ApplyResources(this.imageButton, "imageButton");
            this.imageButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(179)))), ((int)(((byte)(179)))), ((int)(((byte)(179)))));
            this.imageButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.imageButton.ForeColor = System.Drawing.Color.Black;
            this.imageButton.Name = "imageButton";
            this.imageButton.UseVisualStyleBackColor = false;
            this.imageButton.Click += new System.EventHandler(this.imageButton_Click);
            // 
            // exitButton
            // 
            resources.ApplyResources(this.exitButton, "exitButton");
            this.exitButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(179)))), ((int)(((byte)(179)))), ((int)(((byte)(179)))));
            this.exitButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.exitButton.ForeColor = System.Drawing.Color.Black;
            this.exitButton.Name = "exitButton";
            this.exitButton.UseVisualStyleBackColor = false;
            this.exitButton.Click += new System.EventHandler(this.exitButton_Click);
            // 
            // gifButton
            // 
            resources.ApplyResources(this.gifButton, "gifButton");
            this.gifButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(179)))), ((int)(((byte)(179)))), ((int)(((byte)(179)))));
            this.gifButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.gifButton.ForeColor = System.Drawing.Color.Black;
            this.gifButton.Name = "gifButton";
            this.gifButton.UseVisualStyleBackColor = false;
            this.gifButton.Click += new System.EventHandler(this.gifButton_Click);
            // 
            // resetButton
            // 
            resources.ApplyResources(this.resetButton, "resetButton");
            this.resetButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(179)))), ((int)(((byte)(179)))), ((int)(((byte)(179)))));
            this.resetButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.resetButton.ForeColor = System.Drawing.Color.Black;
            this.resetButton.Name = "resetButton";
            this.resetButton.UseVisualStyleBackColor = false;
            this.resetButton.Click += new System.EventHandler(this.resetButton_Click);
            // 
            // openFileDialog1
            // 
            this.openFileDialog1.FileName = "openFileDialog1";
            // 
            // BackgroundForm
            // 
            resources.ApplyResources(this, "$this");
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Dpi;
            this.BackColor = System.Drawing.Color.DarkGray;
            this.Controls.Add(this.resetButton);
            this.Controls.Add(this.gifButton);
            this.Controls.Add(this.exitButton);
            this.Controls.Add(this.imageButton);
            this.ForeColor = System.Drawing.SystemColors.ControlText;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "BackgroundForm";
            this.Load += new System.EventHandler(this.BackgroundForm_Load);
            this.MouseDown += new System.Windows.Forms.MouseEventHandler(this.BackgroundForm_MouseDown);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button imageButton;
        private System.Windows.Forms.Button exitButton;
        private System.Windows.Forms.Button gifButton;
        private System.Windows.Forms.Button resetButton;
        private System.Windows.Forms.OpenFileDialog openFileDialog1;
    }
}