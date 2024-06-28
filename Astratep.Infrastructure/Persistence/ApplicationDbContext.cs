using Astratep.Domain.Entities;
using Microsoft.EntityFrameworkCore;

namespace Astratep.Infrastructure.Persistence
{
    internal class ApplicationDbContext(DbContextOptions<ApplicationDbContext> options) : DbContext(options)
    {
        internal DbSet<Affiliate> Affiliates { get; set; }
        internal DbSet<Company> Companies { get; set; }
        internal DbSet<Payment> Payments { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);

            modelBuilder.Entity<Affiliate>()
                .HasMany(a => a.Companies)
                .WithMany(c => c.Affiliates);

            modelBuilder.Entity<Payment>()
                .HasOne(p => p.Affiliate)
                .WithMany(a => a.Payments)
                .HasForeignKey(p => p.AffiliateID)
                .IsRequired();
        }
    }
}
