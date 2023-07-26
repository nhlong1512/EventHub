using Microsoft.AspNetCore.Mvc;
using TicketBooking.API.Interfaces;

namespace TicketBooking.API.Controller
{
	[ApiController]
	[Route("api/[controller]")]
	public class EmailValidationController : ControllerBase
	{
		private readonly IEmailValidationRepository __emailValidationRepository;

		public EmailValidationController(IEmailValidationRepository emailValidationRepository)
		{
			__emailValidationRepository = emailValidationRepository;
		}

		[HttpGet]
		[ProducesResponseType(200, Type = typeof(string))]
		public async Task<ActionResult> EmailValidate(
			[FromQuery] string email,
			[FromQuery] string fullName)
		{
			if (!ModelState.IsValid)
				return BadRequest();

			var result = await __emailValidationRepository.GetValidationCode(email, fullName);

			return Ok(result);
		}
	}
}