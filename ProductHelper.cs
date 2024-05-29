using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Week22
{
    public class ProductHelper
    {
        public Product SetProductValues(string name, string category,string price,  Product product)
        {
            if(string.IsNullOrEmpty(name) || string.IsNullOrEmpty(category) 
                || string.IsNullOrEmpty(price) || !price.All(char.IsNumber)) {
                return null; 
            }
            product.ProductName = name;
            product.Category = category;
            product.Price = decimal.Parse(price);
            return product;
        }

        public void DisplayProducts(List<Product> products, string searchedValue= "")
        {
            var sortedProducts = products.OrderBy(p => p.Price).ToList();
            Console.ForegroundColor = ConsoleColor.Green;
            Console.WriteLine("Name".PadRight(10) + "Category".PadRight(10) + "Price");
            Console.ForegroundColor = ConsoleColor.White;
            foreach (Product product in sortedProducts) 
            {
                if (product.ProductName.Contains(searchedValue) || product.Category.Contains(searchedValue))
                { 
                    Console.ForegroundColor = ConsoleColor.Yellow;
                }
                Console.WriteLine(product.ProductName.PadRight(10) + product.Category.PadRight(10) + product.Price.ToString().PadRight(10)); 
                Console.ForegroundColor= ConsoleColor.White;
            }
            var sum = sortedProducts.Sum(p => p.Price);
            Console.WriteLine("--------------------------------------");
            Console.WriteLine("Total: ".PadRight(20) + sum);
        }

            
    }
}
