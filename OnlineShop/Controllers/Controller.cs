using OnlineShop.Models;

namespace OnlineShop.Controllers;

public static class Controller
{
    public static List<Product> ListProducts(ApplicationContext db)
    {
        return db.Products.ToList();
    }
}