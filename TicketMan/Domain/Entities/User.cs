namespace TicketMan.Domain.Entities
{
    public class User
    {
        public int Id { get; set; }
        public string PasswordHash { get; set; }
        public string Email { get; set; }
        public string FullName { get; set; }
        public int UserRoleId { get; set; }
        public UserRole UserRole { get; set; }
        public ICollection<Ticket> Tickets { get; set; }
    }
}