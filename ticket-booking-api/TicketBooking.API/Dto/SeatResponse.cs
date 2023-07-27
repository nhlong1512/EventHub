using TicketBooking.API.Enum;

namespace TicketBooking.API.Dto
{
  public class SeatResponse
  {
    public string Name { get; set; }
    public SeatType Type { get; set; }
    public int Price { get; set; }
  }
}