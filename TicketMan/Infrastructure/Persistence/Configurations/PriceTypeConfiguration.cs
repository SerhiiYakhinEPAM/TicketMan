using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using TicketMan.Domain.Entities;

namespace TicketMan.Infrastructure.Persistence.Configurations;

public class PriceTypeConfiguration : IEntityTypeConfiguration<PriceType>
{
    public void Configure(EntityTypeBuilder<PriceType> builder)
    {
        builder.HasKey(pt => pt.Id);

        builder.Property(pt => pt.TypeName)
            .IsRequired()
            .HasMaxLength(128)
            .HasColumnType("nvarchar(128)");
    }
}