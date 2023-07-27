using TicketBooking.API.DBContext;
using TicketBooking.API.Interfaces;
using TicketBooking.API.Models;

namespace TicketBooking.API.Repository
{
	public class CategoryRepository : ICategoryRepository
	{
		private readonly ApplicationDbContext __dbContext;

		public CategoryRepository(ApplicationDbContext applicationDbContext)
		{
			__dbContext = applicationDbContext;
		}

		public List<Category> GetCategories()
		{
			var result = __dbContext.Categories.Where(c => !c.IsDeleted).ToList();
			return result;
		}
  }
}