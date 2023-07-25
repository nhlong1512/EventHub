using Microsoft.EntityFrameworkCore;
using TicketBooking.API.Dto;
using TicketBooking.API.EF;
using TicketBooking.API.Interfaces;
using TicketBooking.API.Models;
using Azure.Storage.Blobs;
using Azure.Storage.Blobs.Models;
using TicketBooking.API.Enum;

namespace TicketBooking.API.Repository
{
	public class EventRepository : IEventRepository
	{
		private readonly ApplicationDbContext __dbContext;

		public EventRepository(ApplicationDbContext applicationDbContext)
		{
			__dbContext = applicationDbContext;
		}

		public ICollection<Event> GetEvents()
		{
			var result = __dbContext.Events.
				Where(x => !x.IsDeleted).
				Include(x => x.Categories).
				ToList();

			foreach (var e in result)
			{
				foreach (var category in e.Categories)
				{
					category.Events = null;
					category.UpdatedAt = null;
					category.CreatedAt = null;
					category.DeletedAt = null;
				}
			}

			return result;
		}

		public Event? GetEvent(string eventId)
		{
			var result = __dbContext.Events
				.Where(x => (x.Id == eventId) && (!x.IsDeleted))
				.Include(x => x.SeatEvents)
				.ThenInclude(x => x.Seat)
				.Include(x => x.Categories)
				.FirstOrDefault();

			if (result == null)
				return result;

			foreach (var category in result.Categories)
			{
				category.Events = null;
				category.UpdatedAt = null;
				category.CreatedAt = null;
				category.DeletedAt = null;
			}

			foreach (var e in result.SeatEvents)
			{
				e.Event = null;
				e.Seat.SeatEvents = null;
				e.Seat.CreatedAt = null;
				e.Seat.UpdatedAt = null;
				e.Seat.DeletedAt = null;
				e.Seat.Invoices = null;
			}

			result.SeatEvents = result.SeatEvents
				.OrderBy(x => x.SeatId[0])
				.ThenBy(x => x.SeatId.Length)
				.ThenBy(x => x.SeatId)
				.ToList();

			return result;
		}

		public void DeleteEvent(Event e)
		{
			e.IsDeleted = true;
			e.DeletedAt = DateTime.Now;
			__dbContext.Update(e);
			__dbContext.SaveChanges();
		}

		public async Task<bool> CreateEvent(EventRequest eventRequest)
		{
			var newEventId = Guid.NewGuid().ToString();

			string imgUrl = await UpLoadImage(eventRequest.Image, newEventId);

			if (AddEvent(eventRequest, imgUrl, newEventId) == 0)
				return false;

			if (AddSeatEvent(eventRequest, newEventId) == 0)
				return false;

			if(AddEventCategory(eventRequest.Categories, newEventId) == 0)
			  return false;

			return true;
		}

		private int AddEvent(EventRequest eventRequest, string imgUrl, string eventId)
		{
			var newEvent = new Event
			{
				Id = eventId,
				Duration = eventRequest.Duration,
				Title = eventRequest.Title,
				Image = imgUrl,
				MinPrice = eventRequest.Prices.Min(),
				StageName = eventRequest.StageName,
				City = eventRequest.City,
				Date = eventRequest.Date,
				CreatedAt = DateTime.Now,
				Location = eventRequest.Location,
			};

			__dbContext.Add(newEvent);

			return __dbContext.SaveChanges();
		}

		private int AddSeatEvent(EventRequest eventRequest, string eventId)
		{
			var seats = __dbContext.Seats.ToList();

			foreach (var seat in seats)
			{
				var seatEvent = new SeatEvent()
				{
					SeatId = seat.Id,
					EventId = eventId,
					SeatStatus = seat.Name == "F18" || seat.Name == "F1" 
						? SeatStatus.Banned 
						: SeatStatus.Free,
					Price = eventRequest.Prices[(int)seat.Type]
				};
				__dbContext.Add(seatEvent);
			}

			return __dbContext.SaveChanges();
		}

		private int AddEventCategory(List<string> categoryNames, string eventId)
		{
			foreach(var categoryName in categoryNames)
			{
				var category = __dbContext.Categories.Where(c => c.Name == categoryName).FirstOrDefault();
				var eventCategory = new EventCategory()
				{
					CategoryId = category.Id,
					EventId = eventId,
				};
				__dbContext.Add(eventCategory);
			}
			
			return __dbContext.SaveChanges();
		}

		private async Task<string> UpLoadImage(IFormFile formFile, string eventId)
		{
			IConfigurationRoot configuration = new ConfigurationBuilder()
				.SetBasePath(Directory.GetCurrentDirectory())
				.AddJsonFile("appsettings.json")
				.Build();

			var connectionString = configuration.GetConnectionString("TicketBookingStorage");
			var blobServiceClient = new BlobServiceClient(connectionString);
			var containerClient = blobServiceClient.GetBlobContainerClient("img");
			var stream = formFile.OpenReadStream();
			var blobClient = containerClient.GetBlobClient(eventId);

			await blobClient.UploadAsync(
				stream,
				httpHeaders: new BlobHttpHeaders { ContentType = formFile.ContentType },
				conditions: null);

			return blobClient.Uri.ToString();
		}
	}
}