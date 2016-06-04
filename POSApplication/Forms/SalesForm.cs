using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using POSApplication.Model;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Drawing.Printing;
using POSApplication.Model.POSClasses.EntityClasses;
using System.IO;
using System.Threading;

namespace POSApplication
{
    public partial class SalesForm : Form
    {
        public static int currentOrderID = 0;
        public SaleClass currentSaleObject;
        public List<ProductPrices> productPrices;
        public string oldBarCodeValue = "";
        public ProductPrices searchedBarcodeProduct;
        public SalesForm()
        {
            InitializeComponent();
        }

        //public void getOpenSales()
        //{
        //    openOrders = new List<int>();
        //    using (var dbCtx = new POSApplication.Model.posdbEntities())
        //    {
        //        var query1 = (from p in dbCtx.salesorders
        //                      where p.SaleStatus = 1    
        //                      select new { OrderID = p.OrderID }).ToList();
        //        foreach(var q in query1)
        //        {
        //            openOrders.AddFirst(q.OrderID);
        //        }
        //    }
        //}

        public void loadProductsList()
        {
            using (var db = new POSApplication.Model.posdbEntities())
            {
                var query = (from c in db.products
                             join p in db.inventories on c.ProductID equals p.ProductID
                             where p.UpdateDt == null
                             //group p by p.ProductID into productGroups
                             select new
                             {
                                 c.ProductName,
                                 p.PurchasePrice,
                                 c.ProductID,
                                 p.SalePrice,
                                 //p.TaxPaid,
                                 c.Barcode,
                                 c.ProductCode
                             }).ToList();

                var query2 = query.GroupBy(p => p.ProductID).Select(a => a.First()).ToList();

                ProductList.Items.Clear();
                productPrices = new List<ProductPrices>();
                foreach (var d in query2)
                {
                    var item = new ProductPrices(d.ProductName, d.PurchasePrice,
                        d.SalePrice,
                        d.ProductID,
                        //d.TaxPaid, 
                        d.Barcode,
                        d.ProductCode);
                    productPrices.Add(item);
                }
                loadProductComboBox();
            }
        }

        public void loadProductComboBox()
        {
            foreach (var item in productPrices)
            {
                ProductList.Items.Add(item.productName);
            }
        }

        public int getProductID(string productName)
        {
            int productID = 0;
            foreach (var item in productPrices.ToList())
            {
                if (item.productName.CompareTo(productName) == 0)
                {
                    productID = item.productID;
                    continue;
                }
            }
            return productID;
        }

        public string getProductName(int productID)
        {
            string productName = "";
            foreach (var item in productPrices.ToList())
            {
                if (item.productID == productID)
                {
                    productName = item.productName;
                    continue;
                }
            }
            return productName;
        }

        public decimal? getPurchasePrice(int productID)
        {
            int purchasePrice = 0;
            using (var db = new POSApplication.Model.posdbEntities())
            {
                var query = (from c in db.inventories
                             where c.ProductID == productID && c.UpdateDt == null
                             select new { PurchasePrice = c.PurchasePrice }).FirstOrDefault();
                return query.PurchasePrice;
            }
        }

