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
    public partial class AccountsForm : Form
    {
        public AccountsForm()
        {
            InitializeComponent();
        }

        public void loadExistingAccounts()
        {
            ExistingAccounts.Items.Clear();
            using (var db = new POSApplication.Model.posdbEntities())
            {
                var query = db.accounts.ToList();
                foreach (var item in query)
                {
                    ExistingAccounts.Items.Add(item.AccountName);
                }
            }

            using (var db = new Model.posdbEntities())
            {
                var query = (from b in db.accounts
                             select new { AccountName = b.AccountName }).ToList();
                comboBox1.Items.Clear();
                comboBox2.Items.Clear();
                comboBox3.Items.Clear();
                int a = 0;
                foreach (var item in query)
                {
                    if (a == 0)
                    {
                        comboBox1.Items.Add("None");
                        comboBox1.Text = "None";
                        comboBox2.Items.Add("None");
                        comboBox2.Text = "None";
                    }
                    a += 1;
                    comboBox1.Items.Add(item.AccountName);
                    comboBox2.Items.Add(item.AccountName);
                    comboBox3.Items.Add(item.AccountName);
                }
            }

            drawChartOfAccount();
        }

        private void CloseButton_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void AccountsForm_Load(object sender, EventArgs e)
        {
            loadExistingAccounts();
        }

        public void drawChartOfAccount()
        {
            treeView1.BeginUpdate();
            treeView1.Nodes.Clear();
            treeView1.Nodes.Add("Accounts");

            using (var db = new Model.posdbEntities())
            {
                var allacounts = db.accounts.ToList();
                foreach (var item in allacounts)
                {
                    if(item.ParentAccountID == null)
                    {
                        treeView1.Nodes[0].Nodes.Add(item.AccountName);
                    }
                }
                treeView1.EndUpdate();
                treeView1.BeginUpdate();
                foreach (var item in allacounts)
                {
                    if (item.ParentAccountID != null)
                    {
                        int? parentID = item.ParentAccountID;
                        string parentAccountName = GetAccountName(parentID);
                        TreeNode node = FindNode(treeView1.Nodes[0], parentAccountName);
                        if(node != null)
                            node.Nodes.Add(new TreeNode(item.AccountName));
                    }
                }
            }
            treeView1.EndUpdate();
        }

        private TreeNode FindNode(TreeNode node, string searchText)
        {
            TreeNode result = null;

            if (node.Text == searchText)
            {
                result = node;
            }
            else
            {
                foreach (TreeNode child in node.Nodes)
                {
                    result = FindNode(child, searchText);
                    if (result != null)
                    {
                        break;
                    }
                }
            }
            return result;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            saveNewAccount();
        }

        public int? GetAccountID(string accountname)
        {
            using (var db = new POSApplication.Model.posdbEntities())
            {
                var query = (from d in db.accounts
                             where d.AccountName == accountname
                             select new { AccountID = d.AccountID }).SingleOrDefault();
                if (query != null)
                {
                    return query.AccountID;
                }
            }
            return null;
        }

        public string GetAccountName(int? accountid)
        {
            using (var db = new POSApplication.Model.posdbEntities())
            {
                var query = (from d in db.accounts
                             where d.AccountID == accountid
                             select new { AccountName = d.AccountName }).SingleOrDefault();
                if (query != null)
                {
                    return query.AccountName;
                }
            }
            return null;
        }

        public void saveNewAccount()
        {
            string accountname = "";
            string description = "";
            string parentaccountname = "";

            if (accountnameField.Text.Length > 0)
            {
                accountname = accountnameField.Text;
            }
            else
            {
                MessageBox.Show("Add Account Name First.");
                return;
            }

            if (descriptionField.Text.Length > 0)
            {
                description = descriptionField.Text;
            }

            if (comboBox1.GetItemText(comboBox1.SelectedItem).Length > 0)
            {
                parentaccountname = comboBox1.GetItemText(comboBox1.SelectedItem);
            }
            else
            {
                MessageBox.Show("Choose Parent Account.");
                return;
            }

            using (var dbCtx = new POSApplication.Model.posdbEntities())
            {
                var existingaccount = dbCtx.accounts.Where(b => b.AccountName == accountname).SingleOrDefault();

                if(existingaccount != null)
                {
                    MessageBox.Show("Account with the same name already exists.");
                    return;
                }

                Model.account a = new Model.account();
                a.AccountName = accountname;
                a.Description = description;
                if (parentaccountname.CompareTo("None") == 0)
                {
                    a.ParentAccountID = null;
                }
                else
                {
                    a.ParentAccountID = GetAccountID(parentaccountname);
                }

                dbCtx.accounts.Add(a);
                dbCtx.SaveChanges();
                MessageBox.Show("New Account '" + accountname + "' has been added.");
                //refreshing the existing accounts list
                loadExistingAccounts();
            }
        }

        public void deleteAccount()
        {
            if (ExistingAccounts.SelectedItem != null)
            {
                string existingAccount = (ExistingAccounts.GetItemText(ExistingAccounts.SelectedItem));

                using (var dbCtx = new POSApplication.Model.posdbEntities())
                {
                    var itemToRemove = dbCtx.accounts.SingleOrDefault(x => x.AccountName == existingAccount);
                    if (itemToRemove != null)
                    {
                        dbCtx.accounts.Remove(itemToRemove);
                        dbCtx.SaveChanges();
                    }
                }
                ExistingAccounts.Items.Remove(ExistingAccounts.SelectedItem);
                loadExistingAccounts();
            }
        }

        private void DeleteButton_Click(object sender, EventArgs e)
        {
            deleteAccount();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            saveEditedAccount();
        }

        public void saveEditedAccount()
        {
            string existingaccountname = "";
            string newaccountname;
            string newdescription;
            string newparentaccount = "";

            if (comboBox3.GetItemText(comboBox3.SelectedItem).Length > 0)
            {
                existingaccountname = comboBox3.GetItemText(comboBox3.SelectedItem);
            }

            if(textBox2.Text.Length > 0)
            { 
                newaccountname = textBox2.Text;
            }
            else
            {
                MessageBox.Show("Enter valid account name");
                return;
            }
            if (textBox3.Text.Length > 0)
            {
                newdescription = textBox3.Text;
            }
            else{
                newdescription = "";
            }

            if(comboBox2.GetItemText(comboBox2.SelectedItem).Length>0)
            {
                newparentaccount = comboBox2.GetItemText(comboBox2.SelectedItem);
            }

            using (var db = new POSApplication.Model.posdbEntities())
            {
                var existingacct = db.accounts.Where(a => a.AccountName == existingaccountname).SingleOrDefault();
                existingacct.AccountName = newaccountname;
                existingacct.Description = newdescription;
                existingacct.ParentAccountID = GetAccountID(newparentaccount);
                db.SaveChanges();
                MessageBox.Show("New changes have been saved.");
                loadExistingAccounts();
                comboBox3.Text = newaccountname;
            }
        }

        private void comboBox3_SelectedIndexChanged(object sender, EventArgs e)
        {
            string existingaccountname = comboBox3.GetItemText(comboBox3.SelectedItem);
            string accountname;
            string description;
            string parentaccountname;
            using (var db = new POSApplication.Model.posdbEntities())
            {
                var a = (from ac in db.accounts
                         where ac.AccountName == existingaccountname
                         select new { Description = ac.Description, ParentAccountID = ac.ParentAccountID}).SingleOrDefault();
                textBox2.Text = existingaccountname;
                textBox3.Text = a.Description;
                comboBox2.Text = GetAccountName(a.ParentAccountID);
            }
        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            string selectedAccountName = "";
            if(treeView1.SelectedNode!=null)
            {
                selectedAccountName = treeView1.SelectedNode.Text;
                //temporary check. should be handled some other better way!!!
                if(selectedAccountName.CompareTo("Accounts") == 0)
                {
                    selectedAccountName = "";
                }
            }
            LedgerForm lf = new LedgerForm(selectedAccountName);
            lf.ShowDialog();
        }
    }
}
