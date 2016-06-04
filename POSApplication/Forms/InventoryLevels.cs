using POSApplication.Model;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace POSApplication.Forms
{
    public partial class InventoryLevels : Form
    {

        public string selectedProductName = null;
        public InventoryLevels()
        {
            InitializeComponent();
            LoadExistingCategories();
        }

        public void LoadExistingCategories()
        {
            using (var db = new POSApplication.Model.posdbEntities())
            {
                var query = (from d in db.categories
                             select new { CategoryName = d.CategoryName }).ToList();

                ExistingCategoryList.Items.Clear();
                int a = 0;
                foreach (var item in query)
                {
                    if (a == 0)
                    {
                        ExistingCategoryList.Text = "Select Category";
                    }
                    ExistingCategoryList.Items.Add(item.CategoryName);
                    a += 1;
                }
            }
        }

        private void CloseButton_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void ProductImage2_Click(object sender, EventArgs e)
        {

        }

        private void InventoryLevels_Load(object sender, EventArgs e)
        {

        }

        private void CategoryList_SelectedIndexChanged(object sender, EventArgs e)
        {
            //using (var db = new POSApplication.Model.posdbEntities())
            //{
            //    string selectedCategoryName = CategoryList.GetItemText(CategoryList.SelectedItem);
            //    var q = (from d in db.categories
            //                 where selectedCategoryName == d.CategoryName
            //                 select new { CategoryID = d.CategoryID }).SingleOrDefault();

            //    var query = (from d in db.products
            //                 where q.CategoryID == d.CategoryID
            //                 select new { ProductName = d.ProductName }).ToList();

            //    ProductList.Items.Clear();
            //    ProductList.Text = "";
            //    int a = 0;
            //    foreach (var item in query)
            //    {
            //        if (a==0)
            //        {
            //            ProductList.Text = item.ProductName;
            //            SetFieldBasedOnProduct(item.ProductName);
            //        }
            //        ProductList.Items.Add(item.ProductName);
            //    }
            //}
        }

        public void SetFieldBasedOnProduct(string selectedProductName)
        {
            using (var db = new POSApplication.Model.posdbEntities())
            {
                var a = (from p in db.products
                         where p.ProductName == selectedProductName
                         select new { ProductID = p.ProductID, BarCode = p.Barcode, ImagePath = p.ImageFileName }).SingleOrDefault();

                var q = (from d in db.inventories
                         where a.ProductID == d.ProductID && d.UpdateDt == null
                         select new { Quantity = d.Quantity, LastCostPrice = d.PurchasePrice, SalePrice = d.SalePrice, PurchaseDate = d.PurchaseDate, Barcode = a.BarCode, ImagePath = a.ImagePath }).SingleOrDefault();

                //var sumquantity = from r in db.inventories
                //                  where
                //                  group r by new
                //                  {
                //                      r.ProductID
                //                  } into g
                //                  select new
                //                  {
                //                      g.Key.ProductID,
                //                      SumQuantity = g.Sum(x => x.Quantity)
                //                  }.SumQuantity;

                if (a != null)
                {
                    if(a.ImagePath != null)
                    {
                        try
                        {
                            FileStream fs = new FileStream(q.ImagePath, System.IO.FileMode.Open, System.IO.FileAccess.Read);
                            ProductImage.Image = Image.FromStream(fs);
                            fs.Close();
                        }
                        catch(Exception e)
                        {
                            MessageBox.Show("File is missing. Please reset the image for the product.");
                        }
                    }
                    
                    QuantityField.Text = q.Quantity.ToString();
                    //ReOrderLevelField.Text = q.ReOrderLevel.ToString();
                    CostPriceField.Text = q.LastCostPrice.ToString();
                    SalePriceField.Text = q.SalePrice.ToString();
                    PurchaseDateField.Text = q.PurchaseDate.ToString();
                }
            }
        }

        private void ProductList_SelectedIndexChanged(object sender, EventArgs e)
        {
            //string selectedProductName = ProductList.GetItemText(ProductList.SelectedItem);
            //SetFieldBasedOnProduct(selectedProductName);
        }

        public void UpdateChanges()
        {
            string categoryName = CategoryList.Text;
            string productName = ProductNameField.Text;
            string ReOrderLevel = ReOrderLevelField.Text;
            string SalePrice = SalePriceField.Text;

            if (SalePrice.Length == 0)
            {
                SalePrice = "0";
            }
            if (ReOrderLevel.Length == 0)
            {
                ReOrderLevel = "0";
            }

            if (productName.Length != 0)
            {
                using (var db = new POSApplication.Model.posdbEntities())
                {
                    var product = db.products.SingleOrDefault(x => x.ProductName == productName);

                    //Model.inventory c = (from x in db.inventories
                    //                     where x.ProductID == item.ProductID && x.UpdateDt == null
                    //                     && x.PurchasePrice == saleprice || x.PurchasePrice == 0
                    //                     select x).FirstOrDefault();
                    decimal salepricedecimalvalue = Decimal.Parse(SalePrice);
                    var items = db.inventories.Where(
                        x => x.ProductID == product.ProductID && x.UpdateDt == null 
                    ||  (x.PurchasePrice == 0 && x.ProductID == product.ProductID && x.UpdateDt == null)
                    ).ToList();

                    foreach (var item in items)
                    {
                        item.UpdateDt = DateTime.Now;
                        db.SaveChanges();

                        var a = new inventory
                        {
                            ProductID = item.ProductID,
                            CreateDt = DateTime.Now,
                            SaleDate = null,
                            PurchasePrice = item.PurchasePrice,
                            Quantity = 0,
                            UpdateDt = null,
                            PackingTypeID = null,
                            SumQuantity = item.SumQuantity,
                            SalePrice = Decimal.Parse(SalePrice),
                            InvoiceID = null
                        };
                        db.inventories.Add(a);
                        db.SaveChanges();
                    }
                    db.SaveChanges();

                    //resetting the categories and products list to stop user from making changes.
                    clearFields();
                    MessageBox.Show("Changes Saved");
                }
            }
            else
            {
                //write something for the else condition
            }
        }

        private void OkBtn_Click(object sender, EventArgs e)
        {
            UpdateChanges();
        }

        public int getProductID(string productName)
        {
            try
            {
                using (var db = new POSApplication.Model.posdbEntities())
                {
                    var query = (from d in db.products
                                     //join  s in db.suppliers on
                                     //d.SupplierID equals s.SupplierID
                                 where d.ProductName == productName
                                 select new
                                 {
                                     productid = d.ProductID
                                 }).SingleOrDefault();
                    return query.productid;
                }
            }
            catch(Exception e)
            {
                MessageBox.Show(e.Message);
            }
            return 0;
        }

        private void ExistingProductsList_DoubleClick(object sender, EventArgs e)
        {
            if (ExistingProductsList.SelectedItem != null)
            {
                clearFields();
                using (var db = new POSApplication.Model.posdbEntities())
                {
                    var ExistingProduct = ExistingProductsList.GetItemText(ExistingProductsList.SelectedItem);
                    int productid = getProductID(ExistingProduct);
                    selectedProductName = ExistingProduct;
                    DateTime lowdate = DateTime.Parse("1111/11/11");
                    var query = (from d in db.inventories
                                 join p in db.products on
                                 d.ProductID equals p.ProductID
                                 join c in db.categories on
                                 p.CategoryID equals c.CategoryID
                                 where d.ProductID == productid && d.UpdateDt == null
                                 orderby d.PurchasePrice descending
                                 select new
                                 {
                                     CategoryName = c.CategoryName,
                                     ProductName = p.ProductName,
                                     Barcode = p.Barcode,
                                     Quantity = d.SumQuantity,
                                     //ReorderLevel = d.ReorderValue,
                                     LastCostPrice = d.PurchasePrice,
                                     SalePrice = d.SalePrice,
                                     LastPurchaseDate = d.PurchaseDate,
                                     Imagepath = p.ImageFileName
                                 }).FirstOrDefault();
                    CategoryList.Text = ExistingCategoryList.GetItemText(ExistingCategoryList.SelectedItem);
                    ProductNameField.Text = query.ProductName;
                    BarCodeField.Text = query.Barcode;

                    var results =
                        (from item in db.inventories
                         where item.ProductID == productid && item.UpdateDt == null
                         group item by item.ProductID into g
                         select new { totalQuantity = g.Sum(item => item.SumQuantity) }).SingleOrDefault();

                    //QuantityField.Text = query.Quantity.ToString();
                    QuantityField.Text = results.totalQuantity.ToString();
                    //ReOrderLevelField.Text = query.ReorderLevel.ToString();
                    CostPriceField.Text = query.LastCostPrice.ToString();
                    SalePriceField.Text = query.SalePrice.ToString();
                    PurchaseDateField.Text = query.LastPurchaseDate.ToString();

                    if (query.Imagepath != null)
                    {
                        try
                        {
                            string ImagesDirectory = Path.Combine(Path.GetDirectoryName(Assembly.GetExecutingAssembly().Location), "Images");
                            Console.WriteLine(ImagesDirectory + "\\" + query.Imagepath);
                            FileStream fs = new FileStream(ImagesDirectory + "\\" + query.Imagepath, System.IO.FileMode.Open, System.IO.FileAccess.Read);

                            ProductImage.Image = Image.FromStream(fs);
                            fs.Close();
                        }
                        catch
                        {
                        }
                    }
                }
            }
        }

        private void ExistingProductsList_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void ExistingCategoryList_SelectedIndexChanged(object sender, EventArgs e)
        {
            var SelectedCategory = ExistingCategoryList.GetItemText(ExistingCategoryList.SelectedItem);
            using (var db = new POSApplication.Model.posdbEntities())
            {
                var query = (from d in db.products
                             join c in db.categories on
                             d.CategoryID equals c.CategoryID
                             where c.CategoryName == SelectedCategory
                             select new
                             {
                                 CategoryName = c.CategoryName,
                                 ProductName = d.ProductName
                             }).ToList();
                ExistingProductsList.Items.Clear();
                foreach (var item in query)
                {
                    ExistingProductsList.Items.Add(item.ProductName);
                }
            }
        }

        public void clearFields()
        {
            CategoryList.Text = "";
            ProductNameField.Text = "";
            BarCodeField.Text = "";
            QuantityField.Text = "";
            ReOrderLevelField.Text = "";
            CostPriceField.Text = "";
            SalePriceField.Text = "";
            PurchaseDateField.Text = "";
            ProductImage.Image = null;
            selectedProductName = null;
        }
    }
}