        public void saveSale()
        {
            var newSale = new Model.salesorder();
            var newSaleItem = new Model.salesorderdetail();

            //set sale properties
            //newStudent.StudentName = "Bill";
            //newSale.SaleStatus = "";
            newSale.SaleAmount = Decimal.Parse(TotalSaleField.Text);
            newSale.SaleTime = DateTime.Now.TimeOfDay;
            newSale.SaleDate = DateTime.Now.Date;
            newSale.TaxPercentage = Decimal.Parse(TaxAppliedField.Text);
            newSale.UserName = AppConfig.loggedInUserName;

            //create DBContext object
            using (var dbCtx = new Model.posdbEntities())
            {
                //Adding saleorder
                dbCtx.salesorders.Add(newSale);
                dbCtx.SaveChanges();
            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            loadProductsList();
            LoadFormObjects();
            LoadExistingCategories();
        }

        public void LoadExistingCategories()
        {
            using (var db = new POSApplication.Model.posdbEntities())
            {
                var query = (from c in db.categories
                             select new { CategoryName = c.CategoryName }).ToList();

                existingcategorieslist.Items.Clear();
                int a = 0;
                foreach (var item in query)
                {
                    if (a == 0)
                        existingcategorieslist.Text = item.CategoryName;
                    existingcategorieslist.Items.Add(item.CategoryName);
                    a += 1;
                }
            }
        }

        public void LoadFormObjects()
        {
            DateLabel.Text = DateTime.Now.Date.ToShortDateString();
            currentSaleObject = new SaleClass();
            currentSaleObject.SaleItems = new List<SaleItemClass>();
            OrderIDField.Text = generateID();
        }

        public string generateID()
        {
            return Guid.NewGuid().ToString("D");
        }

        private void CloseSaleFormBtn_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void PrintReceiptBtn_Click(object sender, EventArgs e)
        {
            PrintPage();
        }

        public void PrintPage()
        {
            /*
            foreach (String printer in PrinterSettings.InstalledPrinters)
            {
                Console.WriteLine(printer.ToString());
            }

            //Create a PrintDocument object
            //PrintDocument PrintDoc = new PrintDocument();
            //Set PrinterName as the selected printer in the printers list
            PrintDoc.PrinterSettings.PrinterName = "CutePDF Writer";
            //Add PrintPage event handler
            PrintDoc.PrintPage += new PrintPageEventHandler(PrintPageMethod);
            //Print the document
            PrintDoc.Print();
            */
            PrintDialog printDlg = new PrintDialog();
            PrintDocument printDoc = new PrintDocument();
            printDoc.DocumentName = "Receipt";
            printDoc.PrintPage += new PrintPageEventHandler(PrintPageMethod);
            printDlg.Document = printDoc;
            printDlg.AllowSelection = true;
            printDlg.AllowSomePages = true;
            //Call ShowDialog
            if (printDlg.ShowDialog() == DialogResult.OK)
            {
                printDoc.Print();
                //Sending Paper Cut POS Command to printer
                //string GS = Convert.ToString((char)29);
                //string ESC = Convert.ToString((char)27);

                //string COMMAND = "";
                //COMMAND = ESC + "@";
                //COMMAND += GS + "V" + (char)1;
                //System.Drawing.Printing.

                //RawPrinterHelper.SendStringToPrinter(printDlg.PrinterSettings.PrinterName, COMMAND);
            }
        }

        public void PrintPageMethod(object sender, PrintPageEventArgs ppev)
        {
            if (AppConfig.PrinterType == "60")
            {
                Printer60mm(ppev);
            }
            else if (AppConfig.PrinterType == "80")
            {
                Printer80mm(ppev);
            }

        }

        public void Printer80mm(PrintPageEventArgs ppev)
        {
            //For small printer - 2 inches
            //int printinglength = 40;
            //For small printer - 2 inches
            //int printinglength = 100;
            ppev.PageSettings.Margins = new Margins(5, 5, 5, 5);
            int printinglength = 95;
            int offset = 10;
            int startingposition = 10;
            Image CurrentImg = null;
            //Get the Graphics object
            Graphics g = ppev.Graphics;
            //Create a font verdana with size 14
            Font font = new Font("Verdana", 7);
            //Create a solid brush with red color
            SolidBrush brush = new SolidBrush(Color.Black);
            //Getting Company Logo
            var dir = new DirectoryInfo(Path.GetDirectoryName(Application.ExecutablePath));
            //foreach (var file in dir.EnumerateFiles("companylogo.*"))
            //{
            //CurrentImg = Image.FromFile(AppConfig.imagefile);
            //}
            FileStream fs = new FileStream(AppConfig.imagefile, FileMode.Open, FileAccess.Read);
            CurrentImg = Image.FromStream(fs);
            //Draw text
            fs.Close();
            if (CurrentImg != null)
            {
                //Draw image using the DrawImage method
                g.DrawImage(CurrentImg, 90, startingposition, 80, 80);
            }
            // Create a rectangle
            Rectangle rect;
            //drawing the date string
            string datestring = DateTime.Now.ToShortDateString();
            offset = 95;
            g.DrawString(CenterWithRespectTo(AppConfig.bussinessname, printinglength), font, brush, -40, offset);
            offset += 13;
            g.DrawString(CenterWithRespectTo(AppConfig.businessSlogan, printinglength), font, brush, -55, offset);
            offset += 13;
            g.DrawString(CenterWithRespectTo("Thankyou for shopping with us", printinglength), font, brush,-55,offset);
            offset += 13;
            g.DrawString(CenterWithRespectTo("Date: " + datestring, printinglength), font, brush, -45, offset);
            offset += 10;
            //drawing a single line
            g.DrawString("-----------------------------------------------------------------", font, brush, -10, offset);
            //printing line items one by one
            decimal NewTotalSaleAmount = 0;
            foreach (var item in currentSaleObject.SaleItems)
            {
                decimal tax = item.TaxPercentage / 100;
                decimal discount = item.Discount / 100;
                decimal priceapplied = item.PriceApplied;

                decimal discountappliedprice = Decimal.Round(item.PriceApplied - (item.PriceApplied * discount), 2);
                decimal taxappliedprice = Decimal.Round((discountappliedprice * tax) + discountappliedprice, 2);

                string productname = getProductName(item.ProductID);
                //s.OrderID = orderid;
                //s.Discount = item.Discount;
                //s.SalePrice = item.PriceApplied;
                //s.Quantity = item.Quantity;
                //s.CostPrice = saleprice;
                //s.TaxPercentage = item.TaxPercentage;
                //s.ProfitTaken = saleprice - item.PurchasePrice;

                offset += 15;
                productname = productname.PadRight(29 - (productname.Length + 1));
                if (productname.Length >= 21)
                    productname = productname.Substring(0, 21);
                g.DrawString(productname, font, brush, -2, offset);
                g.DrawString(("x" + item.Quantity.ToString()).PadLeft(39), font, brush, -10, offset);
                g.DrawString("Rs".PadLeft(60), font, brush, -10, offset);
                g.DrawString(priceapplied.ToString().PadLeft(70), font, brush, -10, offset);
                NewTotalSaleAmount += taxappliedprice;
            }
            offset += 15;
            //drawing the separator line
            g.DrawString("-----------------------------------------------------------------", font, brush, -10, offset);
            //Dispose of object
            offset += 20;
            //decimal discount = currentSaleObject.Discount;
            decimal totalitemsPrice = Decimal.Round(NewTotalSaleAmount, 2);
            decimal discountapplied = Decimal.Round((currentSaleObject.Discount / 100) * totalitemsPrice, 2);
            decimal temp = totalitemsPrice - (currentSaleObject.Discount / 100) * totalitemsPrice;
            decimal taxapplied = Decimal.Round((currentSaleObject.TaxPercentage / 100) * temp, 2);
            decimal finaltotal = decimal.Round(temp + taxapplied, 2);
            g.DrawString(("SubTotal : " + (NewTotalSaleAmount).ToString()).PadLeft(71), font, brush, -10, offset);
            offset += 20;
            g.DrawString(("Discount " + currentSaleObject.Discount.ToString() + "% : " + (discountapplied).ToString()).PadLeft(69), font, brush, -10, offset);
            offset += 20;
            g.DrawString(("Tax " + currentSaleObject.TaxPercentage.ToString() + "% : " + (taxapplied).ToString()).PadLeft(71), font, brush, -10, offset);
            offset += 20;
            g.DrawString(("Total : " + finaltotal.ToString()).PadLeft(73), font, brush, -10, offset);
            offset += 20;
            g.DrawString(("Paid : " + (currentSaleObject.AmountPaid).ToString()).PadLeft(72), font, brush, -10, offset);
            offset += 20;
            g.DrawString(("Balance : " + (currentSaleObject.AmountPaid - currentSaleObject.SaleAmount).ToString()).PadLeft(71), font, brush, -10, offset);
            offset += 60;
            g.DrawString(CenterWithRespectTo("Developed by : TekCentric.net", printinglength), font, brush, -55, offset);
            offset += 20;
            g.DrawString(CenterWithRespectTo("All Reights Reserved", printinglength), font, brush, -48, offset);
            offset += 60;
            g.DrawString("-----------------------------------------------------------------", font, brush, -10, offset);
            g.Dispose();
        }

        public void Printer60mm(PrintPageEventArgs ppev)
        {
            //For small printer - 2 inches
            //int printinglength = 40;
            //For small printer - 2 inches
            //int printinglength = 100;

            int printinglength = 45;
            int offset = 10;
            int startingposition = 10;
            Image CurrentImg = null;
            //Get the Graphics object
            Graphics g = ppev.Graphics;
            //Create a font verdana with size 14
            Font font = new Font("Verdana", 7);
            //Create a solid brush with red color
            SolidBrush brush = new SolidBrush(Color.Black);
            //Getting Company Logo
            var dir = new DirectoryInfo(Path.GetDirectoryName(Application.ExecutablePath));
            //foreach (var file in dir.EnumerateFiles("companylogo.*"))
            //{
            //CurrentImg = Image.FromFile(AppConfig.imagefile);
            //}
            FileStream fs = new FileStream(AppConfig.imagefile, FileMode.Open, FileAccess.Read);
            CurrentImg = Image.FromStream(fs);
            //Draw text
            fs.Close();
            if (CurrentImg != null)
            {
                //Draw image using the DrawImage method
                g.DrawImage(CurrentImg, 60, startingposition, 80, 80);
            }
            // Create a rectangle
            Rectangle rect;
            //drawing the date string
            string datestring = DateTime.Now.ToShortDateString();
            offset = 95;
            g.DrawString(CenterWithRespectTo("Thankyou for shopping with us", printinglength), font, brush, new Rectangle(-10, offset, 300, 31));
            offset += 13;
            g.DrawString(CenterWithRespectTo("Date: " + datestring, printinglength), font, brush, 0, offset);
            offset += 10;
            //drawing a single line
            g.DrawString("---------------------------------------------", font, brush, -10, 120);
            //printing line items one by one

            foreach (var item in currentSaleObject.SaleItems)
            {
                decimal tax = item.TaxPercentage / 100;
                decimal discount = item.Discount / 100;
                decimal priceapplied = item.PriceApplied;

                decimal discountappliedprice = Decimal.Round((item.PriceApplied * discount) + item.PriceApplied, 2);
                decimal taxappliedprice = Decimal.Round((discountappliedprice * tax) + discountappliedprice, 2);

                string productname = getProductName(item.ProductID);
                //s.OrderID = orderid;
                //s.Discount = item.Discount;
                //s.SalePrice = item.PriceApplied;
                //s.Quantity = item.Quantity;
                //s.CostPrice = saleprice;
                //s.TaxPercentage = item.TaxPercentage;
                //s.ProfitTaken = saleprice - item.PurchasePrice;

                offset += 15;
                productname = productname.PadRight(29 - (productname.Length + 1));
                if (productname.Length >= 21)
                    productname = productname.Substring(0, 21);
                g.DrawString(productname, font, brush, -2, offset);
                g.DrawString(("x" + item.Quantity.ToString()).PadLeft(39), font, brush, -10, offset);
                g.DrawString("Rs".PadLeft(44), font, brush, -10, offset);
                g.DrawString(taxappliedprice.ToString().PadLeft(53), font, brush, -10, offset);

            }
            offset += 15;
            //drawing the separator line
            g.DrawString("---------------------------------------------", font, brush, -10, offset);
            //Dispose of object
            offset += 20;
            //decimal discount = currentSaleObject.Discount;
            decimal totalitemsPrice = Decimal.Round(currentSaleObject.SaleAmount, 2);
            decimal discountapplied = Decimal.Round((currentSaleObject.Discount / 100) * totalitemsPrice, 2);
            decimal temp = totalitemsPrice - (currentSaleObject.Discount / 100) * totalitemsPrice;
            decimal taxapplied = Decimal.Round((currentSaleObject.TaxPercentage / 100) * temp, 2);
            decimal finaltotal = decimal.Round(temp + taxapplied, 2);
            g.DrawString(("SubTotal : " + (totalitemsPrice).ToString()).PadLeft(47), font, brush, -10, offset);
            offset += 20;
            g.DrawString(("Discount " + currentSaleObject.Discount.ToString() + "% : " + (discountapplied).ToString()).PadLeft(45), font, brush, -10, offset);
            offset += 20;
            g.DrawString(("Tax " + currentSaleObject.TaxPercentage.ToString() + "% : " + (taxapplied).ToString()).PadLeft(47), font, brush, -10, offset);
            offset += 20;
            g.DrawString(("Total : " + finaltotal.ToString()).PadLeft(49), font, brush, -10, offset);
            offset += 20;
            g.DrawString(("Paid : " + (currentSaleObject.AmountPaid).ToString()).PadLeft(48), font, brush, -10, offset);
            offset += 20;
            g.DrawString(("Balance : " + (currentSaleObject.AmountPaid - currentSaleObject.SaleAmount).ToString()).PadLeft(47), font, brush, -10, offset);
            g.Dispose();
        }

        public static string CenterWithRespectTo(string stringlength, int completelength)
        {
            if (stringlength == null)
            {
                throw new Exception("s");
            }
            if (stringlength.Length > completelength)
            {
                throw new Exception();
            }
            int halfSpace = (completelength - stringlength.Length) / 2;
            return stringlength.PadLeft(halfSpace + stringlength.Length).PadRight(completelength);
        }

        private void AddToSaleListBtn_Click(object sender, EventArgs e)
        {
            AddItemToCart();
            subTotal();
        }

        public int AddItemToCart()
        {
            string ProductName = "";
            decimal Quantity = 0;
            decimal Price = 0;
            decimal Discount = 0;
            decimal itemtax = 0;
            int productid = 0;

            if (ProductList.SelectedItem != null)
            {
                ProductName = ProductList.GetItemText(ProductList.SelectedItem);
                productid = getProductID(ProductName);
            }
            else
            {
                MessageBox.Show("Select a product");
                return 0;
            }

            if (QuantityField.Text.Length > 0)
                try
                {
                    Quantity = Decimal.Parse(QuantityField.Text);
                    using (var dbCtx = new Model.posdbEntities())
                    {
                        var ex = (
                                    from p in dbCtx.inventories
                                    where p.ProductID == productid && p.UpdateDt == null
                                    group p by p.ProductID into g
                                    select new { Quantity = g.Sum(item => item.SumQuantity) }
                                  ).FirstOrDefault();

                        if (ex != null)
                        {
                            if (ex.Quantity <= 0)
                            {
                                MessageBox.Show("Quantity of " + ProductName + " is Zero in Inventory. This Item cannot be sold.");
                                return 0;
                            }
                            else if (ex.Quantity < Quantity)
                            {
                                MessageBox.Show("Product '" + ProductName + "' has only " + ex.Quantity + " items remaining in Inventory.");
                                return 0;
                            }
                        }
                    }
                }
                catch (Exception e3)
                {
                    MessageBox.Show("Enter Numeric Values only");
                }
            else
                MessageBox.Show("Enter Quantity");

            if (PriceField.Text.Length > 0)
                try
                {
                    Price = Decimal.Parse(PriceField.Text);
                }
                catch (Exception e1)
                {
                    MessageBox.Show("Enter Numeric Values only");
                }
            else
                MessageBox.Show("Enter Price");

            if (DiscountField.Text.Length == 0)
            {
                Discount = 0;
            }
            else
            {
                try
                {
                    Discount = Decimal.Parse(DiscountField.Text);
                }
                catch (Exception e2)
                {
                    MessageBox.Show("Enter Numeric Values only");
                }
            }

            if (ItemTaxField.Text.Length == 0)
            {
                itemtax = 0;
            }
            else
            {
                try
                {
                    itemtax = Decimal.Parse(ItemTaxField.Text);
                }
                catch (Exception e2)
                {
                    MessageBox.Show("Enter Numeric Values only");
                }
            }

            SaleItemClass saleItem = new SaleItemClass();
            saleItem.ProductName = ProductName;
            saleItem.ProductID = getProductID(ProductName);
            saleItem.Quantity = Quantity;
            saleItem.PriceApplied = Price;
            saleItem.TaxPercentage = itemtax;
            saleItem.Discount = Discount;
            saleItem.PurchasePrice = getPurchasePrice(saleItem.ProductID);

            currentSaleObject.SaleItems.Add(saleItem);
            refreshSaleItemsList();

            clearFields();
            return 1;
        }

        public void refreshSaleItemsList()
        {
            DataSet saleDS = new DataSet();
            DataTable itemsDataTable = new DataTable("SaleItems");
            itemsDataTable.Columns.Add("ProductName");
            itemsDataTable.Columns.Add("Quantity");
            itemsDataTable.Columns.Add("Price");
            itemsDataTable.Columns.Add("Tax");

            foreach (var item in currentSaleObject.SaleItems)
            {
                itemsDataTable.Rows.Add(item.ProductName, item.Quantity, item.PriceApplied, item.TaxPercentage);
            }

            saleDS.Tables.Add(itemsDataTable);
            SaleItemsList.DataSource = saleDS;
            SaleItemsList.DataMember = "SaleItems";
            SaleItemsList.Refresh();
        }

        private void NewSaleBtn_Click(object sender, EventArgs e)
        {
            currentSaleObject = new SaleClass();
            currentSaleObject.SaleItems = new List<SaleItemClass>();
            SaleItemsList.DataSource = null;
            SaleItemsList.Refresh();
        }

        private void DeleteSaleItemBtn_Click(object sender, EventArgs e)
        {
            if (SaleItemsList.SelectedRows.Count != 0)
            {
                DataGridViewRow row = this.SaleItemsList.SelectedRows[0];
                string productname = row.Cells["ProductName"].Value.ToString();
                deleteItem(productname);
                QuantityField.Text = "";
                PriceField.Text = "";
            }
            subTotal();
        }

        public void deleteItem(string ProductName)
        {
            SaleItemClass selectedSaleItem = null;
            foreach (var item in currentSaleObject.SaleItems)
            {
                if (item.ProductName.CompareTo(ProductName) == 0)
                {
                    selectedSaleItem = item;
                    continue;
                }
            }
            if (selectedSaleItem != null)
            {
                currentSaleObject.SaleItems.Remove(selectedSaleItem);
                refreshSaleItemsList();
            }
        }

        private void ClearSaleBtn_Click(object sender, EventArgs e)
        {
            refreshSaleItemsList();
            clearFields();
        }

        public void refreshSalesItems()
        {
            currentSaleObject = new SaleClass();
            currentSaleObject.SaleItems = new List<SaleItemClass>();
            SaleItemsList.DataSource = null;
            SaleItemsList.Refresh();

            clearFields();
        }

        public void clearFields()
        {
            TotalDiscountField.Text = "";
            TotalSaleField.Text = "";
            TaxAppliedField.Text = "";
            AmountPaidField.Text = "";
            BalanceField.Text = "";
            QuantityField.Text = "";
            PriceField.Text = "";
            DiscountField.Text = "";
            ItemTaxField.Text = "";
        }

        private void SubTotalBtn_Click(object sender, EventArgs e)
        {
            subTotal();
        }

        public void subTotal()
        {
            decimal total = 0;
            decimal taxapplied = 0;
            decimal discount = 0;
            foreach (var item in currentSaleObject.SaleItems)
            {
                decimal price = item.PriceApplied;
                decimal quantity = item.Quantity;
                decimal itemtax = item.TaxPercentage;
                decimal itemdiscount = item.Discount;
                decimal itemstotal = 0;
                //applying discount on item price
                itemstotal = price - ((itemdiscount / 100) * price);
                //applying tax on previous total
                itemstotal = itemstotal + ((itemtax / 100) * itemstotal);
                //multiplying against quantity
                itemstotal = itemstotal * quantity;
                //setting main total
                total += itemstotal;
            }
            if (TotalDiscountField.Text.Length > 0)
            {
                try
                {
                    discount = Decimal.Parse(TotalDiscountField.Text);
                }
                catch (Exception e1)
                {
                    MessageBox.Show("Enter numeric value for Discount");
                }
            }
            if (TaxAppliedField.Text.Length > 0)
            {
                try
                {
                    taxapplied = Decimal.Parse(TaxAppliedField.Text);
                }
                catch (Exception e1)
                {
                    MessageBox.Show("Enter numeric value for Tax");
                }
            }
            //applying discount on total
            total = total - (total * (discount / 100));
            //applying tax on total
            total = total + (total * (taxapplied / 100));

            TotalSaleField.Text = decimal.Round(total, 2).ToString();
            if (AmountPaidField.Text.Length > 0)
            {
                try
                {
                    var amountpaid = decimal.Parse(AmountPaidField.Text);
                    BalanceField.Text = decimal.Round(amountpaid - total).ToString();
                }
                catch (Exception e)
                {
                    MessageBox.Show(e.ToString());
                }
            }
        }

        private void ProductList_SelectedIndexChanged(object sender, EventArgs e)
        {
            string selectedProductName = ProductList.GetItemText(ProductList.SelectedItem);
            foreach (var item in productPrices)
            {
                if (item.productName.CompareTo(selectedProductName) == 0)
                {
                    PriceField.Text = item.salePrice.ToString();
                    QuantityField.Text = "1";
                    QuantityField.Focus();
                    continue;
                }
            }
        }

        public void RecordSale(int checkoutOrHold, string modeOfPayment)
        {
            decimal amountpaid = 0;
            decimal balance = 0;
            decimal discount = 0;
            decimal taxapplied = 0;
            decimal total = 0;
            if (AmountPaidField.Text.Length > 0)
            {
                try
                {
                    amountpaid = Decimal.Parse(AmountPaidField.Text);
                    total = Decimal.Parse(TotalSaleField.Text);
                    BalanceField.Text = decimal.Round(amountpaid - total, 2).ToString();
                    if (total <= amountpaid)
                    {
                        balance = amountpaid - total;

                        //start creating db records
                        using (var db = new POSApplication.Model.posdbEntities())
                        {
                            if (TotalDiscountField.Text.Length > 0)
                            {
                                try
                                {
                                    discount = Decimal.Parse(TotalDiscountField.Text);
                                }
                                catch (Exception e1)
                                {
                                    MessageBox.Show("Enter numeric value for Discount");
                                }
                            }
                            if (TaxAppliedField.Text.Length > 0)
                            {
                                try
                                {
                                    taxapplied = Decimal.Parse(TaxAppliedField.Text);
                                }
                                catch (Exception e1)
                                {
                                    MessageBox.Show("Enter numeric value for Tax");
                                }
                            }
                            total = total + (total * (taxapplied / 100));
                            total = total - (total * (discount / 100));

                            BalanceField.Text = balance.ToString();
                            salesorder so = new salesorder();
                            so.AmountPaid = amountpaid;
                            currentSaleObject.AmountPaid = amountpaid;
                            so.Balance = balance;
                            currentSaleObject.Balance = decimal.Round((decimal)balance, 2);
                            so.Discount = discount;
                            currentSaleObject.Discount = discount;
                            so.ModeOfPayment = modeOfPayment;
                            so.SaleAmount = Decimal.Parse(TotalSaleField.Text);
                            currentSaleObject.SaleAmount = decimal.Round((decimal)so.SaleAmount, 2);

                            //so.SaleDate = DateTime.Now.Date;
                            so.SaleDate = dateTimePicker1.Value.Date;
                            //so.Date_dateofmonth_int = DateTime.Now.Day;
                            so.Date_dateofmonth_int = dateTimePicker1.Value.Day;
                            if (DateTime.Now.DayOfWeek == DayOfWeek.Sunday)
                                so.Date_Dayofweek_int = 7;
                            if (DateTime.Now.DayOfWeek == DayOfWeek.Monday)
                                so.Date_Dayofweek_int = 1;
                            if (DateTime.Now.DayOfWeek == DayOfWeek.Tuesday)
                                so.Date_Dayofweek_int = 2;
                            if (DateTime.Now.DayOfWeek == DayOfWeek.Wednesday)
                                so.Date_Dayofweek_int = 3;
                            if (DateTime.Now.DayOfWeek == DayOfWeek.Thursday)
                                so.Date_Dayofweek_int = 4;
                            if (DateTime.Now.DayOfWeek == DayOfWeek.Friday)
                                so.Date_Dayofweek_int = 5;
                            if (DateTime.Now.DayOfWeek == DayOfWeek.Saturday)
                                so.Date_Dayofweek_int = 6;
                            //so.Date_DayofWeek_string = DateTime.Now.DayOfWeek.ToString();
                            so.Date_DayofWeek_string = dateTimePicker1.Value.DayOfWeek.ToString();
                            //so.date_month_int = DateTime.Now.Month;
                            so.date_month_int = dateTimePicker1.Value.Month;

                            if (DateTime.Now.Month == 1)
                                so.date_month_string = "January";
                            if (DateTime.Now.Month == 2)
                                so.date_month_string = "February";
                            if (DateTime.Now.Month == 3)
                                so.date_month_string = "March";
                            if (DateTime.Now.Month == 4)
                                so.date_month_string = "April";
                            if (DateTime.Now.Month == 5)
                                so.date_month_string = "May";
                            if (DateTime.Now.Month == 6)
                                so.date_month_string = "June";
                            if (DateTime.Now.Month == 7)
                                so.date_month_string = "July";
                            if (DateTime.Now.Month == 8)
                                so.date_month_string = "August";
                            if (DateTime.Now.Month == 9)
                                so.date_month_string = "September";
                            if (DateTime.Now.Month == 10)
                                so.date_month_string = "October";
                            if (DateTime.Now.Month == 11)
                                so.date_month_string = "November";
                            if (DateTime.Now.Month == 12)
                                so.date_month_string = "December";

                            so.date_year_int = dateTimePicker1.Value.Year;
                            so.time_hour = int.Parse(dateTimePicker1.Value.Hour.ToString());

                            so.SaleTime = dateTimePicker1.Value.TimeOfDay;
                            so.UserName = AppConfig.loggedInUserName;

                            //setting the status to checkout or hold sale.
                            so.SaleStatus = checkoutOrHold;
                            so.TaxPercentage = taxapplied;
                            currentSaleObject.TaxPercentage = taxapplied;
                            so.TerminalID = AppConfig.TerminalID;

                            //recording the purchase as purchase on hold
                            if (checkoutOrHold == 1)
                            {
                                so.HoldInvoice = 1;
                            }
                            else
                            {
                                so.HoldInvoice = 0;
                            }

                            so.InvoiceID = OrderIDField.Text;

                            db.salesorders.Add(so);
                            db.SaveChanges();
                            //Adding saleitems
                            int orderid = so.OrderID;
                            foreach (var item in currentSaleObject.SaleItems)
                            {
                                decimal tax = item.TaxPercentage / 100;
                                decimal itemdiscount = item.Discount / 100;
                                decimal saleprice = (item.PriceApplied * tax) + item.PriceApplied;
                                saleprice = (saleprice * itemdiscount) + saleprice;
                                salesorderdetail s = new salesorderdetail();
                                s.ProductID = item.ProductID;
                                s.InvoiceID = OrderIDField.Text;
                                s.Discount = item.Discount;
                                s.SalePrice = item.PriceApplied;
                                s.Quantity = item.Quantity;
                                s.FinalSalePrice = saleprice;
                                s.PurchasePrice = item.PurchasePrice;
                                s.TaxPercentage = item.TaxPercentage;
                                s.ProfitTaken = saleprice - item.PurchasePrice;
                                db.salesorderdetails.Add(s);
                                db.SaveChanges();

                                var quantityremaining = item.Quantity;
                                //////////////////////////////////////////////////////////////////////////////////
                                //closing previous inventory record.
                                //////////////////////////////////////////////////////////////////////////////////
                                var existingproducts = (from v in db.inventories
                                                        where v.ProductID == item.ProductID && v.UpdateDt == null
                                                        orderby v.PurchasePrice
                                                        select v
                                         ).ToList();

                                foreach (var i in existingproducts)
                                {
                                    var updtitem = (from v in db.inventories
                                                    where v.ProductID == item.ProductID && v.UpdateDt == null && v.PurchasePrice == i.PurchasePrice
                                                    select v
                                         ).First();

                                    if (quantityremaining >= i.SumQuantity)
                                    {
                                        quantityremaining -= (decimal)i.SumQuantity;
                                        updtitem.SumQuantity = 0;
                                        updtitem.UpdateDt = dateTimePicker1.Value;
                                        db.SaveChanges();

                                        var a = new inventory
                                        {
                                            ProductID = i.ProductID,
                                            CreateDt = dateTimePicker1.Value,
                                            SaleDate = dateTimePicker1.Value,
                                            PurchasePrice = i.PurchasePrice,
                                            Quantity = 0,
                                            UpdateDt = null,
                                            PackingTypeID = null,
                                            SumQuantity = 0,
                                            SalePrice = i.SalePrice,
                                            InvoiceID = so.InvoiceID
                                        };
                                        db.inventories.Add(a);
                                        db.SaveChanges();

                                    }
                                    else if (quantityremaining < i.SumQuantity)
                                    {
                                        decimal newSumQuantity = (decimal)updtitem.SumQuantity;
                                        updtitem.SumQuantity = i.SumQuantity - quantityremaining;
                                        updtitem.UpdateDt = dateTimePicker1.Value;
                                        db.SaveChanges();

                                        var a = new inventory
                                        {
                                            ProductID = i.ProductID,
                                            CreateDt = dateTimePicker1.Value,
                                            SaleDate = dateTimePicker1.Value,
                                            PurchasePrice = i.PurchasePrice,
                                            Quantity = quantityremaining,
                                            UpdateDt = null,
                                            PackingTypeID = null,
                                            SumQuantity = newSumQuantity - quantityremaining,
                                            SalePrice = i.SalePrice,
                                            InvoiceID = so.InvoiceID
                                        };
                                        db.inventories.Add(a);
                                        db.SaveChanges();

                                        quantityremaining = 0;
                                        break;
                                    }
                                    if (quantityremaining == 0)
                                        break;
                                }

                                //Model.inventory c = (from x in db.inventories
                                //                     where x.ProductID == item.ProductID && x.UpdateDt == null
                                //                     orderby x.PurchasePrice
                                //                     select x).First();
                                //c.UpdateDt = dateTimePicker1.Value;
                                //db.SaveChanges();

                                //decimal existingQuantity;
                                //if (c.SumQuantity != null)
                                //    existingQuantity = c.SumQuantity;
                                //else
                                //    existingQuantity = 0;
                                ////////////////////////////////////////////////////////////////////////////////////

                                ////////////////////////////////////////////////////////////////////////////////////
                                ////adding new inventory record.
                                ////////////////////////////////////////////////////////////////////////////////////
                                //var inv = new inventory
                                //{
                                //    ProductID = item.ProductID,
                                //    CreateDt = dateTimePicker1.Value,
                                //    SaleDate = dateTimePicker1.Value,
                                //    PurchasePrice = item.PriceApplied,
                                //    Quantity = item.Quantity,
                                //    //TaxPaid = item.TaxPercentage,
                                //    //ReorderValue = c.ReorderValue,
                                //    UpdateDt = null,
                                //    PackingTypeID = null,
                                //    SumQuantity = existingQuantity - item.Quantity,
                                //    SalePrice = c.SalePrice,
                                //    InvoiceID = so.InvoiceID
                                //};
                                //db.inventories.Add(inv);
                                //db.SaveChanges();
                            }
                            //db.SaveChanges();

                            if (checkoutOrHold == 1)
                            {
                                MessageBox.Show("Sale is put on HOLD. You can open the Sales on hold again from Invoices Form.");
                            }
                            else
                            {
                                //MessageBox.Show("Proceed to Printing Receipt");
                                //DialogResult dialogResult = MessageBox.Show("Do you want to print Reciept", "Reciept Printing", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                                //if (dialogResult == DialogResult.Yes)
                                //{
                                PrintPage();
                                //}
                                //else if (dialogResult == DialogResult.No)
                                //{

                                //}
                                //resetting everything
                                currentSaleObject = new SaleClass();
                                currentSaleObject.SaleItems = new List<SaleItemClass>();
                                SaleItemsList.DataSource = null;
                                SaleItemsList.Refresh();
                                clearFields();
                            }
                        }
                    }
                    else
                    {
                        MessageBox.Show("Amount Paid Value should be larger or equal to Total");
                    }
                }
                catch (Exception e1)
                {
                    MessageBox.Show("Enter numeric value for Amount Paid");
                }
            }
            else
            {
                MessageBox.Show("Enter value for Amount Paid");
            }
        }

        private void CheckOutBtn_Click(object sender, EventArgs e)
        {
            RecordSale(0, "Cash");
        }

        private void HoldSaleBtn_Click(object sender, EventArgs e)
        {
            RecordSale(1, "Cash");
        }

        private void BarCodeField_TextChanged(object sender, EventArgs e)
        {
            Thread t = new Thread(new ThreadStart(readBarCodeValue));
            t.Start();
        }

        public void readBarCodeValue()
        {
            string readbarcode = "";

            readbarcode = BarCodeField.Text;
            Thread.Sleep(200);
            //if (readbarcode.Length >= 10 && readbarcode == oldBarCodeValue)
            foreach (var item in productPrices)
            {
                if (item.barcode == readbarcode)
                {
                    //oldBarCodeValue = item.barcode;
                    searchedBarcodeProduct = item;
                    setProductNameText();
                }
            }

            //if (readbarcode == oldBarCodeValue)
            //{
            //Thread t1 = new Thread(new ThreadStart(ThreadProcSafe));
            //t1.Start();                
            //}
            //else
            //{
            //    oldBarCodeValue = readbarcode;
            //}
        }

        //private void ThreadProcSafe()
        //{
        //    this.setProductNameText();
        //} 

        delegate void setProductNameDelegate();
        public void setProductNameText()
        {
            Thread.Sleep(300);
            //using (var db = new POSApplication.Model.posdbEntities())
            //{
            //var t = (from d in db.products
            //         where d.Barcode == oldBarCodeValue
            //         select new { ProductName = d.ProductName }).SingleOrDefault();
            if (searchedBarcodeProduct == null)
            {
                MessageBox.Show("Product Not Registered in the system.");
            }
            else
            {
                if (this.ProductList.InvokeRequired)
                {
                    setProductNameDelegate d = new setProductNameDelegate(setProductNameText);
                    this.Invoke(d, new object[] { });
                }
                else
                {
                    BarCodeField.Text = "";
                    ProductList.Text = searchedBarcodeProduct.productName;
                    QuantityField.Text = @"1";
                    PriceField.Text = searchedBarcodeProduct.salePrice.ToString();
                }
            }
            //}
        }
        private void SalesForm_KeyPress(object sender, KeyPressEventArgs e)
        {
            //if (e.KeyChar >= 48 && e.KeyChar <= 57)
            //{
            //    MessageBox.Show("Form.KeyPress: '" +
            //        e.KeyChar.ToString() + "' pressed.");

            //    switch (e.KeyChar)
            //    {
            //        case (char)49:
            //        case (char)52:
            //        case (char)55:
            //            MessageBox.Show("Form.KeyPress: '" +
            //                e.KeyChar.ToString() + "' consumed.");
            //            e.Handled = true;
            //            break;
            //    }
            //}
        }

        private void SalesForm_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.Alt && e.KeyCode == Keys.Z)
            {
                BarCodeField.Focus();
            }

