using Microsoft.EntityFrameworkCore;

namespace FullScaffoldingTrainingProject.Models;

public class TrainingProjectDbContext : DbContext
{
    public DbSet<Product> Product { get; set; }
    public DbSet<Person> Person { get; set; }

    public TrainingProjectDbContext(DbContextOptions options) : base(options)
    {
        
    }

    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        base.OnModelCreating(modelBuilder);
    }
}
