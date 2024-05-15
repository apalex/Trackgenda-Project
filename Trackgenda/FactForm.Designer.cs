namespace Trackgenda
{
    partial class FactForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FactForm));
            this.closeButton = new System.Windows.Forms.Button();
            this.factLabel = new System.Windows.Forms.Label();
            this.displayLabel = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // closeButton
            // 
            this.closeButton.BackColor = System.Drawing.Color.LightCoral;
            this.closeButton.Cursor = System.Windows.Forms.Cursors.Hand;
            resources.ApplyResources(this.closeButton, "closeButton");
            this.closeButton.ForeColor = System.Drawing.Color.White;
            this.closeButton.Name = "closeButton";
            this.closeButton.UseVisualStyleBackColor = false;
            this.closeButton.Click += new System.EventHandler(this.closeButton_Click);
            // 
            // factLabel
            // 
            this.factLabel.BackColor = System.Drawing.Color.Transparent;
            resources.ApplyResources(this.factLabel, "factLabel");
            this.factLabel.Name = "factLabel";
            // 
            // displayLabel
            // 
            this.displayLabel.BackColor = System.Drawing.Color.Transparent;
            resources.ApplyResources(this.displayLabel, "displayLabel");
            this.displayLabel.Name = "displayLabel";
            // 
            // FactForm
            // 
            resources.ApplyResources(this, "$this");
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Dpi;
            this.BackColor = System.Drawing.Color.Gainsboro;
            this.Controls.Add(this.displayLabel);
            this.Controls.Add(this.factLabel);
            this.Controls.Add(this.closeButton);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "FactForm";
            this.Load += new System.EventHandler(this.FactForm_Load);
            this.MouseDown += new System.Windows.Forms.MouseEventHandler(this.FactForm_MouseDown);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button closeButton;
        private System.Windows.Forms.Label factLabel;
        private System.Windows.Forms.Label displayLabel;
    }
}