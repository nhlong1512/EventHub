using TicketBooking.API.Dto;
using TicketBooking.API.Interfaces;
using TicketBooking.API.Models;
using TicketBooking.API.EF;
using TicketBooking.API.Enum;
using Microsoft.EntityFrameworkCore;

namespace TicketBooking.API.Repository
{
	public class InvoiceRepository : IInvoiceRepository
	{
		private readonly ApplicationDbContext __dbContext;

		public InvoiceRepository(ApplicationDbContext dbContext)
		{
			__dbContext = dbContext;
		}

		public string AddInvoice(InvoiceRequest invoiceRequest, string code)
		{
			var invoiceId = Guid.NewGuid().ToString();

			var invoice = new Invoice()
			{
				Id = invoiceId,
				Name = invoiceRequest.FullName,
				Mail = invoiceRequest.Mail,
				Phone = invoiceRequest.Phone,
				EventId = invoiceRequest.EventId,
				Code = code,
			};

			__dbContext.Add(invoice);

			var result = __dbContext.SaveChanges();

			var addSeatInvoice = AddSeatInvoice(invoiceRequest.seatIds, invoiceId);

			if(addSeatInvoice == 0)
				return "";

			if (result == 0)
				return "";

			return invoiceId;
		}

		public int ValidateInvoice(string invoiceId, string code)
		{
			var invoice = __dbContext.Invoice
				.Where(x => x.Id == invoiceId)
				.Where(x => x.Code == code)
				.Include(x => x.Seats)
				.FirstOrDefault();

			if (invoice == null)
				return 0;

			var updateSeatEvent = UpdateSeatEvent(invoice.Seats.ToList(), invoice.EventId);
			
			if(updateSeatEvent == 0)
				return 0;

			invoice.IsValidated = true;
			__dbContext.Update(invoice);

			return __dbContext.SaveChanges();
		}

		private int AddSeatInvoice(List<string> seatIds, string invoiceId)
		{
			foreach (var seatId in seatIds)
			{
				SeatInvoice seatInvoice = new()
				{
					SeatId = seatId,
					InvoiceId = invoiceId,
				};
				__dbContext.Add(seatInvoice);
			}

			return __dbContext.SaveChanges();
		}

		private int UpdateSeatEvent(List<Seat> seats, string eventId)
		{
			var seatIds = new List<string>();

			foreach (var seat in seats)
			{
				seatIds.Add(seat.Id);
			}

			var seatEvents = __dbContext.SeatEvents
				.Where(x => seatIds.Contains(x.SeatId))
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