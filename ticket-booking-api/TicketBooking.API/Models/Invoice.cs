namespace TicketBooking.API.Models
{
	public class Invoice
	{
		public string Id { get; set; }
		public string Name { get; set; }
		public string Mail { get; set; }
		public string Phone { get; set; }
		public DateTime? UpdatedAt { get; set; }
		public DateTime? CreatedAt { get; set; }
		public DateTime? DeletedAt { get; set; }
		public bool IsDeleted { get; set; }
		public ICollection<Seat> Seats { get; set; }
		public string EventId { get; set; }
		public Event Event { get; set; }
	}
}