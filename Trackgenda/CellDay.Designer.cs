namespace Trackgenda
{
    partial class CellDay
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
            this.indexDay = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // indexDay
            // 
            this.indexDay.AutoSize = true;
            this.indexDay.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.indexDay.Location = new System.Drawing.Point(22, 23);
            this.indexDay.Name = "indexDay";
            this.indexDay.Size = new System.Drawing.Size(26, 29);
            this.indexDay.TabIndex = 0;
            this.indexDay.Text = "0";
            // 
            // UserControlDays
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(144F, 144F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Dpi;
            this.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.Controls.Add(this.indexDay);
            this.Margin = new System.Windows.Forms.Padding(5, 9, 5, 9);
            this.Name = "UserControlDays";
            this.Size = new System.Drawing.Size(302, 202);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label indexDay;
    }
}
