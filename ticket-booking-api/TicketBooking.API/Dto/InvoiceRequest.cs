namespace TicketBooking.API.Dto
{
	public class InvoiceRequest
	{
		public string Name { get; set; }
		public string Mail { get; set; }
		public string Phone { get; set; }
		public string EventId { get; set; }
		public List<string> seatIds { get; set; }
	}
}