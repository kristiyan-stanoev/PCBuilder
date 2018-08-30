using Microsoft.AspNetCore.Mvc.Rendering;
using PCBuilder.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace PCBuilder.Common.Models.ViewModels
{
    public class PCViewModel
    {
        public int Id { get; set; }

        [Required]
        public string Username { get; set; }

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

        [Display(Name = "Case image")]
        public string CaseUrl { get; set; }

        [Required]
        [Display(Name = "Power supply")]
        public string PowerSupply { get; set; }

        [Display(Name = "Hard disk drive")]
        public string HardDiskDrive { get; set; }

        [Display(Name = "Solid state drive")]
        public string SolidStateDrive { get; set; }

        [Required]
        [Range(1, 500000)]
        [Display(Name = "Total price")]
        public decimal TotalPrice { get; set; }

        [Range(1, 12)]
        [Display(Name = "System rating")]
        public double SystemRating { get; set; }

        [Display(Name = "Max system rating")]
        public double MaxSystemRating { get; set; }

        [Range(1, 10)]
        [Display(Name = "User rating")]
        public double UserRating { get; set; }

        [Display(Name = "System summary")]
        public string SystemSummary { get; set; }

        public string UsersRatedIds { get; set; }
    }
}
