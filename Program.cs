
using Week22;

List<Product> products = new List<Product>();
ProductHelper productHelper = new ProductHelper();
while (true)
{
    Console.WriteLine("Enter a productname/search for product (s)/quit (q). ");
    var name = Console.ReadLine().Trim().ToLower();
    if (name == "q")
    {
        productHelper.DisplayProducts(products);
    }
    else if (name == "s")
    {
        Console.WriteLine("Enter a searchvalue: ");
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
            Console.ForegroundColor = ConsoleColor.Green;
            Console.WriteLine("Produkten är tillagd");
            Console.ForegroundColor = ConsoleColor.White;
        }


    }

}