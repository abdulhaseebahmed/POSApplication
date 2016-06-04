using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;
using POSApplication.Model;
using System.Net.NetworkInformation;

namespace POSApplication.Forms
{
    public partial class MainForm : Form
    {
        LoginForm lf = null;
        public MainForm()
        {
            InitializeComponent();
        }

        public MainForm(LoginForm lf)
        {
            AppConfig.businessSlogan = GetBusinessSlogan();
            AppConfig.bussinessname = getBusinessName();
            this.lf = lf;
            InitializeComponent();
            this.loginlogoffbutton.Text = "LogOff";
            this.Loggedinuserlabel.Text = AppConfig.loggedInUserName;
            this.RoleLabel.Text = AppConfig.loggedInUserRole;
            this.label1.Text = AppConfig.businessSlogan;
            
            //getting application mac address
            GetMacAddress();
            //getting the printer configuration
            getPrinterConfig();
            if(AppConfig.loggedInUserRole == "Salesman")
            {
                //Reports Button is disabled
                button2.Enabled = false;
                //Accounts Button is disabled
                button8.Enabled = false;
                //Business Registration Button is disabled
                RegisterBusinessButton.Enabled = false;
                //Users Button is disabled
                button4.Enabled = false;
                //Suppliers Button is disabled
                button9.Enabled = false;
                //Products Registration Button is disabled
                ProductsButton.Enabled = false;
                //Inventory Management Button is disabled
                button5.Enabled = false;
            }
        }

        public string GetBusinessSlogan()
        {
            using (var db = new Model.posdbEntities())
            {
                var query = (from s in db.businesses
                             select new { BusinessSlogan = s.Slogan }).SingleOrDefault();
                if (query != null)
                    return query.BusinessSlogan;
                else
                    return "Please set a business slogan.";
            }
        }

        public string getBusinessName()
        {
            using (var db = new Model.posdbEntities())
            {
                var query = (from s in db.businesses
                             select new { s.BusinessName }).SingleOrDefault();
                if (query != null)
                    return query.BusinessName;
                else
                    return "Please set a business name.";
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            ReportsForm rf = new ReportsForm();
            rf.ShowDialog();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            SalesForm sf = new SalesForm();
            sf.ShowDialog();
        }

        private void button6_Click(object sender, EventArgs e)
        {
            PurchaseForm pf = new PurchaseForm();
            pf.ShowDialog();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            InventoryLevels il = new InventoryLevels();
            il.ShowDialog();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            UsersForm af = new UsersForm();
            af.ShowDialog();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            lf.Close();
            this.Close();

        }

        private void button7_Click(object sender, EventArgs e)
        {
            //pictureBox1.Image = null;
            RegisterBusinessForm rf = new RegisterBusinessForm();
            //rf.ShowDialog();

            //LoginForm f = new LoginForm();
            rf.onSuccessfulPictureChange += new EventHandler(child_onPictureChange);
            rf.ShowDialog();
        }

        private void MainForm_Load(object sender, EventArgs e)
        {
            DateLabel.Text = DateTime.Today.Date.ToShortDateString();

            using (var db = new Model.posdbEntities())
            {
                string applicationPath = Path.GetDirectoryName(Application.ExecutablePath);
                var query = (from b in db.businesses
                             select new { ImageFile = b.BusLogoFileName }).SingleOrDefault();
                string fileextension = Path.GetExtension(query.ImageFile);
                string destFile = System.IO.Path.Combine(applicationPath, "companylogo" + fileextension);
                AppConfig.imagefile = destFile;
                FileStream fs = new FileStream(destFile, System.IO.FileMode.Open, System.IO.FileAccess.Read);
                pictureBox1.Image = Image.FromStream(fs);
                fs.Close();
            }
        }

        private void button8_Click(object sender, EventArgs e)
        {
            AccountsForm af = new AccountsForm();
            af.ShowDialog();
        }

        private void aboutMPOSToolStripMenuItem_Click(object sender, EventArgs e)
        {
            HelpDialog hd = new HelpDialog();
            hd.ShowDialog();
        }

        private void exitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            lf.Close();
            this.Close();
        }

