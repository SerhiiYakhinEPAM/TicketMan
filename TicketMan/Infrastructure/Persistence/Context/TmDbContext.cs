using Microsoft.EntityFrameworkCore;
using System.Reflection;
using TicketMan.Application.Common.Interfaces;
using TicketMan.Domain.Entities;

namespace TicketMan.Infrastructure.Persistence.Context;

public class TmDbContext : DbContext, ITmDbContext
{
    public TmDbContext()
    {
    }

    public TmDbContext(DbContextOptions<TmDbContext> options)
        : base(options)
    {
    }

    public virtual DbSet<Event> Events { get; set; }

    public virtual DbSet<Manifest> Manifests { get; set; }

    public virtual DbSet<Offer> Offers { get; set; }

    public virtual DbSet<Price> Prices { get; set; }

    public virtual DbSet<PriceType> PriceTypes { get; set; }

    public virtual DbSet<Row> Rows { get; set; }

    public virtual DbSet<Seat> Seats { get; set; }

    public virtual DbSet<Section> Sections { get; set; }

    public virtual DbSet<Ticket> Tickets { get; set; }

    public virtual DbSet<User> Users { get; set; }

    public virtual DbSet<UserRole> UserRoles { get; set; }

    public virtual DbSet<Venue> Venues { get; set; }

    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        base.OnModelCreating(modelBuilder);
        var assembly = Assembly.GetExecutingAssembly();
        modelBuilder.ApplyConfigurationsFromAssembly(assembly);
    }
}
