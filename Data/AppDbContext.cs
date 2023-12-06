using Microsoft.EntityFrameworkCore;

namespace Data
{
    public class AppDbContext : DbContext
    {
        public DbSet<ComputerEntity> Computers { get; set; }
        private string DbPath { get; set; }
        public AppDbContext()
        {
            var folder = Environment.SpecialFolder.LocalApplicationData;
            var path = Environment.GetFolderPath(folder);
            DbPath = Path.Join(path, "contacts.db");
        }
        protected override void OnConfiguring(DbContextOptionsBuilder options) =>
        options.UseSqlite($"Data Source={DbPath}");

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<ComputerEntity>().HasData(
                new ComputerEntity() { Id = 1, Name = "Nazwa 1", Processor = "Procesor 1", Priority = Priority.High, Storage = "512Gb", GraphicsCard = "GK1", Manufacturer= "Apple", DateOfManufacture = new DateTime(2018, 4, 19) },
                new ComputerEntity() { Id = 2, Name = "Nazwa 2", Processor = "Procesor 2", Priority = Priority.Normal, Storage = "1Tb", GraphicsCard = "GK2", Manufacturer = "Samsung", DateOfManufacture = new DateTime(2021, 8, 07) }
            );
        }
    }
}
