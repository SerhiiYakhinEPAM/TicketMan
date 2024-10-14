using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using TicketMan.Domain.Entities;

namespace TicketMan.Infrastructure.Persistence.Configurations;

public class RowConfiguration : IEntityTypeConfiguration<Row>
{
    public void Configure(EntityTypeBuilder<Row> builder)
    {
        builder.HasKey(r => r.Id);

        builder.Property(r => r.RowNumber)
            .IsRequired()
            .HasColumnType("int");

        builder.HasOne(r => r.Section)
            .WithMany(s => s.Rows)
            .HasForeignKey(r => r.SectionId)
            .OnDelete(DeleteBehavior.NoAction);
    }
}