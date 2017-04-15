//using SuperSupremeMegaStore.Models;
//using System.Data.Entity;
//using System.Data.Entity.ModelConfiguration.Conventions;

//namespace SuperSupremeMegaStore.DAL
//{
//    public class StoreContext : DbContext
//    {
//        public DbSet<Product> Products { get; set; }
//        public DbSet<Department> Departments { get; set; }
//        public DbSet<Purchase> Purchases { get; set; }
//        public DbSet<Employee> Employees { get; set; }
//        public DbSet<Customer> Customers { get; set; }
//        public DbSet<FloorAssignment> FloorAssignments { get; set; }

//        protected override void OnModelCreating(DbModelBuilder modelBuilder)
//        {
//            modelBuilder.Conventions.Remove<PluralizingTableNameConvention>();
//        }
//    }
//}


using SuperSupremeMegaStore.Models;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Data.Entity.ModelConfiguration.Conventions;
using System.Linq;
using System.Web;

namespace SuperSupremeMegaStore.DAL
{
    public class StoreContext : DbContext
    {
        public StoreContext() : base("StoreContext")
        {
        }

        public DbSet<Customer> Customers { get; set; }
        public DbSet<Purchase> Purchases { get; set; }
        public DbSet<Product> Products { get; set; }
        public DbSet<Employee> Employees { get; set; }
        public DbSet<Department> Departments { get; set; }
        public DbSet<Assignment> Assignments { get; set; }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Conventions.Remove<PluralizingTableNameConvention>();
        }


    }
}