using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using TicketMan.Domain.Entities;

namespace TicketMan.Infrastructure.Persistence.Configurations;

public class TicketConfiguration : IEntityTypeConfiguration<Ticket>
{
    public void Configure(EntityTypeBuilder<Ticket> builder)
    {
        builder.HasKey(t => t.Id);

        builder.Property(t => t.PurchaseDate)
            .IsRequired()
            .HasColumnType("datetime2");

        builder.Property(t => t.IsUsed)
            .IsRequired()
            .HasColumnType("bit");

        builder.HasOne(t => t.Event)
            .WithMany(e => e.Tickets)
            .HasForeignKey(t => t.EventId)
            .OnDelete(DeleteBehavior.NoAction); // Изменение каскадного удаления на NO ACTION

        builder.HasOne(t => t.User)
            .WithMany(u => u.Tickets)
            .HasForeignKey(t => t.UserId)
            .OnDelete(DeleteBehavior.NoAction); // Изменение каскадного удаления на NO ACTION

        builder.HasOne(t => t.Seat)
            .WithMany(s => s.Tickets)
            .HasForeignKey(t => t.SeatId)
            .OnDelete(DeleteBehavior.NoAction); // Изменение каскадного удаления на NO ACTION

        builder.HasOne(t => t.Price)
            .WithMany(p => p.Tickets)
            .HasForeignKey(t => t.PriceId)
            .OnDelete(DeleteBehavior.NoAction); // Изменение каскадного удаления на NO ACTION
    }
}