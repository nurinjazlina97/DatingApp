using API.Data;
using Microsoft.EntityFrameworkCore;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.

builder.Services.AddControllers();

builder.Services.AddDbContext<DataContext>(opt => 
{
    opt.UseSqlite(builder.Configuration.GetConnectionString("DefaultConnection"));
    
});

var app = builder.Build();

// Configure the HTTP request pipeline.
app.MapControllers(); // a middleware that's going to tell our request which API endpoint it needs to go to.

app.Run(); //to run application
