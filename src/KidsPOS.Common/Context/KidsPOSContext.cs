using KidsPOS.Common.Enums;
using KidsPOS.Common.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata;

namespace KidsPOS.Common.Context
{
    public class KidsPOSContext : DbContext
    {
        public virtual DbSet<Product> Products { get; set; }
        public virtual DbSet<Receipt> Receipts  { get; set; }
        public virtual DbSet<ReceiptItem> ReceiptItems { get; set; }

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

            builder.Entity<Product>(entity =>
            {
                entity.HasData(new Product()
                {
                    ProductId = 1,
                    Name = "Goldfish",
                    Description = "",
                    Category = Categories.Dry,
                    Price = 1.78,
                    Quantity = 0,
                    Image = "https://d2aam04nmhpdf8.cloudfront.net/images/images/000/101/932/xlarge/e5y9wzbekyxx8zrzuvjz.png",
                    ProductGuid = Guid.NewGuid()
                });
            });
        }
    }
}
