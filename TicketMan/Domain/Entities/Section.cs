namespace TicketMan.Domain.Entities
{
    public class Section
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public int ManifestId { get; set; }
        public Manifest Manifest { get; set; }
        public ICollection<Row> Rows { get; set; }
        public ICollection<Price> Prices { get; set; }
    }
}