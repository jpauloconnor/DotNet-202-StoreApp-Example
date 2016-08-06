using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;

namespace SuperSupremeMegaStore.Models
{
    public class Department
    {
        public int DepartmentID { get; set; }
        [StringLength(50, MinimumLength = 3)]
        public string Name { get; set; }

        [DataType(DataType.Currency)]
        [Column(TypeName = "money")]
        public decimal TotalSales { get; set; }

        public int? EmployeeID { get; set; }
        public virtual Employee Manager { get; set; }
        public virtual ICollection<Product> Products { get; set; }
       
    }
}