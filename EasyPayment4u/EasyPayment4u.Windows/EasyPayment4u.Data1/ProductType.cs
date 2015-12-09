namespace EasyPayment4u.Data1
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("ProductType")]
    public partial class ProductType
    {
        public ProductType()
        {
            Products = new HashSet<Product>();
            ProductCategories = new HashSet<ProductCategory>();
        }

        public int ProductTypeID { get; set; }

        [StringLength(250)]
        public string Type { get; set; }

        [StringLength(250)]
        public string Description { get; set; }

        public virtual ICollection<Product> Products { get; set; }

        public virtual ICollection<ProductCategory> ProductCategories { get; set; }
    }
}
