namespace POSApplication.Forms
{
    partial class InventoryLevels
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(InventoryLevels));
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.ProductNameField = new System.Windows.Forms.TextBox();
            this.CategoryList = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.ReOrderLevelField = new System.Windows.Forms.TextBox();
            this.label12 = new System.Windows.Forms.Label();
            this.SalePriceField = new System.Windows.Forms.TextBox();
            this.ProductImage = new System.Windows.Forms.PictureBox();
            this.BarCodeField = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.QuantityField = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.PurchaseDateField = new System.Windows.Forms.TextBox();
            this.CostPriceField = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.CloseButton = new System.Windows.Forms.Button();
            this.OkBtn = new System.Windows.Forms.Button();
            this.ExistingProductsList = new System.Windows.Forms.ListBox();
            this.ExistingCategoryList = new System.Windows.Forms.ComboBox();
            this.label9 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.ProductImage)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.ProductNameField);
            this.groupBox1.Controls.Add(this.CategoryList);
            this.groupBox1.Controls.Add(this.label8);
            this.groupBox1.Controls.Add(this.ReOrderLevelField);
            this.groupBox1.Controls.Add(this.label12);
            this.groupBox1.Controls.Add(this.SalePriceField);
            this.groupBox1.Controls.Add(this.ProductImage);
            this.groupBox1.Controls.Add(this.BarCodeField);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.label7);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.QuantityField);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.PurchaseDateField);
            this.groupBox1.Controls.Add(this.CostPriceField);
            this.groupBox1.Controls.Add(this.label6);
            this.groupBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.ForeColor = System.Drawing.Color.Black;
            this.groupBox1.Location = new System.Drawing.Point(26, 23);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(390, 401);
            this.groupBox1.TabIndex = 96;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Current Inventory Levels";
            // 
            // ProductNameField
            // 
            this.ProductNameField.Enabled = false;
            this.ProductNameField.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ProductNameField.Location = new System.Drawing.Point(151, 75);
            this.ProductNameField.Name = "ProductNameField";
            this.ProductNameField.Size = new System.Drawing.Size(222, 23);
            this.ProductNameField.TabIndex = 100;
            // 
            // CategoryList
            // 
            this.CategoryList.Enabled = false;
            this.CategoryList.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CategoryList.Location = new System.Drawing.Point(151, 46);
            this.CategoryList.Name = "CategoryList";
            this.CategoryList.Size = new System.Drawing.Size(222, 23);
            this.CategoryList.TabIndex = 99;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.ForeColor = System.Drawing.Color.Black;
            this.label8.Location = new System.Drawing.Point(214, 108);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(96, 17);
            this.label8.TabIndex = 97;
            this.label8.Text = "ReOrder level";
            // 
            // ReOrderLevelField
            // 
            this.ReOrderLevelField.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ReOrderLevelField.Location = new System.Drawing.Point(316, 105);
            this.ReOrderLevelField.Name = "ReOrderLevelField";
            this.ReOrderLevelField.Size = new System.Drawing.Size(57, 23);
            this.ReOrderLevelField.TabIndex = 98;
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label12.ForeColor = System.Drawing.Color.Black;
            this.label12.Location = new System.Drawing.Point(16, 166);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(72, 17);
            this.label12.TabIndex = 95;
            this.label12.Text = "Sale Price";
            // 
            // SalePriceField
            // 
            this.SalePriceField.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.SalePriceField.Location = new System.Drawing.Point(151, 163);
            this.SalePriceField.Name = "SalePriceField";
            this.SalePriceField.Size = new System.Drawing.Size(98, 23);
            this.SalePriceField.TabIndex = 96;
            // 
            // ProductImage
            // 
            this.ProductImage.Location = new System.Drawing.Point(208, 250);
            this.ProductImage.Name = "ProductImage";
            this.ProductImage.Size = new System.Drawing.Size(165, 143);
            this.ProductImage.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.ProductImage.TabIndex = 90;
            this.ProductImage.TabStop = false;
            this.ProductImage.Click += new System.EventHandler(this.ProductImage2_Click);
            // 
            // BarCodeField
            // 
            this.BarCodeField.Enabled = false;
            this.BarCodeField.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BarCodeField.Location = new System.Drawing.Point(151, 221);
            this.BarCodeField.Name = "BarCodeField";
            this.BarCodeField.Size = new System.Drawing.Size(222, 23);
            this.BarCodeField.TabIndex = 94;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Black;
            this.label1.Location = new System.Drawing.Point(16, 78);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(98, 17);
            this.label1.TabIndex = 75;
            this.label1.Text = "Product Name";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.ForeColor = System.Drawing.Color.Black;
            this.label7.Location = new System.Drawing.Point(16, 224);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(61, 17);
            this.label7.TabIndex = 93;
            this.label7.Text = "Barcode";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.Black;
            this.label2.Location = new System.Drawing.Point(16, 108);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(115, 17);
            this.label2.TabIndex = 77;
            this.label2.Text = "Quantity in Stock";
            // 
            // QuantityField
            // 
            this.QuantityField.Enabled = false;
            this.QuantityField.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.QuantityField.Location = new System.Drawing.Point(151, 105);
            this.QuantityField.Name = "QuantityField";
            this.QuantityField.Size = new System.Drawing.Size(57, 23);
            this.QuantityField.TabIndex = 78;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.Black;
            this.label4.Location = new System.Drawing.Point(16, 49);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(65, 17);
            this.label4.TabIndex = 83;
            this.label4.Text = "Category";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.Black;
            this.label3.Location = new System.Drawing.Point(16, 247);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(46, 17);
            this.label3.TabIndex = 89;
            this.label3.Text = "Image";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.Color.Black;
            this.label5.Location = new System.Drawing.Point(16, 137);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(72, 17);
            this.label5.TabIndex = 85;
            this.label5.Text = "Cost Price";
            // 
            // PurchaseDateField
            // 
            this.PurchaseDateField.Enabled = false;
            this.PurchaseDateField.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.PurchaseDateField.Location = new System.Drawing.Point(151, 192);
            this.PurchaseDateField.Name = "PurchaseDateField";
            this.PurchaseDateField.Size = new System.Drawing.Size(98, 23);
            this.PurchaseDateField.TabIndex = 88;
            // 
            // CostPriceField
            // 
            this.CostPriceField.Enabled = false;
            this.CostPriceField.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CostPriceField.Location = new System.Drawing.Point(151, 134);
            this.CostPriceField.Name = "CostPriceField";
            this.CostPriceField.Size = new System.Drawing.Size(98, 23);
            this.CostPriceField.TabIndex = 86;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.ForeColor = System.Drawing.Color.Black;
            this.label6.Location = new System.Drawing.Point(16, 195);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(133, 17);
            this.label6.TabIndex = 87;
            this.label6.Text = "Last Purchase Date";
            // 
            // CloseButton
            // 
            this.CloseButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CloseButton.Image = ((System.Drawing.Image)(resources.GetObject("CloseButton.Image")));
            this.CloseButton.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.CloseButton.Location = new System.Drawing.Point(622, 441);
            this.CloseButton.Name = "CloseButton";
            this.CloseButton.Padding = new System.Windows.Forms.Padding(5, 0, 0, 0);
            this.CloseButton.Size = new System.Drawing.Size(137, 43);
            this.CloseButton.TabIndex = 97;
            this.CloseButton.Text = "Close";
            this.CloseButton.UseVisualStyleBackColor = true;
            this.CloseButton.Click += new System.EventHandler(this.CloseButton_Click);
            // 
            // OkBtn
            // 
            this.OkBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.OkBtn.Image = ((System.Drawing.Image)(resources.GetObject("OkBtn.Image")));
            this.OkBtn.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.OkBtn.Location = new System.Drawing.Point(422, 441);
            this.OkBtn.Name = "OkBtn";
            this.OkBtn.Padding = new System.Windows.Forms.Padding(5, 0, 0, 0);
            this.OkBtn.Size = new System.Drawing.Size(194, 43);
            this.OkBtn.TabIndex = 98;
            this.OkBtn.Text = "Save Changes";
            this.OkBtn.UseVisualStyleBackColor = true;
            this.OkBtn.Click += new System.EventHandler(this.OkBtn_Click);
            // 
            // ExistingProductsList
            // 
            this.ExistingProductsList.FormattingEnabled = true;
            this.ExistingProductsList.Location = new System.Drawing.Point(532, 101);
            this.ExistingProductsList.Name = "ExistingProductsList";
            this.ExistingProductsList.Size = new System.Drawing.Size(227, 316);
            this.ExistingProductsList.TabIndex = 126;
            this.ExistingProductsList.SelectedIndexChanged += new System.EventHandler(this.ExistingProductsList_SelectedIndexChanged);
            this.ExistingProductsList.DoubleClick += new System.EventHandler(this.ExistingProductsList_DoubleClick);
            // 
            // ExistingCategoryList
            // 
            this.ExistingCategoryList.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ExistingCategoryList.FormattingEnabled = true;
            this.ExistingCategoryList.Location = new System.Drawing.Point(532, 72);
            this.ExistingCategoryList.Name = "ExistingCategoryList";
            this.ExistingCategoryList.Size = new System.Drawing.Size(227, 24);
            this.ExistingCategoryList.TabIndex = 125;
            this.ExistingCategoryList.SelectedIndexChanged += new System.EventHandler(this.ExistingCategoryList_SelectedIndexChanged);
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.ForeColor = System.Drawing.Color.Black;
            this.label9.Location = new System.Drawing.Point(443, 98);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(57, 17);
            this.label9.TabIndex = 124;
            this.label9.Text = "Product";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.ForeColor = System.Drawing.Color.Black;
            this.label10.Location = new System.Drawing.Point(443, 71);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(65, 17);
            this.label10.TabIndex = 123;
            this.label10.Text = "Category";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label11.ForeColor = System.Drawing.Color.Black;
            this.label11.Location = new System.Drawing.Point(443, 37);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(133, 17);
            this.label11.TabIndex = 127;
            this.label11.Text = "Existing Products";
            // 
            // InventoryLevels
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(774, 507);
            this.ControlBox = false;
            this.Controls.Add(this.label11);
            this.Controls.Add(this.ExistingProductsList);
            this.Controls.Add(this.ExistingCategoryList);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.OkBtn);
            this.Controls.Add(this.CloseButton);
            this.Controls.Add(this.groupBox1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Name = "InventoryLevels";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Current Inventory Levels";
            this.Load += new System.EventHandler(this.InventoryLevels_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.ProductImage)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.TextBox SalePriceField;
        private System.Windows.Forms.PictureBox ProductImage;
        private System.Windows.Forms.TextBox BarCodeField;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox QuantityField;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox PurchaseDateField;
        private System.Windows.Forms.TextBox CostPriceField;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Button CloseButton;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox ReOrderLevelField;
        private System.Windows.Forms.Button OkBtn;
        private System.Windows.Forms.ListBox ExistingProductsList;
        private System.Windows.Forms.ComboBox ExistingCategoryList;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.TextBox ProductNameField;
        private System.Windows.Forms.TextBox CategoryList;
    }
}