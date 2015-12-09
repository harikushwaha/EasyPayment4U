namespace EasyPayment4u.Data1
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("Country")]
    public partial class Country
    {
        public Country()
        {
            Operators = new HashSet<Operator>();
        }

        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int CountryID { get; set; }

        [Required]
        [StringLength(150)]
        public string CountryName { get; set; }

        [StringLength(150)]
        public string CountryDescription { get; set; }

        public virtual ICollection<Operator> Operators { get; set; }
    }
}
