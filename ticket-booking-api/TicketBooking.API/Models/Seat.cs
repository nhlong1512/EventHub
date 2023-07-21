using TicketBooking.API.Enum;

namespace TicketBooking.API.Models
{
	public class Seat
	{
		public Guid Id { get; set; }
		public string Name { get; set; }
		public SeatType Type { get; set; }
		public DateTime? UpdatedAt { get; set; }
		public DateTime? CreatedAt { get; set; }
		public DateTime? DeletedAt { get; set; }
		public bool IsDeleted { get; set; }
		public ICollection<Invoice> Invoices { get; set; }
		public ICollection<Event> Events { get; set; }
	}
}