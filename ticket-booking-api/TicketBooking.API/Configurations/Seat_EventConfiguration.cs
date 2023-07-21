using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using TicketBooking.API.Enum;
using TicketBooking.API.Models;

namespace TicketBooking.API.Configurations
{
  public class Seat_EventConfiguration: IEntityTypeConfiguration<Seat_Event>
  {
    public void Configure(EntityTypeBuilder<Seat_Event> builder)
    {
      builder.HasKey(e => new {e.EventId, e.SeatId});
      builder.ToTable("Seat_Event");
			builder.Property(e=>e.SeatStatus).HasDefaultValue(SeatStatus.Free);
			builder.Property(e=>e.Price).IsRequired();
    }
  }
}