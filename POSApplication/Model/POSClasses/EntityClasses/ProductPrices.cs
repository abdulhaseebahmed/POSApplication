using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace POSApplication.Model.POSClasses.EntityClasses
{
    public class ProductPrices
    {
        public string productName { get; set; }
        public decimal? purchasePrice { get; set; }
        public decimal? salePrice { get; set; }
        public decimal? taxpaid { get; set; }
        public int productID { get; set; }
        public string barcode { get; set; }
        public string productcode { get; set; }

        public ProductPrices(string productName, decimal? price, decimal? saleprice,
            int productid,
            //decimal? taxpaid, 
            string barcode,
            string productcode
            )
        {
            this.productName = productName;
            this.purchasePrice = price;
            this.salePrice = saleprice;
            this.productID = productid;
            this.taxpaid = taxpaid;
            this.barcode = barcode;
            this.productcode = productcode;
        }

        public ProductPrices(string productName, decimal? purchasePrice, decimal? salePrice, int productID, string barcode)
        {
            this.productName = productName;
            this.purchasePrice = purchasePrice;
            this.salePrice = salePrice;
            this.productID = productID;
            this.barcode = barcode;
        }
    }
}
