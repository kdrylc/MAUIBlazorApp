using MAUIBlazorApp.Classes.Product;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MAUIBlazorApp.Services
{
    public class ProductService
    {
        private List<Product> products;

        public ProductService()
        {
            products = new List<Product>();
            products.Add(new Product
            {
                Id = 1,
                Name = "prod1",
                Price = 10,
                Stock = 30,
                CategoryId = 1
            });

            products.Add(new Product
            {
                Id = 2,
                Name = "prod2",
                Price = 10,
                Stock = 30,
                CategoryId = 1
            });

            products.Add(new Product
            {
                Id = 3,
                Name = "prod3",
                Price = 10,
                Stock = 30,
                CategoryId = 1
            });

        }

        public async Task<List<Product>> productList()
        {
            return products;
        }

        public async Task<List<Product>> searchProductByCategoryId(int categoryId)
        {
            var query = products.Where(x => x.CategoryId == categoryId).ToList();
            return query;
        }
    }
}
