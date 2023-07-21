using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using TicketBooking.API.Models;

namespace TicketBooking.API.Configurations
{
  public class Event_EventTypeConfiguration: IEntityTypeConfiguration<Event_EventType>
  {
    public void Configure(EntityTypeBuilder<Event_EventType> builder)
    {
      builder.HasKey(e => new {e.EventId, e.EventTypeId});
      builder.ToTable("Event_EventType");
    }
  }
}