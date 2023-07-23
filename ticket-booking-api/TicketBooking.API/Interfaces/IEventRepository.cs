using TicketBooking.API.Models;

namespace TicketBooking.API.Interfaces
{
	public interface IEventRepository 
	{
		public ICollection<Event> GetEvents();
		public Event? GetEvent(string eventId);
    }
}