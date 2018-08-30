using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using PCBuilder.Web;
using PCBuilder.Models;
using System;

namespace PCBuilder.Data
{
    public class PCBuilderContext : IdentityDbContext<User>
    {
        public PCBuilderContext(DbContextOptions<PCBuilderContext> options)
            : base(options)
        {
        }

        public DbSet<Case> Cases { get; set; }

        public DbSet<GraphicsCard> GraphicsCards { get; set; }

        public DbSet<Processor> Processors { get; set; }

        public DbSet<Memory> Memory { get; set; }

        public DbSet<Motherboard> Motherboards { get; set; }

        public DbSet<PowerSupply> PowerSupplies { get; set; }

        public DbSet<SolidStateDrive> SolidStateDrives { get; set; }

        public DbSet<HardDiskDrive> HardDiskDrives { get; set; }

        public DbSet<PC> PCs { get; set; }

        protected override void OnModelCreating(ModelBuilder builder)
        {
            builder.Entity<Case>()
            .HasIndex(u => u.ModelName)
            .IsUnique();

            builder.Entity<Memory>()
            .HasIndex(u => u.ModelName)
            .IsUnique();

            builder.Entity<Processor>()
            .HasIndex(u => u.ModelName)
            .IsUnique();

            builder.Entity<GraphicsCard>()
            .HasIndex(u => u.ModelName)
            .IsUnique();

            builder.Entity<Motherboard>()
            .HasIndex(u => u.ModelName)
            .IsUnique();

            builder.Entity<SolidStateDrive>()
            .HasIndex(u => u.ModelName)
            .IsUnique();

            builder.Entity<HardDiskDrive>()
            .HasIndex(u => u.ModelName)
            .IsUnique();

            builder.Entity<PC>()
            .HasIndex(u => u.BuildName)
            .IsUnique();

            builder.Entity<PowerSupply>()
            .HasIndex(u => u.ModelName)
            .IsUnique();

            base.OnModelCreating(builder);
        }
    }
}
