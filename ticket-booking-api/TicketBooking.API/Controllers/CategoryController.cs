using Microsoft.AspNetCore.Mvc;
using AutoMapper;
using TicketBooking.API.Interfaces;
using TicketBooking.API.Dto;

namespace TicketBooking.API.Controller
{
	[ApiController]
	[Route("api/[controller]")]
	public class CategoryController : ControllerBase
	{
		private readonly ICategoryRepository __categoryRepository;
		private readonly IMapper __mapper;

		public CategoryController(ICategoryRepository categoryRepository, IMapper mapper)
		{
			__categoryRepository = categoryRepository;
			__mapper = mapper;
		}

		[HttpGet]
		[ProducesResponseType(204, Type = typeof(IEnumerable<CategoryResponse>))]
		public ActionResult GetCategories()
		{
			var result = __mapper
				.Map<List<CategoryResponse>>(__categoryRepository.GetCategories());

			if(!ModelState.IsValid)
			{
				return BadRequest(ModelState);
			}

			return Ok(result);
		}

	}
}