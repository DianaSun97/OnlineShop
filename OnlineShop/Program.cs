using OnlineShop;
using Microsoft.EntityFrameworkCore;

var builder = WebApplication.CreateBuilder(args);
builder.Services.AddRazorPages();
string connection = builder.Configuration.GetConnectionString("DefaultConnection");
builder.Services.AddDbContext<ApplicationContext>(options => options.UseSqlite(connection));
var app = builder.Build();

app.UseStaticFiles();
app.MapGet("/api/products", (ApplicationContext db) => db.Products.ToList());
app.MapRazorPages();
app.Run();