            if (e.Alt && e.KeyCode == Keys.Q)
            {
                QuantityField.Focus();
            }

            if (e.Alt && e.KeyCode == Keys.P)
            {
                ProductList.Focus();
            }

            if (e.Alt && e.KeyCode == Keys.X)
            {
                clearFields();
            }

            if (e.Alt && e.KeyCode == Keys.S)
            {
                subTotal();
            }

            if (e.Alt && e.KeyCode == Keys.C)
            {
                RecordSale(0, "Cash");
            }

            if (e.Alt && e.KeyCode == Keys.H)
            {
                RecordSale(1, "Cash");
            }

            if (e.Alt && e.KeyCode == Keys.B)
            {
                BarCodeField.Focus();
            }

            if (e.Alt && e.KeyCode == Keys.Enter)
            {
                AddItemToCart();
            }

            if (e.Alt && e.KeyCode == Keys.D)
            {
                TotalDiscountField.Focus();
            }

            if (e.Alt && e.KeyCode == Keys.T)
            {
                TaxAppliedField.Focus();
            }

            if (e.Alt && e.KeyCode == Keys.A)
            {
                AmountPaidField.Focus();
            }
        }

        private void existingcategorieslist_SelectedIndexChanged(object sender, EventArgs e)
        {
            var i = existingcategorieslist.GetItemText(existingcategorieslist.SelectedItem);
            var categoryname = i;
            using (var dbCtx = new POSApplication.Model.posdbEntities())
            {
                //var products = dbCtx.products.ToList(x => x. == categoryname);
                var products = (from d in dbCtx.categories
                                join p in dbCtx.products on
                                d.CategoryID equals p.CategoryID
                                where d.CategoryName == categoryname
                                select new { ProductName = p.ProductName }).ToList();

                if (products != null)
                {
                    int a = 0;
                    existingproductlist.Items.Clear();
                    foreach (var item in products)
                    {
                        existingproductlist.Items.Add(item.ProductName);
                        if (a == 0)
                            existingproductlist.Text = item.ProductName;
                        a += 1;
                    }
                }
            }
        }

