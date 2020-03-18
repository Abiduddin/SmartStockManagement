using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace SmartStockManagementMvcWebApp.Models
{
    public class StockIn
    {

        public int Id { get; set; }
        [Required(ErrorMessage = "please select a company")]
        public int CompanyId { get; set; }
        [Required(ErrorMessage = "please select an item")]
        public int ItemId { get; set; }
        public int ReorderLevel { get; set; }
        public int Available { get; set; }
        [Required(ErrorMessage = "Please enter stockin quantity number")]
        public int StockInQuantity { get; set; }

        public string Date { get; set; }

    }
}