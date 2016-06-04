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
    public partial class CategoriesForm : Form
    {

        public event EventHandler onSuccessfulCategoryAdd;
        private void SuccessfulCategoryAddition()
        {
            if (onSuccessfulCategoryAdd != null)
                onSuccessfulCategoryAdd(CategoryNameField.Text, null);
        }

        public CategoriesForm()
        {
            InitializeComponent();
        }

        private void CloseButton_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void SaveButton_Click(object sender, EventArgs e)
        {
            var categoryName = CategoryNameField.Text;
            var categoryDescription = CategoryDescriptionField.Text;
            var parentCateogryName = ParentCategoryList.Text;

            using (var dbCtx = new POSApplication.Model.posdbEntities())
            {
                var item = dbCtx.categories.SingleOrDefault(x => x.CategoryName == categoryName);
                if (item != null && categoryName.CompareTo(item.CategoryName) == 0)
                {
                    Model.category c = (from x in dbCtx.categories
                                        where x.CategoryName == categoryName
                                        select x).First();
                    c.CategoryName = CategoryNameField.Text;
                    c.ParentCategoryID = getCategoryID(ParentCategoryList.Text);
                    c.Description = CategoryDescriptionField.Text;
                    dbCtx.SaveChanges();
                    MessageBox.Show("Changes Updated Successfully.");

                }
                else if (item == null)
                {
                    if (categoryName == parentCateogryName)
                    {
                        MessageBox.Show("This will result in Category Loop. Please select a different Parent Category.");
                    }
                    else {
                        var r = new Model.category
                        {
                            CategoryName = categoryName,
                            ParentCategoryID = getCategoryID(parentCateogryName),
                            Description = categoryDescription
                        };
                        dbCtx.categories.Add(r);
                        dbCtx.SaveChanges();
                        MessageBox.Show("New Category "+categoryName+" has been added.");
                        SuccessfulCategoryAddition();
                    }
                }
            }

            loadExistingCategories();
            loadParentCategoryCombo();
        }

        public int? getCategoryID(string categoryName)
        {
            using (var dbCtx = new POSApplication.Model.posdbEntities())
            {
                var query = (from d in dbCtx.categories
                             where d.CategoryName == categoryName
                             select new { categoryName = d.CategoryName, categoryID = d.CategoryID }).SingleOrDefault();
                if (query != null)
                    return query.categoryID;
                else
                    return null;
            }
        }

        public string getCategoryName(int? categoryID)
        {
            try
            {
                if (categoryID != null)
                {
                    using (var dbCtx = new POSApplication.Model.posdbEntities())
                    {
                        var query = (from d in dbCtx.categories
                                     where d.CategoryID == categoryID
                                     select new { categoryName = d.CategoryName, categoryID = d.CategoryID }).SingleOrDefault();
                        return query.categoryName;
                    }
                }
            }
            catch (Exception)
            {
            }
            
            return null;
        }

        public void loadExistingCategories()
        {
            using (var db = new POSApplication.Model.posdbEntities())
            {
                var query = (from d in db.categories
                             select new { CategoryName = d.CategoryName }).ToList();
                ExistingCategories.Items.Clear();

                foreach (var item in query)
                {
                    ExistingCategories.Items.Add(item.CategoryName);
                }
            }
        }

        private void DeleteButton_Click(object sender, EventArgs e)
        {
            if (ExistingCategories.SelectedItem != null)
            {
                DeleteCategory(ExistingCategories.GetItemText(ExistingCategories.SelectedItem));
                ExistingCategories.Items.Remove(ExistingCategories.SelectedItem);
            }
        }

        public void DeleteCategory(string categoryName)
        {
            using (var dbCtx = new POSApplication.Model.posdbEntities())
            {
                var itemToRemove = dbCtx.categories.SingleOrDefault(x => x.CategoryName == categoryName);
                if (itemToRemove != null)
                {
                    dbCtx.categories.Remove(itemToRemove);
                    dbCtx.SaveChanges();
                    MessageBox.Show("Category "+categoryName+" has been removed.");
                    clearFields();
                }
            }
        }

        private void CategoriesForm_Load(object sender, EventArgs e)
        {
            loadExistingCategories();
            loadParentCategoryCombo();
        }

        public void loadParentCategoryCombo()
        {
            using (var db = new POSApplication.Model.posdbEntities())
            {
                var query = (from d in db.categories
                             select new { CategoryName = d.CategoryName }).ToList();
                ParentCategoryList.Items.Clear();

                int a = 0;
                foreach (var item in query)
                {
                    if (a == 0)
                        ParentCategoryList.Text = item.CategoryName;
                    ParentCategoryList.Items.Add(item.CategoryName);
                    a += 1;
                }
            }
        }

        private void ExistingCategories_SelectedIndexChanged(object sender, EventArgs e)
        {
            string categoryName = ExistingCategories.GetItemText(ExistingCategories.SelectedItem);
            using (var dbCtx = new POSApplication.Model.posdbEntities())
            {
                var item = dbCtx.categories.SingleOrDefault(x => x.CategoryName == categoryName);
                if (item != null)
                {
                    CategoryNameField.Text = item.CategoryName;
                    ParentCategoryList.Text = getCategoryName(item.ParentCategoryID);
                    CategoryDescriptionField.Text = item.Description;
                }
            }
        }

        private void NewProductButton_Click(object sender, EventArgs e)
        {
            clearFields();
        }

        public void clearFields()
        {
            CategoryNameField.Text = "";
            CategoryDescriptionField.Text = "";
            ParentCategoryList.Text = "";
        }

        private void DeleteButton_Click_1(object sender, EventArgs e)
        {
            if (ExistingCategories.SelectedItem != null)
            {
                DeleteCategory(ExistingCategories.GetItemText(ExistingCategories.SelectedItem));
                ExistingCategories.Items.Remove(ExistingCategories.SelectedItem);
            }
        }
    }
}
