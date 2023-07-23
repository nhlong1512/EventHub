using TicketBooking.API.Enum;

namespace TicketBooking.API.Models
{
	public class SeatEvent
	{
		public string SeatId { get; set; }
		public string EventId { get; set; }
		public SeatStatus SeatStatus { get; set; }
		public int Price { get; set; }
		public Event Event { get; set; }
		public Seat Seat { get; set; }
	}
}