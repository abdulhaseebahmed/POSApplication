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
    
    public partial class Region
    {
        public Region()
        {
            this.Suppliers = new HashSet<Supplier>();
        }
    
        public int RegionID { get; set; }
        public string RegionName { get; set; }
    
        public virtual ICollection<Supplier> Suppliers { get; set; }
    }
}