        private void button9_Click(object sender, EventArgs e)
        {
            SuppliersForm sf = new SuppliersForm();
            sf.ShowDialog();
        }

        private void button7_Click_1(object sender, EventArgs e)
        {
            //AppConfig.loggedInUserID = query.UserID;
            //AppConfig.loggedInUserName = query.UserName;
            //AppConfig.loggedInUserRole = query.RoleName;
            //AppConfig.loginTime = DateTime.Now;
            if (AppConfig.loggedInUserName.Length > 0 && AppConfig.loggedInUserRole.Length > 0)
            {
                logoffuser();
            }
            else
            {
                lf.onSuccessfulUserLogin += new EventHandler(child_onloginuser);
                lf.ShowDialog();
            }
        }

        public void logoffuser()
        {
            AppConfig.loggedInUserName = "";
            AppConfig.loggedInUserRole = "";
            Loggedinuserlabel.Text = "";
            AppConfig.loggedInUserID = 0;
            //AppConfig.loginTime = DateTime.Now;
            loginlogoffbutton.Text = "User Login";
            AppConfig.businessSlogan = "";
            this.Hide();
            lf.Show();

        }

        public void DBAction_LoginUser()
        {
            using (var db = new Model.posdbEntities())
            {
                //code needs to be written here for user login
            }
        }
        public void DBAction_LogoutUser()
        {
            using (var db = new Model.posdbEntities())
            {
                //code needs to be written here for user logoff
            }
        }
        public void child_onloginuser(object sender, EventArgs e)
        {
            this.Loggedinuserlabel.Text = (string)sender;
            this.RoleLabel.Text = (string)AppConfig.loggedInUserRole;
            this.label1.Text = (string)AppConfig.businessSlogan;
            loginlogoffbutton.Text = "Logoff";
        }

        public void child_onPictureChange(object sender, EventArgs e)
        {
            FileStream fs = new FileStream(AppConfig.imagefile, System.IO.FileMode.Open, System.IO.FileAccess.Read);
            pictureBox1.Image = Image.FromStream(fs);
            fs.Close();
            label1.Text = AppConfig.businessSlogan;
            //pictureBox1.Image = Image.FromFile(AppConfig.imagefile);
        }

        private void ProductsButton_Click(object sender, EventArgs e)
        {
            ProductsForm pf = new ProductsForm();
            pf.ShowDialog();
        }

        private void button11_Click(object sender, EventArgs e)
        {
            //JournalLedger jl = new JournalLedger();
            //jl.ShowDialog();
            InvoicesForm inv = new InvoicesForm();
            inv.ShowDialog();
        }

        private void MainForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            lf.Close();
        }

        private void loginToolStripMenuItem_Click(object sender, EventArgs e)
        {
            logoffuser();
        }

        private void businessToolStripMenuItem_Click(object sender, EventArgs e)
        {
            RegisterBusinessForm rf = new RegisterBusinessForm();
            rf.ShowDialog();
        }

