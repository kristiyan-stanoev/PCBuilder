using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace PCBuilder.Common.Models.BindingModels
{
    public class PowerSupplyBindingModel
    {
        [Required]
        [StringLength(100, MinimumLength = 2)]
        public string Manufacturer { get; set; }

        [Display(Name = "Model name")]
        [Required]
        [StringLength(100, MinimumLength = 2)]
        public string ModelName { get; set; }

        [Required]
        [StringLength(100, MinimumLength = 2)]
        public string Connector { get; set; }

        [Display(Name = "Number of cooling vents")]
        [Required]
        [Range(1, 10)]
        public int NumberOfCoolingVents { get; set; }

        [Required]
        [Range(1, 10000)]
        public double Power { get; set; }

        [Required]
        [StringLength(100, MinimumLength = 2)]
        public string Pfc { get; set; }

        [Required]
        [Range(1, 100)]
        public int Effectiveness { get; set; }

        [Required]
        [Range(1, 10000)]
        public decimal Price { get; set; }
    }
}
