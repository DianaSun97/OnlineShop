using Microsoft.AspNetCore.Mvc.RazorPages;
using OnlineShop.Models;

namespace OnlineShop.Pages;

public class Listing : PageModel
{
    private ApplicationContext db;
    private int pageSize = 10;
    public Product[] Products;

    public Listing(ApplicationContext pdb)
    {
        db = pdb;
    }
    
    public void OnGet()
    {
        int page;
        int CurrentPage = int.TryParse(Request.Query["page"], out page) ? page : 1;
        Products = db.Products
            .OrderBy(g => g.ProductID)
            .Skip((CurrentPage - 1) * pageSize)
            .Take(pageSize).ToArray();
    }
}