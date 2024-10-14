using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using TicketMan.Domain.Entities;

namespace TicketMan.Infrastructure.Persistence.Configurations;

public class PriceConfiguration : IEntityTypeConfiguration<Price>
{
    public void Configure(EntityTypeBuilder<Price> builder)
    {
        builder.HasKey(p => p.Id);

        builder.Property(p => p.Amount)
            .IsRequired()
            .HasColumnType("decimal(18,2)");

        builder.HasOne(p => p.Offer)
            .WithMany(o => o.Prices)
            .HasForeignKey(p => p.OfferId);

        builder.HasOne(p => p.PriceType)
            .WithMany(pt => pt.Prices)
            .HasForeignKey(p => p.PriceTypeId);

        builder.HasOne(p => p.Section)
            .WithMany(s => s.Prices)
            .HasForeignKey(p => p.SectionId);

        builder.HasOne(p => p.Row)
            .WithMany(r => r.Prices)
            .HasForeignKey(p => p.RowId);
    }
}