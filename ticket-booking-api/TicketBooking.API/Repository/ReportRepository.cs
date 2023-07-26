using TicketBooking.API.Dto;
using TicketBooking.API.EF;
using TicketBooking.API.Interfaces;
using TicketBooking.API.Models;
using Microsoft.EntityFrameworkCore;

namespace TicketBooking.API.Repository
{
	public class ReportRepository : IReportRepository
	{
		private readonly ApplicationDbContext __dbContext;

		public ReportRepository(ApplicationDbContext dbContext)
		{
			__dbContext = dbContext;
		}

		public List<EventsInMonth> GetEventsInMonths()
		{
			var events = GetEventCurrentYear();
			List<EventsInMonth> result = new();

			for(var month = 1; month <= 12; month += 1)
			{
				var eventCount = 0;
				foreach (var e in events)
				{
					if(e.Date.Month == month)
						eventCount += 1;
				}
        result.Add(new EventsInMonth() { Month = month, EventNumber = eventCount });
			}

			return result;
		}

		public List<RevenueInMonth> GetRevenueInMonths()
		{
			var events = GetEventCurrentYear();
			List<RevenueInMonth> result = new();

			for(var month = 1; month <= 12; month += 1)
			{
				var revenue = 0;
				foreach (var e in events)
				{
					if(e.Date.Month == month)
						revenue += GetEventRevenue(e);
				}
        result.Add(new RevenueInMonth() { Month = month, Revenue = revenue });
			}

			return result;
		}

		private int GetEventRevenue(Event e)
		{
			return 0;
		}

		private List<Event> GetEventCurrentYear()
		{
			var events = __dbContext.Events
				.Where(e => !e.IsDeleted)
				.Where(e => e.IsPublished)
				.Where(e => e.Date.Year == DateTime.Now.Year)
				.Include(e => e.Invoices)
				.Include(e => e.SeatEvents)
				.ToList();

			return events;
		}
  }
}