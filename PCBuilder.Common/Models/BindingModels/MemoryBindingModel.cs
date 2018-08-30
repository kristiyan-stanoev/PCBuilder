using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace PCBuilder.Common.Models.BindingModels
{
    public class MemoryBindingModel
    {
        [Required]
        [StringLength(100, MinimumLength = 2)]
        public string Manufacturer { get; set; }

        [Display(Name = "Model name")]
        [Required]
        [StringLength(100, MinimumLength = 2)]
        public string ModelName { get; set; }

        [Required]
        [Range(1, 10000)]
        public int Amount { get; set; }

        [Required]
        [StringLength(100, MinimumLength = 2)]
        public string Socket { get; set; }

        [Required]
        [StringLength(100, MinimumLength = 2)]
        public string Type { get; set; }

        [Required]
        [Range(1, 100000)]
        public int Frequency { get; set; }

        [Display(Name = "Modules type")]
        [Required]
        [StringLength(100, MinimumLength = 2)]
        public string ModulesType { get; set; }

        [Required]
        [Range(1, 10000)]
        public decimal Price { get; set; }
    }
}
