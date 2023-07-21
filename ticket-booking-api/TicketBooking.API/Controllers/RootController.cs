using Microsoft.AspNetCore.Mvc;

namespace TicketBookingAPI.app.Controller
{
  [ApiController]
  [Route("/")]
  public class RootController : ControllerBase
  {
    [HttpGet]
    public ActionResult<string> Get()
    {
      return "Welcome to API service for Ticket Booking";
    }
  }
}