using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
//Library for iconButtons
using FontAwesome.Sharp;
//Allows me to use native libraries of the operating system
using System.Runtime.InteropServices;

namespace AddressBook
{
    public partial class MyAddressBook : Form
    {
        private int panelWidth;
        private bool hide;
        private Form currentChildForm;

        public static MyAddressBook Self;
        public MyAddressBook()
        {
            InitializeComponent();
            
            //Form styles
            this.Text = string.Empty;
            this.ControlBox = false;
            this.DoubleBuffered = true;
            //Don't cover up task bar when maximizing
            this.MaximizedBounds = Screen.FromHandle(this.Handle).WorkingArea;
            //set sliding panel
            panelWidth = panelDrawer.Width;
            panelDrawer.Width = 0;
            hide = true; 
            //Allow access to MyAddressbook form from child forms
            Self = this;
        }


        private void MyAddressBook_Load(object sender, EventArgs e)
        {
        }


        //Allow form drag from the top panel by importing the user32 library
        [DllImport("user32.DLL", EntryPoint = "ReleaseCapture")]
        private extern static void ReleaseCapture();
        [DllImport("user32.Dll", EntryPoint = "SendMessage")]
        private extern static void SendMessage(System.IntPtr hWnd, int wMsg, int wParam, int lParam);

        //Open Child form in main panel
        public void OpenChildForm(Form childForm)
        {
            if (currentChildForm != null)
            {
                currentChildForm.Close();
            }
            currentChildForm = childForm;
            childForm.TopLevel = false;
            childForm.FormBorderStyle = FormBorderStyle.None;
            childForm.Dock = DockStyle.Fill;
            panelMain.Controls.Add(childForm);
            childForm.BringToFront();
            childForm.Show();
        }
        private void buttonExit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
        private void buttonMaximize_Click(object sender, EventArgs e)
        {
            if (WindowState == FormWindowState.Normal)
                WindowState = FormWindowState.Maximized;
            else
                WindowState = FormWindowState.Normal;
        }
        private void buttonMinimize_Click(object sender, EventArgs e)
        {
            WindowState = FormWindowState.Minimized;
        }
        private void panelTop_MouseDown(object sender, MouseEventArgs e)
        {
            ReleaseCapture();
            SendMessage(this.Handle, 0x112, 0xf012, 0);
        }
        private void iconButtonMenu_Click(object sender, EventArgs e)
        {
            //timer1.Start();
        }
        private void iconButtonContacts_Click(object sender, EventArgs e)
        {
            timer1.Start();
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            if (hide)
            {
                panelDrawer.Width = panelDrawer.Width + 15;
                if(panelDrawer.Width >= panelWidth)
                {
                    timer1.Stop();
                    hide = false;
                    panelMain.Dock = DockStyle.Right;
                    panelDrawer.Dock = DockStyle.Fill;
                    panelDrawer.AutoScroll = true;
                    this.Refresh();
                }
            }
            else
            {
                panelDrawer.AutoScroll = false;
                panelDrawer.Dock = DockStyle.Left;
                panelMain.Dock = DockStyle.Fill;
                panelDrawer.Width = panelDrawer.Width - 15;
                    if(panelDrawer.Width <= 0)
                {
                    timer1.Stop();
                    hide = true;
                    this.Refresh();
                }
            }
        }

        private void panelMain_Paint(object sender, PaintEventArgs e)
        {

        }

        private void ChangeColorOnMouseEnter(object sender, EventArgs e)
        {
            var currentBtn = (IconButton)sender;
            currentBtn.IconColor = Color.LimeGreen;
            currentBtn.ForeColor = Color.LimeGreen;
        }

        private void ChangeColorOnMouseLeave(object sender, EventArgs e)
        {
            var currentBtn = (IconButton)sender;
            currentBtn.IconColor = Color.WhiteSmoke;
            currentBtn.ForeColor = Color.WhiteSmoke;
        }

        private void DisplayAllUserInfo(object sender, MouseEventArgs e)
        {
            UserInfoDisplay display = new UserInfoDisplay();
            OpenChildForm(display);
        }

        private void ChangeColorOnMouseEnterRed(object sender, EventArgs e)
        {
            var currentBtn = (IconButton)sender;
            currentBtn.IconColor = Color.DarkRed;
        }
    }
}
