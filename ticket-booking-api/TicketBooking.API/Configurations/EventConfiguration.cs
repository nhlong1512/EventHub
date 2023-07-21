using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using TicketBooking.API.Models;
using TicketBooking.API.Enum;

namespace TicketBooking.API.Configurations
{
  public class EventConfiguration: IEntityTypeConfiguration<Event>
  {
    public void Configure(EntityTypeBuilder<Event> builder)
    {
      builder.HasKey(e => e.Id);
      builder.ToTable("Event");
      builder.Property(e => e.Status).HasDefaultValue(EventStatus.Available);
      builder.Property(e => e.UpdatedAt).HasDefaultValue(null);
      builder.Property(e => e.DeletedAt).HasDefaultValue(null);
      builder.Property(e => e.CreatedAt).HasDefaultValue(null);
      builder.Property(e => e.IsDeleted).HasDefaultValue(false);
      builder.Property(e => e.Image).HasDefaultValue("");
      builder.Property(e => e.MinPrice).IsRequired();
      builder.Property(e => e.Title).IsRequired();
      builder.Property(e => e.Date).IsRequired();
      builder.Property(e => e.Type).IsRequired();
    }
  }
}