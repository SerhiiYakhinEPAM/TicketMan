using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using TicketMan.Domain.Entities;

namespace TicketMan.Infrastructure.Persistence.Configurations;

public class SectionConfiguration : IEntityTypeConfiguration<Section>
{
    public void Configure(EntityTypeBuilder<Section> builder)
    {
        builder.HasKey(s => s.Id);

        builder.Property(s => s.Name)
            .IsRequired()
            .HasColumnType("nvarchar(max)");

        builder.HasOne(s => s.Manifest)
            .WithMany(m => m.Sections)
            .HasForeignKey(s => s.ManifestId)
            .OnDelete(DeleteBehavior.NoAction);
    }
}