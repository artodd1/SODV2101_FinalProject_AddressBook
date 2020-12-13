using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using FontAwesome.Sharp;

namespace AddressBook.Forms
{
    public partial class Registration : Form
    {
        public Registration()
        {
            InitializeComponent();
        }

        private void iconButtonCreateUser_MouseEnter(object sender, EventArgs e)
        {
            var currentBtn = (IconButton)sender;
            currentBtn.IconColor = Color.LimeGreen;
            currentBtn.ForeColor = Color.LimeGreen;
        }

        private void iconButtonCreateUser_MouseLeave(object sender, EventArgs e)
        {
            var currentBtn = (IconButton)sender;
            currentBtn.IconColor = Color.WhiteSmoke;
            currentBtn.ForeColor = Color.WhiteSmoke;
        }
    }
}
