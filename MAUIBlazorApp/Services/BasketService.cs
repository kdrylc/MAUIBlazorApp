using MAUIBlazorApp.Classes.Product;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MAUIBlazorApp.Services
{
    public class BasketService
    {
        private List<Product> products;
        public BasketService()
        {
            products = new List<Product>();
        }

        public List<Product> basketList()
        {
            return products;
        }
        
        public async Task<bool> acceptProductBasket(Product product)
        {
            try
            {
                products.Add(product);
                return true;
            }
            catch (Exception ex)
            {

                return false;
            }
        }

        public async Task<bool> deleteProductBasket(int Id)
        {
            try
            {
                products = products.Where(x => x.Id != Id).ToList();
                return true;
            }
            catch (Exception ex)
            {
                return false;
            }
        }
    }
}
