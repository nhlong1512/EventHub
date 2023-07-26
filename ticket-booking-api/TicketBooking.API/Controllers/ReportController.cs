using Microsoft.AspNetCore.Mvc;
using TicketBooking.API.Dto;
using TicketBooking.API.Interfaces;

namespace TicketBooking.API.Controller
{
  [ApiController]
  [Route("api/[controller]")]
  public class ReportController : ControllerBase
  {
		private readonly IReportRepository __reportRepository;

		public ReportController(IReportRepository reportRepository)
		{
			__reportRepository = reportRepository;
		}

    [HttpGet]
    [ProducesResponseType(200, Type = typeof(ReportResponse))]
    public ActionResult<EventsInMonth> Get()
    {
			var eventsInMonths = __reportRepository.GetEventsInMonths();
			var revenueInMonths = __reportRepository.GetRevenueInMonths();

			if(eventsInMonths.Count == 0 || revenueInMonths.Count == 0)
				return Problem("Something wrong while getting report");

			var result = new ReportResponse()
			{
				EventsInMonths = eventsInMonths,
				RevenueInMonths = revenueInMonths
			};	

			return Ok(result);
    }
  }
}