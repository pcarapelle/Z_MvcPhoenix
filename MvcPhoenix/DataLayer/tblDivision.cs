//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace MvcPhoenix.DataLayer
{
    using System;
    using System.Collections.Generic;
    
    public partial class tblDivision
    {
        public int DivisionID { get; set; }
        public Nullable<int> ClientID { get; set; }
        public string Division { get; set; }
        public string BillingGroup { get; set; }
        public string BillingCode { get; set; }
        public string BusinessUnit { get; set; }
        public string Abbr { get; set; }
        public Nullable<decimal> WasteRate_OffSpec { get; set; }
        public Nullable<decimal> WasteRate_Empty { get; set; }
        public Nullable<bool> Inactive { get; set; }
        public Nullable<int> LegacyID { get; set; }
        public string Location_MDB { get; set; }
        public string Company_MDB { get; set; }
    }
}