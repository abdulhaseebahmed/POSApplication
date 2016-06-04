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
    public partial class JournalLedger : Form
    {

        List<Model.POSClasses.EntityClasses.TransactionClass> currentTransactions;

        public JournalLedger()
        {
            InitializeComponent();
            currentTransactions = new List<Model.POSClasses.EntityClasses.TransactionClass>();
        }

        private void SuppliersForm_Load(object sender, EventArgs e)
        {
            SetFormFields();
            FillAccountsCombos();
        }

        public void FillAccountsCombos()
        {
            using (var db = new POSApplication.Model.posdbEntities())
            {
                //Creating a new reqion variable
                var acc = db.accounts.Select(x => x.AccountName).ToList();
                CreditAccountID.Items.Clear();

                //filling credit account combo
                foreach (var item in acc)
                {
                    CreditAccountID.Items.Add(item);
                }
                //filling debit account combo
                DebitAccountID.Items.Clear();
                foreach (var item in acc)
                {
                    DebitAccountID.Items.Add(item);
                }
                db.SaveChanges();
            }
        }

        public void SetFormFields()
        {
            this.DateField.Text = DateTime.Now.Date.ToString();
            //SuppliersList.Items.Clear();
            //using (var dbCtx = new POSApplication.Model.posdbEntities())
            //{
            //    var query = from d in dbCtx.suppliers
            //                select new { SupplierName = d.SupplierName };

            //    foreach (var r in query)
            //    {
            //        RegionsList.Items.Add(r.SupplierName);
            //    }
            //}
        }

        private void DeleteButton_Click(object sender, EventArgs e)
        {

        }

        private void CloseButton_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void SalesInvoiceButton_Click(object sender, EventArgs e)
        {
            SalesForm sf = new SalesForm();
            sf.ShowDialog();
        }

        private void PurchaseInvocieButton_Click(object sender, EventArgs e)
        {
            PurchaseForm pf = new PurchaseForm();
            pf.ShowDialog();
        }

        private void NewAccountButton_Click(object sender, EventArgs e)
        {
            AccountsForm accform = new AccountsForm();
            accform.ShowDialog();
        }

        private void CreditButton_Click(object sender, EventArgs e)
        {
            string accountname = "";
            int iscredit = 0;
            double amount = 0;
            string description = "";

            accountname = CreditAccountID.GetItemText(CreditAccountID.SelectedItem);
            try
            {
                if (CreditAmountField.Text.Length > 0)
                {
                    amount = Double.Parse(CreditAmountField.Text);
                }
                else
                {
                    MessageBox.Show("Enter Amount to credit from the selected account.");
                    return;
                }
            }
            catch (Exception e1)
            {
                MessageBox.Show("Enter Amount to credit from the selected account.");
                return;
            }

            if (CreditTransactionDescription.Text.Length > 0)
            {
                description = CreditTransactionDescription.Text;
            }
            else
            {
                description = "No Description";
            }

            SaveTransaction(accountname, 1, amount, description);
        }

        public int SaveTransaction(string accountname, int iscredit, double amount, string description)
        {
            try
            {
                
                Model.POSClasses.EntityClasses.TransactionClass tclass = new Model.POSClasses.EntityClasses.TransactionClass();
                tclass.AccountID = GetAccountID(accountname);
                tclass.AccountName = accountname;
                if (description.Length > 0)
                    tclass.transactionDescription = description;
                else
                    tclass.transactionDescription = "No Description";
                tclass.transactionAmount = amount;
                tclass.iscredit = iscredit;
                tclass.transactionDate = System.DateTime.Now;
                tclass.transactionTime = System.DateTime.Now;
                tclass.balance = 0;
                currentTransactions.Add(tclass);

                updateGrid();
            }
            catch (Exception e)
            {
                MessageBox.Show("Error while saving credit transaction. Details" + e.InnerException.ToString());
            }
            return 0;
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

        private void DebitButton_Click(object sender, EventArgs e)
        {
            string accountname = "";
            int iscredit = 0;
            double amount = 0;
            string description = "";

            try
            {
                accountname = CreditAccountID.GetItemText(DebitAccountID.SelectedItem);
                if (DebitAmountField.Text.Length > 0)
                {
                    amount = Double.Parse(DebitAmountField.Text);
                }
                else
                {
                    MessageBox.Show("Enter Amount to debit from the selected account.");
                    return;
                }
            }
            catch (Exception e1)
            {
                MessageBox.Show("Enter Amount to debit from the selected account.");
                return;
            }

            if (DebitTransactionDescription.Text.Length > 0)
            {
                description = DebitTransactionDescription.Text;
            }

            SaveTransaction(accountname, 0, amount, description);
        }

        public void updateGrid()
        {
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
                //transactionsDataTable.Rows.Add(item.AccountName, iscredit, item.transactionDescription, item.transactionDate.Date.ToShortDateString(), item.transactionTime.ToShortTimeString(), item.transactionAmount, item.balance);
                //working code when deleting the rows.
                transactionsDataTable.Rows.Add(item.AccountName, iscredit, item.transactionDescription, item.transactionDate.Date.ToShortDateString(), item.transactionTime.TimeOfDay.ToString(), item.transactionAmount, item.balance);
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
            TotalDebitField.Text = totalDebit.ToString();
            TotalCreditField.Text = totalCredit.ToString();
            BalanceField.Text = (totalDebit - totalCredit).ToString();
        }

        private void LedgerGridView_Sorted(object sender, EventArgs e)
        {
            reColorGrid();
        }

        private void DeleteTransactionButton_Click(object sender, EventArgs e)
        {
            if (LedgerGridView.SelectedRows.Count > 0 && LedgerGridView.SelectedRows[0].Cells["AccountTitle"].Value != null)
            {
                DataGridViewRow row = this.LedgerGridView.SelectedRows[0];
                string accountName = row.Cells["AccountTitle"].Value.ToString();
                string description = row.Cells["Description"].Value.ToString();
                string transactionType = row.Cells["TransactionType"].Value.ToString();
                string transactionDate = row.Cells["Date"].Value.ToString();
                string transactionTime = row.Cells["Time"].Value.ToString();
                string transactionAmount = row.Cells["Amount"].Value.ToString();
                deleteItem(accountName, transactionType, transactionDate, transactionTime, transactionAmount, description);
            }
        }

        public void deleteItem(string accountName, string tranType, string tranDate, string tranTime, string tranAmount, string tranDescription)
        {
            Model.POSClasses.EntityClasses.TransactionClass selectedTransaction = null;
            DateTime timeobj = System.DateTime.Now;
            foreach (var item in currentTransactions)
            {
                if (item.AccountName.CompareTo(accountName) == 0)
                {
                    if ((item.iscredit == 1 && tranType == "Credit") || (item.iscredit == 0 && tranType == "Debit"))
                    {

                        if (item.transactionDescription.CompareTo(tranDescription) == 0 && item.transactionAmount == double.Parse(tranAmount))
                            timeobj = DateTime.Parse(tranTime);
                        if (timeobj.ToLongTimeString().CompareTo(item.transactionTime.ToLongTimeString()) == 0)
                        {
                            selectedTransaction = item;
                            continue;
                        }
                    }
                }
            }
            if (selectedTransaction != null)
            {
                currentTransactions.Remove(selectedTransaction);
                updateGrid();
                reColorGrid();
            }
        }

        public bool isBalanced()
        {
            double totalcredit = double.Parse(TotalCreditField.Text);
            double totaldebit = double.Parse(TotalDebitField.Text);

            if(totalcredit != totaldebit)
            {
                if(totalcredit > totaldebit)
                    MessageBox.Show("Current Transactions not balanced. Need to make Debit transactions.");
                else
                {
                    MessageBox.Show("Current Transactions not balanced. Need to make Credit transactions.");
                }
            }
            else
            {
                return true;
            }
            return false;
        }

        private void SaveTransactionsButton_Click(object sender, EventArgs e)
        {
            if (isBalanced() == false)
                return;

            Model.transaction trans;
            try
            {
                using (var db = new POSApplication.Model.posdbEntities())
                {
                    foreach (var item in currentTransactions)
                    {
                        trans = new Model.transaction();
                        trans.accountid = GetAccountID(item.AccountName);
                        if (item.iscredit == 0)
                            trans.Debit = Decimal.Parse(item.transactionAmount.ToString());
                        else
                            trans.Credit = Decimal.Parse(item.transactionAmount.ToString());
                        trans.entrydate = item.transactionDate;
                        trans.entrytime = item.transactionTime.TimeOfDay;
                        trans.description = item.transactionDescription;
                        db.transactions.Add(trans);
                        db.SaveChanges();
                    }
                    MessageBox.Show("Transactions saved successfully.");
                }

                LedgerGridView.DataSource = null;
                LedgerGridView.DataMember = null;
                LedgerGridView.Refresh();

                CreditAccountID.Text = "";
                CreditAmountField.Text = "";
                CreditTransactionDescription.Text = "";

                DebitAccountID.Text = "";
                DebitAmountField.Text = "";
                DebitTransactionDescription.Text = "";

            }
            catch (Exception e1)
            {
                MessageBox.Show("Transactions could not be saved.");
            }
        }
    }
}
