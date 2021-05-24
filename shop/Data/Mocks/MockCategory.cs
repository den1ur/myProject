using shop.Data.Interfaces;
using shop.Data.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace shop.Data.Mocks
{
    public class MockCategory : IProductCategory
    {
        public IEnumerable<Category> AllCategories
        {
            get
            {
                return new List<Category>
                {
                    new Category { categoryName = "Сантехика", desc = "Все для водопровода"}
                    new Category { categoryName = "Стройматериалы", desc = "Все для строительства"}
                };
            }
        }
    }
}
