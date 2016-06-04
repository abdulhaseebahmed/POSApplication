namespace POSApplication
{
    partial class PurchasesForm
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
            this.PreviousSaleBtn = new System.Windows.Forms.Button();
            this.NextSaleBtn = new System.Windows.Forms.Button();
            this.FirstSaleButton = new System.Windows.Forms.Button();
            this.LastSaleBtn = new System.Windows.Forms.Button();
            this.productList = new System.Windows.Forms.ComboBox();
            this.label10 = new System.Windows.Forms.Label();
            this.BarCodeField = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.SaleItemsList)).BeginInit();
            this.SuspendLayout();
            // 
            // SaleItemsList
            // 
            this.SaleItemsList.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.SaleItemsList.DefaultCellStyle = dataGridViewCellStyle1;
            this.SaleItemsList.Location = new System.Drawing.Point(12, 99);
            this.SaleItemsList.Name = "SaleItemsList";
            this.SaleItemsList.Size = new System.Drawing.Size(497, 202);
            this.SaleItemsList.TabIndex = 3;
            this.SaleItemsList.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            // 
            // QuantityField
            // 
            this.QuantityField.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.QuantityField.Location = new System.Drawing.Point(229, 67);
            this.QuantityField.Name = "QuantityField";
            this.QuantityField.Size = new System.Drawing.Size(64, 23);
            this.QuantityField.TabIndex = 4;
            this.QuantityField.Text = "sdfsdf";
            // 
            // PriceField
            // 
            this.PriceField.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.PriceField.Location = new System.Drawing.Point(297, 67);
            this.PriceField.Name = "PriceField";
            this.PriceField.Size = new System.Drawing.Size(64, 23);
            this.PriceField.TabIndex = 5;
            this.PriceField.Text = "sdfsdf";
            // 
            // DiscountField
            // 
            this.DiscountField.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.DiscountField.Location = new System.Drawing.Point(365, 67);
            this.DiscountField.Name = "DiscountField";
            this.DiscountField.Size = new System.Drawing.Size(64, 23);
            this.DiscountField.TabIndex = 6;
            this.DiscountField.Text = "sdfsdf";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(8, 44);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(60, 18);
            this.label2.TabIndex = 8;
            this.label2.Text = "Product";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(226, 46);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(62, 18);
            this.label3.TabIndex = 9;
            this.label3.Text = "Quantity";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(294, 46);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(42, 18);
            this.label4.TabIndex = 10;
            this.label4.Text = "Price";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(361, 46);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(67, 18);
            this.label5.TabIndex = 11;
            this.label5.Text = "Discount";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(325, 354);
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
            this.TotalSaleField.Location = new System.Drawing.Point(389, 351);
            this.TotalSaleField.Name = "TotalSaleField";
            this.TotalSaleField.Size = new System.Drawing.Size(120, 26);
            this.TotalSaleField.TabIndex = 12;
            this.TotalSaleField.Text = "sdfsdf";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(335, 386);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(37, 20);
            this.label6.TabIndex = 15;
            this.label6.Text = "Tax";
            // 
            // TaxAppliedField
            // 
            this.TaxAppliedField.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TaxAppliedField.ForeColor = System.Drawing.Color.Crimson;
            this.TaxAppliedField.Location = new System.Drawing.Point(389, 383);
            this.TaxAppliedField.Name = "TaxAppliedField";
            this.TaxAppliedField.Size = new System.Drawing.Size(120, 26);
            this.TaxAppliedField.TabIndex = 14;
            this.TaxAppliedField.Text = "sdfsdf";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(297, 418);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(80, 20);
            this.label7.TabIndex = 17;
            this.label7.Text = "Discount";
            // 
            // TotalDiscountField
            // 
            this.TotalDiscountField.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TotalDiscountField.ForeColor = System.Drawing.Color.Crimson;
            this.TotalDiscountField.Location = new System.Drawing.Point(389, 415);
            this.TotalDiscountField.Name = "TotalDiscountField";
            this.TotalDiscountField.Size = new System.Drawing.Size(120, 26);
            this.TotalDiscountField.TabIndex = 16;
            this.TotalDiscountField.Text = "Discount";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(269, 450);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(111, 20);
            this.label8.TabIndex = 19;
            this.label8.Text = "Amount Paid";
            // 
            // AmountPaidField
            // 
            this.AmountPaidField.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.AmountPaidField.ForeColor = System.Drawing.SystemColors.MenuHighlight;
            this.AmountPaidField.Location = new System.Drawing.Point(389, 447);
            this.AmountPaidField.Name = "AmountPaidField";
            this.AmountPaidField.Size = new System.Drawing.Size(120, 26);
            this.AmountPaidField.TabIndex = 18;
            this.AmountPaidField.Text = "sdfsdf";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.Location = new System.Drawing.Point(302, 482);
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
            this.BalanceField.Location = new System.Drawing.Point(389, 479);
            this.BalanceField.Name = "BalanceField";
            this.BalanceField.Size = new System.Drawing.Size(120, 26);
            this.BalanceField.TabIndex = 20;
            this.BalanceField.Text = "sdfsdf";
            // 
            // PrintReceiptBtn
            // 
            this.PrintReceiptBtn.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.PrintReceiptBtn.Enabled = false;
            this.PrintReceiptBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.PrintReceiptBtn.Location = new System.Drawing.Point(269, 511);
            this.PrintReceiptBtn.Name = "PrintReceiptBtn";
            this.PrintReceiptBtn.Size = new System.Drawing.Size(120, 36);
            this.PrintReceiptBtn.TabIndex = 32;
            this.PrintReceiptBtn.Text = "Print Receipt";
            this.PrintReceiptBtn.UseVisualStyleBackColor = false;
            // 
            // AddToSaleListBtn
            // 
            this.AddToSaleListBtn.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.AddToSaleListBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.AddToSaleListBtn.Location = new System.Drawing.Point(435, 46);
            this.AddToSaleListBtn.Name = "AddToSaleListBtn";
            this.AddToSaleListBtn.Size = new System.Drawing.Size(74, 47);
            this.AddToSaleListBtn.TabIndex = 34;
            this.AddToSaleListBtn.Text = "Add";
            this.AddToSaleListBtn.UseVisualStyleBackColor = false;
            // 
            // ClearSaleBtn
            // 
            this.ClearSaleBtn.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClearSaleBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ClearSaleBtn.Location = new System.Drawing.Point(131, 403);
            this.ClearSaleBtn.Name = "ClearSaleBtn";
            this.ClearSaleBtn.Size = new System.Drawing.Size(108, 55);
            this.ClearSaleBtn.TabIndex = 37;
            this.ClearSaleBtn.Text = "Clear Sale";
            this.ClearSaleBtn.UseVisualStyleBackColor = false;
            // 
            // DeleteSaleItemBtn
            // 
            this.DeleteSaleItemBtn.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.DeleteSaleItemBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.DeleteSaleItemBtn.Location = new System.Drawing.Point(131, 342);
            this.DeleteSaleItemBtn.Name = "DeleteSaleItemBtn";
            this.DeleteSaleItemBtn.Size = new System.Drawing.Size(108, 55);
            this.DeleteSaleItemBtn.TabIndex = 38;
            this.DeleteSaleItemBtn.Text = "Delete Line";
            this.DeleteSaleItemBtn.UseVisualStyleBackColor = false;
            // 
            // HoldSaleBtn
            // 
            this.HoldSaleBtn.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.HoldSaleBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.HoldSaleBtn.Location = new System.Drawing.Point(12, 403);
            this.HoldSaleBtn.Name = "HoldSaleBtn";
            this.HoldSaleBtn.Size = new System.Drawing.Size(108, 55);
            this.HoldSaleBtn.TabIndex = 39;
            this.HoldSaleBtn.Text = "Hold Sale";
            this.HoldSaleBtn.UseVisualStyleBackColor = false;
            // 
            // CheckOutBtn
            // 
            this.CheckOutBtn.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.CheckOutBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CheckOutBtn.Location = new System.Drawing.Point(11, 467);
            this.CheckOutBtn.Name = "CheckOutBtn";
            this.CheckOutBtn.Size = new System.Drawing.Size(228, 80);
            this.CheckOutBtn.TabIndex = 40;
            this.CheckOutBtn.Text = "CHECKOUT";
            this.CheckOutBtn.UseVisualStyleBackColor = false;
            // 
            // SubTotalBtn
            // 
            this.SubTotalBtn.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.SubTotalBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.SubTotalBtn.Location = new System.Drawing.Point(11, 342);
            this.SubTotalBtn.Name = "SubTotalBtn";
            this.SubTotalBtn.Size = new System.Drawing.Size(108, 55);
            this.SubTotalBtn.TabIndex = 41;
            this.SubTotalBtn.Text = "Sub Total";
            this.SubTotalBtn.UseVisualStyleBackColor = false;
            // 
            // CloseSaleFormBtn
            // 
            this.CloseSaleFormBtn.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.CloseSaleFormBtn.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.CloseSaleFormBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CloseSaleFormBtn.Location = new System.Drawing.Point(395, 511);
            this.CloseSaleFormBtn.Name = "CloseSaleFormBtn";
            this.CloseSaleFormBtn.Size = new System.Drawing.Size(114, 36);
            this.CloseSaleFormBtn.TabIndex = 42;
            this.CloseSaleFormBtn.Text = "Close";
            this.CloseSaleFormBtn.UseVisualStyleBackColor = false;
            // 
            // PreviousSaleBtn
            // 
            this.PreviousSaleBtn.BackColor = System.Drawing.Color.OrangeRed;
            this.PreviousSaleBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.PreviousSaleBtn.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.PreviousSaleBtn.Location = new System.Drawing.Point(11, 307);
            this.PreviousSaleBtn.Name = "PreviousSaleBtn";
            this.PreviousSaleBtn.Size = new System.Drawing.Size(74, 29);
            this.PreviousSaleBtn.TabIndex = 43;
            this.PreviousSaleBtn.Text = "<<";
            this.PreviousSaleBtn.UseVisualStyleBackColor = false;
            // 
            // NextSaleBtn
            // 
            this.NextSaleBtn.BackColor = System.Drawing.Color.OrangeRed;
            this.NextSaleBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.NextSaleBtn.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.NextSaleBtn.Location = new System.Drawing.Point(435, 307);
            this.NextSaleBtn.Name = "NextSaleBtn";
            this.NextSaleBtn.Size = new System.Drawing.Size(74, 29);
            this.NextSaleBtn.TabIndex = 44;
            this.NextSaleBtn.Text = ">>";
            this.NextSaleBtn.UseVisualStyleBackColor = false;
            // 
            // FirstSaleButton
            // 
            this.FirstSaleButton.BackColor = System.Drawing.Color.OrangeRed;
            this.FirstSaleButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FirstSaleButton.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.FirstSaleButton.Location = new System.Drawing.Point(91, 307);
            this.FirstSaleButton.Name = "FirstSaleButton";
            this.FirstSaleButton.Size = new System.Drawing.Size(74, 29);
            this.FirstSaleButton.TabIndex = 45;
            this.FirstSaleButton.Text = "I<";
            this.FirstSaleButton.UseVisualStyleBackColor = false;
            // 
            // LastSaleBtn
            // 
            this.LastSaleBtn.BackColor = System.Drawing.Color.OrangeRed;
            this.LastSaleBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LastSaleBtn.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.LastSaleBtn.Location = new System.Drawing.Point(354, 307);
            this.LastSaleBtn.Name = "LastSaleBtn";
            this.LastSaleBtn.Size = new System.Drawing.Size(74, 29);
            this.LastSaleBtn.TabIndex = 46;
            this.LastSaleBtn.Text = ">I";
            this.LastSaleBtn.UseVisualStyleBackColor = false;
            // 
            // productList
            // 
            this.productList.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend;
            this.productList.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.productList.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.productList.FormattingEnabled = true;
            this.productList.Location = new System.Drawing.Point(12, 67);
            this.productList.Name = "productList";
            this.productList.Size = new System.Drawing.Size(211, 24);
            this.productList.TabIndex = 47;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.Location = new System.Drawing.Point(9, 12);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(134, 18);
            this.label10.TabIndex = 49;
            this.label10.Text = "Barcode Scan Item";
            // 
            // BarCodeField
            // 
            this.BarCodeField.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BarCodeField.Location = new System.Drawing.Point(149, 12);
            this.BarCodeField.Name = "BarCodeField";
            this.BarCodeField.Size = new System.Drawing.Size(360, 23);
            this.BarCodeField.TabIndex = 48;
            this.BarCodeField.Text = "sdfsdf";
            // 
            // PurchasesForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.CancelButton = this.CloseSaleFormBtn;
            this.ClientSize = new System.Drawing.Size(521, 556);
            this.ControlBox = false;
            this.Controls.Add(this.label10);
            this.Controls.Add(this.BarCodeField);
            this.Controls.Add(this.productList);
            this.Controls.Add(this.LastSaleBtn);
            this.Controls.Add(this.FirstSaleButton);
            this.Controls.Add(this.NextSaleBtn);
            this.Controls.Add(this.PreviousSaleBtn);
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
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "PurchasesForm";
            this.Text = "Purchases";
            this.Load += new System.EventHandler(this.Form1_Load);
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
        private System.Windows.Forms.Button PreviousSaleBtn;
        private System.Windows.Forms.Button NextSaleBtn;
        private System.Windows.Forms.Button FirstSaleButton;
        private System.Windows.Forms.Button LastSaleBtn;
        private System.Windows.Forms.ComboBox productList;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.TextBox BarCodeField;

    }
}

