using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace POSApplication
{
    public partial class PurchasesForm : Form
    {
        public PurchasesForm()
        {
            InitializeComponent();
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {
            //Capturing all keyboard input

            //POSDBEntities db = new POSDBEntities();
            ////var query = from c in db.SalesOrderDetails select new { c.Product,c.Quantity,c.PriceApplied,c.Discount};
            //var query = (from p in db.Products.ToList()
            //             join s in db.SalesOrderDetails.ToList()
            //             on p.ProductID equals s.ProductID into output
            //             from j in output.DefaultIfEmpty()
            //             select new { Name = p.ProductName, Quantity = j.Quantity, Price = j.PriceApplied, Discount = j.Discount });
            //var salesItems = query.ToList();

            //SaleItemsList.DataSource = salesItems;
        }

        private void button12_Click(object sender, EventArgs e)
        {

        }

        //private void Form1KeyDown(object sender, KeyEventArgs e)
        //{
        //    if(e.KeyCode == Keys.Delete)
        //    {
        //        MessageBox.Show("sadfkjhaskdfjhaskdjfh");
        //        dataGridView1.Rows.RemoveAt(this.dataGridView1.SelectedRows[0].Index);
        //    }
        //}
    }
}
