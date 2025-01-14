//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace EasyPayment4u.Data
{
    using EasyPayment4u.Core;
using System;
using System.Collections.Generic;
    
    public partial class Order : BaseEntity
    {
        public Order()
        {
            this.OrderLines = new HashSet<OrderLine>();
        }
    
        public int OrderID { get; set; }
        public System.DateTime OrderDate { get; set; }
        public int ConsumerID { get; set; }
        public bool IsDeleted { get; set; }
        public bool IsActive { get; set; }
    
        public virtual ICollection<OrderLine> OrderLines { get; set; }
    }
}
