using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace PCBuilder.Models
{
    public class PowerSupply : Part
    {
        public PowerSupply()
            : base()
        {

        }


        [Required]
        [StringLength(100, MinimumLength = 2)]
        public string Connector { get; set; }

        [Display(Name = "Number of cooling vents")]
        [Required]
        [Range(1, 10)]
        public int NumberOfCoolingVents { get; set; }

        [Required]
        [Range(1, 10000)]
        public double Power { get; set; }

        [Required]
        [StringLength(100, MinimumLength = 2)]
        public string Pfc { get; set; }

        [Required]
        [Range(1, 100)]
        public int Effectiveness { get; set; }
    }
}
