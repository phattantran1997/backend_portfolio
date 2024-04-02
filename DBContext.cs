using Microsoft.EntityFrameworkCore;

public class ApplicationDBContext : DbContext
{
    public ApplicationDBContext(DbContextOptions<ApplicationDBContext> options)
       : base(options)
    {
    }

    public DbSet<Experience> Experiences { get; set; }

    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        base.OnModelCreating(modelBuilder);
        modelBuilder.Entity<Experience>(entity =>
        {
            entity.HasKey(e => e.ID);
            entity.Property(e => e.role).IsRequired();
            entity.Property(e => e.nameOfCompany).IsRequired();
            entity.Property(e => e.shortDescription).IsRequired();
            entity.Property(e => e.longDescription).IsRequired();
            entity.Property(e => e.period).IsRequired();
            entity.Property(e => e.highlightSkills).IsRequired();
        });
    }
}