using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;

namespace SuperSupremeMegaStore.Models
{
    public class Product
    {
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        [Display(Name = "Number")]
        public int ProductID { get; set; }

        [StringLength(50, MinimumLength = 3)]
        public string Name { get; set; }

        public long UPC { get; set; }

        public string SectionID { get; set; }

        [Column(TypeName ="money")]
        public decimal Price { get; set; }

        //TODO: handle the inventory
        public int Inventory { get; set; }

        public virtual ICollection<Purchase> Purchases { get; set; }
    }
}