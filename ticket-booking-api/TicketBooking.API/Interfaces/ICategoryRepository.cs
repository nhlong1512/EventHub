using TicketBooking.API.Models;

namespace TicketBooking.API.Interfaces
{
	public interface ICategoryRepository
	{
		public List<Category> GetCategories();
  }
}