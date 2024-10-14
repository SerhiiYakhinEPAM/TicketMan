﻿using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using TicketMan.Domain.Entities;

namespace TicketMan.Infrastructure.Persistence.Configurations;

public class UserConfiguration : IEntityTypeConfiguration<User>
{
    public void Configure(EntityTypeBuilder<User> builder)
    {
        builder.HasKey(u => u.Id);

        builder.Property(u => u.PasswordHash)
            .IsRequired()
            .HasColumnType("nvarchar(max)");

        builder.Property(u => u.Email)
            .IsRequired()
            .HasColumnType("nvarchar(max)");

        builder.Property(u => u.FullName)
            .IsRequired()
            .HasColumnType("nvarchar(max)");

        builder.HasOne(u => u.UserRole)
            .WithMany(ur => ur.Users)
            .HasForeignKey(u => u.UserRoleId);
    }
}