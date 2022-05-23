using Microsoft.EntityFrameworkCore;
using OnlineShop;
using OnlineShop.Controllers;

var builder = WebApplication.CreateBuilder(args);
builder.Services.AddRazorPages();
string connection = builder.Configuration.GetConnectionString("DefaultConnection");
builder.Services.AddDbContext<ApplicationContext>(options => options.UseSqlite(connection));
var app = builder.Build();

app.UseStaticFiles();
app.MapGet("/api/products", Controller.ListProducts);
app.MapRazorPages();
app.Run();

