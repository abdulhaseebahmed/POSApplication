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
    public partial class InvoicesForm : Form
    {
        public InvoicesForm()
        {
            InitializeComponent();
        }

        private void InvoicesForm_Load(object sender, EventArgs e)
        {
            refreshPurchaseInvoices();
            refreshSaleInvoices();
        }

        public void refreshSaleInvoices()
        {
            var saleDS = new DataSet();
            var itemsDataTable = new DataTable("SaleOrders");
            itemsDataTable.Columns.Add("Sale Date");
            itemsDataTable.Columns.Add("Sale Amount");
            itemsDataTable.Columns.Add("Amount Paid");
            itemsDataTable.Columns.Add("Sale Status");
            itemsDataTable.Columns.Add("User Name");

            using (var db = new Model.posdbEntities())
            {
                var query = (from v in db.salesorders
                             orderby v.SaleDate descending
                             select v
                             ).ToList();


                foreach (var item in query)
                {
                    itemsDataTable.Rows.Add(item.SaleDate.Value.ToShortDateString(), item.SaleAmount, item.AmountPaid, item.SaleStatus, item.UserName);
                }

                saleDS.Tables.Add(itemsDataTable);
                SalesInvoices.DataSource = saleDS;
                SalesInvoices.DataMember = "SaleOrders";
                SalesInvoices.Refresh();
            }
        }

        public void refreshPurchaseInvoices()
        {
            var saleDS = new DataSet();
            var itemsDataTable = new DataTable("PurchaseOrders");
            itemsDataTable.Columns.Add("Pruchase Date");
            itemsDataTable.Columns.Add("Pruchase Amount");
            itemsDataTable.Columns.Add("Amount Paid");
            itemsDataTable.Columns.Add("Pruchase Status");
            itemsDataTable.Columns.Add("User Name");

            using (var db = new Model.posdbEntities())
            {
                var query = (from v in db.purchasesorders
                             orderby v.PurchaseDate descending
                             select v
                             ).ToList();


                foreach (var item in query)
                {
                    itemsDataTable.Rows.Add(item.PurchaseDate.Value.ToShortDateString(), item.PurchaseAmount, item.AmountPaid, item.PurchaseStatus, item.UserName);
                }

                saleDS.Tables.Add(itemsDataTable);
                PurchaseInvoices.DataSource = saleDS;
                PurchaseInvoices.DataMember = "PurchaseOrders";
                PurchaseInvoices.Refresh();
            }
        }
    }
}
