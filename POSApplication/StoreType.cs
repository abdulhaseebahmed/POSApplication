//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace POSApplication
{
    using System;
    using System.Collections.Generic;
    
    public partial class StoreType
    {
        public StoreType()
        {
            this.Stores = new HashSet<Store>();
        }
    
        public int StoreTypeID { get; set; }
        public string StoreTypeName { get; set; }
    
        public virtual ICollection<Store> Stores { get; set; }
    }
}
