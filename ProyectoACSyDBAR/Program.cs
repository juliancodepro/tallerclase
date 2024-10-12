using MongoDB.Driver;
using ProyectoACSyDBAR.Data.Repository;
using ProyectoACSyDBAR.Data.Repository.Interfaces;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.

builder.Services.AddControllers();
// Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();

IMongoClient mongoClient = new MongoClient("mongodb://admin:adminpassword@localhost:27017");

builder.Services.AddSingleton(mongoClient);

builder.Services.AddScoped<IProductRepository, ProductRepository>();
  
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
