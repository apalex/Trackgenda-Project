using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Trackgenda
{
    public partial class CalendarForm : Form
    {
        private int uid;
        private bool sidePanelShow = true;
        private bool studyDashboardShow = false;
        private bool dashBoardShow = false;
        private StudyDashboard studyDashboardForm = new StudyDashboard();
        const int WS_MINIMIZEBOX = 0x20000;
        const int CS_DBLCLKS = 0x8;
        private Rectangle originalSizeForm;
        // Add Size Gripper to Form
        private const int WM_NCHITTEST = 0x84;
        private const int HTLEFT = 10;
        private const int HTRIGHT = 11;
        private const int HTTOP = 12;
        private const int HTTOPLEFT = 13;
        private const int HTTOPRIGHT = 14;
        private const int HTBOTTOM = 15;
        private const int HTBOTTOMLEFT = 16;
        private const int HTBOTTOMRIGHT = 17;

        public CalendarForm(int uid)
        {
            this.uid = uid;
            this.DoubleBuffered = true;
            this.SetStyle(ControlStyles.ResizeRedraw, true);
            InitializeComponent();
        }

        public bool StudyDashboardShow
        {
            get { return studyDashboardShow;}
            set { studyDashboardShow = value;}
        }

        protected override CreateParams CreateParams
        {
            get
            {
                CreateParams cp = base.CreateParams;
                cp.Style |= WS_MINIMIZEBOX;
                cp.ClassStyle |= CS_DBLCLKS;
                return cp;
            }
        }

        private void XButton_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void maximizeButton_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Maximized;
        }

        private void minimizeButton_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        private void CalendarForm_MouseDown(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                DraggeableForms.Drag(this.Handle);
            }
        }

        private void CalendarForm_Load(object sender, EventArgs e)
        {
            Controls.OfType<MdiClient>().FirstOrDefault().BackColor = Color.White;
            this.Select();
            currentTimeTimer.Start();
            studyDashboardForm.MdiParent = this;
            originalSizeForm = new Rectangle(this.Location.X,this.Location.Y,this.Size.Width,this.Size.Height);
        }

        private void currentTimeTimer_Tick(object sender, EventArgs e)
        {
            currentTimeLabel.Text = DateTime.Now.ToLongTimeString();
        }

        private void XButton_MouseHover(object sender, EventArgs e)
        {
            XButton.BackColor = Color.LightCoral;
        }

        private void XButton_MouseLeave(object sender, EventArgs e)
        {
            XButton.BackColor = Color.White;
        }

        private void maximizeButton_MouseHover(object sender, EventArgs e)
        {
            maximizeButton.BackColor = Color.LightCoral;
        }

        private void maximizeButton_MouseLeave(object sender, EventArgs e)
        {
            maximizeButton.BackColor = Color.White;
        }

        private void minimizeButton_MouseHover(object sender, EventArgs e)
        {
            minimizeButton.BackColor = Color.LightCoral;
        }

        private void minimizeButton_MouseLeave(object sender, EventArgs e)
        {
            minimizeButton.BackColor = Color.White;
        }

        private void panel1_MouseDown(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                DraggeableForms.Drag(this.Handle);
            }
        }

        private void hamburgerPictureBox_Click(object sender, EventArgs e)
        {
            if (sidePanelShow)
            {
                sidePanel.Hide();
                sidePanelShow = !sidePanelShow;
            } else
            {
                sidePanel.Show();
                sidePanelShow = !sidePanelShow;
            }
        }

        private void stopwatchButton_Click(object sender, EventArgs e)
        {
            StopwatchForm form = new StopwatchForm();
            form.Show();
        }

        private void factButton_Click(object sender, EventArgs e)
        {
            FactForm form = new FactForm();
            form.Show();
        }

        private void motivationalButton_Click(object sender, EventArgs e)
        {
            MotivionalQuoteForm form = new MotivionalQuoteForm();
            form.Show();
        }

        private void exitButton_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void logoutButton_Click(object sender, EventArgs e)
        {
            LoginForm form = new LoginForm();
            this.Close();
            form.Show();
        }

        private void studyButton_Click(object sender, EventArgs e)
        {
            studyDashboardShow = !studyDashboardShow;
            if (studyDashboardShow == true)
            {
                studyDashboardForm.Show();
            } else
            {
                studyDashboardForm.Hide();
            }
        }

        private void CalendarForm_Resize(object sender, EventArgs e)
        {

        }

        private void resizeControl(Rectangle r,Control c)
        {
            float xRatio = (float)r.Width / (float)(originalSizeForm.Width);
            float yRatio = (float)r.Width / (float)(originalSizeForm.Height);

            int newX = (int)(r.Width * xRatio);
            int newY = (int)(r.Height * yRatio);

            int newWidth = (int)(r.Width * xRatio);
            int newHeight = (int)(r.Height * yRatio);

            c.Location = new Point(newX, newY);
            c.Size = new Size(newWidth, newHeight);
        }

        protected override void WndProc(ref Message m)
        {
            base.WndProc(ref m);

            if (m.Msg == WM_NCHITTEST)
            {
                Point cursor = this.PointToClient(Cursor.Position);

                if (cursor.X <= 5)
                {
                    if (cursor.Y <= 5)
                        m.Result = (IntPtr)HTTOPLEFT;
                    else if (cursor.Y >= this.ClientSize.Height - 5)
                        m.Result = (IntPtr)HTBOTTOMLEFT;
                    else
                        m.Result = (IntPtr)HTLEFT;
                }
                else if (cursor.X >= this.ClientSize.Width - 5)
                {
                    if (cursor.Y <= 5)
                        m.Result = (IntPtr)HTTOPRIGHT;
                    else if (cursor.Y >= this.ClientSize.Height - 5)
                        m.Result = (IntPtr)HTBOTTOMRIGHT;
                    else
                        m.Result = (IntPtr)HTRIGHT;
                }
                else if (cursor.Y <= 5)
                {
                    m.Result = (IntPtr)HTTOP;
                }
                else if (cursor.Y >= this.ClientSize.Height - 5)
                {
                    m.Result = (IntPtr)HTBOTTOM;
                }
            }
        }

        private void dashboardButton_Click(object sender, EventArgs e)
        {
            dashBoardShow = !dashBoardShow;
            if (dashBoardShow == true)
            {
                tabControl1.SelectedTab = dashboardTab;
                dashboardButton.Text = "Calendar";
            } else
            {
                tabControl1.SelectedTab = calendarTab;
                dashboardButton.Text = "Dashboard";
            }
        }
    }
}
