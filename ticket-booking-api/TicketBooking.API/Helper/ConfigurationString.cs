namespace TicketBooking.API.Helper
{
  public class ConfigurationString
  {
    static private IConfigurationRoot configuration = new ConfigurationBuilder()
        .SetBasePath(Directory.GetCurrentDirectory())
        .AddJsonFile("appsettings.json")
        .Build();

    static public string Database { get; } = configuration.GetConnectionString("TicketBookingDatabase");
    static public string BlobStorage { get; } = configuration.GetConnectionString("TicketBookingStorage");
    static public string SmtpClient { get; } = configuration.GetConnectionString("SmtpClient");
    static public string EmailClient { get; } = configuration.GetConnectionString("EmailClient");
    static public string EmailPassword { get; } = configuration.GetConnectionString("Password");
  }
}