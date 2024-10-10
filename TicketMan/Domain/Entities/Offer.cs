namespace TicketMan.Domain.Entities;

public partial class Offer
{
    public int Id { get; set; }

    public int? EventId { get; set; }

    public string? Name { get; set; }

    public string? Description { get; set; }

    public virtual Event? Event { get; set; }

    public virtual ICollection<Price> Prices { get; set; } = new List<Price>();

    public virtual ICollection<Seat> Seats { get; set; } = new List<Seat>();
}
