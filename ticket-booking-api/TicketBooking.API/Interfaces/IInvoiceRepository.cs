using TicketBooking.API.Dto;
namespace TicketBooking.API.Interfaces
{
	public interface IInvoiceRepository
	{
		public bool CreateInvoice(InvoiceRequest invoice);
	}
}