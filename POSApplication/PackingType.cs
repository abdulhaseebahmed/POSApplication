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
    
    public partial class PackingType
    {
        public PackingType()
        {
            this.Inventories = new HashSet<Inventory>();
        }
    
        public int PackingTypeID { get; set; }
        public string PackingTypes { get; set; }
    
        public virtual ICollection<Inventory> Inventories { get; set; }
    }
}