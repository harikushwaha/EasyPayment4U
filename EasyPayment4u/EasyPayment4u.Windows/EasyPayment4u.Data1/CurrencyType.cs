namespace EasyPayment4u.Data1
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("CurrencyType")]
    public partial class CurrencyType
    {
        public CurrencyType()
        {
            MobilePlanes = new HashSet<MobilePlane>();
        }

        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int CurrencyTypeID { get; set; }

        [Column("CurrencyType")]
        [Required]
        [StringLength(150)]
        public string CurrencyType1 { get; set; }

        [StringLength(250)]
        public string CurrencyTypeDesc { get; set; }

        public virtual ICollection<MobilePlane> MobilePlanes { get; set; }
    }
}
