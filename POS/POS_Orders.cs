//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace POS
{
    using System;
    using System.Collections.Generic;
    
    public partial class POS_Orders
    {
        public long ID { get; set; }
        public long Branch_ID { get; set; }
        public Nullable<long> UserCreate { get; set; }
        public Nullable<long> UserLastModified { get; set; }
        public Nullable<System.DateTime> CreationDate { get; set; }
        public Nullable<System.DateTime> LastModified { get; set; }
        public Nullable<long> ShiftsTransaction_ID { get; set; }
        public Nullable<long> OrderNo { get; set; }
        public Nullable<int> LookupOrderType_ID { get; set; }
        public Nullable<int> OrderStatus { get; set; }
        public Nullable<System.DateTime> Timedo { get; set; }
        public Nullable<long> Customer_ID { get; set; }
        public string CustomerTel { get; set; }
        public string CustomerAddress { get; set; }
        public string Note { get; set; }
        public Nullable<double> Total { get; set; }
        public Nullable<double> Tax { get; set; }
        public Nullable<double> Discount { get; set; }
        public Nullable<double> Service { get; set; }
        public Nullable<double> DeliveryFees { get; set; }
        public Nullable<double> TotalNet { get; set; }
    }
}
