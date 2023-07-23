using Microsoft.AspNetCore.Mvc;
using TicketBooking.API.Interfaces;
using TicketBooking.API.Dto;
using AutoMapper;

namespace TicketBooking.API.Controller
{
	[ApiController]
	[Route("api/[controller]")]
	public class EventController: ControllerBase
	{
		private readonly IEventRepository __eventRepository;
		private readonly IMapper __mapper;

		public EventController(
			IEventRepository eventRepository,
			IMapper mapper)
		{
			__eventRepository = eventRepository;
			__mapper = mapper;
		}

		[HttpGet]
		[ProducesResponseType(200, Type = typeof(IEnumerable<EventResponse>))]
		public ActionResult GetEvents()
		{
			var events = __mapper.Map<List<EventResponse>>(__eventRepository.GetEvents());

			if(!ModelState.IsValid)
			{
				return BadRequest(ModelState);
			}

			return Ok(events);
		}

		[HttpGet("{eventId}")]
		[ProducesResponseType(200, Type = typeof(IEnumerable<EventDetail>))]
		[ProducesResponseType(400)]
		public ActionResult GetEvent(string eventId)
		{
			var e = __eventRepository.GetEvent(eventId);

			if(e == null){
				return NotFound();
			}

			if(!ModelState.IsValid)
			{
				return BadRequest(ModelState);
			}

			return Ok(__mapper.Map<EventDetail>(e));
		}
	}
}