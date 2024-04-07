using Microsoft.EntityFrameworkCore;

public class ApplicationDBContext : DbContext
{
    public ApplicationDBContext(DbContextOptions<ApplicationDBContext> options)
       : base(options)
    {
    }

    public DbSet<Experience> Experiences { get; set; }
    public DbSet<Publication> Publications { get; set; }

    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        base.OnModelCreating(modelBuilder);
        modelBuilder.Entity<Experience>(entity =>
        {
            entity.Property(e => e.role).IsRequired();
            entity.Property(e => e.nameOfCompany).IsRequired();
            entity.Property(e => e.shortDescription).IsRequired();
            entity.Property(e => e.longDescription).IsRequired();
            entity.Property(e => e.period).IsRequired();
            entity.Property(e => e.highlightSkills).IsRequired();
            entity.Property(e => e.type).IsRequired();
            entity.Property(e => e.image).IsRequired();
        });
        modelBuilder.Entity<Publication>(entity =>
        {
            entity.Property(e => e.name).IsRequired();
            entity.Property(e => e.place).IsRequired();
            entity.Property(e => e.period).IsRequired();
            entity.Property(e => e.type).IsRequired();
            entity.Property(e => e.longDescription).IsRequired();
            entity.Property(e => e.image).IsRequired();
        });
    }
}