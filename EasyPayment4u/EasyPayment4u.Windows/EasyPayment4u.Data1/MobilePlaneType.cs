namespace EasyPayment4u.Data1
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("MobilePlaneType")]
    public partial class MobilePlaneType
    {
        public MobilePlaneType()
        {
            MobilePlanes = new HashSet<MobilePlane>();
        }

        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int MobilePlanTypeID { get; set; }

        [Required]
        [StringLength(150)]
        public string MobilePlanType { get; set; }

        [StringLength(150)]
        public string MobilePlanTypeDescription { get; set; }

        public virtual ICollection<MobilePlane> MobilePlanes { get; set; }
    }
}
