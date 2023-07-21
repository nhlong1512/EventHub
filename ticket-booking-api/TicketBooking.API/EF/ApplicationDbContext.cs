using Microsoft.EntityFrameworkCore;
using TicketBooking.API.Configurations;
using TicketBooking.API.Models;

namespace TicketBooking.API.EF
{
  public class ApplicationDbContext: DbContext
  {
    public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options): base(options) {}

    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
      modelBuilder.ApplyConfiguration(new EventConfiguration());
      
      ApplicationDbContextSeeding.Seed(ref modelBuilder);
    }

    public DbSet<Event> Events { get; set; }
    public DbSet<Chair> Chairs { get; set; }
    public DbSet<Invoice> Invoice { get; set; }
  }
}