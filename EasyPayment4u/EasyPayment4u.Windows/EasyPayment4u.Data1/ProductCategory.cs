namespace EasyPayment4u.Data1
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class ProductCategory
    {
        public int ProductCategoryID { get; set; }

        [Required]
        [StringLength(250)]
        public string Category { get; set; }

        public int ProductTypeID { get; set; }

        public virtual ProductType ProductType { get; set; }
    }
}
