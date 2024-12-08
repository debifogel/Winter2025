using Buses.Core.classes;
using Buses.Core.repsitory;
using Buses.Core.Services;
using Buses.Data.data;
using Buses.Data.repsitions;
using Buses.Service;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.

builder.Services.AddControllers();
// Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();
builder.Services.AddScoped<IStationService,StationService>();
builder.Services.AddScoped<IBusService, BusService>();
builder.Services.AddScoped<IStreetService, StreetService>();
builder.Services.AddScoped<IRepository<Bus>, BusRepository>();
builder.Services.AddScoped<IRepository<Station>, StationReository>();
builder.Services.AddScoped<IRepository<Street>, StreetRepository>();



//builder.Services.AddSingleton<IData, DataContext>();
builder.Services.AddDbContext<IData,DataContext>();
var app = builder.Build();

// Configure the HTTP request pipeline.
if (app.Environment.IsDevelopment())
{
    app.UseSwagger();
    app.UseSwaggerUI();
}

app.UseHttpsRedirection();

app.UseAuthorization();

app.MapControllers();

app.Run();
