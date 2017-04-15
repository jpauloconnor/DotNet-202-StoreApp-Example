using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace SuperSupremeMegaStore.Models
{
    public class Assignment
    {
        public int AssignmentID { get; set; }
        public int EmployeeID { get; set; }
        public int DepartmentID { get; set; }

        public virtual Department Department { get; set; }
        public virtual Employee Employee { get; set; }

    }
}