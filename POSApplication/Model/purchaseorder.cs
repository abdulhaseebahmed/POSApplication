//------------------------------------------------------------------------------
// <auto-generated>
//    This code was generated from a template.
//
//    Manual changes to this file may cause unexpected behavior in your application.
//    Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace POSApplication.Model
{
    using System;
    using System.Collections.Generic;
    
    public partial class purchaseorder
    {
        public int OrderID { get; set; }
        public Nullable<int> TerminalID { get; set; }
        public Nullable<int> SupplierID { get; set; }
        public Nullable<decimal> PurchaseAmount { get; set; }
        public Nullable<System.DateTime> PurchaseDate { get; set; }
        public Nullable<System.TimeSpan> PurchaseTime { get; set; }
        public Nullable<decimal> Discount { get; set; }
        public Nullable<decimal> TaxPercentage { get; set; }
        public Nullable<int> PurchaseStatus { get; set; }
        public Nullable<decimal> AmountPaid { get; set; }
        public Nullable<decimal> Balance { get; set; }
        public string ModeOfPayment { get; set; }
    }
}
