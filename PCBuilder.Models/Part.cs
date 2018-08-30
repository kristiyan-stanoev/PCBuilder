using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace PCBuilder.Models
{
    public abstract class Part
    {
        public Part()
        {
            this.PCs = new List<PC>();
        }

        public int Id { get; set; }

        [Required]
        [StringLength(100, MinimumLength = 2)]
        public string Manufacturer { get; set; }

        [Display(Name = "Model name")]
        [Required]
        [StringLength(100, MinimumLength = 2)]
        public string ModelName { get; set; }

        [Required]
        [Range(1, 10000)]
        public decimal Price { get; set; }

        public ICollection<PC> PCs { get; set; }
    }
}
