using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Design;
using Microsoft.Extensions.Configuration;

namespace TicketBooking.API.EF
{
  class ApplicationDbContextFactory : IDesignTimeDbContextFactory<ApplicationDbContext>
  {
    ApplicationDbContext IDesignTimeDbContextFactory<ApplicationDbContext>.CreateDbContext(string[] args)
    {
      IConfigurationRoot configuration = new ConfigurationBuilder()
        .SetBasePath(Directory.GetCurrentDirectory())
        .AddJsonFile("appsettings.json")
        .Build();

      var connectionString = configuration.GetConnectionString("TicketBooking");

      var optionsBuilder = new DbContextOptionsBuilder<ApplicationDbContext>();
      optionsBuilder.UseSqlServer(connectionString);

      return new ApplicationDbContext(optionsBuilder.Options);
    }
  }
}