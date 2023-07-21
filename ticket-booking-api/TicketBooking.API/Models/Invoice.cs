namespace TicketBooking.API.Models
{
	public class Invoice
	{
		public Guid Id { get; set; }
		public string Name { get; set; }
		public string Mail { get; set; }
		public string Phone { get; set; }
		public DateTime? UpdatedAt { get; set; }
		public DateTime? CreatedAt { get; set; }
		public DateTime? DeletedAt { get; set; }
		public bool IsDeleted { get; set; }
		public ICollection<Seat> Seats { get; set; }
		public Guid EventId { get; set; }
		public Event Event { get; set; }
	}
}