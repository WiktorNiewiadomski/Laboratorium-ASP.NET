using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;

namespace Data
{
    public class AppDbContext : IdentityDbContext<IdentityUser>
    {
        public DbSet<ComputerEntity> Computers { get; set; }
        public DbSet<ProcessorEntity> Processors { get; set; }
        public DbSet<StorageEntity> Storages { get; set; }
        public DbSet<GraphicsCardEntity> GraphicsCards { get; set; }
        private string DbPath { get; set; }
        public AppDbContext()
        {
            var folder = Environment.SpecialFolder.LocalApplicationData;
            var path = Environment.GetFolderPath(folder);
            DbPath = Path.Join(path, "computers.db");
        }
        protected override void OnConfiguring(DbContextOptionsBuilder options) =>
        options.UseSqlite($"Data Source={DbPath}");

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);

            string ADMIN_ID = Guid.NewGuid().ToString();
            string ADMIN_ROLE_ID = Guid.NewGuid().ToString();

            PasswordHasher<IdentityUser> hasher = new PasswordHasher<IdentityUser>();

            modelBuilder.Entity<IdentityRole>().HasData(new IdentityRole
            {
                Name = "admin",
                NormalizedName = "ADMIN",
                Id = ADMIN_ROLE_ID,
                ConcurrencyStamp = ADMIN_ROLE_ID
            });

            var adminEmail = "adam@wsei.edu.pl";

            var admin = new IdentityUser
            {
                Id = ADMIN_ID,
                Email = adminEmail,
                NormalizedEmail = adminEmail.ToUpper(),
                EmailConfirmed = true,
                UserName = "adam",
                NormalizedUserName = "ADAM",
                PasswordHash = hasher.HashPassword(null, "zaq1@WSX"),
                SecurityStamp = string.Empty
            };

            modelBuilder.Entity<IdentityUser>().HasData(admin);

            modelBuilder.Entity<IdentityUserRole<string>>()
            .HasData(new IdentityUserRole<string>
            {
                RoleId = ADMIN_ROLE_ID,
                UserId = ADMIN_ID
            });

            string USER_ID = Guid.NewGuid().ToString();
            string USER_ROLE_ID = Guid.NewGuid().ToString();

            modelBuilder.Entity<IdentityRole>().HasData(new IdentityRole
            {
                Name = "user",
                NormalizedName = "USER",
                Id = USER_ROLE_ID,
                ConcurrencyStamp = USER_ROLE_ID
            });

            var userEmail = "jacek@wsei.edu.pl";

            var user = new IdentityUser
            {
                Id = USER_ID,
                Email = userEmail,
                NormalizedEmail = userEmail.ToUpper(),
                EmailConfirmed = true,
                UserName = "jacek",
                NormalizedUserName = "JACEK",
                PasswordHash = hasher.HashPassword(null, "zaq1@WSX"),
                SecurityStamp = string.Empty
            };

            modelBuilder.Entity<IdentityUser>().HasData(user);

            modelBuilder.Entity<IdentityUserRole<string>>()
            .HasData(new IdentityUserRole<string>
            {
                RoleId = USER_ROLE_ID,
                UserId = USER_ID
            });

            modelBuilder.Entity<ComputerEntity>()
                .HasOne(c => c.Processor)
                .WithMany(p => p.Computers)
                .HasForeignKey(c => c.ProcessorId);

            modelBuilder.Entity<ComputerEntity>()
                .HasOne(c => c.Storage)
                .WithMany(s => s.Computers)
                .HasForeignKey(s => s.StorageId);

            modelBuilder.Entity<ComputerEntity>()
                .HasOne(c => c.GraphicsCard)
                .WithMany(g => g.Computers)
                .HasForeignKey(g => g.GraphicsCardId);

            modelBuilder.Entity<ProcessorEntity>().HasData(
                    new ProcessorEntity()
                    {
                        Id = 1,
                        Name = "Intel Core i5-13600K",
                        CoreCount = 14,
                        CacheSize = 24
                    },
                    new ProcessorEntity()
                    {
                        Id = 2,
                        Name = "AMD Ryzen 5 3600",
                        CoreCount = 6,
                        CacheSize = 35
                    }
                );

            modelBuilder.Entity<StorageEntity>().HasData(
                    new StorageEntity()
                    {
                        Id = 1,
                        Name = "ADATA Ultimate SU650",
                        Type = "SSD",
                        Size = 1000
                    },
                    new StorageEntity()
                    {
                        Id = 2,
                        Name = "SAMSUNG 980",
                        Type = "SSD",
                        Size = 500
                    }
                );

            modelBuilder.Entity<GraphicsCardEntity>().HasData(
                    new GraphicsCardEntity()
                    {
                        Id = 1,
                        Name = "GeForce RTX 4070",
                        Memory = 12
                    },
                    new GraphicsCardEntity()
                    {
                        Id = 2,
                        Name = "Radeon RX 6600",
                        Memory = 8
                    }
                );

            modelBuilder.Entity<ComputerEntity>().HasData(
                new ComputerEntity() { 
                    Id = 1,
                    Name = "Beast 3X8",
                    ProcessorId = 1,
                    StorageId = 1,
                    GraphicsCardId = 1,
                    ComputerType = ComputerType.Gaming,
                    Manufacturer= "SaradaManu",
                    DateOfManufacture = new DateTime(2023, 4, 19)
                },
                new ComputerEntity() {
                    Id = 2,
                    Name = "Workload B30",
                    ProcessorId = 2,
                    StorageId = 2,
                    GraphicsCardId = 2,
                    ComputerType = ComputerType.Premium,
                    Manufacturer = "AlbinoPC",
                    DateOfManufacture = new DateTime(2023, 8, 07)
                }
            );
        }
    }
}
