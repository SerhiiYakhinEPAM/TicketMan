namespace TicketMan.Domain.Entities;

public partial class Venue
{
    public int Id { get; set; }

    public string? Name { get; set; }

    public string? Location { get; set; }

    public virtual ICollection<Event> Events { get; set; } = new List<Event>();

    public virtual ICollection<Manifest> Manifests { get; set; } = new List<Manifest>();
}
