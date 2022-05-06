using Microsoft.EntityFrameworkCore;
using OnlineShop.Models;

namespace OnlineShop;
public class ApplicationContext : DbContext
{
    public DbSet<Product> Products { get; set; } = null!;
    
    public ApplicationContext(DbContextOptions<ApplicationContext> options)
        : base(options)
    {
        Database.EnsureCreated();   // создаем базу данных при первом обращении
    }
    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        modelBuilder.Entity<Product>().HasData(
            new Product {ProductID = 1, Name = "Piim TERE 2,5%, 1L", Category = " Milk ", Description = "Keefir maasika", Price = 275},
            new Product {ProductID = 2, Name = "Mandariin 1kl., kg", Category = " Fruits ", Description = "Keefir maasika", Price = 48.95M},
            new Product {ProductID = 3, Name = "VANA TALLINN Wild Spices 35% 0.5L", Category = "Drinks", Description = "Keefir maasika", Price = 19.50M},
            new Product {ProductID = 4, Name = "Jogurt FARMI leiva-pähkli lakt.vaba,400g", Category = "Milk", Description = "Keefir maasika", Price = 34.95M}
        );
    }
}