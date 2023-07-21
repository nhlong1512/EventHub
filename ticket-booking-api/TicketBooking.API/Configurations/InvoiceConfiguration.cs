using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using TicketBooking.API.Models;

namespace TicketBooking.API.Configurations
{
	class InvoiceConfiguration : IEntityTypeConfiguration<Invoice>
	{
		public void Configure(EntityTypeBuilder<Invoice> builder)
		{
			builder.HasKey(x=>x.Id);
			builder.ToTable("Invoice");
			builder.Property(x=>x.Name).IsRequired();
			builder.Property(x=>x.Mail).IsRequired();
			builder.Property(x=>x.Phone).IsRequired();
			builder.Property(e => e.UpdatedAt).HasDefaultValue(null);
      builder.Property(e => e.DeletedAt).HasDefaultValue(null);
      builder.Property(e => e.CreatedAt).HasDefaultValue(null);
      builder.Property(e => e.IsDeleted).HasDefaultValue(false);
      builder.Property(e => e.Seats).IsRequired();
      builder.Property(e => e.EventId).IsRequired();
      builder.Property(e => e.Event).IsRequired();
		}
	}
}