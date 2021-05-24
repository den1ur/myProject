using shop.Data.Interfaces;
using shop.Data.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace shop.Data.Mocks
{
    public class MockProducts : IAllProducts
    {
        private readonly IProductsCategory _categoryProducts = new MockCategory();
        public IEnumerable<Product> Products
        {
            get
            {
                return new List<Product>
                {
                    new Product{name = "Sifon", shortDesc = "", longDesc = "", img = "", price = 4000, isFavorite = true, avaliable = true, Category = _categoryProducts.AllCategories.First() }
                };
            }
        }
        public IEnumerable<Product> getFavProducts { get; set; }

        public Product getObjectProduct(int productId)
        {
            throw new NotImplementedException();
        }
    }
}
