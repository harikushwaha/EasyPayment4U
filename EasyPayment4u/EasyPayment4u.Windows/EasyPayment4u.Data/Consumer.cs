//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace EasyPayment4u.Data
{
    using EasyPayment4u.Core;
    using System;
    using System.Collections.Generic;

    public partial class Consumer : BaseEntity
    {
        public int ConsumerID { get; set; }
        public string FirstName { get; set; }
        public string MiddleName { get; set; }
        public string LastName { get; set; }
        public Nullable<int> OrderID { get; set; }
        public Nullable<decimal> MobileNumber { get; set; }
        public bool IsDeleted { get; set; }
        public bool IsActive { get; set; }
    }
}
