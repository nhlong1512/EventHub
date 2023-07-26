namespace TicketBooking.API.Interfaces
{
	public interface IEmailValidationRepository
	{
		public Task<string> GetValidationCode(string email, string userName);
	}
}