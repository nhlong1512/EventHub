using TicketBooking.API.Enum;

namespace TicketBooking.API.Models
{
  public class Event
  {
    public Guid Id { get; set; }
    public string Image { get; set; }
    public string Title { get; set; }
    public int MinPrice { get; set; }
    public DateTime Date { get; set; }
    public string Location { get; set; }
    public string? City { get; set; }
    public EventStatus Status { get; set; }
    public DateTime? UpdatedAt { get; set; }
    public DateTime? CreatedAt { get; set; }
    public DateTime? DeletedAt { get; set; }
    public bool IsDeleted { get; set; }
    public ICollection<Invoice> Invoices { get; set;} 
    public ICollection<Seat> Seats { get; set;} 
    public ICollection<EventType> Types { get; set;}
  }
}