namespace TicketMan.Domain.Entities
{
    public class Seat
    {
        public int Id { get; set; }
        public string SeatNumber { get; set; }
        public bool IsGeneralAdmission { get; set; }
        public bool IsReserved { get; set; }
        public int RowId { get; set; }
        public int OfferId { get; set; }
        public Row Row { get; set; }
        public Offer Offer { get; set; }
        public ICollection<Ticket> Tickets { get; set; }
    }
}