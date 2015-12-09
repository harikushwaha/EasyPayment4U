namespace EasyPayment4u.Data1
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("MobleConnectionType")]
    public partial class MobleConnectionType
    {
        public MobleConnectionType()
        {
            Operators = new HashSet<Operator>();
        }

        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int MobleConnectionTypeID { get; set; }

        [Column("MobleConnectionType")]
        [Required]
        [StringLength(150)]
        public string MobleConnectionType1 { get; set; }

        [StringLength(250)]
        public string MobleConnectionTypeDesc { get; set; }

        public virtual ICollection<Operator> Operators { get; set; }
    }
}
