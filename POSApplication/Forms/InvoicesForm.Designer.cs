namespace POSApplication.Forms
{
    partial class InvoicesForm
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
            this.PurchaseInvoices = new System.Windows.Forms.DataGridView();
            this.SalesInvoices = new System.Windows.Forms.DataGridView();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.PurchaseInvoices)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.SalesInvoices)).BeginInit();
            this.SuspendLayout();
            // 
            // PurchaseInvoices
            // 
            this.PurchaseInvoices.AllowUserToOrderColumns = true;
            this.PurchaseInvoices.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.PurchaseInvoices.EditMode = System.Windows.Forms.DataGridViewEditMode.EditOnKeystroke;
            this.PurchaseInvoices.Location = new System.Drawing.Point(12, 32);
            this.PurchaseInvoices.Name = "PurchaseInvoices";
            this.PurchaseInvoices.ReadOnly = true;
            this.PurchaseInvoices.Size = new System.Drawing.Size(745, 214);
            this.PurchaseInvoices.TabIndex = 66;
            // 
            // SalesInvoices
            // 
            this.SalesInvoices.AllowUserToOrderColumns = true;
            this.SalesInvoices.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.SalesInvoices.EditMode = System.Windows.Forms.DataGridViewEditMode.EditOnKeystroke;
            this.SalesInvoices.Location = new System.Drawing.Point(12, 276);
            this.SalesInvoices.Name = "SalesInvoices";
            this.SalesInvoices.ReadOnly = true;
            this.SalesInvoices.Size = new System.Drawing.Size(745, 214);
            this.SalesInvoices.TabIndex = 67;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(9, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(95, 13);
            this.label1.TabIndex = 68;
            this.label1.Text = "Purchase Invoices";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(9, 255);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(76, 13);
            this.label2.TabIndex = 69;
            this.label2.Text = "Sales Invoices";
            // 
            // InvoicesForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1003, 527);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.SalesInvoices);
            this.Controls.Add(this.PurchaseInvoices);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.Name = "InvoicesForm";
            this.SizeGripStyle = System.Windows.Forms.SizeGripStyle.Hide;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Purchase and Sales Invoices";
            this.Load += new System.EventHandler(this.InvoicesForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.PurchaseInvoices)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.SalesInvoices)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView PurchaseInvoices;
        private System.Windows.Forms.DataGridView SalesInvoices;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
    }
}