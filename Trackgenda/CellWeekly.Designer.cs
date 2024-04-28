namespace Trackgenda
{
    partial class CellWeekly
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
            this.eventDisplayLabel = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // eventDisplayLabel
            // 
            this.eventDisplayLabel.BackColor = System.Drawing.Color.Transparent;
            this.eventDisplayLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.eventDisplayLabel.Location = new System.Drawing.Point(32, 14);
            this.eventDisplayLabel.Name = "eventDisplayLabel";
            this.eventDisplayLabel.Size = new System.Drawing.Size(243, 69);
            this.eventDisplayLabel.TabIndex = 0;
            this.eventDisplayLabel.Text = "EVENT";
            this.eventDisplayLabel.Click += new System.EventHandler(this.eventDisplayLabel_Click);
            this.eventDisplayLabel.MouseLeave += new System.EventHandler(this.eventDisplayLabel_MouseLeave);
            this.eventDisplayLabel.MouseHover += new System.EventHandler(this.eventDisplayLabel_MouseHover);
            // 
            // CellWeekly
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(144F, 144F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Dpi;
            this.BackColor = System.Drawing.Color.White;
            this.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.Controls.Add(this.eventDisplayLabel);
            this.Margin = new System.Windows.Forms.Padding(0);
            this.Name = "CellWeekly";
            this.Size = new System.Drawing.Size(300, 100);
            this.Load += new System.EventHandler(this.CellWeekly_Load);
            this.Click += new System.EventHandler(this.CellWeekly_Click);
            this.MouseLeave += new System.EventHandler(this.CellWeekly_MouseLeave);
            this.MouseHover += new System.EventHandler(this.CellWeekly_MouseHover);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label eventDisplayLabel;
    }
}
