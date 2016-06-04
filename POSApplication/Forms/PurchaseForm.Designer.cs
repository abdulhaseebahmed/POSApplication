namespace POSApplication.Forms
{
    partial class PurchaseForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            this.label11 = new System.Windows.Forms.Label();
            this.ItemTaxField = new System.Windows.Forms.TextBox();
            this.DateLabel = new System.Windows.Forms.Label();
            this.label15 = new System.Windows.Forms.Label();
            this.label14 = new System.Windows.Forms.Label();
            this.OrderIDField = new System.Windows.Forms.TextBox();
            this.label13 = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.BarCodeField = new System.Windows.Forms.TextBox();
            this.ProductList = new System.Windows.Forms.ComboBox();
            this.CloseSaleFormBtn = new System.Windows.Forms.Button();
            this.SubTotalBtn = new System.Windows.Forms.Button();
            this.CheckOutBtn = new System.Windows.Forms.Button();
            this.HoldSaleBtn = new System.Windows.Forms.Button();
            this.DeleteSaleItemBtn = new System.Windows.Forms.Button();
            this.ClearSaleBtn = new System.Windows.Forms.Button();
            this.AddToSaleListBtn = new System.Windows.Forms.Button();
            this.PrintReceiptBtn = new System.Windows.Forms.Button();
            this.label9 = new System.Windows.Forms.Label();
            this.BalanceField = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.AmountPaidField = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.TotalDiscountField = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.TaxAppliedField = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.TotalSaleField = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.DiscountField = new System.Windows.Forms.TextBox();
            this.PriceField = new System.Windows.Forms.TextBox();
            this.QuantityField = new System.Windows.Forms.TextBox();
            this.SaleItemsList = new System.Windows.Forms.DataGridView();
            this.NewSupplierButton = new System.Windows.Forms.Button();
            this.SuppliersList = new System.Windows.Forms.ComboBox();
            this.SupplierContactLabel = new System.Windows.Forms.Label();
            this.NewProductButton = new System.Windows.Forms.Button();
            this.LoadListsButton = new System.Windows.Forms.Button();
            this.label16 = new System.Windows.Forms.Label();
            this.existingcategorieslist = new System.Windows.Forms.ComboBox();
            this.label17 = new System.Windows.Forms.Label();
            this.prevpurchasesbutton = new System.Windows.Forms.Button();
            this.existingproductlist = new System.Windows.Forms.ListBox();
            this.label18 = new System.Windows.Forms.Label();
            this.ProductCodeField = new System.Windows.Forms.TextBox();
            this.dateTimePicker1 = new System.Windows.Forms.DateTimePicker();
            ((System.ComponentModel.ISupportInitialize)(this.SaleItemsList)).BeginInit();
            this.SuspendLayout();
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label11.Location = new System.Drawing.Point(355, 185);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(41, 15);
            this.label11.TabIndex = 102;
            this.label11.Text = "Tax %";
            // 
            // ItemTaxField
            // 
            this.ItemTaxField.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ItemTaxField.Location = new System.Drawing.Point(358, 206);
            this.ItemTaxField.Name = "ItemTaxField";
            this.ItemTaxField.Size = new System.Drawing.Size(48, 23);
            this.ItemTaxField.TabIndex = 7;
            // 
            // DateLabel
            // 
            this.DateLabel.AutoSize = true;
            this.DateLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.DateLabel.Location = new System.Drawing.Point(456, 103);
            this.DateLabel.Name = "DateLabel";
            this.DateLabel.Size = new System.Drawing.Size(101, 18);
            this.DateLabel.TabIndex = 101;
            this.DateLabel.Text = "Invoice Date";
            this.DateLabel.Visible = false;
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label15.Location = new System.Drawing.Point(13, 124);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(84, 18);
            this.label15.TabIndex = 100;
            this.label15.Text = "Contact No";
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label14.Location = new System.Drawing.Point(13, 95);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(105, 18);
            this.label14.TabIndex = 99;
            this.label14.Text = "Supplier Name";
            // 
            // OrderIDField
            // 
            this.OrderIDField.Enabled = false;
            this.OrderIDField.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.OrderIDField.Location = new System.Drawing.Point(434, 16);
            this.OrderIDField.Name = "OrderIDField";
            this.OrderIDField.Size = new System.Drawing.Size(162, 23);
            this.OrderIDField.TabIndex = 1;
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label13.Location = new System.Drawing.Point(356, 18);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(72, 18);
            this.label13.TabIndex = 98;
            this.label13.Text = "Invoice ID";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label12.Location = new System.Drawing.Point(356, 58);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(39, 18);
            this.label12.TabIndex = 97;
            this.label12.Text = "Date";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.ForeColor = System.Drawing.Color.LimeGreen;
            this.label10.Location = new System.Drawing.Point(15, 155);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(119, 18);
            this.label10.TabIndex = 96;
            this.label10.Text = "Barcode Scan ";
            // 
            // BarCodeField
            // 
            this.BarCodeField.Enabled = false;
            this.BarCodeField.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BarCodeField.Location = new System.Drawing.Point(136, 154);
            this.BarCodeField.Name = "BarCodeField";
            this.BarCodeField.Size = new System.Drawing.Size(172, 23);
            this.BarCodeField.TabIndex = 3;
            this.BarCodeField.TextChanged += new System.EventHandler(this.BarCodeField_TextChanged);
            // 
            // ProductList
            // 
            this.ProductList.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend;
            this.ProductList.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.ProductList.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ProductList.FormattingEnabled = true;
            this.ProductList.Location = new System.Drawing.Point(18, 206);
            this.ProductList.Name = "ProductList";
            this.ProductList.Size = new System.Drawing.Size(226, 24);
            this.ProductList.TabIndex = 4;
            this.ProductList.SelectedIndexChanged += new System.EventHandler(this.ProductList_SelectedIndexChanged);
            // 
            // CloseSaleFormBtn
            // 
            this.CloseSaleFormBtn.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.CloseSaleFormBtn.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.CloseSaleFormBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CloseSaleFormBtn.Location = new System.Drawing.Point(792, 605);
            this.CloseSaleFormBtn.Name = "CloseSaleFormBtn";
            this.CloseSaleFormBtn.Size = new System.Drawing.Size(114, 36);
            this.CloseSaleFormBtn.TabIndex = 19;
            this.CloseSaleFormBtn.Text = "Close";
            this.CloseSaleFormBtn.UseVisualStyleBackColor = false;
            this.CloseSaleFormBtn.Click += new System.EventHandler(this.CloseSaleFormBtn_Click);
            // 
            // SubTotalBtn
            // 
            this.SubTotalBtn.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.SubTotalBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.SubTotalBtn.Location = new System.Drawing.Point(17, 438);
            this.SubTotalBtn.Name = "SubTotalBtn";
            this.SubTotalBtn.Size = new System.Drawing.Size(127, 55);
            this.SubTotalBtn.TabIndex = 14;
            this.SubTotalBtn.Text = "Sub Total";
            this.SubTotalBtn.UseVisualStyleBackColor = false;
            this.SubTotalBtn.Click += new System.EventHandler(this.SubTotalBtn_Click);
            // 
            // CheckOutBtn
            // 
            this.CheckOutBtn.BackColor = System.Drawing.Color.GreenYellow;
            this.CheckOutBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CheckOutBtn.ForeColor = System.Drawing.Color.Black;
            this.CheckOutBtn.Location = new System.Drawing.Point(18, 563);
            this.CheckOutBtn.Name = "CheckOutBtn";
            this.CheckOutBtn.Size = new System.Drawing.Size(264, 80);
            this.CheckOutBtn.TabIndex = 18;
            this.CheckOutBtn.Text = "CHECKOUT";
            this.CheckOutBtn.UseVisualStyleBackColor = false;
            this.CheckOutBtn.Click += new System.EventHandler(this.CheckOutBtn_Click);
            // 
            // HoldSaleBtn
            // 
            this.HoldSaleBtn.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.HoldSaleBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.HoldSaleBtn.Location = new System.Drawing.Point(18, 499);
            this.HoldSaleBtn.Name = "HoldSaleBtn";
            this.HoldSaleBtn.Size = new System.Drawing.Size(126, 55);
            this.HoldSaleBtn.TabIndex = 16;
            this.HoldSaleBtn.Text = "Hold Sale";
            this.HoldSaleBtn.UseVisualStyleBackColor = false;
            this.HoldSaleBtn.Click += new System.EventHandler(this.HoldSaleBtn_Click);
            // 
            // DeleteSaleItemBtn
            // 
            this.DeleteSaleItemBtn.BackColor = System.Drawing.Color.Maroon;
            this.DeleteSaleItemBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.DeleteSaleItemBtn.ForeColor = System.Drawing.Color.White;
            this.DeleteSaleItemBtn.Location = new System.Drawing.Point(153, 438);
            this.DeleteSaleItemBtn.Name = "DeleteSaleItemBtn";
            this.DeleteSaleItemBtn.Size = new System.Drawing.Size(129, 55);
            this.DeleteSaleItemBtn.TabIndex = 15;
            this.DeleteSaleItemBtn.Text = "Delete Line";
            this.DeleteSaleItemBtn.UseVisualStyleBackColor = false;
            this.DeleteSaleItemBtn.Click += new System.EventHandler(this.DeleteSaleItemBtn_Click);
            // 
            // ClearSaleBtn
            // 
            this.ClearSaleBtn.BackColor = System.Drawing.Color.Red;
            this.ClearSaleBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ClearSaleBtn.ForeColor = System.Drawing.Color.White;
            this.ClearSaleBtn.Location = new System.Drawing.Point(153, 499);
            this.ClearSaleBtn.Name = "ClearSaleBtn";
            this.ClearSaleBtn.Size = new System.Drawing.Size(129, 55);
            this.ClearSaleBtn.TabIndex = 17;
            this.ClearSaleBtn.Text = "Clear Sale";
            this.ClearSaleBtn.UseVisualStyleBackColor = false;
            this.ClearSaleBtn.Click += new System.EventHandler(this.ClearSaleBtn_Click);
            // 
            // AddToSaleListBtn
            // 
            this.AddToSaleListBtn.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.AddToSaleListBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.AddToSaleListBtn.Location = new System.Drawing.Point(484, 185);
            this.AddToSaleListBtn.Name = "AddToSaleListBtn";
            this.AddToSaleListBtn.Size = new System.Drawing.Size(112, 47);
            this.AddToSaleListBtn.TabIndex = 9;
            this.AddToSaleListBtn.Text = "Add";
            this.AddToSaleListBtn.UseVisualStyleBackColor = false;
            this.AddToSaleListBtn.Click += new System.EventHandler(this.AddToSaleListBtn_Click);
            // 
            // PrintReceiptBtn
            // 
            this.PrintReceiptBtn.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.PrintReceiptBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.PrintReceiptBtn.Location = new System.Drawing.Point(666, 605);
            this.PrintReceiptBtn.Name = "PrintReceiptBtn";
            this.PrintReceiptBtn.Size = new System.Drawing.Size(120, 36);
            this.PrintReceiptBtn.TabIndex = 89;
            this.PrintReceiptBtn.Text = "Print Receipt";
            this.PrintReceiptBtn.UseVisualStyleBackColor = false;
            this.PrintReceiptBtn.Visible = false;
            this.PrintReceiptBtn.Click += new System.EventHandler(this.PrintReceiptBtn_Click);
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.Location = new System.Drawing.Point(391, 576);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(74, 20);
            this.label9.TabIndex = 88;
            this.label9.Text = "Balance";
            // 
            // BalanceField
            // 
            this.BalanceField.Enabled = false;
            this.BalanceField.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BalanceField.ForeColor = System.Drawing.Color.Crimson;
            this.BalanceField.Location = new System.Drawing.Point(478, 573);
            this.BalanceField.Name = "BalanceField";
            this.BalanceField.ReadOnly = true;
            this.BalanceField.Size = new System.Drawing.Size(120, 26);
            this.BalanceField.TabIndex = 84;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(358, 544);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(111, 20);
            this.label8.TabIndex = 87;
            this.label8.Text = "Amount Paid";
            // 
            // AmountPaidField
            // 
            this.AmountPaidField.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.AmountPaidField.ForeColor = System.Drawing.SystemColors.MenuHighlight;
            this.AmountPaidField.Location = new System.Drawing.Point(478, 541);
            this.AmountPaidField.Name = "AmountPaidField";
            this.AmountPaidField.Size = new System.Drawing.Size(120, 26);
            this.AmountPaidField.TabIndex = 13;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(386, 448);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(80, 20);
            this.label7.TabIndex = 86;
            this.label7.Text = "Discount";
            // 
            // TotalDiscountField
            // 
            this.TotalDiscountField.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TotalDiscountField.ForeColor = System.Drawing.Color.Crimson;
            this.TotalDiscountField.Location = new System.Drawing.Point(478, 445);
            this.TotalDiscountField.Name = "TotalDiscountField";
            this.TotalDiscountField.Size = new System.Drawing.Size(120, 26);
            this.TotalDiscountField.TabIndex = 10;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(424, 480);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(37, 20);
            this.label6.TabIndex = 85;
            this.label6.Text = "Tax";
            // 
            // TaxAppliedField
            // 
            this.TaxAppliedField.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TaxAppliedField.ForeColor = System.Drawing.Color.Crimson;
            this.TaxAppliedField.Location = new System.Drawing.Point(478, 477);
            this.TaxAppliedField.Name = "TaxAppliedField";
            this.TaxAppliedField.Size = new System.Drawing.Size(120, 26);
            this.TaxAppliedField.TabIndex = 11;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(414, 512);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(49, 20);
            this.label1.TabIndex = 83;
            this.label1.Text = "Total";
            // 
            // TotalSaleField
            // 
            this.TotalSaleField.Enabled = false;
            this.TotalSaleField.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TotalSaleField.ForeColor = System.Drawing.Color.LimeGreen;
            this.TotalSaleField.Location = new System.Drawing.Point(478, 509);
            this.TotalSaleField.Name = "TotalSaleField";
            this.TotalSaleField.Size = new System.Drawing.Size(120, 26);
            this.TotalSaleField.TabIndex = 12;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(409, 185);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(69, 15);
            this.label5.TabIndex = 81;
            this.label5.Text = "Discount %";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(301, 185);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(35, 15);
            this.label4.TabIndex = 78;
            this.label4.Text = "Price";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(247, 185);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(51, 15);
            this.label3.TabIndex = 77;
            this.label3.Text = "Quantity";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(15, 185);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(49, 15);
            this.label2.TabIndex = 74;
            this.label2.Text = "Product";
            // 
            // DiscountField
            // 
            this.DiscountField.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.DiscountField.Location = new System.Drawing.Point(413, 206);
            this.DiscountField.Name = "DiscountField";
            this.DiscountField.Size = new System.Drawing.Size(48, 23);
            this.DiscountField.TabIndex = 8;
            // 
            // PriceField
            // 
            this.PriceField.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.PriceField.Location = new System.Drawing.Point(304, 206);
            this.PriceField.Name = "PriceField";
            this.PriceField.Size = new System.Drawing.Size(48, 23);
            this.PriceField.TabIndex = 6;
            // 
            // QuantityField
            // 
            this.QuantityField.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.QuantityField.Location = new System.Drawing.Point(250, 206);
            this.QuantityField.Name = "QuantityField";
            this.QuantityField.Size = new System.Drawing.Size(48, 23);
            this.QuantityField.TabIndex = 5;
            // 
            // SaleItemsList
            // 
            this.SaleItemsList.AllowUserToAddRows = false;
            this.SaleItemsList.AllowUserToDeleteRows = false;
            this.SaleItemsList.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.SaleItemsList.DefaultCellStyle = dataGridViewCellStyle1;
            this.SaleItemsList.Location = new System.Drawing.Point(17, 242);
            this.SaleItemsList.Name = "SaleItemsList";
            this.SaleItemsList.ReadOnly = true;
            this.SaleItemsList.Size = new System.Drawing.Size(581, 190);
            this.SaleItemsList.TabIndex = 67;
            // 
            // NewSupplierButton
            // 
            this.NewSupplierButton.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.NewSupplierButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.NewSupplierButton.Location = new System.Drawing.Point(14, 10);
            this.NewSupplierButton.Name = "NewSupplierButton";
            this.NewSupplierButton.Size = new System.Drawing.Size(164, 34);
            this.NewSupplierButton.TabIndex = 103;
            this.NewSupplierButton.Text = "New Supplier";
            this.NewSupplierButton.UseVisualStyleBackColor = false;
            this.NewSupplierButton.Click += new System.EventHandler(this.NewSupplierButton_Click);
            // 
            // SuppliersList
            // 
            this.SuppliersList.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend;
            this.SuppliersList.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.SuppliersList.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.SuppliersList.FormattingEnabled = true;
            this.SuppliersList.Location = new System.Drawing.Point(136, 94);
            this.SuppliersList.Name = "SuppliersList";
            this.SuppliersList.Size = new System.Drawing.Size(303, 24);
            this.SuppliersList.TabIndex = 104;
            this.SuppliersList.SelectedIndexChanged += new System.EventHandler(this.SuppliersList_SelectedIndexChanged);
            // 
            // SupplierContactLabel
            // 
            this.SupplierContactLabel.AutoSize = true;
            this.SupplierContactLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.SupplierContactLabel.Location = new System.Drawing.Point(133, 124);
            this.SupplierContactLabel.Name = "SupplierContactLabel";
            this.SupplierContactLabel.Size = new System.Drawing.Size(105, 18);
            this.SupplierContactLabel.TabIndex = 105;
            this.SupplierContactLabel.Text = "None Selected";
            // 
            // NewProductButton
            // 
            this.NewProductButton.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.NewProductButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.NewProductButton.Location = new System.Drawing.Point(186, 10);
            this.NewProductButton.Name = "NewProductButton";
            this.NewProductButton.Size = new System.Drawing.Size(164, 34);
            this.NewProductButton.TabIndex = 106;
            this.NewProductButton.Text = "New Product";
            this.NewProductButton.UseVisualStyleBackColor = false;
            this.NewProductButton.Click += new System.EventHandler(this.NewProductButton_Click);
            // 
            // LoadListsButton
            // 
            this.LoadListsButton.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.LoadListsButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LoadListsButton.Location = new System.Drawing.Point(16, 47);
            this.LoadListsButton.Name = "LoadListsButton";
            this.LoadListsButton.Size = new System.Drawing.Size(334, 36);
            this.LoadListsButton.TabIndex = 108;
            this.LoadListsButton.Text = "Refresh Suppliers and Products";
            this.LoadListsButton.UseVisualStyleBackColor = false;
            this.LoadListsButton.Click += new System.EventHandler(this.LoadListsButton_Click);
            // 
            // label16
            // 
            this.label16.AutoSize = true;
            this.label16.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label16.Location = new System.Drawing.Point(620, 18);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(68, 18);
            this.label16.TabIndex = 110;
            this.label16.Text = "Category";
            // 
            // existingcategorieslist
            // 
            this.existingcategorieslist.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend;
            this.existingcategorieslist.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.existingcategorieslist.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.existingcategorieslist.FormattingEnabled = true;
            this.existingcategorieslist.Location = new System.Drawing.Point(694, 17);
            this.existingcategorieslist.Name = "existingcategorieslist";
            this.existingcategorieslist.Size = new System.Drawing.Size(212, 24);
            this.existingcategorieslist.TabIndex = 111;
            this.existingcategorieslist.SelectedIndexChanged += new System.EventHandler(this.existingcategorieslist_SelectedIndexChanged);
            // 
            // label17
            // 
            this.label17.AutoSize = true;
            this.label17.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label17.Location = new System.Drawing.Point(620, 55);
            this.label17.Name = "label17";
            this.label17.Size = new System.Drawing.Size(68, 18);
            this.label17.TabIndex = 112;
            this.label17.Text = "Products";
            // 
            // prevpurchasesbutton
            // 
            this.prevpurchasesbutton.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.prevpurchasesbutton.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.prevpurchasesbutton.Location = new System.Drawing.Point(358, 607);
            this.prevpurchasesbutton.Name = "prevpurchasesbutton";
            this.prevpurchasesbutton.Size = new System.Drawing.Size(240, 36);
            this.prevpurchasesbutton.TabIndex = 113;
            this.prevpurchasesbutton.Text = "Previous Purchases";
            this.prevpurchasesbutton.UseVisualStyleBackColor = false;
            this.prevpurchasesbutton.Visible = false;
            this.prevpurchasesbutton.Click += new System.EventHandler(this.prevpurchasesbutton_Click);
            // 
            // existingproductlist
            // 
            this.existingproductlist.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.existingproductlist.FormattingEnabled = true;
            this.existingproductlist.Location = new System.Drawing.Point(623, 87);
            this.existingproductlist.Name = "existingproductlist";
            this.existingproductlist.Size = new System.Drawing.Size(282, 511);
            this.existingproductlist.Sorted = true;
            this.existingproductlist.TabIndex = 114;
            this.existingproductlist.SelectedIndexChanged += new System.EventHandler(this.existingproductlist_SelectedIndexChanged);
            this.existingproductlist.DoubleClick += new System.EventHandler(this.existingproductlist_DoubleClick);
            // 
            // label18
            // 
            this.label18.AutoSize = true;
            this.label18.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label18.ForeColor = System.Drawing.Color.Black;
            this.label18.Location = new System.Drawing.Point(314, 155);
            this.label18.Name = "label18";
            this.label18.Size = new System.Drawing.Size(100, 18);
            this.label18.TabIndex = 116;
            this.label18.Text = "Product Code";
            // 
            // ProductCodeField
            // 
            this.ProductCodeField.Enabled = false;
            this.ProductCodeField.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ProductCodeField.Location = new System.Drawing.Point(420, 154);
            this.ProductCodeField.Name = "ProductCodeField";
            this.ProductCodeField.Size = new System.Drawing.Size(176, 23);
            this.ProductCodeField.TabIndex = 115;
            // 
            // dateTimePicker1
            // 
            this.dateTimePicker1.Location = new System.Drawing.Point(401, 58);
            this.dateTimePicker1.Name = "dateTimePicker1";
            this.dateTimePicker1.Size = new System.Drawing.Size(195, 20);
            this.dateTimePicker1.TabIndex = 117;
            // 
            // PurchaseForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(918, 655);
            this.ControlBox = false;
            this.Controls.Add(this.dateTimePicker1);
            this.Controls.Add(this.label18);
            this.Controls.Add(this.ProductCodeField);
            this.Controls.Add(this.existingproductlist);
            this.Controls.Add(this.prevpurchasesbutton);
            this.Controls.Add(this.label17);
            this.Controls.Add(this.existingcategorieslist);
            this.Controls.Add(this.label16);
            this.Controls.Add(this.LoadListsButton);
            this.Controls.Add(this.NewProductButton);
            this.Controls.Add(this.SupplierContactLabel);
            this.Controls.Add(this.SuppliersList);
            this.Controls.Add(this.NewSupplierButton);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.ItemTaxField);
            this.Controls.Add(this.DateLabel);
            this.Controls.Add(this.label15);
            this.Controls.Add(this.label14);
            this.Controls.Add(this.OrderIDField);
            this.Controls.Add(this.label13);
            this.Controls.Add(this.label12);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.BarCodeField);
            this.Controls.Add(this.ProductList);
            this.Controls.Add(this.CloseSaleFormBtn);
            this.Controls.Add(this.SubTotalBtn);
            this.Controls.Add(this.CheckOutBtn);
            this.Controls.Add(this.HoldSaleBtn);
            this.Controls.Add(this.DeleteSaleItemBtn);
            this.Controls.Add(this.ClearSaleBtn);
            this.Controls.Add(this.AddToSaleListBtn);
            this.Controls.Add(this.PrintReceiptBtn);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.BalanceField);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.AmountPaidField);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.TotalDiscountField);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.TaxAppliedField);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.TotalSaleField);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.DiscountField);
            this.Controls.Add(this.PriceField);
            this.Controls.Add(this.QuantityField);
            this.Controls.Add(this.SaleItemsList);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.KeyPreview = true;
            this.Name = "PurchaseForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Purchases";
            this.Load += new System.EventHandler(this.PurchaseForm_Load);
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.PurchaseForm_KeyDown);
            ((System.ComponentModel.ISupportInitialize)(this.SaleItemsList)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.TextBox ItemTaxField;
        private System.Windows.Forms.Label DateLabel;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.TextBox OrderIDField;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.TextBox BarCodeField;
        private System.Windows.Forms.ComboBox ProductList;
        private System.Windows.Forms.Button CloseSaleFormBtn;
        private System.Windows.Forms.Button SubTotalBtn;
        private System.Windows.Forms.Button CheckOutBtn;
        private System.Windows.Forms.Button HoldSaleBtn;
        private System.Windows.Forms.Button DeleteSaleItemBtn;
        private System.Windows.Forms.Button ClearSaleBtn;
        private System.Windows.Forms.Button AddToSaleListBtn;
        private System.Windows.Forms.Button PrintReceiptBtn;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.TextBox BalanceField;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox AmountPaidField;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox TotalDiscountField;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox TaxAppliedField;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox TotalSaleField;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox DiscountField;
        private System.Windows.Forms.TextBox PriceField;
        private System.Windows.Forms.TextBox QuantityField;
        private System.Windows.Forms.DataGridView SaleItemsList;
        private System.Windows.Forms.Button NewSupplierButton;
        private System.Windows.Forms.ComboBox SuppliersList;
        private System.Windows.Forms.Label SupplierContactLabel;
        private System.Windows.Forms.Button NewProductButton;
        private System.Windows.Forms.Button LoadListsButton;
        private System.Windows.Forms.Label label16;
        private System.Windows.Forms.ComboBox existingcategorieslist;
        private System.Windows.Forms.Label label17;
        private System.Windows.Forms.Button prevpurchasesbutton;
        private System.Windows.Forms.ListBox existingproductlist;
        private System.Windows.Forms.Label label18;
        private System.Windows.Forms.TextBox ProductCodeField;
        private System.Windows.Forms.DateTimePicker dateTimePicker1;
    }
}