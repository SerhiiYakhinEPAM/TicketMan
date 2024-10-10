using Microsoft.EntityFrameworkCore;
using TicketMan.Domain.Entities;

namespace TicketMan.Application.Common.Interfaces
{
    public interface ITmDbContext
    {
        DbSet<Event> Events { get; set; }

        DbSet<Manifest> Manifests { get; set; }

        DbSet<Offer> Offers { get; set; }

        DbSet<Price> Prices { get; set; }

        DbSet<PriceType> PriceTypes { get; set; }

        DbSet<Row> Rows { get; set; }

        DbSet<Seat> Seats { get; set; }

        DbSet<Section> Sections { get; set; }

        DbSet<Ticket> Tickets { get; set; }

        DbSet<User> Users { get; set; }

        DbSet<UserRole> UserRoles { get; set; }

        DbSet<Venue> Venues { get; set; }

        Task<int> SaveChangesAsync(CancellationToken cancellationToken);
    }
}
