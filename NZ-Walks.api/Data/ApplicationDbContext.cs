using Microsoft.EntityFrameworkCore;
using NZ_Walks.api.Models.Domain;

namespace NZ_Walks.api.Data
{
    public class ApplicationDbContext:DbContext
    {
        public DbSet<Difficulty> Difficulties { get; set; }
        public DbSet<Region> Regions { get; set; }
        public DbSet<Walk> Walks { get; set; }
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options) : base(options)
        {
        }
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);

        }
    }
}
