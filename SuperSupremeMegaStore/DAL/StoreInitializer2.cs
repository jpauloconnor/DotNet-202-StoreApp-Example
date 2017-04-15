using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using SuperSupremeMegaStore.Models;

namespace SuperSupremeMegaStore.DAL
{
    public class StoreInitializer2 : System.Data.Entity.DropCreateDatabaseIfModelChanges<StoreContext>
    {
        protected override void Seed(StoreContext context)
        {
            var customer = new List<Customer>
            {
            new Customer { FirstName = "Charles", LastName = "Michael", LastPurchase = DateTime.Parse("2004-09-01") },
            new Customer { FirstName = "L", LastName = "Lorraine", LastPurchase = DateTime.Parse("2005-09-01") },
            new Customer { FirstName = "Jenn", LastName = "Aikins", LastPurchase = DateTime.Parse("2006-09-01") },
            new Customer { FirstName = "Paul", LastName = "O'Connor", LastPurchase = DateTime.Parse("2007-09-01") },
            new Customer { FirstName = "Auri", LastName = "Rahimzadeh", LastPurchase = DateTime.Parse("2008-09-01") },
            new Customer { FirstName = "Dave", LastName = "Fancher", LastPurchase = DateTime.Parse("2009-09-01") },
            };

            customer.ForEach(s => context.Customers.Add(s));
            context.SaveChanges();

            var products = new List<Product>
            {
              new Product {ProductID = 1, Name="Box o Nails", UPC=42342342321, Price=10.99m, SectionID="Hardware12", Inventory=48},
              new Product {ProductID = 2, Name="Big Ole Box of Cereal", UPC=43423423423, Price=110.99m, SectionID="Breakfast22", Inventory=12},
              new Product {ProductID = 3, Name="Super Size SUV", UPC=01423423423, Price=100000.99m, SectionID="CarLot42", Inventory=3},
              new Product {ProductID = 4, Name="Unwinnable Video Game", UPC=17423423423, Price=100.99m, SectionID="Games19", Inventory=18},
              new Product {ProductID = 5, Name="4000 pack of Pampers", UPC=92423423423, Price=500.99m, SectionID="Hardware12", Inventory=8},
              new Product {ProductID = 6, Name="Humgous Box o Nails", UPC=33423423423, Price=100.99m, SectionID="Hardware12", Inventory=6},
            };
            products.ForEach(s => context.Products.Add(s));
            context.SaveChanges();

            var purchases = new List<Purchase>
            {
            new Purchase { CustomerID=1, ProductID=1, Quantity=1 },
            new Purchase { CustomerID=2, ProductID=2, Quantity=1 },
            new Purchase { CustomerID=3, ProductID=3, Quantity=1 },
            new Purchase { CustomerID=3, ProductID=4, Quantity=4 },
            new Purchase { CustomerID=4, ProductID=4, Quantity=1 },
            new Purchase { CustomerID=4, ProductID=4, Quantity=1 },
            new Purchase { CustomerID=5, ProductID=5, Quantity=1 },
            new Purchase { CustomerID=6, ProductID=6, Quantity=1 },

            };
            purchases.ForEach(s => context.Purchases.Add(s));
            context.SaveChanges();

            var employees = new List<Employee>
            {
                new Employee { EmployeeID=1, FirstName = "Michael", LastName = "Jordan", HireDate = DateTime.Parse("2005-10-10") },
                new Employee { EmployeeID=2, FirstName = "TJ", LastName = "Day", HireDate = DateTime.Parse("2005-10-10") },
            };
            employees.ForEach(s => context.Employees.Add(s));
            context.SaveChanges();

            var departments = new List<Department>
            {
                new Department { DepartmentID = 1, Name = "Food", TotalSales = 70000 },
                new Department { DepartmentID = 2, Name = "Hardware", TotalSales = 5000 },
                new Department { DepartmentID = 3, Name = "Sporting Goods", TotalSales = 70000 },
                new Department { DepartmentID = 4, Name = "Furniture", TotalSales = 5000 }

            };
            departments.ForEach(s => context.Departments.Add(s));
            context.SaveChanges();

            var assignments = new List<Assignment>
            {
                new Assignment { EmployeeID = 1, DepartmentID = 1 },
                new Assignment { EmployeeID = 2, DepartmentID = 2 },

            };
            assignments.ForEach(s => context.Assignments.Add(s));
            context.SaveChanges();


        }
    }
}