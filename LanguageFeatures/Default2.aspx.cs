using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class LanguageFeatures_Default2 : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {

    }
    protected string GetMessage()
    {
        IEnumerable<Product> products = new ShoppingCart
        {
            Products = new List<Product> {
                new Product {Name = "Kayak", Category = "Watersports", Price = 275M},
                new Product {Name = "Lifejacket", Category = "Watersports", Price = 48.95M},
                new Product {Name = "Soccer ball", Category = "Soccer", Price = 19.50M},
                new Product {Name = "Corner flag", Category = "Soccer", Price = 34.95M}
            }
        };
  //      decimal total = products.FilterByCategory("Soccer").TotalPrices();
        Func<Product, bool> categoryFilter = delegate(Product product) {
            return product.Category == "Soccer";
        };
        //replace delegate definition using lambda expression
        Func<Product, bool> categoryFilter1 = product => product.Category == "Watersports";
        decimal total = products.Filter(categoryFilter).TotalPrices();
        //more explicitly, we can use lambda expression directly in Filter method
        decimal total1 = products.Filter(product => product.Category == "Soccer").TotalPrices();
        //we can even use multiple conditions in the Filter
        decimal total2 = products.Filter(product => product.Category == "Soccer" || product.Price > 20).TotalPrices();
        return String.Format("Soccer Total: {0:c}", total);
    }
}