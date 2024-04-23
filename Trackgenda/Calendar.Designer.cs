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
            this.upperBar = new System.Windows.Forms.Panel();
            this.currentTimeLabel = new System.Windows.Forms.Label();
            this.minimizeButton = new System.Windows.Forms.Button();
            this.maximizeButton = new System.Windows.Forms.Button();
            this.XButton = new System.Windows.Forms.Button();
            this.hamburgerPictureBox = new System.Windows.Forms.PictureBox();
            this.logoLabel = new System.Windows.Forms.Label();
            this.sidePanel = new System.Windows.Forms.FlowLayoutPanel();
            this.sideLogoPicture = new System.Windows.Forms.PictureBox();
            this.dashboardButton = new System.Windows.Forms.Button();
            this.todoButton = new System.Windows.Forms.Button();
            this.studyButton = new System.Windows.Forms.Button();
            this.stopwatchButton = new System.Windows.Forms.Button();
            this.notesButton = new System.Windows.Forms.Button();
            this.motivationalButton = new System.Windows.Forms.Button();
            this.factButton = new System.Windows.Forms.Button();
            this.backgroundButton = new System.Windows.Forms.Button();
            this.settingsButton = new System.Windows.Forms.Button();
            this.logoutButton = new System.Windows.Forms.Button();
            this.exitButton = new System.Windows.Forms.Button();
            this.currentTimeTimer = new System.Windows.Forms.Timer(this.components);
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.monthlyCalendarTab = new System.Windows.Forms.TabPage();
            this.monthPictureBox = new System.Windows.Forms.PictureBox();
            this.dateLabel = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.nextButton = new System.Windows.Forms.Button();
            this.previousButton = new System.Windows.Forms.Button();
            this.monthlyPanel = new System.Windows.Forms.FlowLayoutPanel();
            this.dashboardTab = new System.Windows.Forms.TabPage();
            this.label3 = new System.Windows.Forms.Label();
            this.settingsTab = new System.Windows.Forms.TabPage();
            this.calendarWeeklyTab = new System.Windows.Forms.TabPage();
            this.upperBar.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.hamburgerPictureBox)).BeginInit();
            this.sidePanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.sideLogoPicture)).BeginInit();
            this.tabControl1.SuspendLayout();
            this.monthlyCalendarTab.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.monthPictureBox)).BeginInit();
            this.dashboardTab.SuspendLayout();
            this.SuspendLayout();
            // 
            // upperBar
            // 
            this.upperBar.BackColor = System.Drawing.Color.DimGray;
            this.upperBar.Controls.Add(this.currentTimeLabel);
            this.upperBar.Controls.Add(this.minimizeButton);
            this.upperBar.Controls.Add(this.maximizeButton);
            this.upperBar.Controls.Add(this.XButton);
            this.upperBar.Controls.Add(this.hamburgerPictureBox);
            this.upperBar.Controls.Add(this.logoLabel);
            this.upperBar.Dock = System.Windows.Forms.DockStyle.Top;
            this.upperBar.ForeColor = System.Drawing.Color.Black;
            this.upperBar.Location = new System.Drawing.Point(0, 0);
            this.upperBar.Name = "upperBar";
            this.upperBar.Size = new System.Drawing.Size(1920, 51);
            this.upperBar.TabIndex = 2;
            this.upperBar.MouseDown += new System.Windows.Forms.MouseEventHandler(this.panel1_MouseDown);
            // 
            // currentTimeLabel
            // 
            this.currentTimeLabel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.currentTimeLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.currentTimeLabel.ForeColor = System.Drawing.Color.Black;
            this.currentTimeLabel.Location = new System.Drawing.Point(1637, 15);
            this.currentTimeLabel.Name = "currentTimeLabel";
            this.currentTimeLabel.Size = new System.Drawing.Size(86, 30);
            this.currentTimeLabel.TabIndex = 4;
            this.currentTimeLabel.Text = "Timer";
            this.currentTimeLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // minimizeButton
            // 
            this.minimizeButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.minimizeButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(59)))), ((int)(((byte)(59)))), ((int)(((byte)(59)))));
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
            this.maximizeButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.maximizeButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(59)))), ((int)(((byte)(59)))), ((int)(((byte)(59)))));
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
            this.XButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.XButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(59)))), ((int)(((byte)(59)))), ((int)(((byte)(59)))));
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
            // logoLabel
            // 
            this.logoLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.logoLabel.ForeColor = System.Drawing.Color.Black;
            this.logoLabel.Location = new System.Drawing.Point(55, 15);
            this.logoLabel.Name = "logoLabel";
            this.logoLabel.Size = new System.Drawing.Size(128, 26);
            this.logoLabel.TabIndex = 3;
            this.logoLabel.Text = "Trackgenda";
            // 
            // sidePanel
            // 
            this.sidePanel.BackColor = System.Drawing.Color.DimGray;
            this.sidePanel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.sidePanel.Controls.Add(this.sideLogoPicture);
            this.sidePanel.Controls.Add(this.dashboardButton);
            this.sidePanel.Controls.Add(this.todoButton);
            this.sidePanel.Controls.Add(this.studyButton);
            this.sidePanel.Controls.Add(this.stopwatchButton);
            this.sidePanel.Controls.Add(this.notesButton);
            this.sidePanel.Controls.Add(this.motivationalButton);
            this.sidePanel.Controls.Add(this.factButton);
            this.sidePanel.Controls.Add(this.backgroundButton);
            this.sidePanel.Controls.Add(this.settingsButton);
            this.sidePanel.Controls.Add(this.logoutButton);
            this.sidePanel.Controls.Add(this.exitButton);
            this.sidePanel.Dock = System.Windows.Forms.DockStyle.Left;
            this.sidePanel.ForeColor = System.Drawing.Color.Black;
            this.sidePanel.Location = new System.Drawing.Point(0, 51);
            this.sidePanel.Name = "sidePanel";
            this.sidePanel.Size = new System.Drawing.Size(220, 1029);
            this.sidePanel.TabIndex = 4;
            // 
            // sideLogoPicture
            // 
            this.sideLogoPicture.Image = global::Trackgenda.Properties.Resources.TG;
            this.sideLogoPicture.Location = new System.Drawing.Point(0, 30);
            this.sideLogoPicture.Margin = new System.Windows.Forms.Padding(0, 30, 0, 0);
            this.sideLogoPicture.Name = "sideLogoPicture";
            this.sideLogoPicture.Size = new System.Drawing.Size(219, 81);
            this.sideLogoPicture.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.sideLogoPicture.TabIndex = 15;
            this.sideLogoPicture.TabStop = false;
            // 
            // dashboardButton
            // 
            this.dashboardButton.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.dashboardButton.BackColor = System.Drawing.Color.Gray;
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
            this.dashboardButton.Click += new System.EventHandler(this.dashboardButton_Click);
            // 
            // todoButton
            // 
            this.todoButton.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.todoButton.BackColor = System.Drawing.Color.Gray;
            this.todoButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.todoButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.todoButton.Image = ((System.Drawing.Image)(resources.GetObject("todoButton.Image")));
            this.todoButton.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.todoButton.Location = new System.Drawing.Point(10, 231);
            this.todoButton.Margin = new System.Windows.Forms.Padding(10);
            this.todoButton.Name = "todoButton";
            this.todoButton.Size = new System.Drawing.Size(200, 60);
            this.todoButton.TabIndex = 14;
            this.todoButton.Text = "TODO";
            this.todoButton.UseVisualStyleBackColor = false;
            this.todoButton.Click += new System.EventHandler(this.todoButton_Click);
            // 
            // studyButton
            // 
            this.studyButton.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.studyButton.BackColor = System.Drawing.Color.Gray;
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
            this.studyButton.Click += new System.EventHandler(this.studyButton_Click);
            // 
            // stopwatchButton
            // 
            this.stopwatchButton.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.stopwatchButton.BackColor = System.Drawing.Color.Gray;
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
            this.notesButton.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.notesButton.BackColor = System.Drawing.Color.Gray;
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
            // motivationalButton
            // 
            this.motivationalButton.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.motivationalButton.BackColor = System.Drawing.Color.Gray;
            this.motivationalButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.motivationalButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.motivationalButton.Image = ((System.Drawing.Image)(resources.GetObject("motivationalButton.Image")));
            this.motivationalButton.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.motivationalButton.Location = new System.Drawing.Point(10, 551);
            this.motivationalButton.Margin = new System.Windows.Forms.Padding(10);
            this.motivationalButton.Name = "motivationalButton";
            this.motivationalButton.Size = new System.Drawing.Size(200, 60);
            this.motivationalButton.TabIndex = 20;
            this.motivationalButton.Text = "Motivional Quote";
            this.motivationalButton.UseVisualStyleBackColor = false;
            this.motivationalButton.Click += new System.EventHandler(this.motivationalButton_Click);
            // 
            // factButton
            // 
            this.factButton.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.factButton.BackColor = System.Drawing.Color.Gray;
            this.factButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.factButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.factButton.Image = ((System.Drawing.Image)(resources.GetObject("factButton.Image")));
            this.factButton.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.factButton.Location = new System.Drawing.Point(10, 631);
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
            this.backgroundButton.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.backgroundButton.BackColor = System.Drawing.Color.Gray;
            this.backgroundButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.backgroundButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.backgroundButton.Image = ((System.Drawing.Image)(resources.GetObject("backgroundButton.Image")));
            this.backgroundButton.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.backgroundButton.Location = new System.Drawing.Point(10, 711);
            this.backgroundButton.Margin = new System.Windows.Forms.Padding(10);
            this.backgroundButton.Name = "backgroundButton";
            this.backgroundButton.Size = new System.Drawing.Size(200, 60);
            this.backgroundButton.TabIndex = 18;
            this.backgroundButton.Text = "Background";
            this.backgroundButton.UseVisualStyleBackColor = false;
            this.backgroundButton.Click += new System.EventHandler(this.backgroundButton_Click);
            // 
            // settingsButton
            // 
            this.settingsButton.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.settingsButton.BackColor = System.Drawing.Color.Gray;
            this.settingsButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.settingsButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.settingsButton.Image = ((System.Drawing.Image)(resources.GetObject("settingsButton.Image")));
            this.settingsButton.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.settingsButton.Location = new System.Drawing.Point(10, 791);
            this.settingsButton.Margin = new System.Windows.Forms.Padding(10);
            this.settingsButton.Name = "settingsButton";
            this.settingsButton.Size = new System.Drawing.Size(200, 60);
            this.settingsButton.TabIndex = 17;
            this.settingsButton.Text = "Settings";
            this.settingsButton.UseVisualStyleBackColor = false;
            // 
            // logoutButton
            // 
            this.logoutButton.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.logoutButton.BackColor = System.Drawing.Color.Gray;
            this.logoutButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.logoutButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.logoutButton.Image = ((System.Drawing.Image)(resources.GetObject("logoutButton.Image")));
            this.logoutButton.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.logoutButton.Location = new System.Drawing.Point(10, 871);
            this.logoutButton.Margin = new System.Windows.Forms.Padding(10);
            this.logoutButton.Name = "logoutButton";
            this.logoutButton.Size = new System.Drawing.Size(200, 60);
            this.logoutButton.TabIndex = 16;
            this.logoutButton.Text = "Logout";
            this.logoutButton.UseVisualStyleBackColor = false;
            this.logoutButton.Click += new System.EventHandler(this.logoutButton_Click);
            // 
            // exitButton
            // 
            this.exitButton.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.exitButton.BackColor = System.Drawing.Color.Gray;
            this.exitButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.exitButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.exitButton.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.exitButton.Location = new System.Drawing.Point(10, 951);
            this.exitButton.Margin = new System.Windows.Forms.Padding(10, 10, 10, 0);
            this.exitButton.Name = "exitButton";
            this.exitButton.Size = new System.Drawing.Size(200, 60);
            this.exitButton.TabIndex = 15;
            this.exitButton.Text = "Exit";
            this.exitButton.UseVisualStyleBackColor = false;
            this.exitButton.Click += new System.EventHandler(this.exitButton_Click);
            // 
            // currentTimeTimer
            // 
            this.currentTimeTimer.Enabled = true;
            this.currentTimeTimer.Tick += new System.EventHandler(this.currentTimeTimer_Tick);
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.monthlyCalendarTab);
            this.tabControl1.Controls.Add(this.dashboardTab);
            this.tabControl1.Controls.Add(this.settingsTab);
            this.tabControl1.Controls.Add(this.calendarWeeklyTab);
            this.tabControl1.Location = new System.Drawing.Point(3, 51);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(1914, 1028);
            this.tabControl1.TabIndex = 23;
            // 
            // monthlyCalendarTab
            // 
            this.monthlyCalendarTab.BackColor = System.Drawing.Color.Transparent;
            this.monthlyCalendarTab.Controls.Add(this.monthPictureBox);
            this.monthlyCalendarTab.Controls.Add(this.dateLabel);
            this.monthlyCalendarTab.Controls.Add(this.label6);
            this.monthlyCalendarTab.Controls.Add(this.label7);
            this.monthlyCalendarTab.Controls.Add(this.label8);
            this.monthlyCalendarTab.Controls.Add(this.label4);
            this.monthlyCalendarTab.Controls.Add(this.label5);
            this.monthlyCalendarTab.Controls.Add(this.label2);
            this.monthlyCalendarTab.Controls.Add(this.label1);
            this.monthlyCalendarTab.Controls.Add(this.nextButton);
            this.monthlyCalendarTab.Controls.Add(this.previousButton);
            this.monthlyCalendarTab.Controls.Add(this.monthlyPanel);
            this.monthlyCalendarTab.Location = new System.Drawing.Point(4, 29);
            this.monthlyCalendarTab.Name = "monthlyCalendarTab";
            this.monthlyCalendarTab.Padding = new System.Windows.Forms.Padding(3);
            this.monthlyCalendarTab.Size = new System.Drawing.Size(1906, 995);
            this.monthlyCalendarTab.TabIndex = 0;
            this.monthlyCalendarTab.Text = "tabPage1";
            // 
            // monthPictureBox
            // 
            this.monthPictureBox.Image = ((System.Drawing.Image)(resources.GetObject("monthPictureBox.Image")));
            this.monthPictureBox.Location = new System.Drawing.Point(1019, 0);
            this.monthPictureBox.Name = "monthPictureBox";
            this.monthPictureBox.Size = new System.Drawing.Size(41, 43);
            this.monthPictureBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.monthPictureBox.TabIndex = 10;
            this.monthPictureBox.TabStop = false;
            // 
            // dateLabel
            // 
            this.dateLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dateLabel.Location = new System.Drawing.Point(1047, 0);
            this.dateLabel.Name = "dateLabel";
            this.dateLabel.Size = new System.Drawing.Size(173, 47);
            this.dateLabel.TabIndex = 9;
            this.dateLabel.Text = "date";
            this.dateLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(1529, 49);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(80, 29);
            this.label6.TabIndex = 8;
            this.label6.Text = "Friday";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(1734, 49);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(107, 29);
            this.label7.TabIndex = 7;
            this.label7.Text = "Saturday";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(1314, 49);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(113, 29);
            this.label8.TabIndex = 6;
            this.label8.Text = "Thursday";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(898, 49);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(106, 29);
            this.label4.TabIndex = 5;
            this.label4.Text = "Tuesday";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(1096, 49);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(140, 29);
            this.label5.TabIndex = 4;
            this.label5.Text = "Wednesday";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(693, 49);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(98, 29);
            this.label2.TabIndex = 3;
            this.label2.Text = "Monday";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(486, 49);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(93, 29);
            this.label1.TabIndex = 2;
            this.label1.Text = "Sunday";
            // 
            // nextButton
            // 
            this.nextButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.nextButton.BackColor = System.Drawing.Color.White;
            this.nextButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.nextButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.nextButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.nextButton.ForeColor = System.Drawing.Color.Black;
            this.nextButton.Location = new System.Drawing.Point(263, 104);
            this.nextButton.Name = "nextButton";
            this.nextButton.Size = new System.Drawing.Size(120, 50);
            this.nextButton.TabIndex = 1;
            this.nextButton.Text = "Next";
            this.nextButton.UseVisualStyleBackColor = false;
            this.nextButton.Click += new System.EventHandler(this.nextButton_Click);
            // 
            // previousButton
            // 
            this.previousButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.previousButton.BackColor = System.Drawing.Color.White;
            this.previousButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.previousButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.previousButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.previousButton.ForeColor = System.Drawing.Color.Black;
            this.previousButton.Location = new System.Drawing.Point(263, 198);
            this.previousButton.Name = "previousButton";
            this.previousButton.Size = new System.Drawing.Size(120, 50);
            this.previousButton.TabIndex = 0;
            this.previousButton.Text = "Previous";
            this.previousButton.UseVisualStyleBackColor = false;
            this.previousButton.Click += new System.EventHandler(this.previousButton_Click);
            // 
            // monthlyPanel
            // 
            this.monthlyPanel.Location = new System.Drawing.Point(417, 100);
            this.monthlyPanel.Name = "monthlyPanel";
            this.monthlyPanel.Size = new System.Drawing.Size(1465, 878);
            this.monthlyPanel.TabIndex = 0;
            // 
            // dashboardTab
            // 
            this.dashboardTab.BackColor = System.Drawing.Color.White;
            this.dashboardTab.Controls.Add(this.label3);
            this.dashboardTab.Location = new System.Drawing.Point(4, 29);
            this.dashboardTab.Name = "dashboardTab";
            this.dashboardTab.Padding = new System.Windows.Forms.Padding(3);
            this.dashboardTab.Size = new System.Drawing.Size(1906, 995);
            this.dashboardTab.TabIndex = 1;
            this.dashboardTab.Text = "tabPage2";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(775, 571);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(88, 20);
            this.label3.TabIndex = 0;
            this.label3.Text = "Dashboard";
            // 
            // settingsTab
            // 
            this.settingsTab.BackColor = System.Drawing.Color.White;
            this.settingsTab.Location = new System.Drawing.Point(4, 29);
            this.settingsTab.Name = "settingsTab";
            this.settingsTab.Padding = new System.Windows.Forms.Padding(3);
            this.settingsTab.Size = new System.Drawing.Size(1906, 995);
            this.settingsTab.TabIndex = 2;
            this.settingsTab.Text = "tabPage1";
            // 
            // calendarWeeklyTab
            // 
            this.calendarWeeklyTab.BackColor = System.Drawing.Color.White;
            this.calendarWeeklyTab.Location = new System.Drawing.Point(4, 29);
            this.calendarWeeklyTab.Name = "calendarWeeklyTab";
            this.calendarWeeklyTab.Padding = new System.Windows.Forms.Padding(3);
            this.calendarWeeklyTab.Size = new System.Drawing.Size(1906, 995);
            this.calendarWeeklyTab.TabIndex = 3;
            this.calendarWeeklyTab.Text = "tabPage1";
            // 
            // CalendarForm
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.AutoSize = true;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(1920, 1080);
            this.Controls.Add(this.sidePanel);
            this.Controls.Add(this.upperBar);
            this.Controls.Add(this.tabControl1);
            this.DoubleBuffered = true;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.IsMdiContainer = true;
            this.Name = "CalendarForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Load += new System.EventHandler(this.CalendarForm_Load);
            this.MouseDown += new System.Windows.Forms.MouseEventHandler(this.CalendarForm_MouseDown);
            this.upperBar.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.hamburgerPictureBox)).EndInit();
            this.sidePanel.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.sideLogoPicture)).EndInit();
            this.tabControl1.ResumeLayout(false);
            this.monthlyCalendarTab.ResumeLayout(false);
            this.monthlyCalendarTab.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.monthPictureBox)).EndInit();
            this.dashboardTab.ResumeLayout(false);
            this.dashboardTab.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Panel upperBar;
        private System.Windows.Forms.Label logoLabel;
        private System.Windows.Forms.PictureBox hamburgerPictureBox;
        private System.Windows.Forms.Button XButton;
        private System.Windows.Forms.Button maximizeButton;
        private System.Windows.Forms.Button minimizeButton;
        private System.Windows.Forms.FlowLayoutPanel sidePanel;
        private System.Windows.Forms.Label currentTimeLabel;
        private System.Windows.Forms.Timer currentTimeTimer;
        private System.Windows.Forms.Button dashboardButton;
        private System.Windows.Forms.PictureBox sideLogoPicture;
        private System.Windows.Forms.Button todoButton;
        private System.Windows.Forms.Button studyButton;
        private System.Windows.Forms.Button exitButton;
        private System.Windows.Forms.Button logoutButton;
        private System.Windows.Forms.Button settingsButton;
        private System.Windows.Forms.Button backgroundButton;
        private System.Windows.Forms.Button factButton;
        private System.Windows.Forms.Button notesButton;
        private System.Windows.Forms.Button stopwatchButton;
        private System.Windows.Forms.Button motivationalButton;
        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage monthlyCalendarTab;
        private System.Windows.Forms.TabPage dashboardTab;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TabPage settingsTab;
        private System.Windows.Forms.FlowLayoutPanel monthlyPanel;
        private System.Windows.Forms.Button nextButton;
        private System.Windows.Forms.Button previousButton;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label dateLabel;
        private System.Windows.Forms.TabPage calendarWeeklyTab;
        private System.Windows.Forms.PictureBox monthPictureBox;
    }
}