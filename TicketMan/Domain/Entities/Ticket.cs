﻿namespace TicketMan.Domain.Entities
{
    public class Ticket
    {
        public int Id { get; set; }
        public DateTime PurchaseDate { get; set; }
        public bool IsUsed { get; set; }
        public int EventId { get; set; }
        public int UserId { get; set; }
        public int SeatId { get; set; }
        public int PriceId { get; set; }
        public Event Event { get; set; }
        public User User { get; set; }
        public Seat Seat { get; set; }
        public Price Price { get; set; }
    }
}