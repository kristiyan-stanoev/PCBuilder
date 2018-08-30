using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace PCBuilder.Models
{
    public class Memory : Part
    {
        public Memory()
            : base()
        {

        }

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
    }
}
