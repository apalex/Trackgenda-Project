namespace Trackgenda
{
    partial class CloseButton
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.XButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // XButton
            // 
            this.XButton.BackColor = System.Drawing.Color.LightCoral;
            this.XButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.XButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.XButton.ForeColor = System.Drawing.Color.Snow;
            this.XButton.Location = new System.Drawing.Point(0, 0);
            this.XButton.Name = "XButton";
            this.XButton.Size = new System.Drawing.Size(68, 40);
            this.XButton.TabIndex = 0;
            this.XButton.Text = "X";
            this.XButton.UseVisualStyleBackColor = false;
            this.XButton.Click += new System.EventHandler(this.XButton_Click);
            // 
            // CloseButton
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.XButton);
            this.Name = "CloseButton";
            this.Size = new System.Drawing.Size(68, 40);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button XButton;
    }
}
