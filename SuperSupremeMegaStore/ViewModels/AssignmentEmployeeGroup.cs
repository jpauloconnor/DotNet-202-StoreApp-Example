using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace SuperSupremeMegaStore.ViewModels
{
    public class AssignmentEmployeeGroup
    {
        [DataType(DataType.Date)]
        public DateTime? EmployeeStartDateInfo { get; set; }

        public int EmployeeCount { get; set; }
    }
}