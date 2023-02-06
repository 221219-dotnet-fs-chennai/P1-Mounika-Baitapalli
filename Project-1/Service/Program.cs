using DataFluentApi.Entities;
using BusinessLogic;
using Microsoft.EntityFrameworkCore;
using Models;
using DataFluentApi;



var builder = WebApplication.CreateBuilder(args);

// Add services to the container.
builder.Services.AddMemoryCache();

builder.Services.AddControllers().AddXmlSerializerFormatters();
// Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle


var config = builder.Configuration.GetConnectionString("FindTrainerdb");
builder.Services.AddDbContext<FindTrainerDbContext>(options=> options.UseSqlServer(config));
builder.Services.AddScoped<ISqlRepo<DataFluentApi.Entities.TrainerDetail>, DataFluentApi.EFRepo>();
builder.Services.AddScoped<ITrainersLogic,TrainersLogic>();

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
