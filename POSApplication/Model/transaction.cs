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
    
    public partial class transaction
    {
        public Nullable<System.DateTime> entrydate { get; set; }
        public Nullable<System.TimeSpan> entrytime { get; set; }
        public Nullable<decimal> Debit { get; set; }
        public Nullable<decimal> Credit { get; set; }
        public string description { get; set; }
        public int transactionid { get; set; }
        public Nullable<int> accountid { get; set; }
    }
}