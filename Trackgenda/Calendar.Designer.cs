namespace Trackgenda
{
    partial class CalendarForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(CalendarForm));
            this.label1 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.currentTimeLabel = new System.Windows.Forms.Label();
            this.minimizeButton = new System.Windows.Forms.Button();
            this.maximizeButton = new System.Windows.Forms.Button();
            this.XButton = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.flowLayoutPanel1 = new System.Windows.Forms.FlowLayoutPanel();
            this.currentTimeTimer = new System.Windows.Forms.Timer(this.components);
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(994, 279);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(51, 20);
            this.label1.TabIndex = 0;
            this.label1.Text = "label1";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(971, 392);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 1;
            this.button1.Text = "button1";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.White;
            this.panel1.Controls.Add(this.currentTimeLabel);
            this.panel1.Controls.Add(this.minimizeButton);
            this.panel1.Controls.Add(this.maximizeButton);
            this.panel1.Controls.Add(this.XButton);
            this.panel1.Controls.Add(this.pictureBox1);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1920, 51);
            this.panel1.TabIndex = 2;
            this.panel1.MouseDown += new System.Windows.Forms.MouseEventHandler(this.panel1_MouseDown);
            // 
            // currentTimeLabel
            // 
            this.currentTimeLabel.Location = new System.Drawing.Point(197, 16);
            this.currentTimeLabel.Name = "currentTimeLabel";
            this.currentTimeLabel.Size = new System.Drawing.Size(76, 21);
            this.currentTimeLabel.TabIndex = 4;
            // 
            // minimizeButton
            // 
            this.minimizeButton.BackColor = System.Drawing.Color.White;
            this.minimizeButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.minimizeButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.minimizeButton.ForeColor = System.Drawing.Color.Black;
            this.minimizeButton.Image = ((System.Drawing.Image)(resources.GetObject("minimizeButton.Image")));
            this.minimizeButton.Location = new System.Drawing.Point(1740, 0);
            this.minimizeButton.Name = "minimizeButton";
            this.minimizeButton.Size = new System.Drawing.Size(60, 50);
            this.minimizeButton.TabIndex = 3;
            this.minimizeButton.UseVisualStyleBackColor = false;
            this.minimizeButton.Click += new System.EventHandler(this.minimizeButton_Click);
            this.minimizeButton.MouseLeave += new System.EventHandler(this.minimizeButton_MouseLeave);
            this.minimizeButton.MouseHover += new System.EventHandler(this.minimizeButton_MouseHover);
            // 
            // maximizeButton
            // 
            this.maximizeButton.BackColor = System.Drawing.Color.White;
            this.maximizeButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.maximizeButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.maximizeButton.ForeColor = System.Drawing.Color.Black;
            this.maximizeButton.Image = ((System.Drawing.Image)(resources.GetObject("maximizeButton.Image")));
            this.maximizeButton.Location = new System.Drawing.Point(1800, 0);
            this.maximizeButton.Name = "maximizeButton";
            this.maximizeButton.Size = new System.Drawing.Size(60, 50);
            this.maximizeButton.TabIndex = 3;
            this.maximizeButton.UseVisualStyleBackColor = false;
            this.maximizeButton.Click += new System.EventHandler(this.maximizeButton_Click);
            this.maximizeButton.MouseLeave += new System.EventHandler(this.maximizeButton_MouseLeave);
            this.maximizeButton.MouseHover += new System.EventHandler(this.maximizeButton_MouseHover);
            // 
            // XButton
            // 
            this.XButton.BackColor = System.Drawing.Color.White;
            this.XButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.XButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.XButton.ForeColor = System.Drawing.Color.Black;
            this.XButton.Location = new System.Drawing.Point(1860, 0);
            this.XButton.Name = "XButton";
            this.XButton.Size = new System.Drawing.Size(60, 50);
            this.XButton.TabIndex = 3;
            this.XButton.Text = "X";
            this.XButton.UseVisualStyleBackColor = false;
            this.XButton.Click += new System.EventHandler(this.XButton_Click);
            this.XButton.MouseLeave += new System.EventHandler(this.XButton_MouseLeave);
            this.XButton.MouseHover += new System.EventHandler(this.XButton_MouseHover);
            // 
            // label2
            // 
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(64, 12);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(145, 39);
            this.label2.TabIndex = 3;
            this.label2.Text = "Trackgenda |";
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(12, 12);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(37, 30);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 3;
            this.pictureBox1.TabStop = false;
            // 
            // flowLayoutPanel1
            // 
            this.flowLayoutPanel1.BackColor = System.Drawing.Color.White;
            this.flowLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Left;
            this.flowLayoutPanel1.Location = new System.Drawing.Point(0, 51);
            this.flowLayoutPanel1.Name = "flowLayoutPanel1";
            this.flowLayoutPanel1.Size = new System.Drawing.Size(200, 1029);
            this.flowLayoutPanel1.TabIndex = 4;
            // 
            // currentTimeTimer
            // 
            this.currentTimeTimer.Enabled = true;
            this.currentTimeTimer.Tick += new System.EventHandler(this.currentTimeTimer_Tick);
            // 
            // CalendarForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1920, 1080);
            this.Controls.Add(this.flowLayoutPanel1);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.label1);
            this.DoubleBuffered = true;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "CalendarForm";
            this.Load += new System.EventHandler(this.CalendarForm_Load);
            this.MouseDown += new System.Windows.Forms.MouseEventHandler(this.CalendarForm_MouseDown);
            this.panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Button XButton;
        private System.Windows.Forms.Button maximizeButton;
        private System.Windows.Forms.Button minimizeButton;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel1;
        private System.Windows.Forms.Label currentTimeLabel;
        private System.Windows.Forms.Timer currentTimeTimer;
    }
}