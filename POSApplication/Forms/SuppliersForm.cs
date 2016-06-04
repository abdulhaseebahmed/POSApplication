using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using POSApplication.Model;

namespace POSApplication.Forms
{
    public partial class SuppliersForm : Form
    {
        public string selectedSupplierName;

        public event EventHandler onSuccessfulSupplierAddition;
        private void SuccessfulSupplierAddition()
        {
            if (onSuccessfulSupplierAddition != null)
                onSuccessfulSupplierAddition(SupplierNameField.Text, null);
        }
        
        public SuppliersForm()
        {
            InitializeComponent();
        }
        
        private void SuppliersForm_Load(object sender, EventArgs e)
        {
            LoadExistingSuppliers();
        }

        public void LoadExistingSuppliers()
        {
            SuppliersList.Items.Clear();
            using (var dbCtx = new POSApplication.Model.posdbEntities())
            {
                var query = from d in dbCtx.suppliers
                            select new { SupplierName = d.SupplierName };

                foreach (var r in query)
                {
                    SuppliersList.Items.Add(r.SupplierName);
                }
            }
        }

        private void SaveButton_Click(object sender, EventArgs e)
        {
            var suppliername = selectedSupplierName;
            using (var dbCtx = new POSApplication.Model.posdbEntities())
            {
                var item = dbCtx.suppliers.SingleOrDefault(x => x.SupplierName == suppliername);
                if (item != null && suppliername.CompareTo(item.SupplierName) == 0)
                {
                    supplier c = (from x in dbCtx.suppliers
                                  where x.SupplierName == suppliername
                                  select x).First();
                    c.SupplierName = SupplierNameField.Text;
                    c.SupplierAddress = SupplierAddressField.Text;
                    c.ContactName = ContactPersonNameField.Text;
                    c.ContactNumber = ContactPersonNumberField.Text;
                    dbCtx.SaveChanges();
                    MessageBox.Show("Changes Updated Successfully.");
                }
                else if (item == null)
                {
                    supplier c = (from x in dbCtx.suppliers
                                  where x.SupplierName == SupplierNameField.Text
                                  select x).SingleOrDefault();
                    if (c == null)
                    {
                        if (SupplierNameField.Text.Length > 0 && ContactPersonNameField.Text.Length > 0)
                        {
                            var r = new Model.supplier
                            {
                                SupplierName = SupplierNameField.Text,
                                ContactName = ContactPersonNameField.Text,
                                ContactNumber = ContactPersonNumberField.Text,
                                SupplierAddress = SupplierAddressField.Text
                            };
                            dbCtx.suppliers.Add(r);
                            // call SaveChanges method to save student into database
                            dbCtx.SaveChanges();
                            MessageBox.Show("New Supplier "+ SupplierNameField.Text +" Added.");
                            SuccessfulSupplierAddition();
                        }
                        else
                        {
                            MessageBox.Show("Please enter New supplier name and contact person name.");
                        }
                    }
                    else
                    {
                        MessageBox.Show("Supplier with the same name already exists.");
                    }
                }
            }

            LoadExistingSuppliers();
        }

        public void clearFields()
        {
            SupplierNameField.Text = "";
            ContactPersonNameField.Text = "";
            ContactPersonNumberField.Text = "";
            SupplierAddressField.Text = "";
            selectedSupplierName = null;
        }

        public void deleteSupplier(string supplierName)
        {
            using (var dbCtx = new POSApplication.Model.posdbEntities())
            {
                var itemToRemove = dbCtx.suppliers.First(x => x.SupplierName == supplierName);
                if (itemToRemove != null)
                {
                    dbCtx.suppliers.Remove(itemToRemove);
                    dbCtx.SaveChanges();
                    MessageBox.Show("Supplier Deleted.");
                }
            }
        }

        private void DeleteButton_Click(object sender, EventArgs e)
        {
            if (SuppliersList.SelectedItem != null)
            {
                deleteSupplier(SuppliersList.GetItemText(SuppliersList.SelectedItem));
                SuppliersList.Items.Remove(SuppliersList.SelectedItem);
                clearFields();
            }
        }

        private void CloseButton_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void SuppliersList_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void ExistingSupplierAddress_TextChanged(object sender, EventArgs e)
        {

        }

        private void NewButton_Click(object sender, EventArgs e)
        {
            clearFields();
        }

        private void SuppliersList_DoubleClick(object sender, EventArgs e)
        {
            string supplierName = SuppliersList.GetItemText(SuppliersList.SelectedItem);
            using (var dbCtx = new POSApplication.Model.posdbEntities())
            {
                var item = dbCtx.suppliers.First(x => x.SupplierName == supplierName);
                if (item != null)
                {
                    SupplierNameField.Text = item.SupplierName;
                    ContactPersonNameField.Text = item.ContactName;
                    ContactPersonNumberField.Text = item.ContactNumber;
                    SupplierAddressField.Text = item.SupplierAddress;
                    //setting global field
                    selectedSupplierName = item.SupplierName;
                }
            }
        }
    }
}
