using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace SuperSupremeMegaStore.Models
{
    public class Customer
    {
        public int CustomerID { get; set; }
        [Required]
        [StringLength(50)]
        [Display(Name = "Last Name")]
        public string LastName { get; set; }
        [Required]
        [StringLength(50, ErrorMessage = "First name cannot be longer than 50 characters.")]
        [Column("FirstName")]
        [Display(Name = "First Name")]
        public string FirstName { get; set; }

        [DataType(DataType.Date)]
        [DisplayFormat(DataFormatString = "{0:yyyy-MM-dd}", ApplyFormatInEditMode = true)]
        [Display(Name = "Last Purchase")]
        public DateTime LastPurchase { get; set; }

        [Display(Name = "Full Name")]
        public string FullName
        {
            get
            {
                return LastName + ", " + FirstName;
            }
        }

        public virtual ICollection<Purchase> Purchases { get; set; }

    }
}



//namespace SuperSupremeMegaStore.Migrations
//{
//    using SuperSupremeMegaStore.Models;
//    using SuperSupremeMegaStore.DAL;
//    using System;
//    using System.Collections.Generic;
//    using System.Data.Entity;
//    using System.Data.Entity.Migrations;
//    using System.Linq;

//    internal sealed class Configuration : DbMigrationsConfiguration<SuperSupremeMegaStore.DAL.StoreContext>
//    {
//        public Configuration()
//        {
//            AutomaticMigrationsEnabled = false;
//            ContextKey = "SuperSupremeMegaStore.DAL.StoreContext";
//        }

//        protected override void Seed(SuperSupremeMegaStore.DAL.StoreContext context)
//        {
//            var customers = new List<Customer>
//            {
//                new Customer { FirstName = "Paul", LastName = "O'Connor", LastPurchase = DateTime.Parse("2005-01-01")},
//                new Customer { FirstName = "Michael", LastName = "Phelps" , LastPurchase = DateTime.Parse("2005-10-01")}

//            };
//            customers.ForEach(c => context.Customers.AddOrUpdate(p => p.LastName, c));
//            context.SaveChanges();

//            var employees = new List<Employee>
//            {
//                new Employee { FirstMidName = "Michael", LastName = "Jordan", HireDate = DateTime.Parse("2005-10-10") },
//                new Employee { FirstMidName = "TJ", LastName = "Day", HireDate = DateTime.Parse("2005-10-10") },
//            };
//            employees.ForEach(c => context.Employees.AddOrUpdate(p => p.LastName, c));
//            context.SaveChanges();

//            var departments = new List<Department>
//            {
//                new Department { Name = "Food", TotalSales = 70000 },
//                new Department { Name = "Hardware", TotalSales = 5000 }
//            };
//            departments.ForEach(s => context.Departments.AddOrUpdate(p => p.Name, s));
//            context.SaveChanges();

//            var products = new List<Product>
//            {
//                new Product {ProductID = 120, Name = "Cereal", Price = 4.99m, SectionID = "45Food", Inventory = 12, UPC=09871234908},
//                new Product {ProductID = 121, Name = "Cereal with Marshamallows", Price = 4.99m, SectionID = "40Food", Inventory = 2, UPC=09871234909}

//            };
//            products.ForEach(s => context.Products.AddOrUpdate(p => p.ProductID, s));
//            context.SaveChanges();

//            var floorAssignments = new List<FloorAssignment>
//            {
//                new FloorAssignment { EmployeeID = employees.Single( e => e.LastName == "Donner").ID, Location = "Meat" },
//                new FloorAssignment { EmployeeID = employees.Single( e => e.LastName == "Conner").ID, Location = "Movies"}
//            };
//            floorAssignments.ForEach(s => context.FloorAssignments.AddOrUpdate(p => p.EmployeeID, s));
//            context.SaveChanges();

//            var purchases = new List<Purchase>
//            {
//                new Models.Purchase
//                {
//                    CustomerID = customers.Single(s => s.LastName == "George").CustomerID,
//                    ProductID = products.Single(p => p.Name == "Cheerios").ProductID,
//                    Quantity = 15
//                },
//                new Models.Purchase
//                {
//                    CustomerID = customers.Single(s => s.LastName == "Jones").CustomerID,
//                    ProductID = products.Single(p => p.Name == "Lamborghini").ProductID,
//                    Quantity = 1
//                }
//            };

//            foreach (Purchase p in purchases)
//            {
//                var purchaseInDataBase = context.Purchases.Where(
//                    s =>
//                        s.Customer.CustomerID == p.CustomerID &&
//                        s.Product.ProductID == p.ProductID).SingleOrDefault();
//                if (purchaseInDataBase == null)
//                {
//                    context.Purchases.Add(p);
//                }
//            }
//            context.SaveChanges();
//        }

//    }
//}
