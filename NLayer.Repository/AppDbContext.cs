using Microsoft.EntityFrameworkCore;
using Nlayer.Core;
using NLayer.Repository.Configurations;
using System.Reflection;

namespace NLayer.Repository
{
    public class AppDbContext : DbContext
    {

        public AppDbContext(DbContextOptions<AppDbContext> options) : base(options)
        {

        }
        public DbSet<Category> Categories { get; set; }
        public DbSet<Product> Products { get; set; }
        public DbSet<ProductFeature> ProductFeatures { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            ///bunu 22. bölümde anlatıyor
            ///her bir katman aslında Assembly dir.
            ///bu metot nlayer.repostory deki tüm configuration classlarını reflaction
            ///yaparak buluyor
            modelBuilder.ApplyConfigurationsFromAssembly(Assembly.GetExecutingAssembly());

            //böylede tek tek yazılabilir wiseda da böyle tek tek yazılmış
            //modelBuilder.ApplyConfiguration(new ProductConfiguration());


            //burda yazılabildiğini göstermek için örnek olsun diye yazdık.
            //best practice olarak Seeds fieldının içinde yazıyoruz.burayı kirletmiyoruz
            modelBuilder.Entity<ProductFeature>().HasData(
                new ProductFeature()
                {
                    Id = 1,
                    Color = "Kırmızı",
                    Height = 100,
                    Width = 200,
                    ProductId = 1,
                },
                new ProductFeature()
                {
                    Id = 2,
                    Color = "Mavi",
                    Height = 200,
                    Width = 500,
                    ProductId = 2,
                }
                
                );

            base.OnModelCreating(modelBuilder);
        }
    }
}
