namespace TicketMan.Domain.Entities
{
    public class Manifest
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public int VenueId { get; set; }
        public Venue Venue { get; set; }
        public ICollection<Section> Sections { get; set; }
    }
}