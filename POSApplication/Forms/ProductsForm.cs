using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.IO;
using System.Threading.Tasks;
using System.Windows.Forms;
using POSApplication.Model.POSClasses.EntityClasses;
using System.Reflection;

namespace POSApplication.Forms
{
    public partial class ProductsForm : Form
    {

        public string filename;
        public string fileextension;
        public string filepath;
        public string selectedProductName = null;
        public ProductsForm()
        {
            InitializeComponent();
        }

        private void CloseButton_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        public void resetCategoriesField()
        {
            CategoryList.Items.Clear();
            using (var db = new POSApplication.Model.posdbEntities())
            {
                var query = (from d in db.categories
                             select new { CategoryName = d.CategoryName }).ToList();

                foreach (var item in query)
                {
                    CategoryList.Items.Add(item.CategoryName);
                }
            }
        }

        private void BrowseButton_Click(object sender, EventArgs e)
        {
            OpenFileDialog opf = new OpenFileDialog();
            DialogResult result = opf.ShowDialog();
            if (result == DialogResult.OK)
            {
                //ProductImage.Image = Image.FromFile(opf.FileName);
                //filename = opf.FileName;
                //fileextension = Path.GetExtension(filename);
                //filepath = Path.GetDirectoryName(filename);
                //ProductImage.SizeMode = PictureBoxSizeMode.StretchImage;
                filename = opf.FileName;
                FileStream fs = new FileStream(filename, System.IO.FileMode.Open, System.IO.FileAccess.Read);
                ProductImage.Image = Image.FromStream(fs);
                fs.Close();
            }
        }

