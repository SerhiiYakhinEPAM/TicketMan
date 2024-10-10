namespace TicketMan.Domain.Entities;

public partial class Ticket
{
    public int Id { get; set; }

    public int? EventId { get; set; }

    public int? UserId { get; set; }

    public int? SeatId { get; set; }

    public int? PriceId { get; set; }

    public DateTime? PurchaseDate { get; set; }

    public bool? IsUsed { get; set; }

    public virtual Event? Event { get; set; }

    public virtual Price? Price { get; set; }

    public virtual Seat? Seat { get; set; }

    public virtual User? User { get; set; }
}
