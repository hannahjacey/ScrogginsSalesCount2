using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;
using Microsoft.AspNetCore.Mvc.ModelBinding.Validation;

namespace ScrogginsSalesCount2.Models
{
    public class Vehicle
    {
        public int VehicleId { get; set; }
      
        [Required]
        public string Stock { get; set; } = string.Empty;
        [Required]
        public int? Year { get; set; }
        [Required]
        public string Make { get; set; } = string.Empty;
        [Required]
        public string Model { get; set; } = string.Empty;
        public string SaleDate { get; set; } = string.Empty;
        [Required]
        public string CustomerName { get; set; } = string.Empty;

        [Required]
        public int SalesPersonId { get; set; }
        [ValidateNever]
        public SalesPerson SalesPerson { get; set; } = null!;

    }
}
