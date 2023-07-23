using Microsoft.EntityFrameworkCore;
using TicketBooking.API.EF;
using TicketBooking.API.Interfaces;
using TicketBooking.API.Models;

namespace TicketBooking.API.Repository
{
	public class EventRepository : IEventRepository
	{
		private readonly ApplicationDbContext __dbContext;

		public EventRepository(ApplicationDbContext applicationDbContext)
		{
			__dbContext = applicationDbContext;
		}

		public ICollection<Event> GetEvents()
		{
			var result = __dbContext.Events.
				Where(x=>!x.IsDeleted).
				Include(x => x.Categories).
				ToList();

			foreach(var e in result)
			{
				foreach(var category in e.Categories)
				{
					category.Events = null;
					category.UpdatedAt = null;
					category.CreatedAt = null;
					category.DeletedAt = null;
				}
			}

			return result;
		}

		public Event? GetEvent(string eventId)
		{
			var result = __dbContext.Events
				.Where(x=>(x.Id == eventId) && (!x.IsDeleted))
				.Include(x => x.SeatEvents)
				.ThenInclude(x => x.Seat)
				.FirstOrDefault();

			foreach( var e in result.SeatEvents)
			{
				e.Event = null;
				e.Seat.SeatEvents = null;
				e.Seat.CreatedAt = null;
				e.Seat.UpdatedAt = null;
				e.Seat.DeletedAt = null;
				e.Seat.Invoices = null;
			}

			result.SeatEvents = result.SeatEvents
				.OrderBy(x => x.SeatId[0])
				.ThenBy(x => x.SeatId.Length)
				.ThenBy(x => x.SeatId)
				.ToList();

			return result;
		}
	}
}