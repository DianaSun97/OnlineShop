using System.Collections.Generic;
using OnlineShop.Models;

namespace OnlineShop;

public class ShoppingCart
{
    private LinqValueCalculator calc;
    public IEnumerable<Product> Products { get; set; }

    public ShoppingCart(LinqValueCalculator calcParam)
    {
        calc = calcParam;
    }


    public decimal CalculateProductTotal()
    {
        return calc.ValueProducts(Products);
    }
}