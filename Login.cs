using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace KeyKeeper
{
    public partial class Login : Form
    {
        private MainForm mainform = null;
        
        public Login(Form callingForm)
        {
            mainform = callingForm as MainForm;
            InitializeComponent();
            UserTxtbox.Focus();
            this.Focus();
        }
        

        private void LoginBtn_Click(object sender, EventArgs e)
        {
            loginFunction();
        }

        private void ExitBtn_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void CreateBtn_Click(object sender, EventArgs e)
        {
            this.Hide();
            NewUser newUser = new NewUser(mainform);
            newUser.Show();
        }
        protected override void OnFormClosing(FormClosingEventArgs e)
        {
            base.OnFormClosing(e);

            Application.Exit();
        }

        

        private void loginFunction()
        {
            if (!mainform.sqlClass.goodUsernameAndPassword(UserTxtbox.Text, PasswordTxtBox.Text))
            {
                MessageBox.Show("Wrong Username or Password");
                UserTxtbox.Text = "";
                PasswordTxtBox.Text = "";
            }
            else
            {
                this.Hide();
                this.mainform.addRowToGridView(mainform.sqlClass.loadPassword(mainform.sqlClass.login._id), mainform.sqlClass);
                mainform.Enabled = true;
            }
        }

        private void UserTxtbox_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (char)Keys.Enter)
            {
                loginFunction();

                e.Handled = true;
            }
        }

        
    }
}
