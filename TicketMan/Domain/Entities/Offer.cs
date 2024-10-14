namespace TicketMan.Domain.Entities
{
    public class Offer
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }
        public int EventId { get; set; }
        public Event Event { get; set; }
        public ICollection<Price> Prices { get; set; }
        public ICollection<Seat> Seats { get; set; }
    }
}