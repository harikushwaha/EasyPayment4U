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
    using System;
    using System.Collections.Generic;
    
    public partial class Country
    {
        public Country()
        {
            this.Operators = new HashSet<Operator>();
        }
    
        public int CountryID { get; set; }
        public string CountryName { get; set; }
        public string CountryDescription { get; set; }
    
        public virtual ICollection<Operator> Operators { get; set; }
    }
}
