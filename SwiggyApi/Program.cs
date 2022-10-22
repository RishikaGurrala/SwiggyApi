using SwiggyApi.Core;
using SwiggyApi.Models;
using Microsoft.EntityFrameworkCore;
using ServiceStack.Auth;
using SwiggyApi.Core.Services;
using SwiggyApi.Core.IServices;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.

builder.Services.AddControllers();
builder.Services.AddDbContext<SwiggyContext>(
    options => options.UseSqlServer(builder.Configuration.GetConnectionString("con"))
    );
builder.Services.AddScoped<IRegistrationService, RegistrationService>();
builder.Services.AddScoped<IProductService, ProductService>();
// Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();

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
