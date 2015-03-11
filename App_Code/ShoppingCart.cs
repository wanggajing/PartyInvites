using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Web;

/// <summary>
/// Summary description for ShoppingCart
/// </summary>

//We can also create extension methods that apply to an interface, which allows us to call the extension method on
//all of the classes that implement the interface.
public class ShoppingCart:IEnumerable<Product>
{
    public List<Product> Products { get; set; }
    public IEnumerator<Product> GetEnumerator()
    {
        return Products.GetEnumerator();
    }
    IEnumerator IEnumerable.GetEnumerator()
    {
        return GetEnumerator();
    }
}