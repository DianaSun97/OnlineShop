using System.Collections.Generic;
using System.Linq;
using OnlineShop.Models;

namespace OnlineShop.Models;
public class LinqValueCalculator
{
    public decimal ValueProducts(IEnumerable<Product> products)
    {
        return products.Sum(p => p.Price);
    }
}