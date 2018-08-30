using Microsoft.AspNetCore.Mvc.Rendering;
using PCBuilder.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace PCBuilder.Common.Models.BindingModels
{
    public class PCBindingModel
    {
        [Required]
        [StringLength(100, MinimumLength = 2)]
        [Display(Name = "Build name")]
        public string BuildName { get; set; }

        [Required]
        public string Case { get; set; }

        [Required]
        public string Processor { get; set; }

        [Required]
        [Display(Name = "Graphics card")]
        public string GraphicsCard { get; set; }

        [Required]
        public string Motherboard { get; set; }

        [Required]
        public string Memory { get; set; }

        [Display(Name = "Number of memory sticks")]
        [Required]
        [Range(1, 10)]
        public int NumberOfMemorySticks { get; set; }

        [Required]
        [Display(Name = "Power supply")]
        public string PowerSupply { get; set; }

        [Display(Name = "Hard disk drive")]
        public string HardDiskDrive { get; set; }

        [Display(Name = "Solid state drive")]
        public string SolidStateDrive { get; set; }
    }
}
