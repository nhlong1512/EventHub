using Microsoft.AspNetCore.Mvc;
using TicketBooking.API.Models;
using TicketBooking.API.Interfaces;

namespace TicketBooking.API.Controller
{
	[ApiController]
	[Route("api/[controller]")]
	public class EventController: ControllerBase
	{
		private readonly IEventRepository __eventRepository;

		public EventController(IEventRepository eventRepository)
		{
			__eventRepository = eventRepository;
		}

		[HttpGet]
		[ProducesResponseType(200, Type = typeof(IEnumerable<Event>))]
		public ActionResult Get()
		{
			var events = __eventRepository.GetEvents();

			if(!ModelState.IsValid)
			{
				return BadRequest(ModelState);
			}

			return Ok(events);
		}
	}
}