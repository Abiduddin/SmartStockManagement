using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace SmartStockManagementMvcWebApp.Models
{
    public class Item
    {
        public int Id { get; set; }

        [Required(ErrorMessage = "Please enter an item name")]
        public string Name { get; set; }

        [Required(ErrorMessage = "Please select a category")]
        public int CategoryId { get; set; }

        [Required(ErrorMessage = "Please select a company")]
        public int CompanyId { get; set; }

        public int ReorderLevel { get; set; }

        public int Available { get; set; }


    }
}