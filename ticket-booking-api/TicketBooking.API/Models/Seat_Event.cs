using TicketBooking.API.Enum;

namespace TicketBooking.API.Models
{
	public class Seat_Event
	{
		public Guid SeatId	 { get; set; }
		public Seat Seat { get; set; }
		public Guid EventId { get; set; }
		public Event Event { get; set; }
		public SeatStatus SeatStatus { get; set; }
		public int Price { get; set; }
	}
}