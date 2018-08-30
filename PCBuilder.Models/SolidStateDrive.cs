using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace PCBuilder.Models
{
    public class SolidStateDrive: Part
    {
        public SolidStateDrive()
            : base()
        {

        }

        [Display(Name = "Memory capacity")]
        [Required]
        [Range(1, 10000)]
        public double MemoryCapacity { get; set; }

        [Display(Name = "Read speed")]
        [Required]
        [Range(1, 10000)]
        public int ReadSpeed { get; set; }

        [Display(Name = "Write speed")]
        [Required]
        [Range(1, 10000)]
        public int WriteSpeed { get; set; }

        [Required]
        [StringLength(100, MinimumLength = 2)]
        public string Interface { get; set; }
    }
}
