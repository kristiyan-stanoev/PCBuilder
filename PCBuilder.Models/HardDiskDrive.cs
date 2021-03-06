﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace PCBuilder.Models
{
    public class HardDiskDrive : Part
    {
        public HardDiskDrive()
            : base()
        {

        }

        [Display(Name = "Memory capacity")]
        [Required]
        [Range(1, 10000)]
        public double MemoryCapacity { get; set; }

        [Required]
        [Range(1, 100000)]
        public int Rpm { get; set; }

        [Display(Name = "Read speed")]
        [Required]
        [Range(1, 10000)]
        public int ReadSpeed { get; set; }

        [Display(Name = "Write speed")]
        [Required]
        [Range(1, 10000)]
        public int WriteSpeed { get; set; }

        [Required]
        [Range(1, 1000)]
        public int Cache { get; set; }

        [Required]
        [StringLength(100, MinimumLength = 2)]
        public string Interface { get; set; }
    }
}
