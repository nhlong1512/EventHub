using System.Net;
using System.Net.Mail;
using TicketBooking.API.Interfaces;

namespace TicketBooking.API.Repository
{
	public class EmailValidationRepository : IEmailValidationRepository
	{
		public EmailValidationRepository(){}

		public async Task<string> GetValidationCode(string email, string userName)
		{
			var code = new Random().Next(100000, 999999).ToString();

			if(!await SendCodeToEmail(email, code, userName))
			{
				return "";
			}

			return code;
		}

		public async Task<bool> SendCodeToEmail(string email, string code, string userName)
		{
			var configuration = new ConfigurationBuilder()
			.SetBasePath(Directory.GetCurrentDirectory())
			.AddJsonFile("appsettings.json")
			.Build();

			var emailClient = configuration.GetConnectionString("EmailClient");
			var smtpClient = configuration.GetConnectionString("SmtpClient");
			var password = configuration.GetConnectionString("Password");

			var client = new SmtpClient(smtpClient, 587)
			{
				EnableSsl = true,
				UseDefaultCredentials = false,
				Credentials = new NetworkCredential(emailClient, password)
			};

			var message = new MailMessage(
				from: emailClient,
				to: email,
				GetMailTitle(userName),
				GetMailContent(userName, code)
			)
			{
				IsBodyHtml = true
			};

			try
			{
				await client.SendMailAsync(message);
			}
			catch (Exception)
			{
				return false;
			}

			return true;
		}

		public string GetMailContent(string name, string code)
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

		public string GetMailTitle(string name)
		{
			return $"[EventBooking] {name.ToUpper()}'S PAYMENT INFORMATION";
		}
  }
}