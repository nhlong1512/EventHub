namespace TicketBooking.API.Models
{
	public class Event_EventType
	{
		public Guid EventId { get; set; }
		public Guid EventTypeId { get; set; }
		public Event Event { get; set; }
		public EventType EventType{ get; set; }
	}
}