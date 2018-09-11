using CachingUsingDecoratorPattern;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Products_CachingAndDecoratorPattern
{
    class UserInteraction
    {
        static void Main(string[] args)
        {
            IProductService productService = new MemoryCacheProductService();
            List<Product> products = productService.GetProducts();

            Constants consoleMessages = new Constants();

            Console.WriteLine("--- All Products --- ");
            List<Product> productList = productService.GetProducts();
            for (int i = 0; i < productList.Count; i++)
            {
                Console.Write("Id ---- " + productList[i].Id);
                Console.Write(" Name --- " + productList[i].Name);
                Console.Write(" Price --- " + productList[i].Price);
                Console.WriteLine();
            }
            Console.WriteLine();

            consoleMessages.EnterDetails();
            int id = int.Parse(Console.ReadLine());

            Product product = productService.GetProductById(id);

            Console.Write("Id ---- " + product.Id);
            Console.Write(" Name --- " + product.Name);
            Console.Write(" Price --- " + product.Price);
            Console.WriteLine();
 
            consoleMessages.EnterDetails();
            id = int.Parse(Console.ReadLine());

            product = productService.GetProductById(id);

            Console.Write("Id ---- " + product.Id);
            Console.Write( "Name --- " + product.Name);
            Console.Write(" Price --- " + product.Price);
            Console.WriteLine();

            Console.ReadKey();
        }
    }
}
