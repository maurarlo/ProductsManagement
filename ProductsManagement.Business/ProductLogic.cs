using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ProductsManagement.Entities;

namespace ProductsManagement.Business
{
    public class ProductLogic
    {
        public Data.IProductData ProductData { get; set; }

        public ProductLogic(Data.IProductData productData)
        {
            this.ProductData = productData;
        }

        public void Create(Product product)
        {
            this.ProductData.CreateProduct(product);
        }

        public List<Product> Get()
        {
            return this.ProductData.GetProducts();
        }
    }
}
