using TicketBooking.API.Dto;
namespace TicketBooking.API.Interfaces
{
	public interface IInvoiceRepository
	{
		public string AddInvoice(InvoiceRequest invoice, string code);
		public int ValidateInvoice(string invoiceId, string code);
	}
}