namespace Trackgenda
{
    partial class MotivationalQuoteForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MotivationalQuoteForm));
            this.displayLabel = new System.Windows.Forms.Label();
            this.quotelabel = new System.Windows.Forms.Label();
            this.closeButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // displayLabel
            // 
            resources.ApplyResources(this.displayLabel, "displayLabel");
            this.displayLabel.BackColor = System.Drawing.Color.Transparent;
            this.displayLabel.Name = "displayLabel";
            // 
            // quotelabel
            // 
            resources.ApplyResources(this.quotelabel, "quotelabel");
            this.quotelabel.BackColor = System.Drawing.Color.Transparent;
            this.quotelabel.Name = "quotelabel";
            // 
            // closeButton
            // 
            resources.ApplyResources(this.closeButton, "closeButton");
            this.closeButton.BackColor = System.Drawing.Color.DarkGray;
            this.closeButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.closeButton.ForeColor = System.Drawing.Color.Black;
            this.closeButton.Name = "closeButton";
            this.closeButton.UseVisualStyleBackColor = false;
            this.closeButton.Click += new System.EventHandler(this.closeButton_Click);
            // 
            // MotivationalQuoteForm
            // 
            resources.ApplyResources(this, "$this");
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Dpi;
            this.BackColor = System.Drawing.Color.Gray;
            this.Controls.Add(this.closeButton);
            this.Controls.Add(this.quotelabel);
            this.Controls.Add(this.displayLabel);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "MotivationalQuoteForm";
            this.Load += new System.EventHandler(this.MotivionalQuoteForm_Load);
            this.MouseDown += new System.Windows.Forms.MouseEventHandler(this.MotivionalQuoteForm_MouseDown);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label displayLabel;
        private System.Windows.Forms.Label quotelabel;
        private System.Windows.Forms.Button closeButton;
    }
}