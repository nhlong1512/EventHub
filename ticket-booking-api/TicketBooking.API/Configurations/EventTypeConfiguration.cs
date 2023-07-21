using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using TicketBooking.API.Models;

namespace TicketBooking.API.Configurations
{
  public class EventTypeConfiguration: IEntityTypeConfiguration<EventType>
  {
    public void Configure(EntityTypeBuilder<EventType> builder)
    {
      builder.HasKey(e => e.Id);
      builder.ToTable("EventType");
			builder.Property(e => e.Name).IsRequired();
      builder.Property(e => e.UpdatedAt).HasDefaultValue(null);
      builder.Property(e => e.DeletedAt).HasDefaultValue(null);
      builder.Property(e => e.CreatedAt).HasDefaultValue(null);
      builder.Property(e => e.IsDeleted).HasDefaultValue(false);
    }
  }
}