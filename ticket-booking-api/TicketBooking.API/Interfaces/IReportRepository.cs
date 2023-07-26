using TicketBooking.API.Dto;

namespace TicketBooking.API.Interfaces
{
	public interface IReportRepository
	{
		public List<EventsInMonth> GetEventsInMonths();
		public List<RevenueInMonth> GetRevenueInMonths();
	}
}