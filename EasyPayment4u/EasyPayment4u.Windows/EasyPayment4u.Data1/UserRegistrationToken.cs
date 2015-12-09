namespace EasyPayment4u.Data1
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("UserRegistrationToken")]
    public partial class UserRegistrationToken
    {
        public long Id { get; set; }

        public long? UserId { get; set; }

        [Required]
        [StringLength(10)]
        public string Token { get; set; }
    }
}
