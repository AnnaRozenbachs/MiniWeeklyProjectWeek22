
using Week22;

List<Product> products = new List<Product>();
ProductHelper productHelper = new ProductHelper();
while (true)
{
    Console.ForegroundColor = ConsoleColor.DarkYellow;
    Console.WriteLine("Enter a product by follow the steps. Search for product in list by entering (s). Quit by enter (q). ");
    Console.ForegroundColor = ConsoleColor.White;
    Console.WriteLine("Enter a productname: ");
    var name = Console.ReadLine().Trim().ToLower();
    if (name == "q")
    {
        productHelper.DisplayProducts(products);
    }
    else if (name == "s")
    {
        Console.WriteLine("Enter a search value: ");
        var searchValue = Console.ReadLine();
        productHelper.DisplayProducts(products, searchValue);
    }
    else
    {
        Product product = new Product();
        Console.WriteLine("Enter a category: ");
        string category = Console.ReadLine();
        Console.WriteLine("Enter a price: ");
        string price = Console.ReadLine();
        product = productHelper.SetProductValues(name, category, price, product);
        if (product == null)
        {
            Console.ForegroundColor = ConsoleColor.Red;
            Console.WriteLine("Produkten kunde inte läggas till. Något av fälten är ogiltigt ifyllda.");
            Console.ForegroundColor = ConsoleColor.White;
        }
        else
        {
            products.Add(product);
        }


    }

}