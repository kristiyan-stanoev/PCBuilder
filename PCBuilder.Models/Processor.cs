using System;
using System.ComponentModel.DataAnnotations;

namespace PCBuilder.Models
{
    public class Processor : Part
    {
        public Processor()
            : base()
        {

        }

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
        [StringLength(100, MinimumLength = 2)]
        public int MaxMemorySize { get; set; }
    }
}
