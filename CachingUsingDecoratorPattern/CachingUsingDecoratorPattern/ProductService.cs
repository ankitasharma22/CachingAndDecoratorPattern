using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Products_CachingAndDecoratorPattern
{
    class ProductService : IProductService
    {
        public Product GetProductById(int id)
        {
            IRepository productRepo = new SQLProductRepository();
            Console.WriteLine("Repository------Get BY id");
            return productRepo.GetProductById(id);
        }

        public List<Product> GetProducts()
        {
            IRepository productRepo = new SQLProductRepository();
            Console.WriteLine("Repository------Get all products");
            return productRepo.GetAllProducts();
        }
    }
}
