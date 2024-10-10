namespace TicketMan.Domain.Entities;

public partial class Event
{
    public int Id { get; set; }

    public string? Name { get; set; }

    public DateOnly? Date { get; set; }

    public TimeOnly? Time { get; set; }

    public int? VenueId { get; set; }

    public virtual ICollection<Offer> Offers { get; set; } = new List<Offer>();

    public virtual ICollection<Ticket> Tickets { get; set; } = new List<Ticket>();

    public virtual Venue? Venue { get; set; }
}
