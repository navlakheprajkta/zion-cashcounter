//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace DtdcCashCounter.EntityFr
{
    using System;
    
    public partial class getInvoiceWithoutCompany_Result
    {
        public int IN_Id { get; set; }
        public string invoiceno { get; set; }
        public Nullable<System.DateTime> invoicedate { get; set; }
        public Nullable<System.DateTime> periodfrom { get; set; }
        public Nullable<System.DateTime> periodto { get; set; }
        public Nullable<double> total { get; set; }
        public Nullable<double> fullsurchargetax { get; set; }
        public Nullable<double> fullsurchargetaxtotal { get; set; }
        public Nullable<double> servicetax { get; set; }
        public Nullable<double> servicetaxtotal { get; set; }
        public Nullable<double> othercharge { get; set; }
        public Nullable<double> netamount { get; set; }
        public string Customer_Id { get; set; }
        public Nullable<double> paid { get; set; }
        public string discount { get; set; }
        public Nullable<double> Royalty_charges { get; set; }
        public Nullable<double> Docket_charges { get; set; }
        public string Tempdatefrom { get; set; }
        public string TempdateTo { get; set; }
        public string tempInvoicedate { get; set; }
        public string Address { get; set; }
        public string Invoice_Lable { get; set; }
        public Nullable<long> Firm_Id { get; set; }
        public Nullable<int> totalCount { get; set; }
    }
}
