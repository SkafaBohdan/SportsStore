using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace SportsStore.Models
{
    public class FakeProductRepository : IProductRepository
    {
        public IEnumerable<Product> Products => new List<Product>
        {
            new Product { Name = "Footbal", Price = 25},
            new Product { Name = "Sggsdg", Price = 399},
            new Product { Name = "Test3", Price = 10},
        };
    }
}
