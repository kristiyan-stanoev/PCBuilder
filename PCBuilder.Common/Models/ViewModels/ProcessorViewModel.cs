using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace PCBuilder.Common.Models.ViewModels
{
    public class ProcessorViewModel
    {
        public int Id { get; set; }

        [Required]
        [StringLength(100, MinimumLength = 2)]
        public string Manufacturer { get; set; }

        [Display(Name = "Model name")]
        [Required]
        [StringLength(100, MinimumLength = 2)]
        public string ModelName { get; set; }

        [Required]
        [StringLength(100, MinimumLength = 2)]
        public string Architecture { get; set; }

        [Required]
        [StringLength(100, MinimumLength = 2)]
        public string Socket { get; set; }

        [Display(Name = "Number of cores")]
        [Required]
        [Range(1, 100)]
        public int NumberOfCores { get; set; }

        [Required]
        [Range(1, 10)]
        public double Frequency { get; set; }

        [Required]
        [Range(1, 100)]
        public double Cache { get; set; }

        [Required]
        [Range(1, 10000)]
        public double Power { get; set; }

        //[Display(Name = "Memory type")]
        //[Required]
        //[StringLength(100, MinimumLength = 2)]
        //public string MemoryType { get; set; }

        [Display(Name = "Max memory supported")]
        [Required]
        [Range(1, 1000)]
        public int MaxMemorySize { get; set; }

        [Required]
        [Range(1, 10000)]
        public decimal Price { get; set; }
    }
}
