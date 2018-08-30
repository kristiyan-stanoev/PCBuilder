using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace PCBuilder.Models
{
    public class Motherboard : Part
    {
        public Motherboard()
            : base()
        {

        }

        [Display(Name = "Processor socket number")]
        [Required]
        [StringLength(100, MinimumLength = 2)]
        public string ProcessorSocketNumber { get; set; }

        [Display(Name = "Graphics card socket number")]
        [Required]
        [StringLength(100, MinimumLength = 2)]
        public string GraphicsCardSocketNumber { get; set; }

        [Required]
        [StringLength(100, MinimumLength = 2)]
        public string Chipset { get; set; }

        [Display(Name = "Memory type")]
        [Required]
        [StringLength(100, MinimumLength = 2)]
        public string MemoryType { get; set; }

        [Display(Name = "Memory socket number")]
        [Required]
        [StringLength(100, MinimumLength = 2)]
        public string MemorySocketNumber { get; set; }

        [Display(Name = "Max memory")]
        [Required]
        [Range(1, 10000)]
        public int MaxMemory { get; set; }

        [Display(Name = "Number of memory slots")]
        [Required]
        [Range(1, 10)]
        public int NumberOfMemorySlots { get; set; }

        [Display(Name = "Power connector")]
        [Required]
        [StringLength(100, MinimumLength = 2)]
        public string PowerConnector { get; set; }

        [Display(Name = "HDD Interface")]
        [Required]
        [StringLength(100, MinimumLength = 2)]
        public string HDDInterface { get; set; }

        [Display(Name = "SSD Interface")]
        [Required]
        [StringLength(100, MinimumLength = 2)]
        public string SSDInterface { get; set; }

        [Display(Name = "Form factor")]
        [Required]
        [StringLength(100, MinimumLength = 2)]
        public string FormFactor { get; set; }
    }
}
