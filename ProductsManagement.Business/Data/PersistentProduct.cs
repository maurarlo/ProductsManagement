using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Serialization;
using ProductsManagement.Entities;

namespace ProductsManagement.Business.Data
{
    public class PersistentProduct : IProductData
    {
        public void CreateProduct(Product product)
        {
            ProductCollection productCollection = new ProductCollection();
            productCollection.Products = this.GetProducts();
            productCollection.Products.Add(product);

            XmlSerializer xmlSerializer = new XmlSerializer(typeof(ProductCollection));

            using (Stream outputStream = File.OpenWrite(this.GetFilePath()))
            {
                xmlSerializer.Serialize(outputStream, productCollection);
            }
        }

        public List<Product> GetProducts()
        {
            XmlSerializer xmlSerializer = new XmlSerializer(typeof(ProductCollection));

            ProductCollection productCollection;

            using (StreamReader stream = new StreamReader(this.GetFilePath()))
            {
                productCollection = (ProductCollection)xmlSerializer.Deserialize(stream);
            }

            return productCollection.Products;
        }

        public string GetFilePath()
        {
            const string fileName = "Products.xml";

            string path = $"{AppDomain.CurrentDomain.GetData("DataDirectory")}\\{fileName}";

            if (!File.Exists(path))
            {
                path = $"{AppDomain.CurrentDomain.BaseDirectory}\\{fileName}";

                if (!File.Exists(path))
                {
                    throw new FileNotFoundException("File not found.", path);
                }
            }

            return path;
        }
    }
}
