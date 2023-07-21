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
				return __dbContext.Events.OrderBy(x=>x.Date).ToList();
			}
    }
}