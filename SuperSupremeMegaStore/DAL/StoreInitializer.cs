using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using SuperSupremeMegaStore.Models;

namespace SuperSupremeMegaStore.DAL
{
    public class StoreInitializer : System.Data.Entity.DropCreateDatabaseIfModelChanges<StoreContext>
    {
        protected override void Seed(StoreContext context)
        {
            var customer = new List<Customer>
            {
            new Customer { FirstName = "Zach", LastName = "Tinney", LastPurchase = DateTime.Parse("2005-09-01") },
            new Customer { FirstName = "Chris", LastName = "Wainscott", LastPurchase = DateTime.Parse("2005-09-01") },
            new Customer { FirstName = "Jenn", LastName = "Aikins", LastPurchase = DateTime.Parse("2005-09-01") },
            new Customer { FirstName = "Paul", LastName = "O'Connor", LastPurchase = DateTime.Parse("2005-09-01") },
            new Customer { FirstName = "Auri", LastName = "Rahimzadeh", LastPurchase = DateTime.Parse("2005-09-01") },
            new Customer { FirstName = "Dave", LastName = "Fancher", LastPurchase = DateTime.Parse("2005-09-01") },
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
            new Purchase { CustomerID=4, ProductID=4, Quantity=1 },
            new Purchase { CustomerID=5, ProductID=5, Quantity=1 },
            new Purchase { CustomerID=6, ProductID=6, Quantity=1 },

            };
            purchases.ForEach(s => context.Purchases.Add(s));
            context.SaveChanges();










        }

    }
}