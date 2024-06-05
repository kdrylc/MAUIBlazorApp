using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MAUIBlazorApp.Classes.Product
{
    public class Product
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public decimal Price { get; set; }
        public int Stock { get; set; }
        public int CategoryId { get; set; }
        public int BrandId { get; set; }
        public string Image { get; set; }
        public int Basket { get; set; }
        public bool Added { get; set; } = false;
        public bool Deleted { get; set; } = true;
    }
}
