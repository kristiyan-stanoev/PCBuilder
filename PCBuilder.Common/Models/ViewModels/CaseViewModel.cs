using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace PCBuilder.Common.Models.ViewModels
{
    public class CaseViewModel
    {
        public int Id { get; set; }

        [Required]
        [StringLength(100, MinimumLength = 2)]
        public string Manufacturer { get; set; }

        [Display(Name = "Model name")]
        [Required]
        [StringLength(100, MinimumLength = 2)]
        public string ModelName { get; set; }

        [Display(Name = "FormFactor")]
        [Required]
        [StringLength(100, MinimumLength = 2)]
        public string FormFactor { get; set; }

        [Display(Name = "Number of vents")]
        [Required]
        [Range(1, 10)]
        public int NumberOfVents { get; set; }

        [Display(Name = "Case type")]
        [Required]
        [StringLength(100, MinimumLength = 2)]
        public string CaseType { get; set; }

        [Display(Name = "Number of ports")]
        [Required]
        [Range(1, 20)]
        public int NumberOfPorts { get; set; }

        [Required]
        [Range(0.1, 20)]
        public double Weight { get; set; }

        [Required]
        [StringLength(100, MinimumLength = 2)]
        public string Size { get; set; }

        [Display(Name = "Case image")]
        [DataType(DataType.ImageUrl)]
        public string ImageUrl { get; set; }

        [Required]
        [Range(1, 10000)]
        public decimal Price { get; set; }
    }
}
