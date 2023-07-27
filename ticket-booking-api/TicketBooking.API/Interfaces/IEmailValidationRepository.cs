namespace TicketBooking.API.Interfaces
{
	public interface IEmailValidationRepository
	{
		public Task<string> SendValidationCode(string fullName, string mail);
	}
}