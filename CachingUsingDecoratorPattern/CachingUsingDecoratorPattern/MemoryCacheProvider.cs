using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Runtime.Caching;

namespace Products_CachingAndDecoratorPattern
{
    public class MemoryCacheProvider
    {
        MemoryCache cache = new MemoryCache("CachingProvider");
        public void AddItem(string key, Object value)
        {
            cache.Add(key, value, DateTime.Now.AddSeconds(1000));
        }

        public void RemoveItem(string key)
        {
            cache.Remove(key);
        }

        public object GetItem(string key)
        {
            var response = cache[key];
            return response;
        }
    }
}
