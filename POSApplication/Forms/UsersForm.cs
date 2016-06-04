using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace POSApplication.Forms
{
    public partial class UsersForm : Form
    {
        public UsersForm()
        {
            InitializeComponent();
        }

        private void UsersForm_Load(object sender, EventArgs e)
        {
            RoleCombo.Text = "Salesman";
            LoadExistingPOSUsers();
        }

        public void LoadExistingPOSUsers()
        {
            ExistingUsersList.Items.Clear();
            using (var dbCtx = new POSApplication.Model.posdbEntities())
            {
                var query = from d in dbCtx.posusers
                            select new { UserName = d.UserName };

                foreach (var r in query)
                {
                    ExistingUsersList.Items.Add(r.UserName);
                }
            }
        }

        public void deletePOSUser(string UserName)
        {
            using (var dbCtx = new POSApplication.Model.posdbEntities())
            {
                var itemToRemove = dbCtx.posusers.SingleOrDefault(x => x.UserName == UserName);
                if (itemToRemove != null)
                {
                    dbCtx.posusers.Remove(itemToRemove);
                    dbCtx.SaveChanges();
                    LoadExistingPOSUsers();
                }
            }
        }

        private void SaveButton_Click(object sender, EventArgs e)
        {
            string username = "";
            string password = "";

            if (UserNameField.Text.Length > 0)
            {
                username = UserNameField.Text;
                if (RePasswordField.Text.Length > 0)
                {
                    if (PasswordField.Text.CompareTo(RePasswordField.Text) == 0)
                    {
                        password = PasswordField.Text;
                    }
                    else
                    {
                        MessageBox.Show("Password does not match with re-password.");
                    }
                }
                else
                {
                    MessageBox.Show("Empty password or re-password field.");
                }

                if (username.Length > 0 && password.Length > 0)
                {
                    using (var dbCtx = new POSApplication.Model.posdbEntities())
                    {
                        var query = (from u in dbCtx.roles
                                     where u.RoleName == RoleCombo.Text
                                     select new { RoleID = u.RoleID }).SingleOrDefault();
                        int roleid = (int)query.RoleID;

                        var query1 = (from t1 in dbCtx.posusers
                                      join t2 in dbCtx.roles
                                      on new { t1.RoleID } equals
                                          new { t2.RoleID }
                                      where t1.RoleID == roleid && t1.UserName == username
                                      select new { RoleName = t2.RoleName, UserName = t1.UserName, UserID = t1.UserID }).SingleOrDefault();

                        bool userexists = false;
                        if (query1 != null)
                            userexists = true;
                        else
                            userexists = false;

                        //if user does not already exists then
                        if (!userexists)
                        {
                            //Creating a new posuser variable
                            Model.posuser r = new Model.posuser();
                            r.UserName = username;
                            r.RoleID = roleid;
                            r.Password = password;
                            dbCtx.posusers.Add(r);
                            // call SaveChanges method to save posuser
                            dbCtx.SaveChanges();
                            MessageBox.Show("New User '" + username + "' with role '" + RoleCombo.Text + "' has been added into POS System.");
                            clearFields();
                            LoadExistingPOSUsers();
                        }
                        else
                        {
                            MessageBox.Show("User already exists in the system.");
                            clearFields();
                        }
                    }
                }
            }
            else
            {
                MessageBox.Show("Please enter password for the new user.");
            }
        }

        private void CloseButton_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        public void clearFields()
        {
            UserNameField.Text = "";
            PasswordField.Text = "";
            RePasswordField.Text = "";
            RoleCombo.Text = "Salesman";
        }

        private void DeleteUserButton_Click(object sender, EventArgs e)
        {
            if (ExistingUsersList.SelectedItem != null)
            {
                deletePOSUser(ExistingUsersList.GetItemText(ExistingUsersList.SelectedItem));
                ExistingUsersList.Items.Remove(ExistingUsersList.SelectedItem);
            }
        }

        private void NewButton_Click(object sender, EventArgs e)
        {
            clearFields();
        }
    }
}
