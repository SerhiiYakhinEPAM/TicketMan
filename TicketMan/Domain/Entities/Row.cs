namespace TicketMan.Domain.Entities;

public partial class Row
{
    public int Id { get; set; }

    public int? SectionId { get; set; }

    public int? RowNumber { get; set; }

    public virtual ICollection<Price> Prices { get; set; } = new List<Price>();

    public virtual ICollection<Seat> Seats { get; set; } = new List<Seat>();

    public virtual Section? Section { get; set; }
}
