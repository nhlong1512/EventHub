using Microsoft.AspNetCore.Mvc;
using TicketBooking.API.Dto;
using TicketBooking.API.Interfaces;
using TicketBooking.API.Helper;

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

		[HttpGet("{mail}")]
		[ProducesResponseType(200, Type = typeof(List<InvoiceResponse>))]
		public ActionResult GetInvoice(string mail)
		{
			var result = __invoicesRepository.GetInvoices(mail);

			if(result == null)
				return NotFound();

			if(!ModelState.IsValid)
				return BadRequest(ModelState);

			return Ok(result);	
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
				return Problem(ResponseStatus.ServiceError);
			}

			string invoiceId = __invoicesRepository.AddInvoice(invoiceRequest, code);

			if (invoiceId == "")
			{
				ModelState.AddModelError("", ResponseStatus.AddError);
				return BadRequest(ModelState);
			}

			if (!ModelState.IsValid)
				return BadRequest(ModelState);

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
				return Problem(ResponseStatus.UpdateError);

			if (!ModelState.IsValid)
				return BadRequest(ModelState);

			return Ok(result.ToString());
		}
	}
}