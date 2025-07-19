using Inventrixx.Database.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Inventrixx.DatabaseConfig.Configuration
{
    public class InvoiceConfiguration : IEntityTypeConfiguration<Invoice>
    {
        public void Configure(EntityTypeBuilder<Invoice> builder)
        {
            builder.ToTable("Invoice");
            builder.HasKey(e => e.Id);
            builder.Property(e => e.Date).IsRequired();
            builder.Property(e => e.ActualTotal)
                   .HasColumnType("decimal(10,2)");
            builder.Property(e => e.TotalTax)
                   .HasColumnType("decimal(10,2)");
            builder.Property(e => e.GrandTotal)
                   .HasColumnType("decimal(10,2)");
            builder.HasOne(e => e.Customer)
                   .WithMany(c => c.Invoices)
                   .HasForeignKey(e => e.CustomerId)
                   .OnDelete(DeleteBehavior.ClientSetNull);
        }
    }

}
