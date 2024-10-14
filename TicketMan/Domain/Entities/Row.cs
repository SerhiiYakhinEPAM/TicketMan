namespace TicketMan.Domain.Entities
{
    public class Row
    {
        public int Id { get; set; }
        public int RowNumber { get; set; }
        public int SectionId { get; set; }
        public Section Section { get; set; }
        public ICollection<Seat> Seats { get; set; }
        public ICollection<Price> Prices { get; set; }
    }
}