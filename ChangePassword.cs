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
    public partial class ChangePassword : Form
    {
        private MainForm mainform = null;
        public ChangePassword(Form callingForm)
        {
            mainform = callingForm as MainForm;
            InitializeComponent();
        }

        private void ChangeBtn_Click(object sender, EventArgs e)
        {
            if (mainform.sqlClass.changeUserPassword(OldPassTxtbox.Text, NewPassTxtbox.Text, ConfirmPassTxtbox.Text))
            {
                MessageBox.Show("Password was change");
                this.Hide();
            }else 
            {
                MessageBox.Show("Wrone Old password or new password are no the same!"); ;
            }
        }

        private void CanceleBtn_Click(object sender, EventArgs e)
        {
            this.Hide();
        }
    }
}
