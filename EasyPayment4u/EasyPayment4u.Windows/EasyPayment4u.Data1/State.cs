namespace EasyPayment4u.Data1
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("State")]
    public partial class State
    {
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int StateID { get; set; }

        [Required]
        [StringLength(150)]
        public string StateName { get; set; }

        [StringLength(250)]
        public string StateDescription { get; set; }
    }
}
