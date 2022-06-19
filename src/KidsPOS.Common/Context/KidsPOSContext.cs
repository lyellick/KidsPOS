using KidsPOS.Common.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata;

namespace KidsPOS.Common.Context
{
    public class KidsPOSContext : DbContext
    {
        public virtual DbSet<Product> Users { get; set; }

        protected KidsPOSContext()
        {
        }

        public KidsPOSContext(DbContextOptions<KidsPOSContext> options) : base(options)
        {
        }

        protected override void OnConfiguring(DbContextOptionsBuilder builder)
        {
        }

        protected override void OnModelCreating(ModelBuilder builder)
        {
            base.OnModelCreating(builder);

            foreach (IMutableEntityType entityType in builder.Model.GetEntityTypes())
                builder.Entity(entityType.ClrType).ToTable(entityType.ClrType.Name);
        }
    }
}
