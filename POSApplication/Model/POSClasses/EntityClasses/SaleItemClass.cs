using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace POSApplication.Model.POSClasses.EntityClasses
{
    public class SaleItemClass
    {
        public int OrderID { get; set; }
        public int ProductID { get; set; }
        public string ProductName { get; set; }
        public decimal Quantity { get; set; }
        public decimal Discount { get; set; }
        public decimal PriceApplied { get; set; }
        public decimal? PurchasePrice { get; set; }
        public decimal ProfitTaken { get; set; }
        public decimal TaxPercentage { get; set; }
        public object UpdateDt { get; internal set; }
    }
}