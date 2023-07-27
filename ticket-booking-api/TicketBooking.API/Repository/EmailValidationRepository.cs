using System.Net;
using System.Net.Mail;
using TicketBooking.API.Interfaces;

namespace TicketBooking.API.Repository
{
	public class EmailValidationRepository : IEmailValidationRepository
	{
		private readonly IConfigurationRoot __configuration;
		private readonly SmtpClient __smtpClient;

		public EmailValidationRepository()
		{
			__configuration = new ConfigurationBuilder()
			.SetBasePath(Directory.GetCurrentDirectory())
			.AddJsonFile("appsettings.json")
			.Build();

			__smtpClient = new SmtpClient(__configuration.GetConnectionString("SmtpClient"), 587)
			{
				EnableSsl = true,
				UseDefaultCredentials = false,
				Credentials = new NetworkCredential(
					__configuration.GetConnectionString("EmailClient"),
					__configuration.GetConnectionString("Password"))
			};
		}

		public async Task<string> SendValidationCode(string fullName, string mail)
		{
			var code = GetCode();
			var mailTitle = GetMailTitle(fullName);
			var mailContent = GetMailContent(fullName, code);
			var message = new MailMessage(
				from: __configuration.GetConnectionString("EmailClient"),
				to: mail,
				mailTitle,
				mailContent
			)
			{ IsBodyHtml = true };

			try
			{
				await __smtpClient.SendMailAsync(message);
			}
			catch (Exception)
			{
				return "";
			}

			return code;
		}

		private string GetMailTitle(string name)
		{
			return $"[EventBooking] {name.ToUpper()}'S PAYMENT INFORMATION";
		}

		private string GetCode()
		{
			return new Random().Next(100000, 999999).ToString();
		}

		private string GetMailContent(string name, string code)
		{
			return
			@$"<html lang=""en"">
				<head>    
					<meta 
						content=""text/html; charset=utf-8"" 
						http-equiv=""Content-Type"">
					<title>
						Customer payment information
					</title>
				</head>
				<body>
					<h3>
						Hello {name}, thanks for using our service.
						<br/>
						Your confirmation code is <strong style=""color: blue;"">{code}</strong>
					</h3>
				</body>
			</html>";
		}
	}
}