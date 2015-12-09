namespace EasyPayment4u.Data1
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("Order")]
    public partial class Order
    {
        public Order()
        {
            OrderLines = new HashSet<OrderLine>();
        }

        public int OrderID { get; set; }

        public DateTime OrderDate { get; set; }

        public int ConsumerID { get; set; }

        public bool IsDeleted { get; set; }

        public bool IsActive { get; set; }

        public virtual ICollection<OrderLine> OrderLines { get; set; }
    }
}
