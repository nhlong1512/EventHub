using TicketBooking.API.Dto;
using TicketBooking.API.Enum;
namespace TicketBooking.API.Interfaces
{
	public interface IInvoicerepository
	{
		public AddInvoiceStatus CreateInvoice(InvoiceRequest invoice);
		public Task<string> EmailValidate(string email, string userName);
	}
}