using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ProductsManagement.Entities;

namespace ProductsManagement.Business.Data
{
    public interface IProductData
    {
        List<Product> GetProducts();

        void CreateProduct(Product product);
    }
}
