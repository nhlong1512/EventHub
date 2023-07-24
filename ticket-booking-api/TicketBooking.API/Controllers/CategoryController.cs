using Microsoft.AspNetCore.Mvc;
using TicketBooking.API.Interfaces;
using AutoMapper;
using TicketBooking.API.Dto;

namespace TicketBooking.API.Controller
{
	[ApiController]
	[Route("api/[controller]")]
	public class CategoryController : ControllerBase
	{
		private readonly ICategoryRepository __categoryReposirory;
		private readonly IMapper __mapper;

		public CategoryController(ICategoryRepository categoryReposirory, IMapper mapper)
		{
			__categoryReposirory = categoryReposirory;
			__mapper = mapper;
		}

		[HttpGet]
		[ProducesResponseType(200, Type = typeof(IEnumerable<CategoryResponse>))]
		public ActionResult GetCategories()
		{
			var result = __mapper.Map<List<CategoryResponse>>(__categoryReposirory.GetCategories());

			if(!ModelState.IsValid)
			{
				return BadRequest();
			}

			return Ok(result);
		}

	}
}