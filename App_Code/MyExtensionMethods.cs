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
    public static decimal TotalPrices(this IEnumerable<Product> productEnum)
    {
        decimal total = 0;
        foreach (Product prod in productEnum)
        {
            total += prod.Price;
        }
        return total;
    }
    //The last thing we want to show you about extension methods is that they can be used to filter collections of objects.
//An extension method that operates on an IEnumerable<T> and that also returns an IEnumerable<T> can use the
//yield keyword to apply selection criteria to items in the source data to produce a reduced set of results.
    public static IEnumerable<Product> FilterByCategory(this IEnumerable<Product> productEnum, string categoryParam)
    {
        foreach (Product prod in productEnum)
        {
            if (prod.Category == categoryParam)
            {   
                yield return prod;
            }
        }
    }
}