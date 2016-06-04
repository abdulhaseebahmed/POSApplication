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
    public partial class LedgerForm : Form
    {

        List<Model.POSClasses.EntityClasses.TransactionClass> currentTransactions;
        string selectedAccount = "";
        public LedgerForm()
        {
            InitializeComponent();
            currentTransactions = new List<Model.POSClasses.EntityClasses.TransactionClass>();
            loadAccountsCombo();
        }

        public LedgerForm(string accountName)
        {
            InitializeComponent();
            currentTransactions = new List<Model.POSClasses.EntityClasses.TransactionClass>();
            this.selectedAccount = accountName;
            loadAccountsCombo();
        }

        public void loadAccountsCombo()
        {
            using (var db = new Model.posdbEntities())
            {
                var query = (from b in db.accounts
                             select new { AccountName = b.AccountName }).ToList();
                AccountNameCombo.Items.Clear();
                int a = 0;
                foreach (var item in query)
                {
                    //if (a == 0)
                    //{
                    //    comboBox1.Items.Add("None");
                    //    comboBox1.Text = "None";
                    //    comboBox2.Items.Add("None");
                    //    comboBox2.Text = "None";
                    //}
                    //a += 1;
                    AccountNameCombo.Items.Add(item.AccountName);
                }
            }
        }

        public void searchRecords(string accountname, string startdate, string enddate)
        {
            int? accountid = GetAccountID(accountname);
            using (var db = new POSApplication.Model.posdbEntities())
            {
                DateTime StartDate = DateTime.Parse(startdate);
                DateTime EndDate = DateTime.Parse(enddate);

                var q = (from t in db.transactions
                         where t.accountid == accountid && t.entrydate >= StartDate && t.entrydate <= EndDate
                         select new { AccountTitle = accountname, DebitAmount = t.Debit, CreditAmount = t.Credit, Description = t.description, Date = t.entrydate, Time = t.entrytime }).ToList();

                currentTransactions = new List<Model.POSClasses.EntityClasses.TransactionClass>();

                foreach (var item in q)
                {
                    var trans = new POSApplication.Model.POSClasses.EntityClasses.TransactionClass();
                    trans.AccountID = GetAccountID(item.AccountTitle);
                    trans.AccountName = accountname;
                    if (item.DebitAmount != null)
                    {
                        trans.iscredit = 0;
                        trans.transactionAmount = Double.Parse(item.DebitAmount.GetValueOrDefault().ToString());
                    }
                    else
                    {
                        trans.iscredit = 1;
                        trans.transactionAmount = Double.Parse(item.CreditAmount.GetValueOrDefault().ToString());
                    }
                    trans.transactionDate = item.Date.GetValueOrDefault();
                    trans.transactionTimeString = item.Time.GetValueOrDefault().ToString();
                    trans.transactionDescription = item.Description;
                    currentTransactions.Add(trans);
                }
            }
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

        private void ShowLedgerButton_Click(object sender, EventArgs e)
        {
            if (selectedAccount.Length == 0)
            {
                if (AccountNameCombo.Text.Length > 0)
                    selectedAccount = AccountNameCombo.GetItemText(AccountNameCombo.Text);
            }

            //if (selectedAccount.Length > 0)
            searchRecords(selectedAccount, dateTimePicker1.Value.ToString(), dateTimePicker2.Value.ToString());
            selectedAccount = "";
            string iscredit = "";
            DataSet transactionsDataSet = new DataSet();
            DataTable transactionsDataTable = new DataTable("Transactions");
            transactionsDataTable.Columns.Add("AccountTitle");
            transactionsDataTable.Columns.Add("TransactionType");
            transactionsDataTable.Columns.Add("Description");
            transactionsDataTable.Columns.Add("Date");
            transactionsDataTable.Columns.Add("Time");
            transactionsDataTable.Columns.Add("Amount");
            transactionsDataTable.Columns.Add("Balance");

            foreach (var item in currentTransactions)
            {
                if (item.iscredit == 1)
                    iscredit = "Credit";
                else
                    iscredit = "Debit";
                //working code when deleting the rows.
                transactionsDataTable.Rows.Add(item.AccountName, iscredit, item.transactionDescription, item.transactionDate.Date.ToShortDateString(), item.transactionTimeString, item.transactionAmount, item.balance);
            }

            transactionsDataSet.Tables.Add(transactionsDataTable);
            LedgerGridView.DataSource = transactionsDataSet;
            LedgerGridView.DataMember = "Transactions";
            LedgerGridView.Refresh();
            reColorGrid();
        }

        public void reColorGrid()
        {
            double totalDebit = 0;
            double totalCredit = 0;
            for (int a = 0; a < LedgerGridView.Rows.Count; a++)
            {
                if (LedgerGridView.Rows[a].Cells[1].Value != null)
                {
                    if (LedgerGridView.Rows[a].Cells[1].Value.ToString().CompareTo("Debit") == 0)
                    {
                        LedgerGridView.Rows[a].Cells[1].Style.ForeColor = Color.Green;
                        totalDebit += Double.Parse(LedgerGridView.Rows[a].Cells[5].Value.ToString());
                    }
                    else
                    {
                        LedgerGridView.Rows[a].Cells[1].Style.ForeColor = Color.Red;
                        totalCredit += Double.Parse(LedgerGridView.Rows[a].Cells[5].Value.ToString());
                    }
                }
            }
            //TotalDebitField.Text = totalDebit.ToString();
            //TotalCreditField.Text = totalCredit.ToString();
        }

        private void CloseButton_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
