using MAUIBlazorApp.Classes.Category;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MAUIBlazorApp.Services
{
    public class CategoryService
    {
        private List<Category> list;

        public CategoryService()
        {
            list = new List<Category>();
            list.Add(new Category
            {
                Id = 1,
                Name = "Test",
            });
            list.Add(new Category
            {
                Id = 2,
                Name = "Test2",
            });
            list.Add(new Category
            {
                Id = 3,
                Name = "Test2",
            });
        }

        public async Task<List<Category>> catList()
        {
            return list;
        }
    }
}
