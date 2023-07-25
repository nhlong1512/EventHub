using Microsoft.AspNetCore.Mvc;
using TicketBooking.API.Dto;
using TicketBooking.API.Enum;
using TicketBooking.API.Interfaces;

namespace TicketBooking.API.Controller
{
	public class InvoiceController: ControllerBase
	{
		private readonly IInvoicerepository __invoicesRepository;

		public InvoiceController(IInvoicerepository invoicesRepository)
		{
			__invoicesRepository = invoicesRepository;
		}

		[HttpPost]
		[ProducesResponseType(204, Type = typeof(string))]
		public async Task<ActionResult> AddInvoice(InvoiceRequest invoiceRequest)
		{
			var result = await __invoicesRepository.CreateInvoice(invoiceRequest);

			if(result == AddInvoiceStatus.Fail)
			{
				ModelState.AddModelError("", "Some thing wrong while adding");
				return BadRequest(ModelState);
			}

			if(result == AddInvoiceStatus.InvalidEmail)
			{
				ModelState.AddModelError("", "Cannot send to user email");
				return BadRequest(ModelState);
			}

			if(!ModelState.IsValid)
				return BadRequest();

			return Ok("Success");
		}

		[HttpGet]
		[ProducesResponseType(204, Type = typeof(string))]
		public async Task<ActionResult> EmailValidate(
			[FromQuery] string email, [FromQuery] string userName
		)
		{
			var result = await __invoicesRepository.EmailValidate(email, userName);

			if(result == AddInvoiceStatus.InvalidEmail)
			{
				ModelState.AddModelError("", "Cannot send to email");
				return BadRequest(ModelState);
			}

			if(!ModelState.IsValid)
				return BadRequest();

			return Ok("Success");
		}
	}
}