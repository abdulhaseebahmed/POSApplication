namespace POSApplication.Forms
{
    partial class JournalLedger
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(JournalLedger));
            this.CreditButton = new System.Windows.Forms.Button();
            this.CloseButton = new System.Windows.Forms.Button();
            this.DateField = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.SupplierNameLabel = new System.Windows.Forms.Label();
            this.ContactNameLabel = new System.Windows.Forms.Label();
            this.ContactNumberLabel = new System.Windows.Forms.Label();
            this.LedgerGridView = new System.Windows.Forms.DataGridView();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.CreditAmountField = new System.Windows.Forms.TextBox();
            this.label10 = new System.Windows.Forms.Label();
            this.CreditTransactionDescription = new System.Windows.Forms.TextBox();
            this.CreditAccountID = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.SalesInvoiceButton = new System.Windows.Forms.Button();
            this.PurchaseInvocieButton = new System.Windows.Forms.Button();
            this.DeleteTransactionButton = new System.Windows.Forms.Button();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.DebitAmountField = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.DebitTransactionDescription = new System.Windows.Forms.TextBox();
            this.DebitAccountID = new System.Windows.Forms.ComboBox();
            this.label9 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.DebitButton = new System.Windows.Forms.Button();
            this.NewAccountButton = new System.Windows.Forms.Button();
            this.SaveTransactionsButton = new System.Windows.Forms.Button();
            this.label7 = new System.Windows.Forms.Label();
            this.TotalDebitField = new System.Windows.Forms.TextBox();
            this.TotalCreditField = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.BalanceField = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.LedgerGridView)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // CreditButton
            // 
            this.CreditButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CreditButton.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.CreditButton.Location = new System.Drawing.Point(265, 147);
            this.CreditButton.Name = "CreditButton";
            this.CreditButton.Size = new System.Drawing.Size(149, 28);
            this.CreditButton.TabIndex = 50;
            this.CreditButton.Text = "Credit Amount";
            this.CreditButton.UseVisualStyleBackColor = true;
            this.CreditButton.Click += new System.EventHandler(this.CreditButton_Click);
            // 
            // CloseButton
            // 
            this.CloseButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CloseButton.Image = ((System.Drawing.Image)(resources.GetObject("CloseButton.Image")));
            this.CloseButton.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.CloseButton.Location = new System.Drawing.Point(763, 540);
            this.CloseButton.Name = "CloseButton";
            this.CloseButton.Size = new System.Drawing.Size(165, 43);
            this.CloseButton.TabIndex = 47;
            this.CloseButton.Text = "Close";
            this.CloseButton.UseVisualStyleBackColor = true;
            this.CloseButton.Click += new System.EventHandler(this.CloseButton_Click);
            // 
            // DateField
            // 
            this.DateField.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.DateField.Location = new System.Drawing.Point(144, 18);
            this.DateField.Name = "DateField";
            this.DateField.Size = new System.Drawing.Size(165, 23);
            this.DateField.TabIndex = 46;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(9, 21);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(38, 17);
            this.label1.TabIndex = 45;
            this.label1.Text = "Date";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(6, 92);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(79, 17);
            this.label6.TabIndex = 58;
            this.label6.Text = "Description";
            // 
            // SupplierNameLabel
            // 
            this.SupplierNameLabel.AutoSize = true;
            this.SupplierNameLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.SupplierNameLabel.Location = new System.Drawing.Point(325, 348);
            this.SupplierNameLabel.Name = "SupplierNameLabel";
            this.SupplierNameLabel.Size = new System.Drawing.Size(0, 17);
            this.SupplierNameLabel.TabIndex = 61;
            // 
            // ContactNameLabel
            // 
            this.ContactNameLabel.AutoSize = true;
            this.ContactNameLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ContactNameLabel.Location = new System.Drawing.Point(325, 375);
            this.ContactNameLabel.Name = "ContactNameLabel";
            this.ContactNameLabel.Size = new System.Drawing.Size(0, 17);
            this.ContactNameLabel.TabIndex = 62;
            // 
            // ContactNumberLabel
            // 
            this.ContactNumberLabel.AutoSize = true;
            this.ContactNumberLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ContactNumberLabel.Location = new System.Drawing.Point(325, 401);
            this.ContactNumberLabel.Name = "ContactNumberLabel";
            this.ContactNumberLabel.Size = new System.Drawing.Size(0, 17);
            this.ContactNumberLabel.TabIndex = 63;
            // 
            // LedgerGridView
            // 
            this.LedgerGridView.AllowUserToOrderColumns = true;
            this.LedgerGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.LedgerGridView.EditMode = System.Windows.Forms.DataGridViewEditMode.EditOnKeystroke;
            this.LedgerGridView.Location = new System.Drawing.Point(12, 252);
            this.LedgerGridView.Name = "LedgerGridView";
            this.LedgerGridView.ReadOnly = true;
            this.LedgerGridView.Size = new System.Drawing.Size(745, 297);
            this.LedgerGridView.TabIndex = 64;
            this.LedgerGridView.Sorted += new System.EventHandler(this.LedgerGridView_Sorted);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.CreditAmountField);
            this.groupBox1.Controls.Add(this.label10);
            this.groupBox1.Controls.Add(this.CreditTransactionDescription);
            this.groupBox1.Controls.Add(this.CreditAccountID);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label6);
            this.groupBox1.Controls.Add(this.CreditButton);
            this.groupBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.Location = new System.Drawing.Point(12, 58);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(426, 188);
            this.groupBox1.TabIndex = 65;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Credit Transaction";
            // 
            // CreditAmountField
            // 
            this.CreditAmountField.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CreditAmountField.Location = new System.Drawing.Point(153, 61);
            this.CreditAmountField.Name = "CreditAmountField";
            this.CreditAmountField.Size = new System.Drawing.Size(173, 23);
            this.CreditAmountField.TabIndex = 71;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.Location = new System.Drawing.Point(6, 63);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(56, 17);
            this.label10.TabIndex = 70;
            this.label10.Text = "Amount";
            // 
            // CreditTransactionDescription
            // 
            this.CreditTransactionDescription.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CreditTransactionDescription.Location = new System.Drawing.Point(153, 90);
            this.CreditTransactionDescription.Multiline = true;
            this.CreditTransactionDescription.Name = "CreditTransactionDescription";
            this.CreditTransactionDescription.Size = new System.Drawing.Size(261, 51);
            this.CreditTransactionDescription.TabIndex = 69;
            // 
            // CreditAccountID
            // 
            this.CreditAccountID.FormattingEnabled = true;
            this.CreditAccountID.Location = new System.Drawing.Point(153, 33);
            this.CreditAccountID.Name = "CreditAccountID";
            this.CreditAccountID.Size = new System.Drawing.Size(261, 21);
            this.CreditAccountID.TabIndex = 61;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(6, 33);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(76, 17);
            this.label2.TabIndex = 60;
            this.label2.Text = "Account ID";
            // 
            // SalesInvoiceButton
            // 
            this.SalesInvoiceButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.SalesInvoiceButton.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.SalesInvoiceButton.Location = new System.Drawing.Point(12, 555);
            this.SalesInvoiceButton.Name = "SalesInvoiceButton";
            this.SalesInvoiceButton.Size = new System.Drawing.Size(165, 28);
            this.SalesInvoiceButton.TabIndex = 62;
            this.SalesInvoiceButton.Text = "Sales Invoice";
            this.SalesInvoiceButton.UseVisualStyleBackColor = true;
            this.SalesInvoiceButton.Click += new System.EventHandler(this.SalesInvoiceButton_Click);
            // 
            // PurchaseInvocieButton
            // 
            this.PurchaseInvocieButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.PurchaseInvocieButton.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.PurchaseInvocieButton.Location = new System.Drawing.Point(183, 555);
            this.PurchaseInvocieButton.Name = "PurchaseInvocieButton";
            this.PurchaseInvocieButton.Size = new System.Drawing.Size(165, 28);
            this.PurchaseInvocieButton.TabIndex = 67;
            this.PurchaseInvocieButton.Text = "Purchase Invoice";
            this.PurchaseInvocieButton.UseVisualStyleBackColor = true;
            this.PurchaseInvocieButton.Click += new System.EventHandler(this.PurchaseInvocieButton_Click);
            // 
            // DeleteTransactionButton
            // 
            this.DeleteTransactionButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.DeleteTransactionButton.ForeColor = System.Drawing.Color.Red;
            this.DeleteTransactionButton.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.DeleteTransactionButton.Location = new System.Drawing.Point(763, 441);
            this.DeleteTransactionButton.Name = "DeleteTransactionButton";
            this.DeleteTransactionButton.Size = new System.Drawing.Size(165, 43);
            this.DeleteTransactionButton.TabIndex = 73;
            this.DeleteTransactionButton.Text = "Delete Transaction";
            this.DeleteTransactionButton.UseVisualStyleBackColor = true;
            this.DeleteTransactionButton.Click += new System.EventHandler(this.DeleteTransactionButton_Click);
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.DebitAmountField);
            this.groupBox2.Controls.Add(this.label5);
            this.groupBox2.Controls.Add(this.DebitTransactionDescription);
            this.groupBox2.Controls.Add(this.DebitAccountID);
            this.groupBox2.Controls.Add(this.label9);
            this.groupBox2.Controls.Add(this.label11);
            this.groupBox2.Controls.Add(this.DebitButton);
            this.groupBox2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox2.Location = new System.Drawing.Point(464, 58);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(460, 188);
            this.groupBox2.TabIndex = 75;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Debit Transaction";
            // 
            // DebitAmountField
            // 
            this.DebitAmountField.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.DebitAmountField.Location = new System.Drawing.Point(187, 60);
            this.DebitAmountField.Name = "DebitAmountField";
            this.DebitAmountField.Size = new System.Drawing.Size(173, 23);
            this.DebitAmountField.TabIndex = 71;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(6, 63);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(56, 17);
            this.label5.TabIndex = 70;
            this.label5.Text = "Amount";
            // 
            // DebitTransactionDescription
            // 
            this.DebitTransactionDescription.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.DebitTransactionDescription.Location = new System.Drawing.Point(187, 89);
            this.DebitTransactionDescription.Multiline = true;
            this.DebitTransactionDescription.Name = "DebitTransactionDescription";
            this.DebitTransactionDescription.Size = new System.Drawing.Size(261, 52);
            this.DebitTransactionDescription.TabIndex = 69;
            // 
            // DebitAccountID
            // 
            this.DebitAccountID.FormattingEnabled = true;
            this.DebitAccountID.Location = new System.Drawing.Point(187, 33);
            this.DebitAccountID.Name = "DebitAccountID";
            this.DebitAccountID.Size = new System.Drawing.Size(261, 21);
            this.DebitAccountID.TabIndex = 61;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.Location = new System.Drawing.Point(6, 33);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(76, 17);
            this.label9.TabIndex = 60;
            this.label9.Text = "Account ID";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label11.Location = new System.Drawing.Point(6, 92);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(79, 17);
            this.label11.TabIndex = 58;
            this.label11.Text = "Description";
            // 
            // DebitButton
            // 
            this.DebitButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.DebitButton.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.DebitButton.Location = new System.Drawing.Point(299, 147);
            this.DebitButton.Name = "DebitButton";
            this.DebitButton.Size = new System.Drawing.Size(149, 28);
            this.DebitButton.TabIndex = 50;
            this.DebitButton.Text = "Debit Amount";
            this.DebitButton.UseVisualStyleBackColor = true;
            this.DebitButton.Click += new System.EventHandler(this.DebitButton_Click);
            // 
            // NewAccountButton
            // 
            this.NewAccountButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.NewAccountButton.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.NewAccountButton.Location = new System.Drawing.Point(354, 555);
            this.NewAccountButton.Name = "NewAccountButton";
            this.NewAccountButton.Size = new System.Drawing.Size(165, 28);
            this.NewAccountButton.TabIndex = 76;
            this.NewAccountButton.Text = "Manage Accounts";
            this.NewAccountButton.UseVisualStyleBackColor = true;
            this.NewAccountButton.Click += new System.EventHandler(this.NewAccountButton_Click);
            // 
            // SaveTransactionsButton
            // 
            this.SaveTransactionsButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.SaveTransactionsButton.ForeColor = System.Drawing.Color.LimeGreen;
            this.SaveTransactionsButton.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.SaveTransactionsButton.Location = new System.Drawing.Point(763, 490);
            this.SaveTransactionsButton.Name = "SaveTransactionsButton";
            this.SaveTransactionsButton.Size = new System.Drawing.Size(165, 43);
            this.SaveTransactionsButton.TabIndex = 77;
            this.SaveTransactionsButton.Text = "Save Transactions";
            this.SaveTransactionsButton.UseVisualStyleBackColor = true;
            this.SaveTransactionsButton.Click += new System.EventHandler(this.SaveTransactionsButton_Click);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(763, 264);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(88, 17);
            this.label7.TabIndex = 78;
            this.label7.Text = "Total Debit";
            // 
            // TotalDebitField
            // 
            this.TotalDebitField.BackColor = System.Drawing.Color.White;
            this.TotalDebitField.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TotalDebitField.ForeColor = System.Drawing.Color.LimeGreen;
            this.TotalDebitField.Location = new System.Drawing.Point(763, 284);
            this.TotalDebitField.Name = "TotalDebitField";
            this.TotalDebitField.ReadOnly = true;
            this.TotalDebitField.Size = new System.Drawing.Size(161, 23);
            this.TotalDebitField.TabIndex = 79;
            // 
            // TotalCreditField
            // 
            this.TotalCreditField.BackColor = System.Drawing.Color.White;
            this.TotalCreditField.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TotalCreditField.ForeColor = System.Drawing.Color.Red;
            this.TotalCreditField.Location = new System.Drawing.Point(763, 337);
            this.TotalCreditField.Name = "TotalCreditField";
            this.TotalCreditField.ReadOnly = true;
            this.TotalCreditField.Size = new System.Drawing.Size(161, 23);
            this.TotalCreditField.TabIndex = 81;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(763, 317);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(93, 17);
            this.label8.TabIndex = 80;
            this.label8.Text = "Total Credit";
            // 
            // BalanceField
            // 
            this.BalanceField.BackColor = System.Drawing.Color.White;
            this.BalanceField.Enabled = false;
            this.BalanceField.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BalanceField.ForeColor = System.Drawing.Color.Red;
            this.BalanceField.Location = new System.Drawing.Point(763, 401);
            this.BalanceField.Name = "BalanceField";
            this.BalanceField.ReadOnly = true;
            this.BalanceField.Size = new System.Drawing.Size(161, 23);
            this.BalanceField.TabIndex = 83;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(763, 381);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(66, 17);
            this.label3.TabIndex = 82;
            this.label3.Text = "Balance";
            // 
            // JournalLedger
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(939, 593);
            this.ControlBox = false;
            this.Controls.Add(this.BalanceField);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.TotalCreditField);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.TotalDebitField);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.SaveTransactionsButton);
            this.Controls.Add(this.NewAccountButton);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.DeleteTransactionButton);
            this.Controls.Add(this.PurchaseInvocieButton);
            this.Controls.Add(this.SalesInvoiceButton);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.LedgerGridView);
            this.Controls.Add(this.ContactNumberLabel);
            this.Controls.Add(this.ContactNameLabel);
            this.Controls.Add(this.SupplierNameLabel);
            this.Controls.Add(this.CloseButton);
            this.Controls.Add(this.DateField);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Name = "JournalLedger";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = " ";
            this.Load += new System.EventHandler(this.SuppliersForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.LedgerGridView)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button CreditButton;
        private System.Windows.Forms.Button CloseButton;
        private System.Windows.Forms.TextBox DateField;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label SupplierNameLabel;
        private System.Windows.Forms.Label ContactNameLabel;
        private System.Windows.Forms.Label ContactNumberLabel;
        private System.Windows.Forms.DataGridView LedgerGridView;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button SalesInvoiceButton;
        private System.Windows.Forms.Button PurchaseInvocieButton;
        private System.Windows.Forms.ComboBox CreditAccountID;
        private System.Windows.Forms.TextBox CreditTransactionDescription;
        private System.Windows.Forms.TextBox CreditAmountField;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Button DeleteTransactionButton;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.TextBox DebitAmountField;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox DebitTransactionDescription;
        private System.Windows.Forms.ComboBox DebitAccountID;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Button DebitButton;
        private System.Windows.Forms.Button NewAccountButton;
        private System.Windows.Forms.Button SaveTransactionsButton;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox TotalDebitField;
        private System.Windows.Forms.TextBox TotalCreditField;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox BalanceField;
        private System.Windows.Forms.Label label3;
    }
}