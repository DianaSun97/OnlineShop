using Microsoft.AspNetCore.Mvc.RazorPages;
using OnlineShop.Models;

namespace OnlineShop.Pages;

public class Description : PageModel
{
    private ApplicationContext db;
    public Product? Product;

    public Description(ApplicationContext pdb)
    {
        db = pdb;
    }
    public void OnGet()
    {
        Product = db.Products.Take(1).First();
    }
}