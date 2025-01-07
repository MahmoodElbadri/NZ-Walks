using Microsoft.EntityFrameworkCore;
using NZ_Walks.api.Models.Domain;

namespace NZ_Walks.api.Data
{
    public class ApplicationDbContext:DbContext
    {
        public DbSet<Difficulty> Difficulties { get; set; }
        public DbSet<Region> Regions { get; set; }
        public DbSet<Walk> Walks { get; set; }
        public DbSet<Image> Images { get; set; }
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options) : base(options)
        {
        }
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);

            List<Difficulty> difficulties = new List<Difficulty>()
            {
                new Difficulty()
                {
                    Id = Guid.NewGuid(),
                    Name = "Easy"
                },
                new Difficulty()
                {
                    Id = Guid.NewGuid(),
                    Name = "Medium"
                },
                new Difficulty()
                {
                    Id = Guid.NewGuid(),
                    Name = "Hard"
                }
            };

            modelBuilder.Entity<Difficulty>().HasData(difficulties);

            List<Region> regions = new List<Region>()
            {
                new Region() {
                    Id = Guid.NewGuid(),
                    Code = "NZ-NZL",
                    Name = "New Zealand",
                    RegionImageUrl = "https://images.unsplash.com/photo-1503376780353-7e6692767b90?ixlib=rb-4.0.3&ixid=MnwxMjA3fDB8MHxwaG90by1wYWdlfHx8fGVufDB8fHx8&auto=format&fit=crop&w=1170&q=80"
                },
                new Region() {
                    Id = Guid.NewGuid(),
                    Code = "AKL",
                    Name = "Auckland",
                    RegionImageUrl = "https://images.unsplash.com/photo-1503376780353-7e6692767b90?ixlib=rb-4.0.3&ixid=MnwxMjA3fDB8MHxwaG90by1wYWdlfHx8fGVufDB8fHx8&auto=format&fit=crop&w=1170&q=80"
                },
                new Region() {
                    Id= Guid.NewGuid(),
                    Code = "WGN",
                    Name = "Wellington",
                    RegionImageUrl = "https://images.unsplash.com/photo-1503376780353-7e6692767b90?ixlib=rb-4.0.3&ixid=MnwxMjA3fDB8MHxwaG90by1wYWdlfHx8fGVufDB8fHx8&auto=format&fit=crop&w=1170&q=80"
                },
                new Region() {
                    Id = Guid.NewGuid(),
                    Code = "MEL",
                    Name = "Melbourne",
                    RegionImageUrl = "https://images.unsplash.com/photo-1503376780353-7e6692767b90?ixlib=rb-4.0.3&ixid=MnwxMjA3fDB8MHxwaG90by1wYWdlfHx8fGVufDB8fHx8&auto=format&fit=crop&w=1170&q=80"
                },
                new Region() {
                    Id = Guid.NewGuid(),
                    Code = "SDY",
                    Name = "Sydney",
                    RegionImageUrl = "https://images.unsplash.com/photo-1503376780353-7e6692767b90?ixlib=rb-4.0.3&ixid=MnwxMjA3fDB8MHxwaG90by1wYWdlfHx8fGVufDB8fHx8&auto=format&fit=crop&w=1170&q=80"
                },
                new Region() {
                    Id= Guid.NewGuid(),
                    Code = "NSW",
                    Name = "New South Wales",
                    RegionImageUrl = "https://images.unsplash.com/photo-1503376780353-7e6692767b90?ixlib=rb-4.0.3&ixid=MnwxMjA3fDB8MHxwaG90by1wYWdlfHx8fGVufDB8fHx8&auto=format&fit=crop&w=1170&q=80"
                },
                new Region() {
                    Id = Guid.NewGuid(),
                    Code = "VIC",
                    Name = "Victoria",
                    RegionImageUrl = "https://images.unsplash.com/photo-1503376780353-7e6692767b90?ixlib=rb-4.0.3&ixid=MnwxMjA3fDB8MHxwaG90by1wYWdlfHx8fGVufDB8fHx8&auto=format&fit=crop&w=1170&q=80"
                },
                new Region() {
                    Id = Guid.NewGuid(),
                    Code = "QLD",
                    Name = "Queensland",
                    RegionImageUrl = "https://images.unsplash.com/photo-1503376780353-7e6692767b90?ixlib=rb-4.0.3&ixid=MnwxMjA3fDB8MHxwaG90by1wYWdlfHx8fGVufDB8fHx8&auto=format&fit=crop&w=1170&q=80"
                }
            };

            modelBuilder.Entity<Region> ().HasData(regions);
        }
    }
}
