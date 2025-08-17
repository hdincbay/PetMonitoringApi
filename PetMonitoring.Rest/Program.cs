using Microsoft.EntityFrameworkCore;
using PetMonitoring.Entity.Models;
using PetMonitoring.Repository;
using PetMonitoring.Repository.Concrete;
using PetMonitoring.Repository.Contract;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.
builder.Services.AddDbContext<RepositoryContext>(option =>
{
    option.UseSqlServer(builder.Configuration.GetConnectionString("sqlConnection"));
});
builder.Services.AddIdentity<User, Role>().AddEntityFrameworkStores<RepositoryContext>();


//Repository layer, IOC Registry
builder.Services.AddScoped<IDeviceRepository, DeviceRepository>();
builder.Services.AddScoped<IMovementDataRepository, MovementDataRepository>();
builder.Services.AddScoped<ITemperatureDataRepository, TemperatureDataRepository>();
builder.Services.AddScoped<IRepositoryManager, RepositoryManager>();


builder.Services.AddControllers();
// Learn more about configuring OpenAPI at https://aka.ms/aspnet/openapi
builder.Services.AddOpenApi();

var app = builder.Build();

// Configure the HTTP request pipeline.
if (app.Environment.IsDevelopment())
{
    app.MapOpenApi();
}

app.UseHttpsRedirection();

app.UseAuthorization();

app.MapControllers();

app.Run();
