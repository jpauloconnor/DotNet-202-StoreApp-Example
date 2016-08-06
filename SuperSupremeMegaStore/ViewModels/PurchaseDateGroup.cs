using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace SuperSupremeMegaStore.ViewModels
{
    public class PurchaseDateGroup
    {
        [DataType(DataType.Date)]
        public DateTime? PurchaseDateInfo { get; set; }

        public int PurchaseCount { get; set; }
    }
}