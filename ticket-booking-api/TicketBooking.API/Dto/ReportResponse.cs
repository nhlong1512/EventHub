namespace TicketBooking.API.Dto
{
	public class ReportResponse
	{
		public List<EventsInMonth> EventsInMonths { get; set; }
		public List<RevenueInMonth> RevenueInMonths { get; set;}
	}
}