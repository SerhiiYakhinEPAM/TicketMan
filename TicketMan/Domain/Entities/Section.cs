namespace TicketMan.Domain.Entities;

public partial class Section
{
    public int Id { get; set; }

    public int? ManifestId { get; set; }

    public string? Name { get; set; }

    public virtual Manifest? Manifest { get; set; }

    public virtual ICollection<Price> Prices { get; set; } = new List<Price>();

    public virtual ICollection<Row> Rows { get; set; } = new List<Row>();
}
