//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace electronicComponents.DAL
{
    using System;
    using System.Collections.Generic;
    
    public partial class ProductCategoryParent
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public ProductCategoryParent()
        {
            this.ProductCategories = new HashSet<ProductCategory>();
        }
    
        public int id { get; set; }
        public string name { get; set; }
        public Nullable<bool> isDelete { get; set; }
        public Nullable<bool> isActive { get; set; }
    
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<ProductCategory> ProductCategories { get; set; }
    }
}