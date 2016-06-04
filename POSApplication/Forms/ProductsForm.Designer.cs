namespace POSApplication.Forms
{
    partial class ProductsForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ProductsForm));
            this.CloseButton = new System.Windows.Forms.Button();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.NewProductButton = new System.Windows.Forms.Button();
            this.ProductCodeField = new System.Windows.Forms.TextBox();
            this.label12 = new System.Windows.Forms.Label();
            this.ColorField = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.WeightField = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.HeightField = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.WidthField = new System.Windows.Forms.TextBox();
            this.SizeField = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.GuaranteeField = new System.Windows.Forms.TextBox();
            this.WarrantyField = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.ExistingProductsList = new System.Windows.Forms.ListBox();
            this.ExistingCategoryList = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.DeleteProductButton = new System.Windows.Forms.Button();
            this.SuppliersList = new System.Windows.Forms.ComboBox();
            this.label17 = new System.Windows.Forms.Label();
            this.SaveProductButton = new System.Windows.Forms.Button();
            this.BrowseButton = new System.Windows.Forms.Button();
            this.ProductNameField = new System.Windows.Forms.TextBox();
            this.ProductImage = new System.Windows.Forms.PictureBox();
            this.ProductBarcodeField = new System.Windows.Forms.TextBox();
            this.label10 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.CategoryList = new System.Windows.Forms.ComboBox();
            this.label13 = new System.Windows.Forms.Label();
            this.label15 = new System.Windows.Forms.Label();
            this.ProductDescriptionField = new System.Windows.Forms.TextBox();
            this.NewSupplierButton = new System.Windows.Forms.Button();
            this.NewCategoryButton = new System.Windows.Forms.Button();
            this.ClearImageButton = new System.Windows.Forms.Button();
            this.groupBox2.SuspendLayout();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.ProductImage)).BeginInit();
            this.SuspendLayout();
            // 
            // CloseButton
            // 
            this.CloseButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CloseButton.Image = ((System.Drawing.Image)(resources.GetObject("CloseButton.Image")));
            this.CloseButton.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.CloseButton.Location = new System.Drawing.Point(785, 430);
            this.CloseButton.Name = "CloseButton";
            this.CloseButton.Padding = new System.Windows.Forms.Padding(5, 0, 0, 0);
            this.CloseButton.Size = new System.Drawing.Size(137, 43);
            this.CloseButton.TabIndex = 82;
            this.CloseButton.Text = "Close";
            this.CloseButton.UseVisualStyleBackColor = true;
            this.CloseButton.Click += new System.EventHandler(this.CloseButton_Click);
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.ClearImageButton);
            this.groupBox2.Controls.Add(this.NewProductButton);
            this.groupBox2.Controls.Add(this.ProductCodeField);
            this.groupBox2.Controls.Add(this.label12);
            this.groupBox2.Controls.Add(this.ColorField);
            this.groupBox2.Controls.Add(this.label9);
            this.groupBox2.Controls.Add(this.WeightField);
            this.groupBox2.Controls.Add(this.label8);
            this.groupBox2.Controls.Add(this.HeightField);
            this.groupBox2.Controls.Add(this.label5);
            this.groupBox2.Controls.Add(this.WidthField);
            this.groupBox2.Controls.Add(this.SizeField);
            this.groupBox2.Controls.Add(this.label3);
            this.groupBox2.Controls.Add(this.label4);
            this.groupBox2.Controls.Add(this.GuaranteeField);
            this.groupBox2.Controls.Add(this.WarrantyField);
            this.groupBox2.Controls.Add(this.label6);
            this.groupBox2.Controls.Add(this.label7);
            this.groupBox2.Controls.Add(this.groupBox1);
            this.groupBox2.Controls.Add(this.SuppliersList);
            this.groupBox2.Controls.Add(this.label17);
            this.groupBox2.Controls.Add(this.SaveProductButton);
            this.groupBox2.Controls.Add(this.BrowseButton);
            this.groupBox2.Controls.Add(this.ProductNameField);
            this.groupBox2.Controls.Add(this.ProductImage);
            this.groupBox2.Controls.Add(this.ProductBarcodeField);
            this.groupBox2.Controls.Add(this.label10);
            this.groupBox2.Controls.Add(this.label11);
            this.groupBox2.Controls.Add(this.CategoryList);
            this.groupBox2.Controls.Add(this.label13);
            this.groupBox2.Controls.Add(this.label15);
            this.groupBox2.Controls.Add(this.ProductDescriptionField);
            this.groupBox2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox2.ForeColor = System.Drawing.Color.Black;
            this.groupBox2.Location = new System.Drawing.Point(12, 12);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(946, 408);
            this.groupBox2.TabIndex = 98;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Create New Product";
            // 
            // NewProductButton
            // 
            this.NewProductButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.5F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.NewProductButton.ForeColor = System.Drawing.Color.DarkOrange;
            this.NewProductButton.Location = new System.Drawing.Point(422, 314);
            this.NewProductButton.Name = "NewProductButton";
            this.NewProductButton.Size = new System.Drawing.Size(126, 37);
            this.NewProductButton.TabIndex = 128;
            this.NewProductButton.Text = "New";
            this.NewProductButton.UseVisualStyleBackColor = true;
            this.NewProductButton.Click += new System.EventHandler(this.New_Button_Click);
            // 
            // ProductCodeField
            // 
            this.ProductCodeField.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ProductCodeField.Location = new System.Drawing.Point(433, 61);
            this.ProductCodeField.MaxLength = 30;
            this.ProductCodeField.Name = "ProductCodeField";
            this.ProductCodeField.Size = new System.Drawing.Size(116, 23);
            this.ProductCodeField.TabIndex = 127;
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label12.ForeColor = System.Drawing.Color.Black;
            this.label12.Location = new System.Drawing.Point(333, 61);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(94, 17);
            this.label12.TabIndex = 126;
            this.label12.Text = "Product Code";
            // 
            // ColorField
            // 
            this.ColorField.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ColorField.Location = new System.Drawing.Point(475, 209);
            this.ColorField.Name = "ColorField";
            this.ColorField.Size = new System.Drawing.Size(74, 23);
            this.ColorField.TabIndex = 125;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.ForeColor = System.Drawing.Color.Black;
            this.label9.Location = new System.Drawing.Point(333, 212);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(41, 17);
            this.label9.TabIndex = 124;
            this.label9.Text = "Color";
            // 
            // WeightField
            // 
            this.WeightField.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.WeightField.Location = new System.Drawing.Point(475, 180);
            this.WeightField.Name = "WeightField";
            this.WeightField.Size = new System.Drawing.Size(74, 23);
            this.WeightField.TabIndex = 123;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.ForeColor = System.Drawing.Color.Black;
            this.label8.Location = new System.Drawing.Point(333, 182);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(52, 17);
            this.label8.TabIndex = 122;
            this.label8.Text = "Weight";
            // 
            // HeightField
            // 
            this.HeightField.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.HeightField.Location = new System.Drawing.Point(475, 150);
            this.HeightField.Name = "HeightField";
            this.HeightField.Size = new System.Drawing.Size(74, 23);
            this.HeightField.TabIndex = 121;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.Color.Black;
            this.label5.Location = new System.Drawing.Point(333, 153);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(49, 17);
            this.label5.TabIndex = 120;
            this.label5.Text = "Height";
            // 
            // WidthField
            // 
            this.WidthField.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.WidthField.Location = new System.Drawing.Point(475, 121);
            this.WidthField.Name = "WidthField";
            this.WidthField.Size = new System.Drawing.Size(74, 23);
            this.WidthField.TabIndex = 119;
            // 
            // SizeField
            // 
            this.SizeField.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.SizeField.Location = new System.Drawing.Point(474, 90);
            this.SizeField.Name = "SizeField";
            this.SizeField.Size = new System.Drawing.Size(74, 23);
            this.SizeField.TabIndex = 118;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.Black;
            this.label3.Location = new System.Drawing.Point(333, 93);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(35, 17);
            this.label3.TabIndex = 116;
            this.label3.Text = "Size";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.Black;
            this.label4.Location = new System.Drawing.Point(333, 122);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(44, 17);
            this.label4.TabIndex = 117;
            this.label4.Text = "Width";
            // 
            // GuaranteeField
            // 
            this.GuaranteeField.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.GuaranteeField.Location = new System.Drawing.Point(279, 209);
            this.GuaranteeField.MaxLength = 2;
            this.GuaranteeField.Name = "GuaranteeField";
            this.GuaranteeField.Size = new System.Drawing.Size(34, 23);
            this.GuaranteeField.TabIndex = 115;
            // 
            // WarrantyField
            // 
            this.WarrantyField.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.WarrantyField.Location = new System.Drawing.Point(279, 180);
            this.WarrantyField.MaxLength = 2;
            this.WarrantyField.Name = "WarrantyField";
            this.WarrantyField.Size = new System.Drawing.Size(34, 23);
            this.WarrantyField.TabIndex = 114;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.ForeColor = System.Drawing.Color.Black;
            this.label6.Location = new System.Drawing.Point(6, 183);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(107, 17);
            this.label6.TabIndex = 112;
            this.label6.Text = "Warranty Years";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.ForeColor = System.Drawing.Color.Black;
            this.label7.Location = new System.Drawing.Point(6, 212);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(117, 17);
            this.label7.TabIndex = 113;
            this.label7.Text = "Guarantee Years";
            // 
            // groupBox1
            // 
            this.groupBox1.BackColor = System.Drawing.Color.LightGray;
            this.groupBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.groupBox1.Controls.Add(this.ExistingProductsList);
            this.groupBox1.Controls.Add(this.ExistingCategoryList);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.DeleteProductButton);
            this.groupBox1.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.groupBox1.Location = new System.Drawing.Point(561, 14);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(378, 394);
            this.groupBox1.TabIndex = 111;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Existing Products";
            // 
            // ExistingProductsList
            // 
            this.ExistingProductsList.FormattingEnabled = true;
            this.ExistingProductsList.ItemHeight = 16;
            this.ExistingProductsList.Location = new System.Drawing.Point(139, 56);
            this.ExistingProductsList.Name = "ExistingProductsList";
            this.ExistingProductsList.Size = new System.Drawing.Size(227, 324);
            this.ExistingProductsList.TabIndex = 121;
            this.ExistingProductsList.SelectedIndexChanged += new System.EventHandler(this.ExistingProductsList_SelectedIndexChanged);
            this.ExistingProductsList.DoubleClick += new System.EventHandler(this.ExistingProductsList_DoubleClick);
            // 
            // ExistingCategoryList
            // 
            this.ExistingCategoryList.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ExistingCategoryList.FormattingEnabled = true;
            this.ExistingCategoryList.Location = new System.Drawing.Point(139, 22);
            this.ExistingCategoryList.Name = "ExistingCategoryList";
            this.ExistingCategoryList.Size = new System.Drawing.Size(227, 24);
            this.ExistingCategoryList.TabIndex = 120;
            this.ExistingCategoryList.SelectedIndexChanged += new System.EventHandler(this.ExistingCategoryList_SelectedIndexChanged_1);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.Black;
            this.label2.Location = new System.Drawing.Point(6, 56);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(57, 17);
            this.label2.TabIndex = 119;
            this.label2.Text = "Product";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Black;
            this.label1.Location = new System.Drawing.Point(6, 29);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(65, 17);
            this.label1.TabIndex = 118;
            this.label1.Text = "Category";
            // 
            // DeleteProductButton
            // 
            this.DeleteProductButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.5F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.DeleteProductButton.ForeColor = System.Drawing.Color.Red;
            this.DeleteProductButton.Location = new System.Drawing.Point(6, 343);
            this.DeleteProductButton.Name = "DeleteProductButton";
            this.DeleteProductButton.Size = new System.Drawing.Size(126, 37);
            this.DeleteProductButton.TabIndex = 117;
            this.DeleteProductButton.Text = "Delete";
            this.DeleteProductButton.UseVisualStyleBackColor = true;
            this.DeleteProductButton.Click += new System.EventHandler(this.DeleteProductButton_Click);
            // 
            // SuppliersList
            // 
            this.SuppliersList.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.SuppliersList.FormattingEnabled = true;
            this.SuppliersList.Location = new System.Drawing.Point(148, 120);
            this.SuppliersList.Name = "SuppliersList";
            this.SuppliersList.Size = new System.Drawing.Size(165, 24);
            this.SuppliersList.TabIndex = 106;
            // 
            // label17
            // 
            this.label17.AutoSize = true;
            this.label17.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label17.ForeColor = System.Drawing.Color.Black;
            this.label17.Location = new System.Drawing.Point(6, 124);
            this.label17.Name = "label17";
            this.label17.Size = new System.Drawing.Size(64, 17);
            this.label17.TabIndex = 105;
            this.label17.Text = "Supplier ";
            // 
            // SaveProductButton
            // 
            this.SaveProductButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.5F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.SaveProductButton.ForeColor = System.Drawing.Color.Green;
            this.SaveProductButton.Location = new System.Drawing.Point(422, 357);
            this.SaveProductButton.Name = "SaveProductButton";
            this.SaveProductButton.Size = new System.Drawing.Size(126, 37);
            this.SaveProductButton.TabIndex = 101;
            this.SaveProductButton.Text = "Save  Product";
            this.SaveProductButton.UseVisualStyleBackColor = true;
            this.SaveProductButton.Click += new System.EventHandler(this.SaveProductButton_Click);
            // 
            // BrowseButton
            // 
            this.BrowseButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.5F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BrowseButton.ForeColor = System.Drawing.Color.Black;
            this.BrowseButton.Location = new System.Drawing.Point(9, 250);
            this.BrowseButton.Name = "BrowseButton";
            this.BrowseButton.Size = new System.Drawing.Size(114, 33);
            this.BrowseButton.TabIndex = 100;
            this.BrowseButton.Text = "Browse Image";
            this.BrowseButton.UseVisualStyleBackColor = true;
            this.BrowseButton.Click += new System.EventHandler(this.BrowseButton_Click);
            // 
            // ProductNameField
            // 
            this.ProductNameField.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ProductNameField.Location = new System.Drawing.Point(148, 61);
            this.ProductNameField.Name = "ProductNameField";
            this.ProductNameField.Size = new System.Drawing.Size(165, 23);
            this.ProductNameField.TabIndex = 98;
            // 
            // ProductImage
            // 
            this.ProductImage.Location = new System.Drawing.Point(148, 250);
            this.ProductImage.Name = "ProductImage";
            this.ProductImage.Size = new System.Drawing.Size(165, 144);
            this.ProductImage.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.ProductImage.TabIndex = 90;
            this.ProductImage.TabStop = false;
            // 
            // ProductBarcodeField
            // 
            this.ProductBarcodeField.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ProductBarcodeField.Location = new System.Drawing.Point(148, 150);
            this.ProductBarcodeField.Name = "ProductBarcodeField";
            this.ProductBarcodeField.Size = new System.Drawing.Size(165, 23);
            this.ProductBarcodeField.TabIndex = 94;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.ForeColor = System.Drawing.Color.Black;
            this.label10.Location = new System.Drawing.Point(6, 64);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(107, 17);
            this.label10.TabIndex = 75;
            this.label10.Text = "Product Name *";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label11.ForeColor = System.Drawing.Color.Black;
            this.label11.Location = new System.Drawing.Point(6, 153);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(70, 17);
            this.label11.TabIndex = 93;
            this.label11.Text = "Barcode *";
            // 
            // CategoryList
            // 
            this.CategoryList.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CategoryList.FormattingEnabled = true;
            this.CategoryList.Location = new System.Drawing.Point(148, 29);
            this.CategoryList.Name = "CategoryList";
            this.CategoryList.Size = new System.Drawing.Size(165, 24);
            this.CategoryList.TabIndex = 91;
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label13.ForeColor = System.Drawing.Color.Black;
            this.label13.Location = new System.Drawing.Point(6, 32);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(74, 17);
            this.label13.TabIndex = 83;
            this.label13.Text = "Category *";
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label15.ForeColor = System.Drawing.Color.Black;
            this.label15.Location = new System.Drawing.Point(6, 93);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(132, 17);
            this.label15.TabIndex = 85;
            this.label15.Text = "Product Description";
            // 
            // ProductDescriptionField
            // 
            this.ProductDescriptionField.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ProductDescriptionField.Location = new System.Drawing.Point(148, 90);
            this.ProductDescriptionField.Name = "ProductDescriptionField";
            this.ProductDescriptionField.Size = new System.Drawing.Size(165, 23);
            this.ProductDescriptionField.TabIndex = 86;
            // 
            // NewSupplierButton
            // 
            this.NewSupplierButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.5F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.NewSupplierButton.ForeColor = System.Drawing.Color.ForestGreen;
            this.NewSupplierButton.Location = new System.Drawing.Point(12, 434);
            this.NewSupplierButton.Name = "NewSupplierButton";
            this.NewSupplierButton.Size = new System.Drawing.Size(165, 35);
            this.NewSupplierButton.TabIndex = 109;
            this.NewSupplierButton.Text = "Create New Supplier";
            this.NewSupplierButton.UseVisualStyleBackColor = true;
            this.NewSupplierButton.Click += new System.EventHandler(this.NewSupplierButton_Click);
            // 
            // NewCategoryButton
            // 
            this.NewCategoryButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.5F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.NewCategoryButton.ForeColor = System.Drawing.Color.ForestGreen;
            this.NewCategoryButton.Location = new System.Drawing.Point(183, 434);
            this.NewCategoryButton.Name = "NewCategoryButton";
            this.NewCategoryButton.Size = new System.Drawing.Size(165, 35);
            this.NewCategoryButton.TabIndex = 110;
            this.NewCategoryButton.Text = "Create New Category";
            this.NewCategoryButton.UseVisualStyleBackColor = true;
            this.NewCategoryButton.Click += new System.EventHandler(this.NewCategoryButton_Click);
            // 
            // ClearImageButton
            // 
            this.ClearImageButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.5F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ClearImageButton.ForeColor = System.Drawing.Color.Red;
            this.ClearImageButton.Location = new System.Drawing.Point(9, 289);
            this.ClearImageButton.Name = "ClearImageButton";
            this.ClearImageButton.Size = new System.Drawing.Size(114, 33);
            this.ClearImageButton.TabIndex = 129;
            this.ClearImageButton.Text = "Clear Image";
            this.ClearImageButton.UseVisualStyleBackColor = true;
            this.ClearImageButton.Click += new System.EventHandler(this.button1_Click);
            // 
            // ProductsForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.LightGray;
            this.ClientSize = new System.Drawing.Size(970, 481);
            this.ControlBox = false;
            this.Controls.Add(this.NewCategoryButton);
            this.Controls.Add(this.NewSupplierButton);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.CloseButton);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Name = "ProductsForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Products Management";
            this.Load += new System.EventHandler(this.InventoryForm_Load);
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.ProductImage)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button CloseButton;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Button SaveProductButton;
        private System.Windows.Forms.Button BrowseButton;
        private System.Windows.Forms.TextBox ProductNameField;
        private System.Windows.Forms.PictureBox ProductImage;
        private System.Windows.Forms.TextBox ProductBarcodeField;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.ComboBox CategoryList;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.TextBox ProductDescriptionField;
        private System.Windows.Forms.ComboBox SuppliersList;
        private System.Windows.Forms.Label label17;
        private System.Windows.Forms.Button NewSupplierButton;
        private System.Windows.Forms.Button NewCategoryButton;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button DeleteProductButton;
        private System.Windows.Forms.TextBox GuaranteeField;
        private System.Windows.Forms.TextBox WarrantyField;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.ComboBox ExistingCategoryList;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox WeightField;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox HeightField;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox WidthField;
        private System.Windows.Forms.TextBox SizeField;
        private System.Windows.Forms.ListBox ExistingProductsList;
        private System.Windows.Forms.TextBox ColorField;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.TextBox ProductCodeField;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Button NewProductButton;
        private System.Windows.Forms.Button ClearImageButton;
    }
}