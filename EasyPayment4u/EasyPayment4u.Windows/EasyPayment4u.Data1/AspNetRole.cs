namespace EasyPayment4u.Data1
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class AspNetRole
    {
        public AspNetRole()
        {
            AspNetUsers = new HashSet<AspNetUser>();
        }

        public string Id { get; set; }

        [Required]
        [StringLength(256)]
        public string Name { get; set; }

        [StringLength(150)]
        public string Email { get; set; }

        public virtual AspNetRole AspNetRoles1 { get; set; }

        public virtual AspNetRole AspNetRole1 { get; set; }

        public virtual ICollection<AspNetUser> AspNetUsers { get; set; }
    }
}
