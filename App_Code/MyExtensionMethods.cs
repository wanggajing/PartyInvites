using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

/// <summary>
/// Summary description for MyExtensionMethods
/// </summary>
public static class MyExtensionMethods
{
    //Suppose we need to be able to determine the total value of the Product objects in the ShoppingCart
//class, but we can’t modify the class itself, perhaps because it comes from a third party and we don’t have the source
//code. We can use an extension method to get the functionality we need.
    //extension method
    public static decimal TotalPrices(this ShoppingCart cartParam)
    {
        decimal total = 0;
        foreach (Product prod in cartParam.Products)
        {
            total += prod.Price;
        }
        return total;
    }
}