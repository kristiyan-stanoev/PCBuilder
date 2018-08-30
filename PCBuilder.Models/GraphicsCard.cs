using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace PCBuilder.Models
{
    public class GraphicsCard : Part
    {
        public GraphicsCard()
            : base()
        {

        }

        [Required]
        [StringLength(100, MinimumLength = 2)]
        public string Architecture { get; set; }

        [Required]
        [StringLength(100, MinimumLength = 2)]
        public string Socket { get; set; }

        [Required]
        public int Pipelines { get; set; }

        [Display(Name = "Core speed")]
        [Required]
        [Range(1, 10000)]
        public int CoreSpeed { get; set; }

        [Display(Name = "Memory speed")]
        [Required]
        [Range(1, 100000)]
        public string MemorySpeed { get; set; }

        [Display(Name = "Memory type")]
        [Required]
        [StringLength(100, MinimumLength = 2)]
        public string MemoryType { get; set; }

        [Display(Name = "Memory amount")]
        [Required]
        [Range(1, 10000)]
        public int MemoryAmount { get; set; }

        [Display(Name = "Max power")]
        [Required]
        [Range(1, 1000)]
        public int MaxPower { get; set; }

        [Required]
        [StringLength(100, MinimumLength = 2)]
        public string DirectX { get; set; }
    }
}
