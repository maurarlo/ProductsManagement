using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Serialization;

namespace ProductsManagement.Entities
{
    [XmlRoot]
    public class ProductCollection
    {
        [XmlElement("Product")]
        public List<Product> Products { get; set; }
    }
}
