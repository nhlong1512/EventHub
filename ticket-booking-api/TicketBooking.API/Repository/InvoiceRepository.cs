using TicketBooking.API.Dto;
using TicketBooking.API.Interfaces;
using TicketBooking.API.Models;
using TicketBooking.API.EF;
using System.Net.Mail;
using System.Net;
using TicketBooking.API.Enum;

namespace TicketBooking.API.Repository
{
	public class InvoiceRepository : IInvoicerepository
	{
		private readonly ApplicationDbContext __dbContext;

		public InvoiceRepository(ApplicationDbContext dbContext)
		{
			__dbContext = dbContext;
		}

		public async Task<AddInvoiceStatus> CreateInvoice(InvoiceRequest invoiceRequest)
		{
			string invoiceId = Guid.NewGuid().ToString();

			if (AddInvoice(invoiceRequest, invoiceId) == 0)
				return AddInvoiceStatus.Fail;

			if (AddSeatInvoice(invoiceRequest.seatIds, invoiceId) == 0)
				return AddInvoiceStatus.Fail;

			return AddInvoiceStatus.Success;
		}

		private int AddInvoice(InvoiceRequest invoiceRequest, string invoiceId)
		{
			var invoice = new Invoice()
			{
				Id = invoiceId,
				Name = invoiceRequest.Name,
				Mail = invoiceRequest.Mail,
				Phone = invoiceRequest.Phone,
				EventId = invoiceRequest.EventId,
			};

			__dbContext.Add(invoice);

			return __dbContext.SaveChanges();
		}

		private int AddSeatInvoice(List<string> seatIds, string invoiceId)
		{
			foreach (var seatId in seatIds)
			{
				SeatInvoice seatInvoice = new SeatInvoice()
				{
					SeatId = seatId,
					InvoiceId = invoiceId,
				};
				__dbContext.Add(seatInvoice);
			}

			return __dbContext.SaveChanges();
		}

		public async Task<AddInvoiceStatus> EmailValidate(string email, string userName)
		{
			IConfigurationRoot configuration = new ConfigurationBuilder()
							.SetBasePath(Directory.GetCurrentDirectory())
							.AddJsonFile("appsettings.json")
							.Build();

			var emailClient = configuration.GetConnectionString("EmailClient");
			var smtpClient = configuration.GetConnectionString("SmtpClient");
			var password = configuration.GetConnectionString("Password");
			var code = (new Random()).Next(100000, 999999).ToString();

			var client = new SmtpClient(smtpClient, 587)
			{
				EnableSsl = true,
				UseDefaultCredentials = false,
				Credentials = new NetworkCredential(emailClient, password)
			};

			try
			{
				await client.SendMailAsync(new MailMessage(
					from: emailClient,
					to: email,
					"[EventBooking] CUSTOMER'S PAYMENT INFORMATION",
					$"Hello ${userName}, thanks for using our service.\nYour confirmation code is ${code}"
				));
			}
			catch (Exception)
			{
				return AddInvoiceStatus.InvalidEmail;
			}

			return AddInvoiceStatus.Success;
		}
	}
}