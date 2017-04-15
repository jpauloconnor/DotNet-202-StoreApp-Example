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
       
        public string Name { get; set; }
        public decimal TotalSales { get; set; }

        public virtual ICollection<Assignment> Assignments { get; set; }
    }
}
