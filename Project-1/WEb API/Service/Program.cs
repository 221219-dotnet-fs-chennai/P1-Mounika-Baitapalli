using BusinessLogic;
using DataFluentApi;
using DataFluentApi.Entities;
using Models;
using Microsoft.EntityFrameworkCore;



var builder = WebApplication.CreateBuilder(args);

// Add services to the container.

builder.Services.AddControllers();
// Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();


var config = builder.Configuration.GetConnectionString("TrainerDbConnection");
builder.Services.AddDbContext<FindTrainerDatabaseContext>(options=> options.UseSqlServer(config));
//builder.Services.AddDbContext<FindTrainerDatabaseContext>(options => options.UseSqlServer(config));
builder.Services.AddScoped<ISqlRepo<DataFluentApi.Entities.TrainerDetail>, EFRepo>();
builder.Services.AddScoped<ITrainersLogic, TrainersLogic>();


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
