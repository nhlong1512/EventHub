using TicketBooking.API.Dto;
using TicketBooking.API.Models;

namespace TicketBooking.API.Interfaces
{
	public interface IEventRepository 
	{
		public ICollection<Event> GetEvents();
		public Event? GetEvent(string eventId);
		public void DeleteEvent(Event e);
		public Task<bool> CreateEvent(EventRequest eventRequest);
  }
}