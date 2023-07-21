using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using TicketBooking.API.Enum;
using TicketBooking.API.Models;

namespace TicketBooking.API.Configurations
{
	class ChairConfiguration : IEntityTypeConfiguration<Seat>
	{
		public void Configure(EntityTypeBuilder<Seat> builder)
		{
			builder.HasKey(x=>x.Id);
			builder.ToTable("Seat");
			builder.Property(x=>x.Name).IsRequired();
			builder.Property(x=>x.Type).HasDefaultValue(SeatType.Normal);
			builder.Property(e => e.UpdatedAt).HasDefaultValue(null);
      builder.Property(e => e.DeletedAt).HasDefaultValue(null);
      builder.Property(e => e.CreatedAt).HasDefaultValue(null);
      builder.Property(e => e.IsDeleted).HasDefaultValue(false);
      builder.Property(e => e.Invoices).HasDefaultValue(Array.Empty<Invoice>());
      builder.Property(e => e.Events).HasDefaultValue(Array.Empty<Event>());
		}
	}
}