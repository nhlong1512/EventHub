using AutoMapper;
using TicketBooking.API.Dto;
using TicketBooking.API.Models;

namespace TicketBooking.API.Helper
{
  public class MappingProfiles: Profile
  {
    public MappingProfiles()
    {
      CreateMap<Event, EventResponse>();
      CreateMap<Event, EventDetail>();
    }
  }
}