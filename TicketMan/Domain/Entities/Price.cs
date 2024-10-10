namespace TicketMan.Domain.Entities;

public partial class Price
{
    public int Id { get; set; }

    public int? OfferId { get; set; }

    public int? PriceTypeId { get; set; }

    public int? SectionId { get; set; }

    public int? RowId { get; set; }

    public decimal? Amount { get; set; }

    public virtual Offer? Offer { get; set; }

    public virtual PriceType? PriceType { get; set; }

    public virtual Row? Row { get; set; }

    public virtual Section? Section { get; set; }

    public virtual ICollection<Ticket> Tickets { get; set; } = new List<Ticket>();
}
