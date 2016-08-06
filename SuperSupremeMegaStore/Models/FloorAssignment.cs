using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;

namespace SuperSupremeMegaStore.Models
{
    public class FloorAssignment
    {
        [Key]
        [ForeignKey("Employee")]
        public int EmployeeID { get; set; }
        [StringLength(50)]
        [Display(Name = "Floor Location")]
        public string Location { get; set; }

        public virtual Employee Employee { get; set; }
    }
}