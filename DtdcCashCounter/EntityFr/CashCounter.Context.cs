﻿//------------------------------------------------------------------------------
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
    using System.Data.Entity;
    using System.Data.Entity.Infrastructure;
    
    public partial class DtdcBillingEntities : DbContext
    {
        public DtdcBillingEntities()
            : base("name=DtdcBillingEntities")
        {
        }
    
        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            throw new UnintentionalCodeFirstException();
        }
    
        public virtual DbSet<ActivityLog> ActivityLogs { get; set; }
        public virtual DbSet<Admin> Admins { get; set; }
        public virtual DbSet<Company> Companies { get; set; }
        public virtual DbSet<Destination> Destinations { get; set; }
        public virtual DbSet<Dtdc_Ptp> Dtdc_Ptp { get; set; }
        public virtual DbSet<dtdcPlu> dtdcPlus { get; set; }
        public virtual DbSet<Employee> Employees { get; set; }
        public virtual DbSet<Other_Service> Other_Service { get; set; }
        public virtual DbSet<sectorName> sectorNames { get; set; }
        public virtual DbSet<Sector> Sectors { get; set; }
        public virtual DbSet<Service_list> Service_list { get; set; }
        public virtual DbSet<WalletPoint> WalletPoints { get; set; }
        public virtual DbSet<RedeemOtp> RedeemOtps { get; set; }
        public virtual DbSet<Expense> Expenses { get; set; }
        public virtual DbSet<Payment> Payments { get; set; }
        public virtual DbSet<Saving> Savings { get; set; }
        public virtual DbSet<User> Users { get; set; }
        public virtual DbSet<Sendmessage> Sendmessages { get; set; }
        public virtual DbSet<wallet_History> wallet_History { get; set; }
        public virtual DbSet<Receipt_details> Receipt_details { get; set; }
        public virtual DbSet<express_cargo> express_cargo { get; set; }
        public virtual DbSet<Nondox> Nondoxes { get; set; }
        public virtual DbSet<Ratem> Ratems { get; set; }
        public virtual DbSet<Franchisee> Franchisees { get; set; }
        public virtual DbSet<Transaction> Transactions { get; set; }
    }
}
