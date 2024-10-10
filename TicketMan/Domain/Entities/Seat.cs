namespace TicketMan.Domain.Entities;

public partial class Seat
{
    public int Id { get; set; }

    public int? RowId { get; set; }

    public string? SeatNumber { get; set; }

    public bool? IsGeneralAdmission { get; set; }

    public int? OfferId { get; set; }

    public bool? IsReserved { get; set; }

    public virtual Offer? Offer { get; set; }

    public virtual Row? Row { get; set; }

    public virtual ICollection<Ticket> Tickets { get; set; } = new List<Ticket>();
}
