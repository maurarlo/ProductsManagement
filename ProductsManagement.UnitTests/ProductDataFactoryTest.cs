using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using ProductsManagement.Business.Data;

namespace ProductsManagement.UnitTests
{
    [TestClass]
    public class ProductDataFactoryTest
    {
        [TestMethod]
        public void When_get_in_memory_storage_with_value_equal_1_returns_InMemoryProduct_object()
        {
            var productStorage = ProductDataFactory.Get("1");

            Assert.IsTrue(productStorage.GetType() == typeof(InMemoryProduct));
        }

        [TestMethod]
        public void When_get_persistent_storage_with_value_equal_2_returns_PersistentProduct_object()
        {
            var productStorage = ProductDataFactory.Get("2");

            Assert.IsTrue(productStorage.GetType() == typeof(PersistentProduct));
        }

        [TestMethod]
        public void When_get_storage_with_an_inexistent_value_returns_InMemoryProduct_object()
        {
            var productStorage = ProductDataFactory.Get(string.Empty);

            Assert.IsTrue(productStorage.GetType() == typeof(InMemoryProduct));
        }
    }
}
