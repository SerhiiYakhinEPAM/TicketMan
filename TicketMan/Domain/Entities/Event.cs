namespace TicketMan.Domain.Entities
{
    public class Event
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public DateOnly Date { get; set; }
        public TimeOnly Time { get; set; }
        public int VenueId { get; set; }
        public Venue Venue { get; set; }
        public ICollection<Offer> Offers { get; set; }
        public ICollection<Ticket> Tickets { get; set; }
    }
}