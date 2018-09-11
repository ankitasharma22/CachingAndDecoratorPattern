using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Products_CachingAndDecoratorPattern
{
    interface IProductService
    {
        List<Product> GetProducts();
        Product GetProductById(int id);
    }
}