        private void existingproductlist_DoubleClick(object sender, EventArgs e)
        {
            var i = existingproductlist.GetItemText(existingproductlist.SelectedItem);
            ProductList.Text = i.ToString();
            //loadProductsList(existingcategorieslist.GetItemText(existingcategorieslist.SelectedItem));

            //foreach (var item in productPrices)
            //{
            //    switch (item.productName.CompareTo(i))
            //    {
            //        case 0:
            //            QuantityField.Text = @"1";
            //            continue;
            //    }
            //}

            using (var dbCtx = new POSApplication.Model.posdbEntities())
            {
                var pinv = (from inv in dbCtx.inventories
                            join p in dbCtx.products on
                            inv.ProductID equals p.ProductID
                            where p.ProductName == i && inv.UpdateDt == null
                            select new
                            {
                                ProductName = p.ProductName,
                                LastPurchasePrice = inv.SalePrice,
                                Barcode = p.Barcode,
                                ProductCode = p.ProductCode
                            }).FirstOrDefault();
                if (pinv != null)
                {
                    QuantityField.Text = @"1";
                    PriceField.Text = pinv.LastPurchasePrice.ToString();
                    if (pinv.Barcode != null)
                        BarCodeField.Text = pinv.Barcode;
                    else
                        BarCodeField.Text = "No Barcode";
                    if (pinv.ProductCode != null)
                        ProductCodeField.Text = pinv.ProductCode;
                    else
                        ProductCodeField.Text = "No Product Code";
                }
            }
            
            //using (var dbCtx = new POSApplication.Model.posdbEntities())
            //{
            //var products = (from p in dbCtx.products
            //                where p.ProductName == productName
            //                select new { ProductName = p.ProductName }).ToList();

            //if (products != null)
            //{
            //int a = 0;
            //existingproductlist.Items.Clear();
            //foreach (var item in products)
            //{
            //    existingproductlist.Items.Add(item.ProductName);
            //    if (a == 0)
            //        existingproductlist.Text = item.ProductName;
            //    a += 1;
            //}
            //}
            //}
        }
    }
}