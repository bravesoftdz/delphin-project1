//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace PizzaStore.Models
{
    using System;
    using System.Collections.Generic;
    
    public partial class NumberOfPizzaOrdered
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public NumberOfPizzaOrdered()
        {
            this.Orders = new HashSet<Order>();
        }
    
        public int ID { get; set; }
        public int Pizza1 { get; set; }
        public Nullable<int> Pizza2 { get; set; }
        public Nullable<int> Pizza3 { get; set; }
        public Nullable<int> Pizza4 { get; set; }
        public Nullable<int> Pizza5 { get; set; }
        public Nullable<int> Pizza6 { get; set; }
        public Nullable<int> Pizza7 { get; set; }
        public Nullable<int> Pizza8 { get; set; }
        public Nullable<int> Pizza9 { get; set; }
        public Nullable<int> Pizza10 { get; set; }
        public Nullable<int> Pizza11 { get; set; }
        public Nullable<int> Pizza12 { get; set; }
    
        public virtual Pizza Pizza { get; set; }
        public virtual Pizza Pizza13 { get; set; }
        public virtual Pizza Pizza14 { get; set; }
        public virtual Pizza Pizza15 { get; set; }
        public virtual Pizza Pizza16 { get; set; }
        public virtual Pizza Pizza17 { get; set; }
        public virtual Pizza Pizza18 { get; set; }
        public virtual Pizza Pizza19 { get; set; }
        public virtual Pizza Pizza20 { get; set; }
        public virtual Pizza Pizza21 { get; set; }
        public virtual Pizza Pizza22 { get; set; }
        public virtual Pizza Pizza23 { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Order> Orders { get; set; }
    }
}