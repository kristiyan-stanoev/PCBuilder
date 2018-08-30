using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace PCBuilder.Models
{
    public class PC
    {
        public PC()
        {
            this.MaxSystemRating = 12;
            this.UsersRatedCount = 0;
            this.UsersRatedIds = "";
        }
        public int Id { get; set; }

        [Required]
        [StringLength(100, MinimumLength = 2)]
        [Display(Name = "Build name")]
        public string BuildName { get; set; }

        [Required]
        public string UserId { get; set; }

        public User User { get; set; }

        [Required]
        public int CaseId { get; set; }

        public Case Case { get; set; }

        [Required]
        public int ProcessorId { get; set; }

        public Processor Processor { get; set; }

        [Required]
        public int GraphicsCardId { get; set; }

        public GraphicsCard GraphicsCard { get; set; }

        [Required]
        public int MemoryId { get; set; }

        public Memory Memory { get; set; }

        [Display(Name = "Number of memory sticks")]
        [Required]
        [Range(1, 10)]
        public int NumberOfMemorySticks { get; set; }

        [Required]
        public int MotherboardId { get; set; }

        public Motherboard Motherboard { get; set; }

        [Required]
        public int PowerSupplyId { get; set; }

        public PowerSupply PowerSupply { get; set; }

        public int? HardDiskDriveId { get; set; }

        public HardDiskDrive HardDiskDrive { get; set; }

        public int? SolidStateDriveId { get; set; }

        public SolidStateDrive SolidStateDrive { get; set; }

        [Required]
        [Range(1, 500000)]
        public decimal TotalPrice { get; set; }

        [Range(1, 12)]
        [Display(Name = "System rating")]
        public double SystemRating { get; set; }

        [Display(Name = "Max system rating")]
        public double MaxSystemRating { get; set; }

        [Range(0, 10)]
        [Display(Name = "User rating")]
        public double UserRating { get; set; }

        [Display(Name = "System summary")]
        public string SystemSummary { get; set; }

        public string UsersRatedIds { get; set; }

        public int UsersRatedCount { get; set; }
    }
}