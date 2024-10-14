namespace TicketMan.Domain.Entities
{
    public class Venue
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Location { get; set; }
        public ICollection<Event> Events { get; set; }
        public ICollection<Manifest> Manifests { get; set; }
    }
}