namespace EasyPayment4u.Data1
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("Operator")]
    public partial class Operator
    {
        public Operator()
        {
            Locations = new HashSet<Location>();
        }

        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int OperatorID { get; set; }

        [Required]
        [StringLength(100)]
        public string OperatorName { get; set; }

        [StringLength(150)]
        public string OperatorDescription { get; set; }

        public int MobileConnectionTypeID { get; set; }

        public int? CountryID { get; set; }

        public int LocationID { get; set; }

        public virtual Country Country { get; set; }

        public virtual MobleConnectionType MobleConnectionType { get; set; }

        public virtual ICollection<Location> Locations { get; set; }
    }
}
