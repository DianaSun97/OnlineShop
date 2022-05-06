using Microsoft.AspNetCore.Mvc.RazorPages;
using OnlineShop.Models;

namespace OnlineShop.Pages;

public class Shopcart : PageModel
{
    private ApplicationContext db;
    public ShoppingCart Cart;

    public Shopcart(ApplicationContext pdb)
    {
        db = pdb;
        LinqValueCalculator calc = new LinqValueCalculator();
        Cart = new ShoppingCart(calc)
        {
            Products = db.Products.ToArray()
        };
    }
    public void OnGet()
    {
    }
}