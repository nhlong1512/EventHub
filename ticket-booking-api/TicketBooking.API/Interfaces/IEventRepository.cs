using TicketBooking.API.Dto;
using TicketBooking.API.Models;

namespace TicketBooking.API.Interfaces
{
	public interface IEventRepository 
	{
		public ICollection<Event> GetPublishedEvents();
		public ICollection<Event> GetUnPublishedEvents();
		public Event? GetEvent(string eventId);
		public Task<bool> CreateEvent(EventRequest eventRequest);
		public bool SetPublished(Event e);
		public bool DeleteEvent(Event e);
  }
}