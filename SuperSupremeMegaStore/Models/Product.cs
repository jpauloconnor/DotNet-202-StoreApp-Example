using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace SuperSupremeMegaStore.Models
{
    public class Product
    {
        public int ProductID { get; set; }
        public string Name { get; set; }
        public long UPC { get; set; }
        public string SectionID { get; set; }
        public decimal Price { get; set; }
        public int Inventory { get; set; }

        public virtual ICollection<Purchase> Purchases { get; set; }

    }
}