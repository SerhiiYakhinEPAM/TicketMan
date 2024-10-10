namespace TicketMan.Domain.Entities;

public partial class Manifest
{
    public int Id { get; set; }

    public int? VenueId { get; set; }

    public string? Name { get; set; }

    public virtual ICollection<Section> Sections { get; set; } = new List<Section>();

    public virtual Venue? Venue { get; set; }
}
