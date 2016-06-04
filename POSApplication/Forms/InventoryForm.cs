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

namespace POSApplication.Forms
{
    public partial class InventoryForm : Form
    {

        string filename;
        string fileextension;
        string filepath;
        public InventoryForm()
        {
            InitializeComponent();
        }

        private void CloseButton_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void SaveCategoryButton_Click(object sender, EventArgs e)
        {
            string newCategoryName;
            try
            {
                newCategoryName = NewCategoryField.Text;
                if (newCategoryName.Length > 0)
                {
                    using (var db = new POSApplication.Model.posdbEntities())
                    {
                        var query2 = (from d in db.cateogries
                                      where d.CategoryName == newCategoryName
                                      select new { CategoryName = d.CategoryName }).SingleOrDefault();
                        if (query2 == null)
                        {
                            Model.cateogry c = new Model.cateogry();
                            c.CategoryName = newCategoryName;
                            db.cateogries.Add(c);
                            db.SaveChanges();
                            MessageBox.Show("New Category '" + newCategoryName + "' has been added in the system.");
                            resetCategoriesField();
                        }
                        else
                        {
                            MessageBox.Show("Category already exists in the system.");
                            NewCategoryField.Text = "";
                        }
                    }
                }
            }
            catch (Exception e1)
            {
                MessageBox.Show("Enter Correct CategoryName");
            }
        }

        public void resetCategoriesField()
        {
            ExistingCategoriesCombo.Items.Clear();
            using (var db = new POSApplication.Model.posdbEntities())
            {
                var query = (from d in db.cateogries
                             select new { CategoryName = d.CategoryName }).ToList();

                foreach (var item in query)
                {
                    ExistingCategoriesCombo.Items.Add(item.CategoryName);
                }
            }
        }

        private void BrowseButton_Click(object sender, EventArgs e)
        {
            OpenFileDialog opf = new OpenFileDialog();
            DialogResult result = opf.ShowDialog();
            if (result == DialogResult.OK)
            {
                ProductImage1.Image = Image.FromFile(opf.FileName);
                filename = opf.FileName;
                fileextension = Path.GetExtension(filename);
                filepath = Path.GetDirectoryName(filename);
                ProductImage1.SizeMode = PictureBoxSizeMode.Zoom;
            }
        }

        public void SaveProduct()
        {
            using (var db = new POSApplication.Model.posdbEntities())
            {
                var query = (from d in db.cateogries
                             where d.CategoryName == ExistingCategoriesCombo.GetItemText(ExistingCategoriesCombo.SelectedItem)
                             select new { CategoryID = d.CategoryID }).SingleOrDefault();

                string productname;
                string productdescription;
                if (ProductNameField.Text.Length > 0)
                {
                    productname = ProductNameField.Text;
                    productdescription = ProductDescriptionField.Text;
                    Model.product p = new Model.product();
                    p.ProductName = ProductNameField.Text;
                    p.ProductDescription = productdescription;
                    p.CategoryID = query.CategoryID;
                    p.ImageFileName = Path.GetFileName(filename);
                    p.Barcode = SetBarcodeField.Text;
                    db.products.Add(p);
                    db.SaveChanges();
                    MessageBox.Show("New Product '" + productname + "' has been added in the system.");
                    clearFields();
                }
                else
                {

                }

            }
        }

        public void clearFields()
        {
            ProductNameField.Text = "";
            ProductDescriptionField.Text = "";
            ProductImage1.Image = null;
            SetBarcodeField.Text = "";
        }

        private void SaveProductButton_Click(object sender, EventArgs e)
        {
            SaveProduct();
        }

        private void InventoryForm_Load(object sender, EventArgs e)
        {
            loadExistingCategories();
        }

        public void loadExistingCategories()
        {
            CategoryList.Items.Clear();
            using (var db = new POSApplication.Model.posdbEntities())
            {
                var query = (from d in db.cateogries
                             select new { CategoryName = d.CategoryName }).ToList();

                foreach (var item in query)
                {
                    CategoryList.Items.Add(item.CategoryName);
                }
            }
        }

        public void loadProductsCombo(int categoryid)
        {
            ProductList.Items.Clear();
            using (var db = new POSApplication.Model.posdbEntities())
            {
                var query = (from d in db.products
                             where d.CategoryID == categoryid
                             select new { ProductName = d.ProductName }).ToList();

                foreach (var item in query)
                {
                    ProductList.Items.Add(item.ProductName);
                }
            }
        }

        private void CategoryList_SelectedIndexChanged(object sender, EventArgs e)
        {
            //123456789012
            //123456789012
            //8964000759585
            int categoryid = int.Parse(CategoryList.GetItemText(CategoryList.SelectedItem));
            loadProductsCombo(categoryid);
        }

        private void DeleteCategoryButton_Click(object sender, EventArgs e)
        {
            string selectedCategory = ExistingCategoriesCombo.GetItemText(ExistingCategoriesCombo.SelectedItem);
            deleteCategory(selectedCategory);
        }

        public void deleteCategory(string categoryName)
        {
            string selectedCategory = ExistingCategoriesCombo.GetItemText(ExistingCategoriesCombo.SelectedItem);
            using (var db = new POSApplication.Model.posdbEntities())
            {
                var query = (from d in db.cateogries
                             where d.CategoryName == selectedCategory
                             select new { CategoryID = d.CategoryID, CategoryName = d.CategoryName }).SingleOrDefault();
                Model.cateogry c = new Model.cateogry();
                c.CategoryID = query.CategoryID;
                c.CategoryName = query.CategoryName;
                db.cateogries.Remove(c);
                db.SaveChanges();
                MessageBox.Show("Existing Category " + selectedCategory + " has been deleted.");
            }
        }
    }
}