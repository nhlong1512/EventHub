using Microsoft.AspNetCore.Mvc;
using TicketBooking.API.Dto;
using TicketBooking.API.Interfaces;

namespace TicketBooking.API.Controller
{
	[ApiController]
	[Route("api/[controller]")]
	public class InvoiceController: ControllerBase
	{
		private readonly IInvoiceRepository __invoicesRepository;

		public InvoiceController(IInvoiceRepository invoicesRepository)
		{
			__invoicesRepository = invoicesRepository;
		}

		[HttpPost]
		[ProducesResponseType(204, Type = typeof(string))]
		public ActionResult AddInvoice(InvoiceRequest invoiceRequest)
		{
			var result = __invoicesRepository.CreateInvoice(invoiceRequest);

			if (!result)
			{
					ModelState.AddModelError("", "Some thing wrong while adding");
					return BadRequest(ModelState);
			}

			if (!ModelState.IsValid)
					return BadRequest();

			return Ok("Success");
		}
	}
}