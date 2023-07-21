namespace TicketBooking.API.Models
{
	public class Seat_Invoice
	{
		public Guid SeatId 	{ get; set; }
		public Guid InvoiceId 	{ get; set; }
		public Seat Seat { get; set; }
		public Invoice Invoice { get; set; }
	}
}