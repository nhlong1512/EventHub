using Microsoft.EntityFrameworkCore;
using TicketBooking.API.EF;
using TicketBooking.API.Interfaces;
using TicketBooking.API.Repository;

var builder = WebApplication.CreateBuilder(args);

builder.Services.AddControllers();
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();
builder.Services.AddScoped<IEventRepository, EventRepository>();

builder.Services.AddDbContext<ApplicationDbContext> (option => {
    option.UseSqlServer(builder.Configuration.GetConnectionString("TicketBooking"));
});


var app = builder.Build();

if (app.Environment.IsDevelopment())
{
    app.UseSwagger();
    app.UseSwaggerUI();
}

app.UseHttpsRedirection();

app.UseAuthorization();

app.MapControllers();

app.Run();