        public int SaveProduct()
        {
            using (var db = new POSApplication.Model.posdbEntities())
            {
                string selectedCategory = CategoryList.GetItemText(CategoryList.SelectedItem);
                string selectedSupplier = SuppliersList.GetItemText(SuppliersList.SelectedItem);

                string path = System.Reflection.Assembly.GetExecutingAssembly().Location;
                var directory = System.IO.Path.GetDirectoryName(path);

                if (selectedCategory.Length > 0)
                {
                    var query = (from d in db.categories
                                 where d.CategoryName == selectedCategory
                                 select new { CategoryID = d.CategoryID }).SingleOrDefault();

                    var supp = (from d in db.suppliers
                                where d.SupplierName == selectedSupplier
                                select new { SupplierID = d.SupplierID }).SingleOrDefault();

                    if (ProductNameField.Text.Length > 0)
                    {
                        if (selectedProductName == null)
                        {
                            Model.product p = new Model.product();

                            p.ProductName = ProductNameField.Text;
                            p.ProductDescription = ProductDescriptionField.Text;
                            p.CategoryID = query.CategoryID;
                            if (supp != null)
                                p.SupplierID = supp.SupplierID;
                            else
                                p.SupplierID = 0;
                            p.ImageFileName = Path.GetFileName(filename);
                            p.Barcode = ProductBarcodeField.Text;
                            p.WarrantyPeriodYears = WarrantyField.Text;
                            p.GuaranteePeriodYears = GuaranteeField.Text;
                            p.ProductCode = ProductCodeField.Text;
                            p.ProductSize = SizeField.Text;
                            p.ProductWeight = WeightField.Text;
                            p.ProductColor = ColorField.Text;
                            p.ProductWidth = WidthField.Text;
                            p.ProductHeight = HeightField.Text;

                            db.products.Add(p);
                            db.SaveChanges();

                            //adding the same product in inventory with sum quantity 0
                            ///////////////////////////////////////////////////////////////////////////
                            var existprd = (from ep in db.products
                                            where
                                            ep.ProductName == p.ProductName &&
                                            ep.CategoryID == p.CategoryID && 
                                            ep.ProductCode == p.ProductCode
                                            select new { ProductID = ep.ProductID }
                                            ).SingleOrDefault();

                            if(existprd != null)
                            {
                                POSApplication.Model.inventory inv = new POSApplication.Model.inventory();
                                inv.ProductID = existprd.ProductID;
                                inv.Quantity = 0;
                                inv.PackingTypeID = 0;
                                inv.PurchasePrice = 0;
                                inv.SalePrice = 0;
                                inv.PurchaseDate = null;
                                inv.SaleDate = null;
                                inv.CreateDt = DateTime.Now;
                                inv.UpdateDt = null;
                                inv.SumQuantity = 0;
                                db.inventories.Add(inv);
                                db.SaveChanges();
                            }

                            ///////////////////////////////////////////////////////////////////////////

                            if (filename != null)
                            {
                                string destfile = System.IO.Path.Combine(path + "\\images", filename);
                                string ImagesDirectory = Path.Combine(Path.GetDirectoryName(Assembly.GetExecutingAssembly().Location), "Images");
                                destfile = Path.Combine(Path.GetDirectoryName(Assembly.GetExecutingAssembly().Location), "Images\\" + Path.GetFileName(filename));
                                //MessageBox.Show(destfile);
                                var dir = new System.IO.DirectoryInfo(ImagesDirectory);
                                //foreach (var file in dir.EnumerateFiles(Path.GetFileNameWithoutExtension(filename)))
                                //{
                                //    file.Delete();
                                //}
                                try
                                {
                                    //File.Copy(filename.Replace("\\\\","\\"), destfile, true);
                                    File.Copy(filename, destfile, true);
                                }
                                catch(Exception e)
                                {
                                    MessageBox.Show(e.ToString());
                                }

                                //Model.AppConfig.imagefile = destfile;
                                //FileStream fs = new FileStream(Model.AppConfig.imagefile, System.IO.FileMode.Open, System.IO.FileAccess.Read);
                                //ProductImage.Image = Image.FromStream(fs);
                                //fs.Close();
                            }
                            MessageBox.Show("New Product '" + ProductNameField.Text + "' has been added in the system.");
                            clearFields();
                            loadCategories();
                            return 1;
                        }
                        else
                        {
                            Model.product p = (from x in db.products
                                               where x.ProductName == selectedProductName
                                               select x).First();

                            p.ProductName = ProductNameField.Text;
                            p.ProductDescription = ProductDescriptionField.Text;
                            p.CategoryID = query.CategoryID;
                            if (supp != null)
                                p.SupplierID = supp.SupplierID;
                            else
                                p.SupplierID = 0;
                            if (ProductImage.Image != null)
                                p.ImageFileName = Path.GetFileName(filename);
                            else
                                p.ImageFileName = null;
                            p.Barcode = ProductBarcodeField.Text;
                            p.WarrantyPeriodYears = WarrantyField.Text;
                            p.GuaranteePeriodYears = GuaranteeField.Text;
                            p.ProductCode = ProductCodeField.Text;
                            p.ProductSize = SizeField.Text;
                            p.ProductWeight = WeightField.Text;
                            p.ProductColor = ColorField.Text;
                            p.ProductWidth = WidthField.Text;
                            p.ProductHeight = HeightField.Text;

                            db.SaveChanges();

                            if (filename != null)
                            {
                                string destfile = System.IO.Path.Combine(path + "\\images", filename);
                                string ImagesDirectory = Path.Combine(Path.GetDirectoryName(Assembly.GetExecutingAssembly().Location), "Images");
                                destfile = Path.Combine(Path.GetDirectoryName(Assembly.GetExecutingAssembly().Location), "Images\\" + Path.GetFileName(filename));
                                //MessageBox.Show(destfile);
                                var dir = new System.IO.DirectoryInfo(ImagesDirectory);
                                //foreach (var file in dir.EnumerateFiles(Path.GetFileNameWithoutExtension(filename)))
                                //{
                                //    file.Delete();
                                //}
                                try
                                {
                                    //File.Copy(filename.Replace("\\\\","\\"), destfile, true);
                                    File.Copy(filename, destfile, true);
                                }
                                catch (Exception e)
                                {
                                    MessageBox.Show(e.ToString());
                                }
                                //Model.AppConfig.imagefile = destfile;
                                //FileStream fs = new FileStream(Model.AppConfig.imagefile, System.IO.FileMode.Open, System.IO.FileAccess.Read);
                                //ProductImage.Image = Image.FromStream(fs);
                                //fs.Close();
                                //return 1;
                            }
                            else
                            {
                                
                            }

                            MessageBox.Show("Product '" + selectedProductName + "' has been updated.");
                            clearFields();
                            return 1;
                        }



                    }
                    else
                    {
                        MessageBox.Show("Enter name for the new Product.");
                        return 0;
                    }
                }
                else
                {
                    MessageBox.Show("Select a Category for the new Product.");
                    return 0;
                }
            }
        }
        
        private void SaveProductButton_Click(object sender, EventArgs e)
        {
            SaveProduct();
        }

        private void InventoryForm_Load(object sender, EventArgs e)
        {
            loadCategories();
            LoadExistingProducts();
            loadExistingSuppliers();
        }

