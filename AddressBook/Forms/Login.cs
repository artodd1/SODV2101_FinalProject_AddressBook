using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Configuration;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using AddressBook.Forms;

namespace AddressBook
{
    public partial class LoginForm : Form
    {
        public LoginForm()
        {
            InitializeComponent();   
        }
        private void LoginForm_Load(object sender, EventArgs e)
        {

        }
        private void btnLogin_Click(object sender, EventArgs e)
        {
            MyAddressBook myAddressBook = new MyAddressBook();
            this.Hide();
            //Because i'm hiding the login form I need the new form to close it when the new form itself closes.
            myAddressBook.FormClosed += (s, args) => this.Close();
            myAddressBook.Show();
        }
        private void textBoxPassword_TextChanged(object sender, EventArgs e)
        {
            
        }

        private void button1_MouseEnter(object sender, EventArgs e)
        {
            var currentBtn = (Button)sender;
            currentBtn.ForeColor = Color.Red;
        }

        private void button1_MouseLeave(object sender, EventArgs e)
        {
            var currentBtn = (Button)sender;
            currentBtn.ForeColor = Color.WhiteSmoke;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Registration resgistration = new Registration();
            resgistration.Show();
        }
    }
}
