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
    public partial class AddNewPassword : Form
    {
        public string whatToAdd = "";
        public string whereToAdd = "";
        private MainForm mainform = null;
        public AddNewPassword(Form callingForm)
        {
            mainform = callingForm as MainForm;
            InitializeComponent();
            editOrAddForm(mainform.editOrAddForm, mainform.indexOfPassword);
        }
        private void AddBtn_Click(object sender, EventArgs e)
        {
            ///
            /// 1 is Add 2 is Edit
            /// 
            switch (mainform.editOrAddForm)
            {
                case 1:
                    if (Service.Text == string.Empty || Username.Text == string.Empty || Password.Text == string.Empty)
                    {
                        MessageBox.Show("Service, Username, Password are nessery\n Please Complite");
                    }
                    else
                    {
                        whereToAdd += "IdUser, ";
                        whatToAdd += "'" + mainform.sqlClass.login._id + "', ";
                        foreach (var c in this.Controls)
                        {
                            if (c is TextBox && ((TextBox)c).Text != string.Empty)
                            {
                                whereToAdd += ((TextBox)c).Name.ToString() + ", ";
                                whatToAdd += "'" + ((TextBox)c).Text + "', ";
                            }
                        }
                        whereToAdd = whereToAdd.Remove(whereToAdd.Length - 2);
                        whatToAdd = whatToAdd.Remove(whatToAdd.Length - 2);
                        mainform.sqlClass.addNewPasswordToDb(whatToAdd, whereToAdd);
                        this.Hide();
                        this.mainform.addRowToGridView(mainform.sqlClass.loadPassword(mainform.sqlClass.login._id), mainform.sqlClass);
                    }
                    break;
                case 2:
                    if (Service.Text == string.Empty || Username.Text == string.Empty || Password.Text == string.Empty)
                    {
                        MessageBox.Show("Service, Username, Password are nessery\n Please Complite");
                    }
                    else
                    {
                        string commandEdit = "";
                        foreach (var c in this.Controls)
                        {
                            if (c is TextBox && ((TextBox)c).Text != string.Empty)
                            {
                                commandEdit += ((TextBox)c).Name.ToString() + " = ";
                                commandEdit += "'" + ((TextBox)c).Text + "', ";
                            }
                        }
                        commandEdit = commandEdit.Remove(commandEdit.Length - 2);
                        mainform.sqlClass.editPasswordInDb(commandEdit, mainform.sqlClass.loadPassword(mainform.sqlClass.login._id)[mainform.indexOfPassword]._id);                    
                        this.Hide();
                        this.mainform.addRowToGridView(mainform.sqlClass.loadPassword(mainform.sqlClass.login._id), mainform.sqlClass);
                    }
                    break;
            }
            
        }

        private void CancelBtn_Click(object sender, EventArgs e)
        {
            this.Hide();
            clearTextbox(this);
        }

        private void clearTextbox(Control control)
        {
            foreach (var c in control.Controls)
            {
                if (c is TextBox) ((TextBox)c).Text = String.Empty;
                
            }
        }

        private void editOrAddForm(int i, int index)
        {
            switch (i)
            {
                case 1:
                    this.Text="Add New Password";
                    AddBtn.Text = "Add";
                    break;
                case 2:
                    this.Text = "Edit Password";
                    AddBtn.Text = "Edit";
                    Service.Text = mainform.sqlClass.loadPassword(mainform.sqlClass.login._id)[index]._service;
                    Url.Text = mainform.sqlClass.loadPassword(mainform.sqlClass.login._id)[index]._url;
                    Email.Text = mainform.sqlClass.loadPassword(mainform.sqlClass.login._id)[index]._email;
                    Username.Text = mainform.sqlClass.loadPassword(mainform.sqlClass.login._id)[index]._username;
                    Password.Text = mainform.sqlClass.loadPassword(mainform.sqlClass.login._id)[index]._password;
                    break;
            }
        }
    }
}
