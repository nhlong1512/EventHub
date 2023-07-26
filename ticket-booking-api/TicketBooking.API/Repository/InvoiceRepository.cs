using TicketBooking.API.Dto;
using TicketBooking.API.Interfaces;
using TicketBooking.API.Models;
using TicketBooking.API.EF;
using TicketBooking.API.Enum;

namespace TicketBooking.API.Repository
{
	public class InvoiceRepository : IInvoiceRepository
	{
		private readonly ApplicationDbContext __dbContext;

		public InvoiceRepository(ApplicationDbContext dbContext)
		{
			__dbContext = dbContext;
		}

		public bool CreateInvoice(InvoiceRequest invoiceRequest)
		{
			string invoiceId = Guid.NewGuid().ToString();

			if (AddInvoice(invoiceRequest, invoiceId) == 0)
				return false;

			if (AddSeatInvoice(invoiceRequest.seatIds, invoiceId) == 0)
				return false;

			if (UpdateSeatEvent(invoiceRequest.seatIds, invoiceRequest.EventId) == 0)
				return false;

			return true;
		}

    private int AddInvoice(InvoiceRequest invoiceRequest, string invoiceId)
		{
			var invoice = new Invoice()
			{
				Id = invoiceId,
				Name = invoiceRequest.FullName,
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

		private int UpdateSeatEvent(List<string> seatIds, string eventId) 
		{
			var seatEvents = __dbContext.SeatEvents
				.Where(x => seatIds.FindIndex(y => y == x.SeatId) >= 0)
				.Where(x => x.EventId == eventId)
				.ToList();

			foreach (var seatEvent in seatEvents)
			{
				seatEvent.SeatStatus = SeatStatus.Picked;
				__dbContext.Update(seatEvent);
			}

			return __dbContext.SaveChanges();
		}
	}
}