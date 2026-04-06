using Cocktail_Api.Models;
using Cocktail_Api.Services;
using Microsoft.EntityFrameworkCore;
using Scalar.AspNetCore;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.

builder.Services.AddControllers();
// Learn more about configuring OpenAPI at https://aka.ms/aspnet/openapi
builder.Services.AddOpenApi();

builder.Services.AddDbContext<CocktailDbContext>(options =>
    options.UseSqlite());

builder.Services.AddHttpClient<Cocktail_Service>(client =>
{
    client.BaseAddress = new Uri("https://www.thecocktaildb.com/api/json/v1/1/");
    client.DefaultRequestHeaders.Add("Accept", "application/json");
});


builder.Services.AddCors(options =>
{
    options.AddPolicy("AllowAngular",
        policy =>
        {
            policy.WithOrigins("http://localhost:4200")
                  .AllowAnyHeader()
                  .AllowAnyMethod();
        });
});

builder.Services.AddControllers();


var app = builder.Build();

app.UseCors("AllowAngular");


// Configure the HTTP request pipeline.
if (app.Environment.IsDevelopment())
{
    app.MapOpenApi();
    app.MapScalarApiReference();

}


app.UseHttpsRedirection();

app.UseAuthorization();

app.MapControllers();

app.Run();
