using Inventrixx.Database.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Inventrixx.DatabaseConfig.Configuration
{
    public class ProductPriceConfiguration : IEntityTypeConfiguration<ProductPrice>
    {
        public void Configure(EntityTypeBuilder<ProductPrice> builder)
        {
            builder.ToTable("ProductPrice");
            builder.HasKey(e => e.Id);
            builder.Property(e => e.Price)
                   .HasColumnType("decimal(10,2)");
            builder.Property(e => e.EffectiveFrom).IsRequired();
            builder.Property(e => e.EffectiveTo).IsRequired();
            builder.HasOne(e => e.Product)
                   .WithMany(p => p.ProductPrices)
                   .HasForeignKey(e => e.ProductId)
                   .OnDelete(DeleteBehavior.ClientSetNull);
        }
    }

}
