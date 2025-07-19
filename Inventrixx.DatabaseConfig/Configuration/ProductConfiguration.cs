using Inventrixx.Database.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Inventrixx.DatabaseConfig.Configuration
{
    public class ProductConfiguration : IEntityTypeConfiguration<Product>
    {
        public void Configure(EntityTypeBuilder<Product> builder)
        {
            builder.ToTable("Product");
            builder.HasKey(e => e.Id);
            builder.Property(e => e.Name)
                   .HasMaxLength(100)
                   .IsUnicode(false)
                   .IsRequired();
            builder.Property(e => e.Tax)
                   .HasColumnType("decimal(5,2)");
            builder.HasOne(e => e.Category)
                   .WithMany(c => c.Products)
                   .HasForeignKey(e => e.CategoryId)
                   .OnDelete(DeleteBehavior.ClientSetNull);
        }
    }

}
