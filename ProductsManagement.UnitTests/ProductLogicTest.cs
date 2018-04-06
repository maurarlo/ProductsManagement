using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using ProductsManagement.Business;
using ProductsManagement.Business.Data;

namespace ProductsManagement.UnitTests
{
    [TestClass]
    public class ProductLogicTest
    {
        [TestMethod]
        public void When_get_products_from_memory_returns_empty_because_it_has_nothing()
        {
            ProductLogic productLogic = new ProductLogic(new InMemoryProduct());

            var products = productLogic.Get();

            Assert.AreEqual(0, products.Count);
        }

        [TestMethod]
        public void When_get_products_from_memory_returns_one_product_because_this_exist_in_memory()
        {
            InMemoryProduct.Products.Add(new Entities.Product
            {
                Number = 1,
                Price = 1000,
                Title = "Car",
            });


            ProductLogic productLogic = new ProductLogic(new InMemoryProduct());

            var products = productLogic.Get();

            Assert.AreEqual(1, products.Count);
        }

        [TestMethod]
        public void When_get_products_from_persistent_returns_two_products_that_exist_in_xml_file()
        {
            ProductLogic productLogic = new ProductLogic(new PersistentProduct());

            var products = productLogic.Get();

            Assert.AreEqual(2, products.Count);
        }

        [TestMethod]
        public void When_get_products_from_persistent_returns_three_products_after_add_new_product_to_xml_file()
        {
            ProductLogic productLogic = new ProductLogic(new PersistentProduct());

            productLogic.Create(new Entities.Product { Number = 222, Title = "From unit test", Price = 111 });

            var products = productLogic.Get();

            Assert.AreEqual(3, products.Count);
        }
    }
}
