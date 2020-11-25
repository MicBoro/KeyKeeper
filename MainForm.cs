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
    public partial class MainForm : Form
    {
        public SqlClass sqlClass = new SqlClass();

        public int selectRow = 0;
        public int editOrAddForm = 1;
        public int indexOfPassword = -1;
        public MainForm()
        {
            InitializeComponent();
            this.Enabled = false;
        }


        public void addRowToGridView(List<StoredPasswordClass> s, SqlClass sql)
        {
            
            PasswordTableGril.Rows.Clear();
            foreach(StoredPasswordClass SPC in s)
            {
                var passwordValue = "";
                var row = new DataGridViewRow();
                row.Cells.Add(new DataGridViewTextBoxCell { Value = SPC._service });
                row.Cells.Add(new DataGridViewTextBoxCell { Value = SPC._url });
                row.Cells.Add(new DataGridViewTextBoxCell { Value = SPC._username });
                ///
                ///change password to *
                ///
                for (int i = 0; i < SPC._password.Length; i++)
                    passwordValue += "*";

                row.Cells.Add(new DataGridViewTextBoxCell { Value = passwordValue });
                row.Cells.Add(new DataGridViewTextBoxCell { Value = SPC._email });
                PasswordTableGril.Rows.Add(row);
            }
        }

        

        private void AddNewPassword_Click(object sender, EventArgs e)
        {
            editOrAddForm = 1;
            AddNewPassword addNP = new AddNewPassword(this);
            
            addNP.Show();
        }

        
        private void changePassword_Click(object sender, EventArgs e)
        {
            ChangePassword changePassword = new ChangePassword(this);
            changePassword.Show();
        }

        private void logout_Click(object sender, EventArgs e)
        {
            Login login = new Login(this);
            login.Show();
            sqlClass.login = null;
            PasswordTableGril.Rows.Clear();
            this.Enabled = false;
        }

        private void exit_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void delete_Click(object sender, EventArgs e)
        {
            sqlClass.deletePasswordFromDb(sqlClass.loadPassword(sqlClass.login._id)[PasswordTableGril.CurrentRow.Index]._id);
            addRowToGridView(sqlClass.loadPassword(sqlClass.login._id), sqlClass);
        }

        private void edit_Click(object sender, EventArgs e)
        {
            if (PasswordTableGril.CurrentRow !=null)
            {
                editOrAddForm = 2;
                indexOfPassword = PasswordTableGril.CurrentRow.Index;
                AddNewPassword addNewPassword = new AddNewPassword(this);
                addNewPassword.Show();
            }
            else
            {
                MessageBox.Show("Nothing to edit");
            }
        }

        private void MainForm_Load(object sender, EventArgs e)
        {
            Login login = new Login(this);
            login.Show();
        }

        private void showHideToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var passwordShowHide = "";

            for (int i = 0; i < PasswordTableGril.Rows[selectRow].Cells["Password"].Value.ToString().Length; i++)
                passwordShowHide += "*";

            if (PasswordTableGril.Rows[selectRow].Cells["Password"].Value.ToString() == passwordShowHide)
                PasswordTableGril.Rows[selectRow].Cells["Password"].Value = sqlClass.loadPassword(sqlClass.login._id)[PasswordTableGril.CurrentRow.Index]._password;
                else
                PasswordTableGril.Rows[selectRow].Cells["Password"].Value = passwordShowHide;
        }

        private void contextMenuStrip1_Opening(object sender, CancelEventArgs e)
        {
            if (PasswordTableGril.CurrentRow != null)
            selectRow = PasswordTableGril.CurrentRow.Index;
            if (PasswordTableGril.Rows.Count == 0)
            {
                contextMenuStrip1.Items[1].Enabled = false;
                contextMenuStrip1.Items[0].Enabled = false;
            }
            else
            {
                contextMenuStrip1.Items[1].Enabled = true;
                contextMenuStrip1.Items[0].Enabled = true;
            }

        }

        private void copyToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Clipboard.SetText(sqlClass.loadPassword(sqlClass.login._id)[PasswordTableGril.CurrentRow.Index]._password);
        }

        private void PasswordTableGril_CellMouseDown(object sender, DataGridViewCellMouseEventArgs e)
        {
            var dataGrid = (DataGridView)sender;
            if (e.Button == MouseButtons.Right && e.RowIndex != -1)
            {
                var row = dataGrid.Rows[e.RowIndex];

                    dataGrid.CurrentCell = row.Cells[e.ColumnIndex];
                row.Selected = true;
                dataGrid.Focus();
            }
        }

        private void SearchTxtbox_TextChanged(object sender, EventArgs e)
        {
            addRowToGridView(sqlClass.loadingSearchingFromDb(SearchTxtbox.Text), sqlClass);
        }

    }
}
