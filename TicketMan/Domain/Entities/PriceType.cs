namespace TicketMan.Domain.Entities;

public partial class PriceType
{
    public int Id { get; set; }

    public string? TypeName { get; set; }

    public virtual ICollection<Price> Prices { get; set; } = new List<Price>();
}
