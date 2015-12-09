namespace EasyPayment4u.Data1
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("Consumer")]
    public partial class Consumer
    {
        public int ConsumerID { get; set; }

        [StringLength(50)]
        public string FirstName { get; set; }

        [StringLength(50)]
        public string MiddleName { get; set; }

        [StringLength(50)]
        public string LastName { get; set; }

        public int? OrderID { get; set; }

        [Column(TypeName = "numeric")]
        public decimal? MobileNumber { get; set; }

        public bool IsDeleted { get; set; }

        public bool IsActive { get; set; }
    }
}
