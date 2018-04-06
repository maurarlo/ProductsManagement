using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProductsManagement.Business.Data
{
    public static class ProductDataFactory
    {
        public static IProductData Get(string productDataId)
        {
            switch (productDataId)
            {
                case "1":
                    return new InMemoryProduct();
                case "2":
                    return new PersistentProduct();
                default:
                    return new InMemoryProduct();
            }
        }
    }
}
