using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ProductsManagement.Entities;

namespace ProductsManagement.Business.Data
{
    public class InMemoryProduct : IProductData
    {
        public static List<Product> Products { get; set; }

        static InMemoryProduct()
        {
            Products = new List<Product>();
        }

        public void CreateProduct(Product product)
        {
            Products.Add(product);
        }

        public List<Product> GetProducts()
        {
            return Products;
        }
    }
}
