using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using TicketBooking.API.Enum;
using TicketBooking.API.Models;

namespace TicketBooking.API.Configurations
{
  public class Seat_InvoiceConfiguration: IEntityTypeConfiguration<Seat_Invoice>
  {
    public void Configure(EntityTypeBuilder<Seat_Invoice> builder)
    {
      builder.HasKey(e => new {e.InvoiceId, e.SeatId});
      builder.ToTable("Seat_Invoice");
    }
  }
}