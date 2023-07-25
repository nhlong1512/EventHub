using TicketBooking.API.Dto;
using TicketBooking.API.Enum;
namespace TicketBooking.API.Interfaces
{
	public interface IInvoicerepository
	{
		public Task<AddInvoiceStatus> CreateInvoice(InvoiceRequest invoice);
		public Task<AddInvoiceStatus> EmailValidate(string email, string userName);
	}
}