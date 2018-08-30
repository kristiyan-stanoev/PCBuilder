using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace PCBuilder.Models
{
    public class Case : Part
    {
        public Case()
            :base()
        {

        }

        [Display(Name = "Form factor")]
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
    }
}
