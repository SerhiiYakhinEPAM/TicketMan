using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using TicketMan.Domain.Entities;

namespace TicketMan.Infrastructure.Persistence.Configurations;

public class OfferConfiguration : IEntityTypeConfiguration<Offer>
{
    public void Configure(EntityTypeBuilder<Offer> builder)
    {
        builder.HasKey(o => o.Id);

        builder.Property(o => o.Name)
            .IsRequired()
            .HasMaxLength(128)
            .HasColumnType("nvarchar(128)");

        builder.Property(o => o.Description)
            .HasMaxLength(128)
            .HasColumnType("nvarchar(128)");

        builder.HasOne(o => o.Event)
            .WithMany(e => e.Offers)
            .HasForeignKey(o => o.EventId);
    }
}