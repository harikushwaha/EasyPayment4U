namespace EasyPayment4u.Data1
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("User")]
    public partial class User
    {
        public User()
        {
            UserClaims = new HashSet<UserClaim>();
            UserLogins = new HashSet<UserLogin>();
            Roles = new HashSet<Role>();
        }

        public long Id { get; set; }

        [Required]
        [StringLength(50)]
        public string UserName { get; set; }

        [Required]
        [StringLength(255)]
        public string EMail { get; set; }

        [StringLength(500)]
        public string PasswordHash { get; set; }

        public DateTime? CreationDate { get; set; }

        public DateTime? ApprovalDate { get; set; }

        public DateTime? LastLoginDate { get; set; }

        public bool IsLocked { get; set; }

        public string PasswordQuestion { get; set; }

        public string PasswordAnswer { get; set; }

        [StringLength(200)]
        public string ActivationToken { get; set; }

        public bool EmailConfirmed { get; set; }

        public string SecurityStamp { get; set; }

        [StringLength(50)]
        public string PhoneNumber { get; set; }

        public bool PhoneNumberConfirmed { get; set; }

        public bool TwoFactorEnabled { get; set; }

        [Column(TypeName = "datetime2")]
        public DateTime? LockoutEndDateUtc { get; set; }

        public bool LockoutEnabled { get; set; }

        public int AccessFailedCount { get; set; }

        public bool IsConfirmed { get; set; }

        public virtual ICollection<UserClaim> UserClaims { get; set; }

        public virtual ICollection<UserLogin> UserLogins { get; set; }

        public virtual ICollection<Role> Roles { get; set; }
    }
}
