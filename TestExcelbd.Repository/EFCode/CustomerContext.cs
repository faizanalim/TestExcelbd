using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Text;
using TestExcelbd.Repository.Models;

namespace TestExcelbd.Repository.EF_Code
{
    public class CustomerContext : DbContext
    {
        public CustomerContext(DbContextOptions<CustomerContext> options) : base(options)
        {
        }
        public DbSet<Customer> Customers { get; set; }
        public DbSet<CustomerAddress> CustomerAddresses { get; set; }
        public DbSet<Country> Countries { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Customer>().ToTable("Customer");
            modelBuilder.Entity<CustomerAddress>().ToTable("CustomerAddress");
            modelBuilder.Entity<Country>().ToTable("Country");
        }
    }


}
