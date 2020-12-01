using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AddressBook.UserControls
{
    public partial class MenuContact : UserControl
    {
        //change name to profile pic
        public Image contactImg
        {
            get{return roundPictureBoxContactImg.Image;}
            set{roundPictureBoxContactImg.Image = value;}
        }
        public string contactName
        {
            get{return labelName.Text;}
            set{labelName.Text = value;}
        }
        public string contactEmail
        {
            get{return labelContactEmail.Text;}
            set{labelContactEmail.Text = value;}
        }
        public string contactPhone
        {
            get { return labelContactPhone.Text; }
            set { labelContactPhone.Text = value; }
        }
        public MenuContact()
        {
            InitializeComponent();
        }
        //Anytime an event is added to a menu contact it is applied to all parts of the menu contact control
        public new event EventHandler Click
        {
            add
            {
                base.Click += value;
                foreach (Control control in Controls)
                {
                    control.Click += value;
                }
            }
            remove
            {
                base.Click -= value;
                foreach (Control control in Controls)
                {
                    control.Click -= value;
                }
            }
        }
        private void MenuContact_Load(object sender, EventArgs e)
        {

        }

        private void MenuContact_MouseEnter_1(object sender, EventArgs e)
        {
            this.BackColor = Color.FromArgb(50, 50, 50);
        }

        private void MenuContact_MouseLeave_1(object sender, EventArgs e)
        {
            this.BackColor = Color.FromArgb(30, 30, 30);
        }

        private void MenuContact_MouseClick(object sender, MouseEventArgs e)
        {
            this.BackColor = Color.FromArgb(50, 50, 50);
        }
    }
}
