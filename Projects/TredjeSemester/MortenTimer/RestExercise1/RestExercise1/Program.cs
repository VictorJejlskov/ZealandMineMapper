using Microsoft.EntityFrameworkCore;
using RestExercise1;
using RestExercise1.Models;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.

builder.Services.AddControllers();
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();
builder.Services.AddCors(options =>
{
    options.AddPolicy(name: "AllowAll", policy =>
    {
        policy.AllowAnyOrigin().
        AllowAnyMethod().
        AllowAnyHeader();
    });
});
//builder.Services.AddDbContext<IPAContext>(options => options.UseSqlServer(Secrets.IpaConnectionString));

var app = builder.Build();
app.UseSwagger();
app.UseSwaggerUI();

// Configure the HTTP request pipeline.
app.UseCors("AllowAll");
app.UseAuthorization();

app.MapControllers();

app.Run();
