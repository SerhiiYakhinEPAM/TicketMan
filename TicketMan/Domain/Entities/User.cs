namespace TicketMan.Domain.Entities;

public partial class User
{
    public int Id { get; set; }

    public string? PasswordHash { get; set; }

    public string? Email { get; set; }

    public string? FullName { get; set; }

    public int? UserRoleId { get; set; }

    public virtual ICollection<Ticket> Tickets { get; set; } = new List<Ticket>();

    public virtual UserRole? UserRole { get; set; }
}
