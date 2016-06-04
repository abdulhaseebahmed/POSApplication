namespace POSApplication
{
    partial class SalesForm
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
            this.SaleItemsList = new System.Windows.Forms.DataGridView();
            this.QuantityField = new System.Windows.Forms.TextBox();
            this.PriceField = new System.Windows.Forms.TextBox();
            this.DiscountField = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.TotalSaleField = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.TaxAppliedField = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.TotalDiscountField = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.AmountPaidField = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.BalanceField = new System.Windows.Forms.TextBox();
            this.PrintReceiptBtn = new System.Windows.Forms.Button();
            this.AddToSaleListBtn = new System.Windows.Forms.Button();
            this.ClearSaleBtn = new System.Windows.Forms.Button();
            this.DeleteSaleItemBtn = new System.Windows.Forms.Button();
            this.HoldSaleBtn = new System.Windows.Forms.Button();
            this.CheckOutBtn = new System.Windows.Forms.Button();
            this.SubTotalBtn = new System.Windows.Forms.Button();
            this.CloseSaleFormBtn = new System.Windows.Forms.Button();
            this.ProductList = new System.Windows.Forms.ComboBox();
            this.label10 = new System.Windows.Forms.Label();
            this.BarCodeField = new System.Windows.Forms.TextBox();
            this.label12 = new System.Windows.Forms.Label();
            this.label13 = new System.Windows.Forms.Label();
            this.OrderIDField = new System.Windows.Forms.TextBox();
            this.CustomerNameField = new System.Windows.Forms.TextBox();
            this.label14 = new System.Windows.Forms.Label();
            this.ContactNumberField = new System.Windows.Forms.TextBox();
            this.label15 = new System.Windows.Forms.Label();
            this.DateLabel = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.ItemTaxField = new System.Windows.Forms.TextBox();
            this.dateTimePicker1 = new System.Windows.Forms.DateTimePicker();
            this.existingproductlist = new System.Windows.Forms.ListBox();
            this.label17 = new System.Windows.Forms.Label();
            this.existingcategorieslist = new System.Windows.Forms.ComboBox();
            this.label16 = new System.Windows.Forms.Label();
            this.prevpurchasesbutton = new System.Windows.Forms.Button();
            this.label18 = new System.Windows.Forms.Label();
            this.ProductCodeField = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.SaleItemsList)).BeginInit();
            this.SuspendLayout();
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
            this.SaleItemsList.Location = new System.Drawing.Point(12, 161);
            this.SaleItemsList.Name = "SaleItemsList";
            this.SaleItemsList.ReadOnly = true;
            this.SaleItemsList.Size = new System.Drawing.Size(581, 245);
            this.SaleItemsList.TabIndex = 3;
            // 
            // QuantityField
            // 
            this.QuantityField.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.QuantityField.Location = new System.Drawing.Point(229, 129);
            this.QuantityField.Name = "QuantityField";
            this.QuantityField.Size = new System.Drawing.Size(48, 23);
            this.QuantityField.TabIndex = 5;
            // 
            // PriceField
            // 
            this.PriceField.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.PriceField.Location = new System.Drawing.Point(283, 129);
            this.PriceField.Name = "PriceField";
            this.PriceField.ReadOnly = true;
            this.PriceField.Size = new System.Drawing.Size(48, 23);
            this.PriceField.TabIndex = 5;
            // 
            // DiscountField
            // 
            this.DiscountField.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.DiscountField.Location = new System.Drawing.Point(391, 128);
            this.DiscountField.Name = "DiscountField";
            this.DiscountField.Size = new System.Drawing.Size(48, 23);
            this.DiscountField.TabIndex = 7;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(8, 108);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(49, 15);
            this.label2.TabIndex = 8;
            this.label2.Text = "Product";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(226, 108);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(51, 15);
            this.label3.TabIndex = 9;
            this.label3.Text = "Quantity";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(280, 108);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(35, 15);
            this.label4.TabIndex = 10;
            this.label4.Text = "Price";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(388, 108);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(55, 15);
            this.label5.TabIndex = 11;
            this.label5.Text = "Discount";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(409, 486);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(49, 20);
            this.label1.TabIndex = 13;
            this.label1.Text = "Total";
            // 
            // TotalSaleField
            // 
            this.TotalSaleField.Enabled = false;
            this.TotalSaleField.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TotalSaleField.ForeColor = System.Drawing.Color.LimeGreen;
            this.TotalSaleField.Location = new System.Drawing.Point(473, 483);
            this.TotalSaleField.Name = "TotalSaleField";
            this.TotalSaleField.Size = new System.Drawing.Size(120, 26);
            this.TotalSaleField.TabIndex = 11;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(419, 454);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(37, 20);
            this.label6.TabIndex = 15;
            this.label6.Text = "Tax";
            // 
            // TaxAppliedField
            // 
            this.TaxAppliedField.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TaxAppliedField.ForeColor = System.Drawing.Color.Crimson;
            this.TaxAppliedField.Location = new System.Drawing.Point(473, 451);
            this.TaxAppliedField.Name = "TaxAppliedField";
            this.TaxAppliedField.Size = new System.Drawing.Size(120, 26);
            this.TaxAppliedField.TabIndex = 10;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(381, 422);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(80, 20);
            this.label7.TabIndex = 17;
            this.label7.Text = "Discount";
            // 
            // TotalDiscountField
            // 
            this.TotalDiscountField.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TotalDiscountField.ForeColor = System.Drawing.Color.Crimson;
            this.TotalDiscountField.Location = new System.Drawing.Point(473, 419);
            this.TotalDiscountField.Name = "TotalDiscountField";
            this.TotalDiscountField.Size = new System.Drawing.Size(120, 26);
            this.TotalDiscountField.TabIndex = 9;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(353, 518);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(111, 20);
            this.label8.TabIndex = 19;
            this.label8.Text = "Amount Paid";
            // 
            // AmountPaidField
            // 
            this.AmountPaidField.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.AmountPaidField.ForeColor = System.Drawing.SystemColors.MenuHighlight;
            this.AmountPaidField.Location = new System.Drawing.Point(473, 515);
            this.AmountPaidField.Name = "AmountPaidField";
            this.AmountPaidField.Size = new System.Drawing.Size(120, 26);
            this.AmountPaidField.TabIndex = 12;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.Location = new System.Drawing.Point(386, 550);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(74, 20);
            this.label9.TabIndex = 21;
            this.label9.Text = "Balance";
            // 
            // BalanceField
            // 
            this.BalanceField.Enabled = false;
            this.BalanceField.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BalanceField.ForeColor = System.Drawing.Color.Crimson;
            this.BalanceField.Location = new System.Drawing.Point(473, 547);
            this.BalanceField.Name = "BalanceField";
            this.BalanceField.ReadOnly = true;
            this.BalanceField.Size = new System.Drawing.Size(120, 26);
            this.BalanceField.TabIndex = 13;
            // 
            // PrintReceiptBtn
            // 
            this.PrintReceiptBtn.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.PrintReceiptBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.PrintReceiptBtn.Location = new System.Drawing.Point(668, 579);
            this.PrintReceiptBtn.Name = "PrintReceiptBtn";
            this.PrintReceiptBtn.Size = new System.Drawing.Size(120, 36);
            this.PrintReceiptBtn.TabIndex = 32;
            this.PrintReceiptBtn.Text = "Print Receipt";
            this.PrintReceiptBtn.UseVisualStyleBackColor = false;
            this.PrintReceiptBtn.Visible = false;
            this.PrintReceiptBtn.Click += new System.EventHandler(this.PrintReceiptBtn_Click);
            // 
            // AddToSaleListBtn
            // 
            this.AddToSaleListBtn.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.AddToSaleListBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.AddToSaleListBtn.Location = new System.Drawing.Point(465, 108);
            this.AddToSaleListBtn.Name = "AddToSaleListBtn";
            this.AddToSaleListBtn.Size = new System.Drawing.Size(128, 47);
            this.AddToSaleListBtn.TabIndex = 8;
            this.AddToSaleListBtn.Text = "Add";
            this.AddToSaleListBtn.UseVisualStyleBackColor = false;
            this.AddToSaleListBtn.Click += new System.EventHandler(this.AddToSaleListBtn_Click);
            // 
            // ClearSaleBtn
            // 
            this.ClearSaleBtn.BackColor = System.Drawing.Color.Red;
            this.ClearSaleBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ClearSaleBtn.ForeColor = System.Drawing.Color.White;
            this.ClearSaleBtn.Location = new System.Drawing.Point(148, 473);
            this.ClearSaleBtn.Name = "ClearSaleBtn";
            this.ClearSaleBtn.Size = new System.Drawing.Size(129, 55);
            this.ClearSaleBtn.TabIndex = 37;
            this.ClearSaleBtn.Text = "Clear Sale";
            this.ClearSaleBtn.UseVisualStyleBackColor = false;
            this.ClearSaleBtn.Click += new System.EventHandler(this.ClearSaleBtn_Click);
            // 
            // DeleteSaleItemBtn
            // 
            this.DeleteSaleItemBtn.BackColor = System.Drawing.Color.Maroon;
            this.DeleteSaleItemBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.DeleteSaleItemBtn.ForeColor = System.Drawing.Color.White;
            this.DeleteSaleItemBtn.Location = new System.Drawing.Point(148, 412);
            this.DeleteSaleItemBtn.Name = "DeleteSaleItemBtn";
            this.DeleteSaleItemBtn.Size = new System.Drawing.Size(129, 55);
            this.DeleteSaleItemBtn.TabIndex = 38;
            this.DeleteSaleItemBtn.Text = "Delete Line";
            this.DeleteSaleItemBtn.UseVisualStyleBackColor = false;
            this.DeleteSaleItemBtn.Click += new System.EventHandler(this.DeleteSaleItemBtn_Click);
            // 
            // HoldSaleBtn
            // 
            this.HoldSaleBtn.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.HoldSaleBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.HoldSaleBtn.Location = new System.Drawing.Point(13, 473);
            this.HoldSaleBtn.Name = "HoldSaleBtn";
            this.HoldSaleBtn.Size = new System.Drawing.Size(126, 55);
            this.HoldSaleBtn.TabIndex = 39;
            this.HoldSaleBtn.Text = "Hold Sale";
            this.HoldSaleBtn.UseVisualStyleBackColor = false;
            this.HoldSaleBtn.Click += new System.EventHandler(this.HoldSaleBtn_Click);
            // 
            // CheckOutBtn
            // 
            this.CheckOutBtn.BackColor = System.Drawing.Color.GreenYellow;
            this.CheckOutBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CheckOutBtn.ForeColor = System.Drawing.Color.Black;
            this.CheckOutBtn.Location = new System.Drawing.Point(13, 537);
            this.CheckOutBtn.Name = "CheckOutBtn";
            this.CheckOutBtn.Size = new System.Drawing.Size(264, 80);
            this.CheckOutBtn.TabIndex = 40;
            this.CheckOutBtn.Text = "CHECKOUT";
            this.CheckOutBtn.UseVisualStyleBackColor = false;
            this.CheckOutBtn.Click += new System.EventHandler(this.CheckOutBtn_Click);
            // 
            // SubTotalBtn
            // 
            this.SubTotalBtn.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.SubTotalBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.SubTotalBtn.Location = new System.Drawing.Point(12, 412);
            this.SubTotalBtn.Name = "SubTotalBtn";
            this.SubTotalBtn.Size = new System.Drawing.Size(127, 55);
            this.SubTotalBtn.TabIndex = 41;
            this.SubTotalBtn.Text = "Sub Total";
            this.SubTotalBtn.UseVisualStyleBackColor = false;
            this.SubTotalBtn.Click += new System.EventHandler(this.SubTotalBtn_Click);
            // 
            // CloseSaleFormBtn
            // 
            this.CloseSaleFormBtn.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.CloseSaleFormBtn.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.CloseSaleFormBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CloseSaleFormBtn.Location = new System.Drawing.Point(794, 579);
            this.CloseSaleFormBtn.Name = "CloseSaleFormBtn";
            this.CloseSaleFormBtn.Size = new System.Drawing.Size(114, 36);
            this.CloseSaleFormBtn.TabIndex = 42;
            this.CloseSaleFormBtn.Text = "Close";
            this.CloseSaleFormBtn.UseVisualStyleBackColor = false;
            this.CloseSaleFormBtn.Click += new System.EventHandler(this.CloseSaleFormBtn_Click);
            // 
            // ProductList
            // 
            this.ProductList.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend;
            this.ProductList.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.ProductList.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ProductList.FormattingEnabled = true;
            this.ProductList.Location = new System.Drawing.Point(12, 128);
            this.ProductList.Name = "ProductList";
            this.ProductList.Size = new System.Drawing.Size(211, 24);
            this.ProductList.TabIndex = 4;
            this.ProductList.SelectedIndexChanged += new System.EventHandler(this.ProductList_SelectedIndexChanged);
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.ForeColor = System.Drawing.Color.LimeGreen;
            this.label10.Location = new System.Drawing.Point(9, 78);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(119, 18);
            this.label10.TabIndex = 49;
            this.label10.Text = "Barcode Scan ";
            // 
            // BarCodeField
            // 
            this.BarCodeField.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BarCodeField.Location = new System.Drawing.Point(135, 77);
            this.BarCodeField.Name = "BarCodeField";
            this.BarCodeField.Size = new System.Drawing.Size(213, 23);
            this.BarCodeField.TabIndex = 3;
            this.BarCodeField.TextChanged += new System.EventHandler(this.BarCodeField_TextChanged);
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label12.Location = new System.Drawing.Point(296, 42);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(89, 18);
            this.label12.TabIndex = 53;
            this.label12.Text = "Invoice Date";
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label13.Location = new System.Drawing.Point(296, 13);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(72, 18);
            this.label13.TabIndex = 54;
            this.label13.Text = "Invoice ID";
            // 
            // OrderIDField
            // 
            this.OrderIDField.Enabled = false;
            this.OrderIDField.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.OrderIDField.Location = new System.Drawing.Point(374, 12);
            this.OrderIDField.Name = "OrderIDField";
            this.OrderIDField.Size = new System.Drawing.Size(219, 23);
            this.OrderIDField.TabIndex = 1;
            // 
            // CustomerNameField
            // 
            this.CustomerNameField.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CustomerNameField.Location = new System.Drawing.Point(135, 12);
            this.CustomerNameField.Name = "CustomerNameField";
            this.CustomerNameField.Size = new System.Drawing.Size(155, 23);
            this.CustomerNameField.TabIndex = 0;
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label14.Location = new System.Drawing.Point(8, 13);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(118, 18);
            this.label14.TabIndex = 57;
            this.label14.Text = "Customer Name";
            // 
            // ContactNumberField
            // 
            this.ContactNumberField.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ContactNumberField.Location = new System.Drawing.Point(135, 41);
            this.ContactNumberField.Name = "ContactNumberField";
            this.ContactNumberField.Size = new System.Drawing.Size(155, 23);
            this.ContactNumberField.TabIndex = 2;
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label15.Location = new System.Drawing.Point(8, 42);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(84, 18);
            this.label15.TabIndex = 60;
            this.label15.Text = "Contact No";
            // 
            // DateLabel
            // 
            this.DateLabel.AutoSize = true;
            this.DateLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.DateLabel.Location = new System.Drawing.Point(457, 42);
            this.DateLabel.Name = "DateLabel";
            this.DateLabel.Size = new System.Drawing.Size(101, 18);
            this.DateLabel.TabIndex = 61;
            this.DateLabel.Text = "Invoice Date";
            this.DateLabel.Visible = false;
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label11.Location = new System.Drawing.Point(334, 108);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(27, 15);
            this.label11.TabIndex = 63;
            this.label11.Text = "Tax";
            // 
            // ItemTaxField
            // 
            this.ItemTaxField.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ItemTaxField.Location = new System.Drawing.Point(337, 129);
            this.ItemTaxField.Name = "ItemTaxField";
            this.ItemTaxField.Size = new System.Drawing.Size(48, 23);
            this.ItemTaxField.TabIndex = 6;
            // 
            // dateTimePicker1
            // 
            this.dateTimePicker1.Location = new System.Drawing.Point(393, 42);
            this.dateTimePicker1.Name = "dateTimePicker1";
            this.dateTimePicker1.Size = new System.Drawing.Size(200, 20);
            this.dateTimePicker1.TabIndex = 64;
            // 
            // existingproductlist
            // 
            this.existingproductlist.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.existingproductlist.FormattingEnabled = true;
            this.existingproductlist.Location = new System.Drawing.Point(626, 83);
            this.existingproductlist.Name = "existingproductlist";
            this.existingproductlist.Size = new System.Drawing.Size(282, 485);
            this.existingproductlist.Sorted = true;
            this.existingproductlist.TabIndex = 118;
            this.existingproductlist.DoubleClick += new System.EventHandler(this.existingproductlist_DoubleClick);
            // 
            // label17
            // 
            this.label17.AutoSize = true;
            this.label17.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label17.Location = new System.Drawing.Point(623, 51);
            this.label17.Name = "label17";
            this.label17.Size = new System.Drawing.Size(68, 18);
            this.label17.TabIndex = 117;
            this.label17.Text = "Products";
            // 
            // existingcategorieslist
            // 
            this.existingcategorieslist.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend;
            this.existingcategorieslist.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.existingcategorieslist.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.existingcategorieslist.FormattingEnabled = true;
            this.existingcategorieslist.Location = new System.Drawing.Point(697, 13);
            this.existingcategorieslist.Name = "existingcategorieslist";
            this.existingcategorieslist.Size = new System.Drawing.Size(212, 24);
            this.existingcategorieslist.TabIndex = 116;
            this.existingcategorieslist.SelectedIndexChanged += new System.EventHandler(this.existingcategorieslist_SelectedIndexChanged);
            // 
            // label16
            // 
            this.label16.AutoSize = true;
            this.label16.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label16.Location = new System.Drawing.Point(623, 14);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(68, 18);
            this.label16.TabIndex = 115;
            this.label16.Text = "Category";
            // 
            // prevpurchasesbutton
            // 
            this.prevpurchasesbutton.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.prevpurchasesbutton.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.prevpurchasesbutton.Location = new System.Drawing.Point(353, 579);
            this.prevpurchasesbutton.Name = "prevpurchasesbutton";
            this.prevpurchasesbutton.Size = new System.Drawing.Size(240, 36);
            this.prevpurchasesbutton.TabIndex = 119;
            this.prevpurchasesbutton.Text = "Previous Sales";
            this.prevpurchasesbutton.UseVisualStyleBackColor = false;
            this.prevpurchasesbutton.Visible = false;
            // 
            // label18
            // 
            this.label18.AutoSize = true;
            this.label18.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label18.ForeColor = System.Drawing.Color.Black;
            this.label18.Location = new System.Drawing.Point(354, 79);
            this.label18.Name = "label18";
            this.label18.Size = new System.Drawing.Size(100, 18);
            this.label18.TabIndex = 121;
            this.label18.Text = "Product Code";
            // 
            // ProductCodeField
            // 
            this.ProductCodeField.Enabled = false;
            this.ProductCodeField.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ProductCodeField.Location = new System.Drawing.Point(465, 77);
            this.ProductCodeField.Name = "ProductCodeField";
            this.ProductCodeField.Size = new System.Drawing.Size(128, 23);
            this.ProductCodeField.TabIndex = 120;
            // 
            // SalesForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.CancelButton = this.CloseSaleFormBtn;
            this.ClientSize = new System.Drawing.Size(934, 627);
            this.ControlBox = false;
            this.Controls.Add(this.label18);
            this.Controls.Add(this.ProductCodeField);
            this.Controls.Add(this.prevpurchasesbutton);
            this.Controls.Add(this.existingproductlist);
            this.Controls.Add(this.label17);
            this.Controls.Add(this.existingcategorieslist);
            this.Controls.Add(this.label16);
            this.Controls.Add(this.dateTimePicker1);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.ItemTaxField);
            this.Controls.Add(this.DateLabel);
            this.Controls.Add(this.label15);
            this.Controls.Add(this.ContactNumberField);
            this.Controls.Add(this.CustomerNameField);
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
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "SalesForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Sales";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.SalesForm_KeyDown);
            this.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.SalesForm_KeyPress);
            ((System.ComponentModel.ISupportInitialize)(this.SaleItemsList)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView SaleItemsList;
        private System.Windows.Forms.TextBox QuantityField;
        private System.Windows.Forms.TextBox PriceField;
        private System.Windows.Forms.TextBox DiscountField;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox TotalSaleField;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox TaxAppliedField;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox TotalDiscountField;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox AmountPaidField;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.TextBox BalanceField;
        private System.Windows.Forms.Button PrintReceiptBtn;
        private System.Windows.Forms.Button AddToSaleListBtn;
        private System.Windows.Forms.Button ClearSaleBtn;
        private System.Windows.Forms.Button DeleteSaleItemBtn;
        private System.Windows.Forms.Button HoldSaleBtn;
        private System.Windows.Forms.Button CheckOutBtn;
        private System.Windows.Forms.Button SubTotalBtn;
        private System.Windows.Forms.Button CloseSaleFormBtn;
        private System.Windows.Forms.ComboBox ProductList;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.TextBox BarCodeField;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.TextBox OrderIDField;
        private System.Windows.Forms.TextBox CustomerNameField;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.TextBox ContactNumberField;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.Label DateLabel;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.TextBox ItemTaxField;
        private System.Windows.Forms.DateTimePicker dateTimePicker1;
        private System.Windows.Forms.ListBox existingproductlist;
        private System.Windows.Forms.Label label17;
        private System.Windows.Forms.ComboBox existingcategorieslist;
        private System.Windows.Forms.Label label16;
        private System.Windows.Forms.Button prevpurchasesbutton;
        private System.Windows.Forms.Label label18;
        private System.Windows.Forms.TextBox ProductCodeField;
    }
}

