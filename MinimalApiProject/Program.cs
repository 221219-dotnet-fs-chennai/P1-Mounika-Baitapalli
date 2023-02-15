using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.InMemory;
using Microsoft.Extensions.Options;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.
// Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();
builder.Services.AddDbContext<FruitContext>(options => options.UseInMemoryDatabase("FruitsList"));

var app = builder.Build();

// Configure the HTTP request pipeline.
if (app.Environment.IsDevelopment())
{
    app.UseSwagger();
    app.UseSwaggerUI();
}








app.MapPost("/fruits", async (Fruit f, FruitContext fc) =>
{
    fc.FruitsList.Add(f);
    await fc.SaveChangesAsync();

});
app.MapDelete("/fruit/{Id}", async (int Id, FruitContext fc) =>
{
    if (await fc.FruitsList.FindAsync(Id) is Fruit f)
    {
        fc.FruitsList.Remove(f);
        await fc.SaveChangesAsync();
        return Results.Ok(f);
    }
    return Results.NotFound();

});
app.MapGet("/fruits", (int Id, FruitContext fc) =>
fc.FruitsList.FindAsync(Id));

app.MapPut("/fruit/{Id}", async (int Id, Fruit f, FruitContext fc) =>
{
    var num = await fc.FruitsList.FindAsync(Id);
    if (num is null)
        return Results.NotFound();
    num.apple = f.apple;
    num.pineapple = f.pineapple;
    num.orange = f.orange;
    num.grapes = f.grapes;
    num.grapes = f.grapes;
    await fc.SaveChangesAsync();
    return Results.Ok(num);
});





 


app.Run();
app.UseHttpsRedirection();

class Fruit 
{
    public int Id { get; set; }
    public string Banana { get; set; }
    public string apple { get; set; }
    public string orange { get; set; }
    public string grapes { get; set; }
    public string pineapple { get; set; }
}

 class FruitContext:DbContext
{

public FruitContext(DbContextOptions <FruitContext> options):base(options)
{

}
    public DbSet<Fruit> FruitsList { get; set; }

}





