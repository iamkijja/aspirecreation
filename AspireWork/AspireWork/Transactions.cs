//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace AspireWork
{
    using System;
    using System.Collections.Generic;
    
    public partial class Transactions
    {
        public int Id { get; set; }
        public string TransactionType { get; set; }
        public Nullable<System.DateTime> TransactionDate { get; set; }
        public Nullable<double> TransactionAmount { get; set; }
        public Nullable<int> SupplierID { get; set; }
        public Nullable<int> CustomerID { get; set; }
        public Nullable<double> WHTAmount { get; set; }
        public Nullable<double> VATAmount { get; set; }
        public string ReferenceURL { get; set; }
    }
}