using Microsoft.EntityFrameworkCore;
using Microsoft.Identity.Client.Extensions.Msal;
using System.Runtime.Intrinsics.Arm;

namespace Demo.Models
{
    public class ApplicationDbContext : DbContext
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options)
            : base(options)
        {
        }

        public DbSet<CPU> CPUs { get; set; }
        public DbSet<GPU> GPUs { get; set; }
        public DbSet<Motherboard> Motherboards { get; set; }
        public DbSet<RAM> RAMs { get; set; }
        public DbSet<Storage> Storages { get; set; }
        public DbSet<PowerSupply> PowerSupplies { get; set; }
        public DbSet<Case> Cases { get; set; }
        public DbSet<Build> Builds { get; set; }
        public DbSet<Contact> Contacts { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);

            // ✅ SEED DATA — these will automatically populate the database

            // CPUs
            modelBuilder.Entity<CPU>().HasData(
                new CPU { Id = 1, Name = "Intel Core i5-12400F", Socket = "LGA1700", Cores = 6, ClockSpeedGHz = 2.5f, Price = 160 },
                new CPU { Id = 2, Name = "Intel Core i7-13700K", Socket = "LGA1700", Cores = 16, ClockSpeedGHz = 3.4f, Price = 420 },
                new CPU { Id = 3, Name = "AMD Ryzen 5 5600", Socket = "AM4", Cores = 6, ClockSpeedGHz = 3.5f, Price = 140 },
                new CPU { Id = 4, Name = "AMD Ryzen 7 7800X3D", Socket = "AM5", Cores = 8, ClockSpeedGHz = 4.2f, Price = 400 },
                new CPU { Id = 5, Name = "Intel Core i9-14900K", Socket = "LGA1700", Cores = 24, ClockSpeedGHz = 3.2f, Price = 600 }
            );

            // GPUs
            modelBuilder.Entity<GPU>().HasData(
                new GPU { Id = 1, Name = "NVIDIA RTX 4060", MemoryGB = 8, Chipset = "Ada Lovelace", Price = 300 },
                new GPU { Id = 2, Name = "NVIDIA RTX 4070", MemoryGB = 12, Chipset = "Ada Lovelace", Price = 550 },
                new GPU { Id = 3, Name = "AMD Radeon RX 7600", MemoryGB = 8, Chipset = "RDNA 3", Price = 270 },
                new GPU { Id = 4, Name = "AMD Radeon RX 7900 XT", MemoryGB = 20, Chipset = "RDNA 3", Price = 750 },
                new GPU { Id = 5, Name = "NVIDIA RTX 4090", MemoryGB = 24, Chipset = "Ada Lovelace", Price = 1600 }
            );

            // Motherboards
            modelBuilder.Entity<Motherboard>().HasData(
                new Motherboard { Id = 1, Name = "ASUS TUF Gaming B660M-PLUS", Socket = "LGA1700", FormFactor = "Micro-ATX", Price = 150 },
                new Motherboard { Id = 2, Name = "MSI MAG B550 TOMAHAWK", Socket = "AM4", FormFactor = "ATX", Price = 180 },
                new Motherboard { Id = 3, Name = "Gigabyte X670 AORUS ELITE", Socket = "AM5", FormFactor = "ATX", Price = 230 },
                new Motherboard { Id = 4, Name = "ASRock Z790 Steel Legend", Socket = "LGA1700", FormFactor = "ATX", Price = 220 },
                new Motherboard { Id = 5, Name = "MSI PRO B650-P", Socket = "AM5", FormFactor = "ATX", Price = 200 }
            );

            // RAM
            modelBuilder.Entity<RAM>().HasData(
                new RAM { Id = 1, Name = "Corsair Vengeance LPX 16GB", CapacityGB = 16, Type = "DDR4", SpeedMHz = 3200, Price = 50 },
                new RAM { Id = 2, Name = "G.Skill Trident Z5 32GB", CapacityGB = 32, Type = "DDR5", SpeedMHz = 6000, Price = 160 },
                new RAM { Id = 3, Name = "Kingston Fury Beast 16GB", CapacityGB = 16, Type = "DDR4", SpeedMHz = 3600, Price = 55 },
                new RAM { Id = 4, Name = "Crucial DDR5 32GB", CapacityGB = 32, Type = "DDR5", SpeedMHz = 5600, Price = 140 },
                new RAM { Id = 5, Name = "TeamGroup T-Force Delta RGB 16GB", CapacityGB = 16, Type = "DDR4", SpeedMHz = 3200, Price = 60 }
            );

            // Storage
            modelBuilder.Entity<Storage>().HasData(
                new Storage { Id = 1, Name = "Samsung 970 EVO Plus", Type = "NVMe SSD", CapacityGB = 1000, Price = 90 },
                new Storage { Id = 2, Name = "Crucial MX500", Type = "SSD", CapacityGB = 1000, Price = 70 },
                new Storage { Id = 3, Name = "WD Blue SN570", Type = "NVMe SSD", CapacityGB = 500, Price = 40 },
                new Storage { Id = 4, Name = "Seagate Barracuda", Type = "HDD", CapacityGB = 2000, Price = 60 },
                new Storage { Id = 5, Name = "Kingston KC3000", Type = "NVMe SSD", CapacityGB = 2000, Price = 160 }
            );

            // Power Supplies
            modelBuilder.Entity<PowerSupply>().HasData(
                new PowerSupply { Id = 1, Name = "Corsair RM750e", Wattage = 750, Efficiency = "80+ Gold", Price = 100 },
                new PowerSupply { Id = 2, Name = "EVGA 600 BR", Wattage = 600, Efficiency = "80+ Bronze", Price = 50 },
                new PowerSupply { Id = 3, Name = "Seasonic Focus GX-850", Wattage = 850, Efficiency = "80+ Gold", Price = 120 },
                new PowerSupply { Id = 4, Name = "Cooler Master MWE 650", Wattage = 650, Efficiency = "80+ Bronze", Price = 70 },
                new PowerSupply { Id = 5, Name = "ASUS ROG Loki 1000W", Wattage = 1000, Efficiency = "80+ Platinum", Price = 250 }
            );

            // Cases
            modelBuilder.Entity<Case>().HasData(
                new Case { Id = 1, Name = "NZXT H510", FormFactor = "ATX", Color = "White", Price = 80 },
                new Case { Id = 2, Name = "Lian Li Lancool II Mesh", FormFactor = "ATX", Color = "Black", Price = 100 },
                new Case { Id = 3, Name = "Cooler Master NR200", FormFactor = "Mini-ITX", Color = "Black", Price = 90 },
                new Case { Id = 4, Name = "Fractal Design Meshify 2", FormFactor = "ATX", Color = "Black", Price = 140 },
                new Case { Id = 5, Name = "Corsair 4000D Airflow", FormFactor = "ATX", Color = "White", Price = 120 }
            );
        }
    }
}
