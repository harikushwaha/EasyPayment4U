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
    
    public partial class MobilePlaneType
    {
        public MobilePlaneType()
        {
            this.MobilePlanes = new HashSet<MobilePlane>();
        }
    
        public int MobilePlanTypeID { get; set; }
        public string MobilePlanType { get; set; }
        public string MobilePlanTypeDescription { get; set; }
    
        public virtual ICollection<MobilePlane> MobilePlanes { get; set; }
    }
}