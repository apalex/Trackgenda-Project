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
            this.panel1 = new System.Windows.Forms.Panel();
            this.currentTimeLabel = new System.Windows.Forms.Label();
            this.minimizeButton = new System.Windows.Forms.Button();
            this.maximizeButton = new System.Windows.Forms.Button();
            this.XButton = new System.Windows.Forms.Button();
            this.hamburgerPictureBox = new System.Windows.Forms.PictureBox();
            this.label2 = new System.Windows.Forms.Label();
            this.sidePanel = new System.Windows.Forms.FlowLayoutPanel();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.dashboardButton = new System.Windows.Forms.Button();
            this.eventsButton = new System.Windows.Forms.Button();
            this.studyButton = new System.Windows.Forms.Button();
            this.stopwatchButton = new System.Windows.Forms.Button();
            this.notesButton = new System.Windows.Forms.Button();
            this.factButton = new System.Windows.Forms.Button();
            this.backgroundButton = new System.Windows.Forms.Button();
            this.settingsButton = new System.Windows.Forms.Button();
            this.logoutButton = new System.Windows.Forms.Button();
            this.exitButton = new System.Windows.Forms.Button();
            this.currentTimeTimer = new System.Windows.Forms.Timer(this.components);
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.hamburgerPictureBox)).BeginInit();
            this.sidePanel.SuspendLayout();
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
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.White;
            this.panel1.Controls.Add(this.currentTimeLabel);
            this.panel1.Controls.Add(this.minimizeButton);
            this.panel1.Controls.Add(this.maximizeButton);
            this.panel1.Controls.Add(this.XButton);
            this.panel1.Controls.Add(this.hamburgerPictureBox);
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
            this.currentTimeLabel.Location = new System.Drawing.Point(185, 15);
            this.currentTimeLabel.Name = "currentTimeLabel";
            this.currentTimeLabel.Size = new System.Drawing.Size(78, 36);
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
            // hamburgerPictureBox
            // 
            this.hamburgerPictureBox.Image = ((System.Drawing.Image)(resources.GetObject("hamburgerPictureBox.Image")));
            this.hamburgerPictureBox.Location = new System.Drawing.Point(12, 12);
            this.hamburgerPictureBox.Name = "hamburgerPictureBox";
            this.hamburgerPictureBox.Size = new System.Drawing.Size(37, 30);
            this.hamburgerPictureBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.hamburgerPictureBox.TabIndex = 3;
            this.hamburgerPictureBox.TabStop = false;
            this.hamburgerPictureBox.Click += new System.EventHandler(this.hamburgerPictureBox_Click);
            // 
            // label2
            // 
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(60, 15);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(132, 26);
            this.label2.TabIndex = 3;
            this.label2.Text = "Trackgenda |";
            // 
            // sidePanel
            // 
            this.sidePanel.BackColor = System.Drawing.Color.White;
            this.sidePanel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.sidePanel.Controls.Add(this.pictureBox1);
            this.sidePanel.Controls.Add(this.dashboardButton);
            this.sidePanel.Controls.Add(this.eventsButton);
            this.sidePanel.Controls.Add(this.studyButton);
            this.sidePanel.Controls.Add(this.stopwatchButton);
            this.sidePanel.Controls.Add(this.notesButton);
            this.sidePanel.Controls.Add(this.factButton);
            this.sidePanel.Controls.Add(this.backgroundButton);
            this.sidePanel.Controls.Add(this.settingsButton);
            this.sidePanel.Controls.Add(this.logoutButton);
            this.sidePanel.Controls.Add(this.exitButton);
            this.sidePanel.Dock = System.Windows.Forms.DockStyle.Left;
            this.sidePanel.Location = new System.Drawing.Point(0, 51);
            this.sidePanel.Name = "sidePanel";
            this.sidePanel.Size = new System.Drawing.Size(220, 1029);
            this.sidePanel.TabIndex = 4;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::Trackgenda.Properties.Resources.TG;
            this.pictureBox1.Location = new System.Drawing.Point(0, 30);
            this.pictureBox1.Margin = new System.Windows.Forms.Padding(0, 30, 0, 0);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(219, 81);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 15;
            this.pictureBox1.TabStop = false;
            // 
            // dashboardButton
            // 
            this.dashboardButton.BackColor = System.Drawing.Color.White;
            this.dashboardButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.dashboardButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dashboardButton.Image = ((System.Drawing.Image)(resources.GetObject("dashboardButton.Image")));
            this.dashboardButton.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.dashboardButton.Location = new System.Drawing.Point(10, 151);
            this.dashboardButton.Margin = new System.Windows.Forms.Padding(10, 40, 10, 10);
            this.dashboardButton.Name = "dashboardButton";
            this.dashboardButton.Size = new System.Drawing.Size(200, 60);
            this.dashboardButton.TabIndex = 5;
            this.dashboardButton.Text = "Dashboard";
            this.dashboardButton.UseVisualStyleBackColor = false;
            // 
            // eventsButton
            // 
            this.eventsButton.BackColor = System.Drawing.Color.White;
            this.eventsButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.eventsButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.eventsButton.Image = ((System.Drawing.Image)(resources.GetObject("eventsButton.Image")));
            this.eventsButton.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.eventsButton.Location = new System.Drawing.Point(10, 231);
            this.eventsButton.Margin = new System.Windows.Forms.Padding(10);
            this.eventsButton.Name = "eventsButton";
            this.eventsButton.Size = new System.Drawing.Size(200, 60);
            this.eventsButton.TabIndex = 14;
            this.eventsButton.Text = "Events";
            this.eventsButton.UseVisualStyleBackColor = false;
            // 
            // studyButton
            // 
            this.studyButton.BackColor = System.Drawing.Color.White;
            this.studyButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.studyButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.studyButton.Image = ((System.Drawing.Image)(resources.GetObject("studyButton.Image")));
            this.studyButton.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.studyButton.Location = new System.Drawing.Point(10, 311);
            this.studyButton.Margin = new System.Windows.Forms.Padding(10);
            this.studyButton.Name = "studyButton";
            this.studyButton.Size = new System.Drawing.Size(200, 60);
            this.studyButton.TabIndex = 22;
            this.studyButton.Text = "Study";
            this.studyButton.UseVisualStyleBackColor = false;
            // 
            // stopwatchButton
            // 
            this.stopwatchButton.BackColor = System.Drawing.Color.White;
            this.stopwatchButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.stopwatchButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.stopwatchButton.Image = ((System.Drawing.Image)(resources.GetObject("stopwatchButton.Image")));
            this.stopwatchButton.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.stopwatchButton.Location = new System.Drawing.Point(10, 391);
            this.stopwatchButton.Margin = new System.Windows.Forms.Padding(10);
            this.stopwatchButton.Name = "stopwatchButton";
            this.stopwatchButton.Size = new System.Drawing.Size(200, 60);
            this.stopwatchButton.TabIndex = 21;
            this.stopwatchButton.Text = "Stopwatch";
            this.stopwatchButton.UseVisualStyleBackColor = false;
            this.stopwatchButton.Click += new System.EventHandler(this.stopwatchButton_Click);
            // 
            // notesButton
            // 
            this.notesButton.BackColor = System.Drawing.Color.White;
            this.notesButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.notesButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.notesButton.Image = ((System.Drawing.Image)(resources.GetObject("notesButton.Image")));
            this.notesButton.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.notesButton.Location = new System.Drawing.Point(10, 471);
            this.notesButton.Margin = new System.Windows.Forms.Padding(10);
            this.notesButton.Name = "notesButton";
            this.notesButton.Size = new System.Drawing.Size(200, 60);
            this.notesButton.TabIndex = 20;
            this.notesButton.Text = "Notes";
            this.notesButton.UseVisualStyleBackColor = false;
            // 
            // factButton
            // 
            this.factButton.BackColor = System.Drawing.Color.White;
            this.factButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.factButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.factButton.Image = ((System.Drawing.Image)(resources.GetObject("factButton.Image")));
            this.factButton.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.factButton.Location = new System.Drawing.Point(10, 551);
            this.factButton.Margin = new System.Windows.Forms.Padding(10);
            this.factButton.Name = "factButton";
            this.factButton.Size = new System.Drawing.Size(200, 60);
            this.factButton.TabIndex = 19;
            this.factButton.Text = "Fun Fact";
            this.factButton.UseVisualStyleBackColor = false;
            this.factButton.Click += new System.EventHandler(this.factButton_Click);
            // 
            // backgroundButton
            // 
            this.backgroundButton.BackColor = System.Drawing.Color.White;
            this.backgroundButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.backgroundButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.backgroundButton.Image = ((System.Drawing.Image)(resources.GetObject("backgroundButton.Image")));
            this.backgroundButton.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.backgroundButton.Location = new System.Drawing.Point(10, 631);
            this.backgroundButton.Margin = new System.Windows.Forms.Padding(10);
            this.backgroundButton.Name = "backgroundButton";
            this.backgroundButton.Size = new System.Drawing.Size(200, 60);
            this.backgroundButton.TabIndex = 18;
            this.backgroundButton.Text = "Background";
            this.backgroundButton.UseVisualStyleBackColor = false;
            // 
            // settingsButton
            // 
            this.settingsButton.BackColor = System.Drawing.Color.White;
            this.settingsButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.settingsButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.settingsButton.Image = ((System.Drawing.Image)(resources.GetObject("settingsButton.Image")));
            this.settingsButton.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.settingsButton.Location = new System.Drawing.Point(10, 801);
            this.settingsButton.Margin = new System.Windows.Forms.Padding(10, 100, 10, 10);
            this.settingsButton.Name = "settingsButton";
            this.settingsButton.Size = new System.Drawing.Size(200, 60);
            this.settingsButton.TabIndex = 17;
            this.settingsButton.Text = "Settings";
            this.settingsButton.UseVisualStyleBackColor = false;
            // 
            // logoutButton
            // 
            this.logoutButton.BackColor = System.Drawing.Color.White;
            this.logoutButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.logoutButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.logoutButton.Image = ((System.Drawing.Image)(resources.GetObject("logoutButton.Image")));
            this.logoutButton.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.logoutButton.Location = new System.Drawing.Point(10, 881);
            this.logoutButton.Margin = new System.Windows.Forms.Padding(10);
            this.logoutButton.Name = "logoutButton";
            this.logoutButton.Size = new System.Drawing.Size(200, 60);
            this.logoutButton.TabIndex = 16;
            this.logoutButton.Text = "Logout";
            this.logoutButton.UseVisualStyleBackColor = false;
            // 
            // exitButton
            // 
            this.exitButton.BackColor = System.Drawing.Color.White;
            this.exitButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.exitButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.exitButton.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.exitButton.Location = new System.Drawing.Point(10, 961);
            this.exitButton.Margin = new System.Windows.Forms.Padding(10, 10, 10, 0);
            this.exitButton.Name = "exitButton";
            this.exitButton.Size = new System.Drawing.Size(200, 60);
            this.exitButton.TabIndex = 15;
            this.exitButton.Text = "Exit";
            this.exitButton.UseVisualStyleBackColor = false;
            // 
            // currentTimeTimer
            // 
            this.currentTimeTimer.Enabled = true;
            this.currentTimeTimer.Tick += new System.EventHandler(this.currentTimeTimer_Tick);
            // 
            // CalendarForm
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(1920, 1080);
            this.Controls.Add(this.sidePanel);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.label1);
            this.DoubleBuffered = true;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.IsMdiContainer = true;
            this.Name = "CalendarForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Load += new System.EventHandler(this.CalendarForm_Load);
            this.MouseDown += new System.Windows.Forms.MouseEventHandler(this.CalendarForm_MouseDown);
            this.panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.hamburgerPictureBox)).EndInit();
            this.sidePanel.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.PictureBox hamburgerPictureBox;
        private System.Windows.Forms.Button XButton;
        private System.Windows.Forms.Button maximizeButton;
        private System.Windows.Forms.Button minimizeButton;
        private System.Windows.Forms.FlowLayoutPanel sidePanel;
        private System.Windows.Forms.Label currentTimeLabel;
        private System.Windows.Forms.Timer currentTimeTimer;
        private System.Windows.Forms.Button dashboardButton;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Button eventsButton;
        private System.Windows.Forms.Button studyButton;
        private System.Windows.Forms.Button exitButton;
        private System.Windows.Forms.Button logoutButton;
        private System.Windows.Forms.Button settingsButton;
        private System.Windows.Forms.Button backgroundButton;
        private System.Windows.Forms.Button factButton;
        private System.Windows.Forms.Button notesButton;
        private System.Windows.Forms.Button stopwatchButton;
    }
}