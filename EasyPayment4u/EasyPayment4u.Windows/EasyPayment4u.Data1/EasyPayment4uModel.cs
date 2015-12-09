namespace EasyPayment4u.Data1
{
    using System;
    using System.Data.Entity;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Linq;

    public partial class EasyPayment4uModel : DbContext
    {
        public EasyPayment4uModel()
            : base("name=EasyPayment4uModel1")
        {
        }

        public virtual DbSet<AspNetRole> AspNetRoles { get; set; }
        public virtual DbSet<AspNetUserClaim> AspNetUserClaims { get; set; }
        public virtual DbSet<AspNetUserLogin> AspNetUserLogins { get; set; }
        public virtual DbSet<AspNetUser> AspNetUsers { get; set; }
        public virtual DbSet<Country> Countries { get; set; }
        public virtual DbSet<CurrencyType> CurrencyTypes { get; set; }
        public virtual DbSet<Customer> Customers { get; set; }
        public virtual DbSet<MobilePlaneType> MobilePlaneTypes { get; set; }
        public virtual DbSet<MobleConnectionType> MobleConnectionTypes { get; set; }
        public virtual DbSet<Operator> Operators { get; set; }
        public virtual DbSet<Order> Orders { get; set; }
        public virtual DbSet<OrderLine> OrderLines { get; set; }
        public virtual DbSet<Product> Products { get; set; }
        public virtual DbSet<ProductCategory> ProductCategories { get; set; }
        public virtual DbSet<ProductType> ProductTypes { get; set; }
        public virtual DbSet<Role> Roles { get; set; }
        public virtual DbSet<State> States { get; set; }
        public virtual DbSet<sysdiagram> sysdiagrams { get; set; }
        public virtual DbSet<Test> Tests { get; set; }
        public virtual DbSet<User> Users { get; set; }
        public virtual DbSet<UserClaim> UserClaims { get; set; }
        public virtual DbSet<UserLogin> UserLogins { get; set; }
        public virtual DbSet<UserRegistrationToken> UserRegistrationTokens { get; set; }
        public virtual DbSet<Location> Locations { get; set; }
        public virtual DbSet<MobilePlane> MobilePlanes { get; set; }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            //modelBuilder.Entity<AspNetRole>()
            //    .HasOptional(e => e.AspNetRoles1)
            //    .WithRequired(e => e.AspNetRole1);

            //modelBuilder.Entity<AspNetRole>()
            //    .HasMany(e => e.AspNetUsers)
            //    .WithMany(e => e.AspNetRoles)
            //    .Map(m => m.ToTable("AspNetUserRoles").MapLeftKey("RoleId").MapRightKey("UserId"));

            //modelBuilder.Entity<AspNetUser>()
            //    .HasMany(e => e.AspNetUserClaims)
            //    .WithRequired(e => e.AspNetUser)
            //    .HasForeignKey(e => e.UserId);

            //modelBuilder.Entity<AspNetUser>()
            //    .HasMany(e => e.AspNetUserLogins)
            //    .WithRequired(e => e.AspNetUser)
            //    .HasForeignKey(e => e.UserId);

            //modelBuilder.Entity<Country>()
            //    .Property(e => e.CountryName)
            //    .IsUnicode(false);

            //modelBuilder.Entity<CurrencyType>()
            //    .Property(e => e.CurrencyType1)
            //    .IsUnicode(false);

            //modelBuilder.Entity<CurrencyType>()
            //    .HasMany(e => e.MobilePlanes)
            //    .WithRequired(e => e.CurrencyType)
            //    .WillCascadeOnDelete(false);

            //modelBuilder.Entity<Customer>()
            //    .Property(e => e.FirstName)
            //    .IsUnicode(false);

            //modelBuilder.Entity<Customer>()
            //    .Property(e => e.LastName)
            //    .IsUnicode(false);

            //modelBuilder.Entity<Customer>()
            //    .HasMany(e => e.Orders)
            //    .WithRequired(e => e.Customer)
            //    .WillCascadeOnDelete(false);

            //modelBuilder.Entity<MobilePlaneType>()
            //    .Property(e => e.MobilePlanType)
            //    .IsUnicode(false);

            //modelBuilder.Entity<MobilePlaneType>()
            //    .HasMany(e => e.MobilePlanes)
            //    .WithRequired(e => e.MobilePlaneType)
            //    .HasForeignKey(e => e.MobilePlaneTypeID)
            //    .WillCascadeOnDelete(false);

            //modelBuilder.Entity<MobleConnectionType>()
            //    .Property(e => e.MobleConnectionType1)
            //    .IsUnicode(false);

            //modelBuilder.Entity<MobleConnectionType>()
            //    .HasMany(e => e.Operators)
            //    .WithRequired(e => e.MobleConnectionType)
            //    .HasForeignKey(e => e.MobileConnectionTypeID)
            //    .WillCascadeOnDelete(false);

            //modelBuilder.Entity<Operator>()
            //    .Property(e => e.OperatorDescription)
            //    .IsUnicode(false);

            //modelBuilder.Entity<Operator>()
            //    .HasMany(e => e.Locations)
            //    .WithRequired(e => e.Operator)
            //    .HasForeignKey(e => e.LocationID)
            //    .WillCascadeOnDelete(false);

            //modelBuilder.Entity<Order>()
            //    .HasMany(e => e.OrderLines)
            //    .WithRequired(e => e.Order)
            //    .WillCascadeOnDelete(false);

            //modelBuilder.Entity<Product>()
            //    .HasMany(e => e.OrderLines)
            //    .WithRequired(e => e.Product)
            //    .WillCascadeOnDelete(false);

            //modelBuilder.Entity<ProductCategory>()
            //    .Property(e => e.Category)
            //    .IsUnicode(false);

            //modelBuilder.Entity<ProductType>()
            //    .Property(e => e.Type)
            //    .IsUnicode(false);

            //modelBuilder.Entity<ProductType>()
            //    .HasMany(e => e.Products)
            //    .WithRequired(e => e.ProductType)
            //    .WillCascadeOnDelete(false);

            //modelBuilder.Entity<ProductType>()
            //    .HasMany(e => e.ProductCategories)
            //    .WithRequired(e => e.ProductType)
            //    .WillCascadeOnDelete(false);

            //modelBuilder.Entity<Role>()
            //    .HasMany(e => e.Users)
            //    .WithMany(e => e.Roles)
            //    .Map(m => m.ToTable("UserRole").MapLeftKey("RoleId").MapRightKey("UserId"));

            //modelBuilder.Entity<State>()
            //    .Property(e => e.StateName)
            //    .IsUnicode(false);

            //modelBuilder.Entity<Test>()
            //    .Property(e => e.Address)
            //    .IsUnicode(false);

            //modelBuilder.Entity<Test>()
            //    .Property(e => e.Email)
            //    .IsUnicode(false);

            //modelBuilder.Entity<UserRegistrationToken>()
            //    .Property(e => e.Token)
            //    .IsFixedLength();

            //modelBuilder.Entity<Location>()
            //    .Property(e => e.City)
            //    .IsUnicode(false);

            //modelBuilder.Entity<MobilePlane>()
            //    .Property(e => e.MobilePlaneDescription)
            //    .IsUnicode(false);
        }
    }
}
