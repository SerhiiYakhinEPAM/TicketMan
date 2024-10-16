﻿using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using TicketMan.Domain.Entities;

namespace TicketMan.Infrastructure.Persistence.Configurations;

public class ManifestConfiguration : IEntityTypeConfiguration<Manifest>
{
    public void Configure(EntityTypeBuilder<Manifest> builder)
    {
        builder.HasKey(m => m.Id);

        builder.Property(m => m.Name)
            .HasMaxLength(128)
            .HasColumnType("nvarchar(128)");

        builder.HasOne(m => m.Venue)
            .WithMany(v => v.Manifests)
            .HasForeignKey(m => m.VenueId);
    }
}