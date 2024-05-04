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
            this.event1Label = new System.Windows.Forms.Label();
            this.event2Label = new System.Windows.Forms.Label();
            this.event3Label = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // indexDay
            // 
            this.indexDay.AutoSize = true;
            this.indexDay.BackColor = System.Drawing.Color.Transparent;
            this.indexDay.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.indexDay.ForeColor = System.Drawing.Color.White;
            this.indexDay.Location = new System.Drawing.Point(22, 23);
            this.indexDay.Name = "indexDay";
            this.indexDay.Size = new System.Drawing.Size(26, 29);
            this.indexDay.TabIndex = 0;
            this.indexDay.Text = "0";
            this.indexDay.MouseHover += new System.EventHandler(this.indexDay_MouseHover);
            // 
            // event1Label
            // 
            this.event1Label.AutoSize = true;
            this.event1Label.BackColor = System.Drawing.Color.Transparent;
            this.event1Label.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.event1Label.ForeColor = System.Drawing.Color.White;
            this.event1Label.Location = new System.Drawing.Point(81, 30);
            this.event1Label.Name = "event1Label";
            this.event1Label.Size = new System.Drawing.Size(0, 25);
            this.event1Label.TabIndex = 1;
            this.event1Label.Click += new System.EventHandler(this.event1Label_Click);
            this.event1Label.MouseHover += new System.EventHandler(this.event1Label_MouseHover);
            // 
            // event2Label
            // 
            this.event2Label.AutoSize = true;
            this.event2Label.BackColor = System.Drawing.Color.Transparent;
            this.event2Label.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.event2Label.ForeColor = System.Drawing.Color.White;
            this.event2Label.Location = new System.Drawing.Point(81, 91);
            this.event2Label.Name = "event2Label";
            this.event2Label.Size = new System.Drawing.Size(0, 25);
            this.event2Label.TabIndex = 2;
            this.event2Label.Click += new System.EventHandler(this.event2Label_Click);
            this.event2Label.MouseHover += new System.EventHandler(this.event2Label_MouseHover);
            // 
            // event3Label
            // 
            this.event3Label.AutoSize = true;
            this.event3Label.BackColor = System.Drawing.Color.Transparent;
            this.event3Label.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.event3Label.ForeColor = System.Drawing.Color.White;
            this.event3Label.Location = new System.Drawing.Point(81, 145);
            this.event3Label.Name = "event3Label";
            this.event3Label.Size = new System.Drawing.Size(0, 25);
            this.event3Label.TabIndex = 3;
            this.event3Label.Click += new System.EventHandler(this.event3Label_Click);
            this.event3Label.MouseHover += new System.EventHandler(this.event3Label_MouseHover);
            // 
            // CellDay
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(144F, 144F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Dpi;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(179)))), ((int)(((byte)(179)))), ((int)(((byte)(179)))));
            this.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.Controls.Add(this.event3Label);
            this.Controls.Add(this.event2Label);
            this.Controls.Add(this.event1Label);
            this.Controls.Add(this.indexDay);
            this.Margin = new System.Windows.Forms.Padding(5, 9, 5, 9);
            this.Name = "CellDay";
            this.Size = new System.Drawing.Size(302, 202);
            this.Load += new System.EventHandler(this.CellDay_Load);
            this.Click += new System.EventHandler(this.CellDay_Click);
            this.MouseLeave += new System.EventHandler(this.CellDay_MouseLeave);
            this.MouseHover += new System.EventHandler(this.CellDay_MouseHover);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label indexDay;
        private System.Windows.Forms.Label event1Label;
        private System.Windows.Forms.Label event2Label;
        private System.Windows.Forms.Label event3Label;
    }
}
