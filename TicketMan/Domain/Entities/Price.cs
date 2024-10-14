namespace TicketMan.Domain.Entities
{
    public class Price
    {
        public int Id { get; set; }
        public decimal Amount { get; set; }
        public int OfferId { get; set; }
        public int PriceTypeId { get; set; }
        public int SectionId { get; set; }
        public int RowId { get; set; }
        public Offer Offer { get; set; }
        public PriceType PriceType { get; set; }
        public Section Section { get; set; }
        public Row Row { get; set; }
        public ICollection<Ticket> Tickets { get; set; }
    }
}