using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class LanguageFeatures_LINQ : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {

    }
    //without LINQ
    protected string GetMessage()
    {
        Product[] products = {
            new Product {Name = "Kayak", Category = "Watersports", Price = 275M},
            new Product {Name = "Lifejacket", Category = "Watersports",Price = 48.95M},
            new Product {Name = "Soccer ball", Category = "Soccer", Price = 19.50M},
            new Product {Name = "Corner flag", Category = "Soccer", Price = 34.95M}
        };
        Product[] foundProducts = new Product[3];
        Array.Sort(products, (item1, item2) =>
        {
            return Comparer<decimal>.Default.Compare(item1.Price, item2.Price);
        });
        Array.Copy(products, foundProducts, 3);
        StringBuilder result = new StringBuilder();
        foreach (Product p in foundProducts)
        {
            result.AppendFormat("Price: {0} ", p.Price);
        }
        return result.ToString();
    }
    //use LINQ query syntax
    protected string GetMessage1()
    {
        Product[] products = {
            new Product {Name = "Kayak", Category = "Watersports", Price = 275M},
            new Product {Name = "Lifejacket", Category = "Watersports", Price = 48.95M},
            new Product {Name = "Soccer ball", Category = "Soccer", Price = 19.50M},
            new Product {Name = "Corner flag", Category = "Soccer", Price = 34.95M}
        };
        var foundProducts = from prod in products
                            orderby prod.Price descending
                            select prod.Price;
        int count = 0;
        StringBuilder result = new StringBuilder();
        foreach (var price in foundProducts)
        {
            result.AppendFormat("Price: {0} ", price);
            if (++count == 3)
            {
                break;
            }
        }
        return result.ToString();
    }
    //use LINQ method syntax
    protected string GetMessage2()
    {
        Product[] products = {
            new Product {Name = "Kayak", Category = "Watersports", Price = 275M},
            new Product {Name = "Lifejacket", Category = "Watersports", Price = 48.95M},
            new Product {Name = "Soccer ball", Category = "Soccer", Price = 19.50M},
            new Product {Name = "Corner flag", Category = "Soccer", Price = 34.95M}
        };
        var foundProducts = products.OrderByDescending(p => p.Price)
                            .Take(3)
                            .Select(p => p.Price);
        StringBuilder result = new StringBuilder();
        foreach (var price in foundProducts)
        {
            result.AppendFormat("Price: {0} ", price);
        }
        return result.ToString();
    }
    //Using deferred LINQ extension methods
    protected string GetMessage3()
    {
        Product[] products = {
            new Product {Name = "Kayak", Category = "Watersports", Price = 275M},
            new Product {Name = "Lifejacket", Category = "Watersports", Price = 48.95M},
            new Product {Name = "Soccer ball", Category = "Soccer", Price = 19.50M},
            new Product {Name = "Corner flag", Category = "Soccer", Price = 34.95M}
        };
        var foundProducts = products.OrderByDescending(e => e.Price)
        .Take(3)
        .Select(e => e.Price);
        //You can see that the query isn’t evaluated until the results are enumerated, and so the change we made—introducing
        //Stadium into the Product array—is reflected in the output.
        products[2] = new Product { Name = "Stadium", Price = 79600M };
        StringBuilder result = new StringBuilder();
        foreach (var price in foundProducts)
        {
            result.AppendFormat("Price: {0} ", price);
        }
        return result.ToString();
    }
    ////Using non-deferred LINQ extension methods
    protected string GetMessage()
    {
        Product[] products = {
            new Product {Name = "Kayak", Category = "Watersports", Price = 275M},
            new Product {Name = "Lifejacket", Category = "Watersports", Price = 48.95M},
            new Product {Name = "Soccer ball", Category = "Soccer", Price = 19.50M},
            new Product {Name = "Corner flag", Category = "Soccer", Price = 34.95M}
        };
        var totalPrice = products.OrderByDescending(e => e.Price)
        .Take(3)
        .Select(e => e.Price)
        .Sum(e => e);
        //You can see that the Stadium item, with its much higher price, has not been included in the total—this is because
        //the results from the Sum method are evaluated as soon as the method is called, rather than being deferred until the
        //results are used.
        products[2] = new Product { Name = "Stadium", Price = 79600M };
        return String.Format("Total: {0}", totalPrice.ToString());
    }
}