        private void LoadExistingProducts()
        {
            using (var db = new POSApplication.Model.posdbEntities())
            {
                string selectedCategoryName = ExistingCategoryList.GetItemText(ExistingCategoryList.SelectedItem);
                var query = (from p in db.products
                             join c in db.categories on p.CategoryID equals c.CategoryID
                             //join s in db.suppliers on p.SupplierID equals s.SupplierID
                             where c.CategoryName == selectedCategoryName
                             select new { ProductName = p.ProductName, ProductDescription = p.ProductDescription, Barcode = p.Barcode, ImageFile = p.ImageFileName, SupplierID = p.SupplierID }).ToList();

                //ExistingProductList.Items.Clear();
                int a = 0;
                foreach (var item in query)
                {
                    if (a == 0)
                    {
                        var supp = (from s in db.suppliers
                                    where s.SupplierID == item.SupplierID
                                    select new { SupplierName = s.SupplierName }).SingleOrDefault();

                        //ExistingProductList.Text = item.ProductName;
                        //ExistingDescriptionField.Text = item.ProductDescription;
                        //if(supp != null)
                        //{
                        //    ExistingSupplierField.Text = supp.SupplierName;
                        //}
                        //else
                        //{
                        //    ExistingSupplierField.Text = "No Supplier";
                        //}
                        //ExistingBarcodeField.Text = item.Barcode;

                        //if(item.ImageFile != null)
                        //{
                        //    FileStream fs = new FileStream(item.ImageFile, System.IO.FileMode.Open, System.IO.FileAccess.Read);
                        //    ExistingProductImage.Image = Image.FromStream(fs);
                        //    fs.Close();
                        //}
                    }
                    //ExistingProductList.Items.Add(item.ProductName);
                    a += 1;
                }
            }
        }

        public void loadExistingSuppliers()
        {
            using (var db = new POSApplication.Model.posdbEntities())
            {
                var query = (from d in db.suppliers
                             select new { SupplierName = d.SupplierName }).ToList();

                SuppliersList.Items.Clear();
                int a = 0;
                foreach (var item in query)
                {
                    if (a == 0)
                    {
                        SuppliersList.Text = "Select Supplier";
                    }

                    SuppliersList.Items.Add(item.SupplierName);
                    a += 1;
                }
            }
        }

        public void loadCategories()
        {
            using (var db = new POSApplication.Model.posdbEntities())
            {
                var query = (from d in db.categories
                             select new { CategoryName = d.CategoryName }).ToList();

                CategoryList.Items.Clear();
                ExistingCategoryList.Items.Clear();
                int a = 0;
                foreach (var item in query)
                {
                    if (a == 0)
                    {
                        //CategoryList.Text = item.CategoryName;
                        //ExistingCategoryList.Text = item.CategoryName;
                        CategoryList.Text = "Select Category";
                        ExistingCategoryList.Text = "Select Category";
                    }
                    CategoryList.Items.Add(item.CategoryName);
                    ExistingCategoryList.Items.Add(item.CategoryName);
                    a += 1;
                }
            }
        }

        public void loadProductsCombo(int categoryid)
        {
            //ProductList.Items.Clear();
            //using (var db = new POSApplication.Model.posdbEntities())
            //{
            //    var query = (from d in db.products
            //                 where d.CategoryID == categoryid
            //                 select new { ProductName = d.ProductName }).ToList();

            //    foreach (var item in query)
            //    {
            //        ProductList.Items.Add(item.ProductName);
            //    }
            //}
        }

        //private void CategoryList_SelectedIndexChanged(object sender, EventArgs e)
        //{
        //    //123456789012
        //    //123456789012
        //    //8964000759585
        //    int categoryid = int.Parse(CategoryList.GetItemText(CategoryList.SelectedItem));
        //    loadProductsCombo(categoryid);
        //}

        private void DeleteCategoryButton_Click(object sender, EventArgs e)
        {
            string selectedCategory = CategoryList.GetItemText(CategoryList.SelectedItem);
            deleteCategory(selectedCategory);
        }

        public void deleteCategory(string categoryName)
        {


            using (var dbCtx = new POSApplication.Model.posdbEntities())
            {
                var itemToRemove = dbCtx.categories.SingleOrDefault(x => x.CategoryName == categoryName);
                if (itemToRemove != null)
                {
                    dbCtx.categories.Remove(itemToRemove);
                    dbCtx.SaveChanges();
                }
            }
        }

        private void NewSupplierButton_Click(object sender, EventArgs e)
        {
            var sf = new SuppliersForm();
            sf.onSuccessfulSupplierAddition += new EventHandler(child_onSupplierAddition);
            sf.ShowDialog();
        }

        private void NewCategoryButton_Click(object sender, EventArgs e)
        {
            CategoriesForm cf = new CategoriesForm();
            cf.onSuccessfulCategoryAdd += new EventHandler(child_onCategoryAddition);
            cf.Show();
        }

        public void child_onCategoryAddition(object sender, EventArgs e)
        {
            clearFields();
            loadCategories();
        }

