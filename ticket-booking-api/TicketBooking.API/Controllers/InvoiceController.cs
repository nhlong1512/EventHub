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
		public ActionResult AddInvoice(InvoiceRequest invoiceRequest)
		{
			var result = __invoicesRepository.CreateInvoice(invoiceRequest);

			if (result == AddInvoiceStatus.Fail)
			{
					ModelState.AddModelError("", "Some thing wrong while adding");
					return BadRequest(ModelState);
			}

			if (!ModelState.IsValid)
					return BadRequest();

			return Ok("Success");
		}

    [HttpGet]
		[ProducesResponseType(204, Type = typeof(string))]
		public async Task<ActionResult> EmailValidate(
			[FromQuery] string email, [FromQuery] string userName
		)
		{
			if(!ModelState.IsValid)
				return BadRequest();

			var result = await __invoicesRepository.EmailValidate(email, userName);

			return Ok(result);
		}
	}
}