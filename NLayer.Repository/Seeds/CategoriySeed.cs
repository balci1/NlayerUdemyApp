using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Nlayer.Core;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
///Projelerimizin çoğunda, oluşturulan veritabanında bazı 
///ilk verilere sahip olmak isteyebiliriz. Bu nedenle, 
///veritabanını oluşturmak ve yapılandırmak için geçiş dosyalarımızı çalıştırır çalıştırmaz,
///otomatik olarak bazı başlangıç verileriyle doldururuz. Bu eyleme “Data Seeding” yani Veri Tohumlama denir.
namespace NLayer.Repository.Seeds
{
    internal class CategoriySeed : IEntityTypeConfiguration<Category>
    {
        public void Configure(EntityTypeBuilder<Category> builder)
        {
            builder.HasData(
                new Category { Id = 1, Name = "Kalemler" },
                new Category { Id = 2, Name = "Kitaplar" },
                new Category { Id = 3, Name = "Defterler" });
        }
    }
}
