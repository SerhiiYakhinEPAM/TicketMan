namespace TicketMan.Domain.Entities
{
    public class PriceType
    {
        public int Id { get; set; }
        public string TypeName { get; set; }
        public ICollection<Price> Prices { get; set; }
    }
}