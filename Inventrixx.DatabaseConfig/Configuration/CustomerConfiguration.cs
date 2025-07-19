using Inventrixx.Database.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Inventrixx.DatabaseConfig.Configuration
{
    public class CustomerConfiguration : IEntityTypeConfiguration<Customer>
    {
        public void Configure(EntityTypeBuilder<Customer> builder)
        {
            builder.ToTable("Customer");
            builder.HasKey(e => e.Id);
            builder.Property(e => e.Name)
                   .HasMaxLength(100)
                   .IsUnicode(false)
                   .IsRequired();
        }
    }

}
