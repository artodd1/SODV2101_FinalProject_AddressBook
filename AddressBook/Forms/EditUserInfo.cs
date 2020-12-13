using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AddressBook
{
    public partial class EditUserInfo : Form
    {
        public EditUserInfo()
        {
            InitializeComponent();
        }

        private void EditUserInfo_Load(object sender, EventArgs e)
        {
            //set the size of this form to the size of the main panel on the parent form
            this.Size = DisplayRectangle.Size;
        }

        private void buttonSubmitEdit_Click(object sender, EventArgs e)
        {
            UserInfoDisplay user = new UserInfoDisplay();
            MyAddressBook.Self.OpenChildForm(user);
        }

        private void dateTimePicker1_ValueChanged(object sender, EventArgs e)
        {

        }
    }
}
