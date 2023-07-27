using Microsoft.AspNetCore.Mvc;
using TicketBooking.API.Dto;
using TicketBooking.API.Interfaces;

namespace TicketBooking.API.Controller
{
	[ApiController]
	[Route("api/[controller]")]
	public class InvoiceController : ControllerBase
	{
		private readonly IInvoiceRepository __invoicesRepository;
		private readonly IEmailValidationRepository __emailValidationRepository;

		public InvoiceController(
			IInvoiceRepository invoicesRepository,
			IEmailValidationRepository emailValidationRepository
		)
		{
			__invoicesRepository = invoicesRepository;
			__emailValidationRepository = emailValidationRepository;
		}

		[HttpPost]
		[ProducesResponseType(204, Type = typeof(string))]
		public async Task<ActionResult> AddInvoice(InvoiceRequest invoiceRequest)
		{
			string code = await __emailValidationRepository.SendValidationCode(
				invoiceRequest.FullName,
				invoiceRequest.Mail
			);

			if (code == "")
			{
				return Problem("Something wrong while sending code to customer");
			}

			string invoiceId = __invoicesRepository.AddInvoice(invoiceRequest, code);

			if (invoiceId == "")
			{
				ModelState.AddModelError("", "Some thing wrong while adding");
				return BadRequest(ModelState);
			}

			if (!ModelState.IsValid)
				return BadRequest();

			return Ok(invoiceId);
		}

		[HttpGet]
		[ProducesResponseType(200, Type = typeof(string))]
		public ActionResult ValidateInvoice(
				[FromQuery] string invoiceId,
				[FromQuery] string code)
		{
			int result = __invoicesRepository.ValidateInvoice(invoiceId, code);

			if (result == 0)
				return Problem("Something wrong while validating invoice");

			if (!ModelState.IsValid)
				return BadRequest();

			return Ok(result.ToString());
		}
	}
}