using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using POSApplication.Model;

namespace POSApplication.Forms
{
    public partial class LoginForm : Form
    {

        public event EventHandler onSuccessfulUserLogin;
        public LoginForm()
        {
            InitializeComponent();
        }

        private void CloseButton_Click(object sender, EventArgs e)
        {
            this.Close(); 
        }

        private void OkBtn_Click(object sender, EventArgs e)
        {

            DateTime todayDate = DateTime.Now;
            DateTime expirayDate = DateTime.Parse("12/12/2016");
            if(todayDate >= expirayDate)
            {
                MessageBox.Show("The License has expired. Please purchase a new license.");
            }
            else
            {
                string username = "";
                string password = "";
                string userrole = "";

                if (loginnamefield.Text.Length > 0)
                {
                    username = loginnamefield.Text;
                }
                if (PasswordField.Text.Length > 0)
                {
                    password = PasswordField.Text;
                }

                userrole = RoleCombo.Text;

                if (username.Length > 0)
                {
                    using (var dbCtx = new POSApplication.Model.posdbEntities())
                    {
                        bool userexists = false;
                        bool passwordcorrect = false;
                        bool correctrole = false;
                        //var query = (from t1 in dbCtx.posusers
                        //             join t2 in dbCtx.roles
                        //             on new { t1.RoleID } equals
                        //                 new { t2.RoleID }
                        //             where t2.RoleName == userrole && t1.UserName == username && t1.Password == password
                        //             select new { RoleName = t2.RoleName, UserName = t1.UserName, UserID = t1.UserID }).SingleOrDefault();

                        var query = (from t2 in dbCtx.posusers
                                     where t2.UserName == username
                                     select new { Password = t2.Password }).SingleOrDefault();

                        if (query != null)
                            userexists = true;
                        else
                            userexists = false;

                        if (userexists)
                        {
                            if (query.Password == password)
                            {
                                var query1 = (from p1 in dbCtx.posusers
                                              join p2 in dbCtx.roles
                                              on p1.RoleID equals
                                                  p2.RoleID
                                              where p1.UserName == username
                                              select new { RoleName = p2.RoleName, UserName = p1.UserName, UserID = p1.UserID }).SingleOrDefault();
                                if (query1.RoleName == userrole)
                                {
                                    AppConfig.loggedInUserID = query1.UserID;
                                    AppConfig.loggedInUserName = query1.UserName;
                                    AppConfig.loggedInUserRole = query1.RoleName;
                                    AppConfig.loginTime = DateTime.Now;
                                    //AppConfig static class variables set now
                                    SuccessfulUserLogin();

                                    this.Hide();

                                    MainForm mf = new MainForm(this);
                                    mf.Show();

                                    //this.Close();
                                }
                                else
                                {
                                    MessageBox.Show("Invalid Role Selected.");
                                }
                            }
                            else
                            {
                                MessageBox.Show("Invalid Password.");
                            }

                        }
                        else
                        {
                            MessageBox.Show("Invalid Username.");
                        }
                    }
                }
                else
                {
                    MessageBox.Show("Enter UserName.");
                }
            }
            
        }

        private void SuccessfulUserLogin()
        {
            if (onSuccessfulUserLogin != null)
                onSuccessfulUserLogin(AppConfig.loggedInUserName, null);
            loginnamefield.Text = "";
            PasswordField.Text = "";
        }


        private void LoginForm_Load(object sender, EventArgs e)
        {
            RoleCombo.SelectedText = "Salesman";
        }
    }
}
