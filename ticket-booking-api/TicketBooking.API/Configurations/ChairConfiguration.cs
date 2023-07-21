using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using TicketBooking.API.Migrations;
using TicketBooking.API.Models;

namespace TicketBooking.API.Configurations
{
	class ChairConfiguration : IEntityTypeConfiguration<Chair>
	{
		public void Configure(EntityTypeBuilder<Chair> builder)
		{
			// builder.HasKey(x=>x.Id);
			// builder.ToTable("Chair");
			// builder.Property()		
		}
	}
}