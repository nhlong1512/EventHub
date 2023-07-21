using TicketBooking.API.Enum;

namespace TicketBooking.API.Models
{
	public class Chair
	{
		public Guid Id { get; set; }
		public string Name { get; set; }
		public ChairStatus Status { get; set; }
		public ChairType Type { get; set; }
		public int Price { get; set; }
		public DateTime? UpdatedAt { get; set; }
		public DateTime? CreatedAt { get; set; }
		public DateTime? DeletedAt { get; set; }
		public bool IsDeleted { get; set; }
		public Invoice Invoice { get; set; }
		public Event Event { get; set; }
	}
}