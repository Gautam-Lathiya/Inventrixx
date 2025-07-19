using Inventrixx.Database.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Inventrixx.DatabaseConfig.Configuration
{
    public class InvoiceDetailConfiguration : IEntityTypeConfiguration<InvoiceDetail>
    {
        public void Configure(EntityTypeBuilder<InvoiceDetail> builder)
        {
            builder.ToTable("InvoiceDetail");
            builder.HasKey(e => e.Id);
            builder.Property(e => e.Rate)
                   .HasColumnType("decimal(10,2)");
            builder.Property(e => e.SubTotal)
                   .HasColumnType("decimal(10,2)");
            builder.Property(e => e.TaxAmount)
                   .HasColumnType("decimal(10,2)");
            builder.Property(e => e.TotalAmount)
                   .HasColumnType("decimal(10,2)");
            builder.HasOne(e => e.Invoice)
                   .WithMany(i => i.InvoiceDetails)
                   .HasForeignKey(e => e.InvoiceId)
                   .OnDelete(DeleteBehavior.ClientSetNull);
            builder.HasOne(e => e.Product)
                   .WithMany(p => p.InvoiceDetails)
                   .HasForeignKey(e => e.ProductId)
                   .OnDelete(DeleteBehavior.ClientSetNull);
        }
    }

}