        private void salesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            SalesForm sf = new SalesForm();
            sf.ShowDialog();
        }

        private void purchasesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            PurchaseForm pf = new PurchaseForm();
            pf.ShowDialog();
        }

        private void suppliersToolStripMenuItem_Click(object sender, EventArgs e)
        {
            SuppliersForm sf = new SuppliersForm();
            sf.ShowDialog();
        }

        private void inventoryToolStripMenuItem_Click(object sender, EventArgs e)
        {
            InventoryLevels il = new InventoryLevels();
            il.ShowDialog();
        }

        private void usersToolStripMenuItem_Click(object sender, EventArgs e)
        {
            UsersForm uf = new UsersForm();
            uf.ShowDialog();
        }

        private void productsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ProductsForm pf = new ProductsForm();
            pf.ShowDialog();
        }

        private void productCategoriesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            CategoriesForm cf = new CategoriesForm();
            cf.ShowDialog();
        }

        private void reportsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ReportsForm rf = new ReportsForm();
            rf.ShowDialog();
        }

        private void mmPaperToolStripMenuItem1_DoubleClick(object sender, EventArgs e)
        {

            MessageBox.Show("");
        }

        public void GetMacAddress()
        {
            var macAddr =
            (
                from nic in NetworkInterface.GetAllNetworkInterfaces()
                where nic.OperationalStatus == OperationalStatus.Up
                select nic.GetPhysicalAddress().ToString()
            ).FirstOrDefault();
            AppConfig.MacAddress = macAddr;
        }

        public void getPrinterConfig()
        {
            using (var db = new Model.posdbEntities())
            {
                var printertype = (from p in db.terminals
                                   where p.TerminalName == AppConfig.MacAddress
                                   select new { PrinterType = p.PrinterType }).SingleOrDefault();

                if (printertype != null)
                {
                    AppConfig.PrinterType = printertype.PrinterType.ToString();
                    if(AppConfig.PrinterType == "80")
                    {
                        mmPaperToolStripMenuItem.Checked = true;
                        mmPaperToolStripMenuItem1.Checked = false;
                    }
                    else if(AppConfig.PrinterType == "60")
                    {
                        mmPaperToolStripMenuItem.Checked = false;
                        mmPaperToolStripMenuItem1.Checked = true;
                    }
                }
                else
                {
                    terminal ter = new terminal();
                    ter.StoreID = 1;
                    ter.TerminalName = AppConfig.MacAddress;
                    ter.PrinterType = 80;
                    AppConfig.PrinterType = "80".ToString();
                    db.terminals.Add(ter);
                    db.SaveChanges();
                }
            }
        }

        private void mmPaperToolStripMenuItem_CheckedChanged(object sender, EventArgs e)
        {
            ToolStripMenuItem temp;
            // uncheck the old one
            //temp.CheckState = CheckState.Unchecked;
            temp = (ToolStripMenuItem)sender;
            // check the new one
            //temp.CheckState = CheckState.Checked;

            using (var db = new Model.posdbEntities())
            {
                if (temp.CheckState == CheckState.Checked)
                {
                    var printertype = (from p in db.terminals
                                       where p.TerminalName == AppConfig.MacAddress
                                       select p).Single();
                    if (temp.Text == "60mm Paper")
                    {
                        printertype.PrinterType = 60;
                        AppConfig.PrinterType = "60";
                    }
                    else if (temp.Text == "80mm Paper")
                    {
                        printertype.PrinterType = 80;
                        AppConfig.PrinterType = "80";
                    }
                    db.SaveChanges();

                    mmPaperToolStripMenuItem1.CheckState = CheckState.Unchecked;
                }
            }
        }

        private void mmPaperToolStripMenuItem1_CheckedChanged(object sender, EventArgs e)
        {
            ToolStripMenuItem temp;
            // uncheck the old one
            //temp.CheckState = CheckState.Unchecked;
            temp = (ToolStripMenuItem)sender;
            // check the new one
            //temp.CheckState = CheckState.Checked;

            using (var db = new Model.posdbEntities())
            {
                if (temp.CheckState == CheckState.Checked)
                {
                    var printertype = (from p in db.terminals
                                       where p.TerminalName == AppConfig.MacAddress
                                       select p).Single();
                    if (temp.Text == "60mm Paper")
                    {
                        printertype.PrinterType = 60;
                        AppConfig.PrinterType = "60";
                    }
                    else if (temp.Text == "80mm Paper")
                    {
                        printertype.PrinterType = 80;
                        AppConfig.PrinterType = "80";
                    }
                    db.SaveChanges();

                    mmPaperToolStripMenuItem.CheckState = CheckState.Unchecked;
                }
            }
        }
    }
}
