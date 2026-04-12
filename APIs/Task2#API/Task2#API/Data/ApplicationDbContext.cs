using Microsoft.EntityFrameworkCore;
using Task2_API.Data;

namespace Task2_API.Data
{
    public class ApplicationDbContext : DbContext
    {
        public ApplicationDbContext(DbContextOptions options) : base(options)
        {

        }
        
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);
            modelBuilder.Entity<JobListing>().ToTable("JobListing");
        }
        public DbSet<Task2_API.Data.JobListing> JobListing { get; set; } = default!;
    }
}
