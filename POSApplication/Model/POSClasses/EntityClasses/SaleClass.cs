using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace POSApplication.Model.POSClasses.EntityClasses
{
    public class SaleClass
    {
        public int CustomerID { get; set; }
        public int OrderID { get; set; }
        public int TerminalID { get; set; }
        public decimal SaleAmount { get; set; }
        public DateTime SaleDate { get; set; }
        public decimal Discount { get; set; }
        public decimal TaxPercentage { get; set; }
        public string SaleStatus { get; set; }
        public decimal AmountPaid { get; set; }
        public decimal Balance { get; set; }
        public string ModeOfPayment { get; set; }
        public List<SaleItemClass> SaleItems { get; set; }
    }
}
