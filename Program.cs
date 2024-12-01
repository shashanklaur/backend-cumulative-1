using Microsoft.EntityFrameworkCore;
using SchoolDatabase.Models;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.
builder.Services.AddControllersWithViews();

// Add database context
builder.Services.AddDbContext<SchoolDbContext>(options =>
	options.UseMySql(builder.Configuration.GetConnectionString("SchoolDatabase"),
	new MySqlServerVersion(new Version(8, 0, 23))));

var app = builder.Build();

// Configure the HTTP request pipeline.
app.UseStaticFiles();
app.UseRouting();

app.MapDefaultControllerRoute();

app.Run();


