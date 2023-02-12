using BusinessLogic;
using DataFluentApi.Entities;
using DataFluentApi;
using Microsoft.EntityFrameworkCore;
using System.Text.RegularExpressions;
using Models;
//using Serilog;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.

builder.Services.AddControllers();
// Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();

var config = builder.Configuration.GetConnectionString("TrainerDbConnection");
builder.Services.AddDbContext<FindTrainerDatabaseContext>(options => options.UseSqlServer(config));

builder.Services.AddScoped<ISqlRepo, EFRepo>();
builder.Services.AddScoped<ITrainersLogic, TrainersLogic>();


//Log.Logger.

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
