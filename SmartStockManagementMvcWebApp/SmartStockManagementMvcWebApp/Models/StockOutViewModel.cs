using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace SmartStockManagementMvcWebApp.Models
{
    public class StockOutViewModel
    {
        public string Company { get; set; }
        public string Item { get; set; }
        public int ReorderLevel { get; set; }
        public float Available { get; set; }
        public float StockOutQuantity { get; set; }
    }
}