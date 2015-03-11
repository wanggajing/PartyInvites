using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class LanguageFeatures_Default : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {

    }
    protected string GetMessage()
    {
        // create a new Product object
        Product myProduct = new Product();
        // set the property values
        myProduct.ProductID = 100;
        myProduct.Name = "Kayak";
        myProduct.Description = "A boat for one person";
        myProduct.Price = 275M;
        myProduct.Category = "Watersports";
        //use object initializer
        Product myProduct2 = new Product
        {
            ProductID = 110,
            Name = "GaTop",
            Description = "Hello GaTop",
            Price = 300,
            Category = "SomeCategory"
        };
        //use collection initializer
        string[] stringArray = { "apple", "orange", "plum" };
        List<int> intList = new List<int> { 10, 20, 30, 40 };
        Dictionary<string, int> myDict = new Dictionary<string, int> {
            { "apple", 10 }, { "orange", 20 }, { "plum", 30 }
        };
        List<Product> products = new List<Product>
        {
            new Product{
                ProductID = 120,
                Name = "dasg",
                Description = "sdgf GaTop",
                Price = 300,
                Category = "safds"
            },
            new Product{
                ProductID = 130,
                Name = "swares",
                Description = "sfee sdfsfs",
                Price = 300,
                Category = "freww"
            },
        };
        // code which utilize extension method
        ShoppingCart cart = new ShoppingCart
        {
            Products = new List<Product> {
                new Product {Name = "Kayak", Price = 275M},
                new Product {Name = "Lifejacket", Price = 48.95M},
                new Product {Name = "Soccer ball", Price = 19.50M},
                new Product {Name = "Corner flag", Price = 34.95M}
            }
        };
        decimal cartTotal = cart.TotalPrices();
        return String.Format("Total: {0:c}", cartTotal);
     //   return String.Format("Category: {0}", myProduct.Category);        
    }
}