using Microsoft.EntityFrameworkCore;
namespace Task_3_API.Data
{
    public class AppDbContext : DbContext   
    {
        public AppDbContext(DbContextOptions<AppDbContext> options) : base(options)
        {
        }
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);
            modelBuilder.Entity<FeedbackRequest>().ToTable("Feedback");
        }
        public DbSet<FeedbackRequest> Feedback { get; set; } = default!;
    }
}
