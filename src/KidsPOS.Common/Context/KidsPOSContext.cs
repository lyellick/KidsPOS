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
                },
                new Product()
                {
                    ProductId = 2,
                    Name = "Yellow Cake Mix",
                    Description = "",
                    Category = Categories.Dry,
                    Price = 1.48,
                    Quantity = 0,
                    Image = "https://cdn.shopify.com/s/files/1/0071/0420/0763/products/BettyCrockerSuperMoistYellowCakeMix_15.25oz_540x.png",
                    ProductGuid = Guid.NewGuid()
                },
                new Product()
                {
                    ProductId = 3,
                    Name = "Cream Cheese",
                    Description = "",
                    Category = Categories.Dairy,
                    Price = 3.98,
                    Quantity = 0,
                    Image = "https://cdn.shopify.com/s/files/1/0270/6410/7107/products/Screen-Shot-2019-10-24-at-3.28.13-PM_fc3e580e-8a2d-45a8-a40a-d3e40d4a3dad_615x.gif",
                    ProductGuid = Guid.NewGuid()
                },
                new Product()
                {
                    ProductId = 4,
                    Name = "Cheez-It",
                    Description = "",
                    Category = Categories.Dry,
                    Price = 3.46,
                    Quantity = 0,
                    Image = "https://images.kglobalservices.com/www.cheezit.com/en_us/product/product_4821790/prod_img-8235260_optimized_orig_00024100705665_c1l1.png",
                    ProductGuid = Guid.NewGuid()
                },
                new Product()
                {
                    ProductId = 5,
                    Name = "Teddy Grahams",
                    Description = "",
                    Category = Categories.Dry,
                    Price = 3.68,
                    Quantity = 0,
                    Image = "https://www.discoverteddy.com/images/products/detail/honey-product.png",
                    ProductGuid = Guid.NewGuid()
                },
                new Product()
                {
                    ProductId = 6,
                    Name = "Vanilla Waffers",
                    Description = "",
                    Category = Categories.Dry,
                    Price = 1.79,
                    Quantity = 0,
                    Image = "https://api.hy-vee.cloud/cdn-cgi/image/f=auto,w=640,q=60,dpr=1/https://e22d0640933e3c7f8c86-34aee0c49088be50e3ac6555f6c963fb.ssl.cf2.rackcdn.com/0075450174490_CL_default_default_large.jpeg",
                    ProductGuid = Guid.NewGuid()
                },
                new Product()
                {
                    ProductId = 7,
                    Name = "Jell-O",
                    Description = "",
                    Category = Categories.Dry,
                    Price = 1.24,
                    Quantity = 0,
                    Image = "https://shopfoodex.com/images/043000205563.gif",
                    ProductGuid = Guid.NewGuid()
                },
                new Product()
                {
                    ProductId = 8,
                    Name = "Soda",
                    Description = "",
                    Category = Categories.Canned,
                    Price = 4.88,
                    Quantity = 0,
                    Image = "https://i5.walmartimages.com/asr/244a77a1-6754-4706-9cbf-fe6977930ef7.4faef0eb4936c9b49537103fc7341b53.jpeg",
                    ProductGuid = Guid.NewGuid()
                },
                new Product()
                {
                    ProductId = 9,
                    Name = "Bananas",
                    Description = "",
                    Category = Categories.Fruit,
                    Price = 0.75,
                    Quantity = 0,
                    Image = "https://www.dolenz.co.nz/uploads/cache/img/rc/UlbhALJo//uploads/media/5ad5653d97b82/fruit-heros-banana-new.png",
                    ProductGuid = Guid.NewGuid()
                },
                new Product()
                {
                    ProductId = 10,
                    Name = "Grapes",
                    Description = "",
                    Category = Categories.Fruit,
                    Price = 0.82,
                    Quantity = 0,
                    Image = "https://www.dole.com/-/media/project/dole/produce-images/fruit/grapes_web.png?rev=f0477eb188cb4f1ea07a564bb4da4e96&hash=C3D6FA59C04498E8F4BE377697436DAC",
                    ProductGuid = Guid.NewGuid()
                });
            });
        }
    }
}
