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

namespace AddressBook
{
   // public delegate void EditUserHandler(Form edit);
    public partial class UserInfoDisplay : Form
    {
       // public event EditUserHandler openEditForm;
        public UserInfoDisplay()
        {
            InitializeComponent();
            this.DoubleBuffered = true;
        }

        private void UserInfoDisplaycs_Load(object sender, EventArgs e)
        {
            this.Size = DisplayRectangle.Size;
        }

        private void ChangeColorGreen(object sender, EventArgs e)
        {
            var currentBtn = (IconButton)sender;
            currentBtn.IconColor = Color.LimeGreen;
        }

        private void ChangeColorLeaveWhite(object sender, EventArgs e)
        {
            var currentBtn = (IconButton)sender;
            currentBtn.IconColor = Color.WhiteSmoke;
        }

        private void EditUser(object sender, MouseEventArgs e)
        {
            EditUserInfo edit = new EditUserInfo();
            MyAddressBook.Self.OpenChildForm(edit);
        }
    }
}
