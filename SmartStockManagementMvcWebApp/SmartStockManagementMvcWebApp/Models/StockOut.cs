using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace SmartStockManagementMvcWebApp.Models
{
    public class StockOut
    {
        public int Id { get; set; }
        [Required(ErrorMessage = "Please select a company ")]
        public int CompanyId { get; set; }
        [Required(ErrorMessage = "Please select an item")]
        public int ItemId { get; set; }

        public int ReorderLevel { get; set; }
        public int Available { get; set; }
        [Required(ErrorMessage = "Please enter stockout quantity number")]
        public string ActionType { get; set; }

        public int StockOutQuantity { get; set; }

        public string Date { get; set; }


    }
}