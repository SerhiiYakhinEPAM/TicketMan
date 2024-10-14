using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using TicketMan.Domain.Entities;

namespace TicketMan.Infrastructure.Persistence.Configurations;

public class SeatConfiguration : IEntityTypeConfiguration<Seat>
{
    public void Configure(EntityTypeBuilder<Seat> builder)
    {
        builder.HasKey(s => s.Id);

        builder.Property(s => s.SeatNumber)
            .IsRequired()
            .HasColumnType("nvarchar(max)");

        builder.Property(s => s.IsGeneralAdmission)
            .IsRequired()
            .HasColumnType("bit");

        builder.Property(s => s.IsReserved)
            .IsRequired()
            .HasColumnType("bit");

        builder.HasOne(s => s.Row)
            .WithMany(r => r.Seats)
            .HasForeignKey(s => s.RowId)
            .OnDelete(DeleteBehavior.NoAction);

        builder.HasOne(s => s.Offer)
            .WithMany(o => o.Seats)
            .HasForeignKey(s => s.OfferId)
            .OnDelete(DeleteBehavior.NoAction);
    }
}