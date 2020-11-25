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
    public partial class NewUser : Form
    {
        
        private MainForm mainform = null;

        public NewUser(Form callingForm)
        {
            mainform = callingForm as MainForm;
            InitializeComponent();
        }

        private void CreateBtn_Click(object sender, EventArgs e)
        {
            if(UsernameTxtbox.Text!= string.Empty && PasswordTxtbox.Text != string.Empty)
            if (mainform.sqlClass.isThatUser(UsernameTxtbox.Text) == 0)
            {
                if (PasswordTxtbox.Text == ConfirmPassTxtbox.Text)
                {
                    mainform.sqlClass.addNewUser(UsernameTxtbox.Text, PasswordTxtbox.Text);
                    mainform.sqlClass.goodUsernameAndPassword(UsernameTxtbox.Text, PasswordTxtbox.Text);
                    this.Hide();
                    this.mainform.addRowToGridView(mainform.sqlClass.loadPassword(mainform.sqlClass.login._id), mainform.sqlClass);
                    mainform.Enabled = true;
                }
                else
                {
                    MessageBox.Show("Password are no same");
                }
            }
            else
            {
                MessageBox.Show("This user name are taken");
                }
            else
            {
                MessageBox.Show("No Username or password");
            }
        }
        protected override void OnFormClosing(FormClosingEventArgs e)
        {
            base.OnFormClosing(e);

            if (e.CloseReason == CloseReason.WindowsShutDown) return;
            Login login = new Login(mainform);
            login.Show();
            this.Hide();
        }

        private void CanceleBtn_Click(object sender, EventArgs e)
        {
            Login login = new Login(mainform);
            login.Show();
            this.Hide();
        }
    }
}