        public void child_onSupplierAddition(object sender, EventArgs e)
        {
            clearFields();
            loadExistingSuppliers();
        }

        private void ExistingCategoryList_SelectedIndexChanged(object sender, EventArgs e)
        {
            LoadExistingProducts();
        }

        private void New_Button_Click(object sender, EventArgs e)
        {
            clearFields();
        }

        public void clearFields()
        {
            CategoryList.Text = "";
            ProductNameField.Text = "";
            ProductDescriptionField.Text = "";
            SuppliersList.Text = "";
            ProductBarcodeField.Text = "";
            GuaranteeField.Text = "";
            WarrantyField.Text = "";
            ProductCodeField.Text = "";
            SizeField.Text = "";
            ColorField.Text = "";
            WeightField.Text = "";
            WidthField.Text = "";
            HeightField.Text = "";
            filename = null;
            ProductImage.Image = null;
            selectedProductName = null;
        }

        private void ExistingProductsList_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void ExistingProductsList_DoubleClick(object sender, EventArgs e)
        {
            clearFields();
            using (var db = new POSApplication.Model.posdbEntities())
            {
                var ExistingProduct = ExistingProductsList.GetItemText(ExistingProductsList.SelectedItem);
                selectedProductName = ExistingProduct;
                var query = (from d in db.products
                                 //join  s in db.suppliers on
                                 //d.SupplierID equals s.SupplierID
                             where d.ProductName == ExistingProduct
                             select new
                             {
                                 ProductName = d.ProductName,
                                 ProductDescription = d.ProductDescription,
                                 //SupplierName = s == null ? "No Supplier" : s.SupplierName,
                                 Barcode = d.Barcode,
                                 WarrantyYears = d.WarrantyPeriodYears,
                                 GuaranteeYears = d.GuaranteePeriodYears,
                                 ProductCode = d.ProductCode,
                                 Size = d.ProductSize,
                                 Width = d.ProductWidth,
                                 Height = d.ProductHeight,
                                 Weight = d.ProductWeight,
                                 Color = d.ProductColor,
                                 Image = d.ImageFileName
                             }).SingleOrDefault();
                var supplierQuery = (from d in db.products
                                     join s in db.suppliers on
                                     d.SupplierID equals s.SupplierID
                                     where d.ProductName == ExistingProduct
                                     select new
                                     {
                                         SupplierName = s == null ? "No Supplier" : s.SupplierName
                                     }).SingleOrDefault();
                CategoryList.Text = ExistingCategoryList.GetItemText(ExistingCategoryList.SelectedItem);
                ProductNameField.Text = query.ProductName;
                ProductDescriptionField.Text = query.ProductDescription;
                ProductCodeField.Text = query.ProductCode;
                if (supplierQuery != null)
                    SuppliersList.Text = supplierQuery.SupplierName;
                else
                    SuppliersList.Text = "No Supplier";
                ProductBarcodeField.Text = query.Barcode;
                WarrantyField.Text = query.WarrantyYears;
                GuaranteeField.Text = query.GuaranteeYears;
                SizeField.Text = query.Size;
                WidthField.Text = query.Width;
                WeightField.Text = query.Weight;
                HeightField.Text = query.Height;
                ColorField.Text = query.Color;
                if (query.Image != null)
                {
                    try
                    {
                        string ImagesDirectory = Path.Combine(Path.GetDirectoryName(Assembly.GetExecutingAssembly().Location), "Images");
                        //Console.WriteLine(ImagesDirectory + "\\" + query.Image);
                        filename = ImagesDirectory + "\\" + query.Image;
                        FileStream fs = new FileStream(filename, System.IO.FileMode.Open, System.IO.FileAccess.Read);
                        ProductImage.Image = Image.FromStream(fs);
                        fs.Close();
                    }
                    catch
                    {
                    }
                }
            }
        }

        private void ExistingCategoryList_SelectedIndexChanged_1(object sender, EventArgs e)
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

        private void DeleteProductButton_Click(object sender, EventArgs e)
        {
            string productname = ExistingProductsList.GetItemText(ExistingProductsList.SelectedItem);
            using (var dbCtx = new POSApplication.Model.posdbEntities())
            {
                var itemToRemove = dbCtx.products.SingleOrDefault(x => x.ProductName == productname);
                if (itemToRemove != null)
                {
                    dbCtx.products.Remove(itemToRemove);
                    dbCtx.SaveChanges();
                    ExistingProductsList.Items.Remove(ExistingProductsList.SelectedItem);
                    clearFields();
                    MessageBox.Show("Product Deleted.");
                }
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            ProductImage.Image = null;
        }
    }
}