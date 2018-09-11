using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Products_CachingAndDecoratorPattern
{
    interface IRepository
    {
        List<Product> GetAllProducts();
        Product GetProductById(int id);
    }
}
