using Microsoft.EntityFrameworkCore;
using TicketBooking.API.EF;
using TicketBooking.API.Interfaces;
using TicketBooking.API.Repository;

var builder = WebApplication.CreateBuilder(args);

builder.Services
    .AddControllersWithViews()
    .AddNewtonsoftJson(options =>
        options.SerializerSettings.ReferenceLoopHandling
        = Newtonsoft.Json.ReferenceLoopHandling.Ignore);

builder.Services.AddEndpointsApiExplorer();

builder.Services.AddSwaggerGen();

builder.Services.AddScoped<IEventRepository, EventRepository>();

builder.Services.AddScoped<ICategoryRepository, CategoryRepository>();

builder.Services.AddScoped<IInvoiceRepository, InvoiceRepository>();

builder.Services.AddScoped<IEmailValidationRepository, EmailValidationRepository>();

builder.Services.AddScoped<IReportRepository, ReportRepository>();

builder.Services.AddAutoMapper(AppDomain.CurrentDomain.GetAssemblies());

builder.Services.AddCors(options =>
{
    options.AddPolicy("MyPolicies", policy =>
    {
        policy
            .AllowAnyOrigin()
            .AllowAnyMethod()
            .AllowAnyHeader();
    });
});

builder.Services.AddDbContext<ApplicationDbContext>(option =>
{
    option.UseSqlServer(builder.Configuration.GetConnectionString("TicketBookingDatabase"));
});


var app = builder.Build();

if (app.Environment.IsDevelopment())
{
    app.UseSwagger();
    app.UseSwaggerUI();
}

app.UseHttpsRedirection();

app.UseCors("MyPolicies");

app.UseAuthorization();

app.MapControllers();

app.Run();
