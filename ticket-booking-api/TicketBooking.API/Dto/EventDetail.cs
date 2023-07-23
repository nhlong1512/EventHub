using TicketBooking.API.Models;

namespace TicketBooking.API.Dto
{
  public class EventDetail
  {
    public string Id { get; set; }
    public ICollection<SeatEvent> SeatEvents{ get; set;} 
  }
}