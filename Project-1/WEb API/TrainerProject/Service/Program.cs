using BusinessLogic;
using DataFluentApi.Entities;
using DataFluentApi;
using Microsoft.EntityFrameworkCore;
using System.Text.RegularExpressions;
using Models;
using Serilog;

var builder = WebApplication.CreateBuilder(args);



builder.Services.AddControllers();

builder.Services.AddCors(options =>  options.AddDefaultPolicy(
         policy =>
         {
             policy.AllowAnyOrigin().AllowAnyHeader().AllowAnyMethod();
         }
         )
     );





builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();

Log.Logger = new LoggerConfiguration().WriteTo.File(@"C:\Users\Admin\Documents\Revature_Projects\P1-Mounika-Baitapalli\Project-1\TrainerProject\Service\Controllers\logs.txt", rollingInterval: RollingInterval.Day, rollOnFileSizeLimit: true)
                .CreateLogger();
Log.Logger.Information(".....Program starts here.............");

Log.Logger.Information(".....configuring connection with Database.............");

var config = builder.Configuration.GetConnectionString("TrainerDbConnection");
builder.Services.AddDbContext<FindTrainerDatabaseContext>(options => options.UseSqlServer(config));

builder.Services.AddScoped<ISqlRepo, EFRepo>();
builder.Services.AddScoped<ITrainersLogic, TrainersLogic>();



Log.Logger.Information(".....Application is Building here.............");

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
app.UseCors();

Log.Logger.Information(".....Application is Running here.............");
app.Run();
