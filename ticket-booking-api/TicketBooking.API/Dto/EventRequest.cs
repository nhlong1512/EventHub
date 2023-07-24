using System.Buffers.Text;

namespace TicketBooking.API.Dto
{
  public class EventRequest
  {
    public string Id { get; set; }
    public string Image { get; set; }
    public string Title { get; set; }
    public string Duration { get; set; }
    public DateTime Date { get; set; }
    public string Location { get; set; }
    public string? City { get; set; }
    public List<string> Categories { get; set; }
    public List<int> Prices { get; set; }
  }
}