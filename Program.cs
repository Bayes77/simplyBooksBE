using Microsoft.EntityFrameworkCore;
using simplyBooksBE.Data;
using simplyBooksBE.Interfaces;
using simplyBooksBE.Repositories;
using simplyBooksBE.Endpoints;
using simplyBooksBE.Models;
using simplyBooksBE.Services;
using System.Text.Json.Serialization;
using Microsoft.AspNetCore.Http.Json;
using System.Collections.Generic;



var builder = WebApplication.CreateBuilder(args);


builder.Services.AddNpgsql<simplyBooksBEDbContext>(builder.Configuration["simplyBooksBEDbConnectionString"]);

// Set the JSON serializer options
builder.Services.Configure<JsonOptions>(options =>
{
    options.SerializerOptions.ReferenceHandler = ReferenceHandler.IgnoreCycles;
});


builder.Services.AddScoped<IAuthorsRepository, AuthorsRepository>();
builder.Services.AddScoped<IAuthorsServices, AuthorsServices>();
builder.Services.AddScoped<IBooksRepository, BooksRepository>();
builder.Services.AddScoped<IBooksServices, BooksService>();

// Add services to the container.
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

app.MapAuthorsEndpoints();
app.MapBooksEndpoints();

app.Run();
