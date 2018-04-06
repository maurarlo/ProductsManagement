using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Serialization;

namespace ProductsManagement.Entities
{
    [XmlRoot]
    public class Product
    {
        [XmlAttribute("id")]
        public int Id { get; set; }

        [XmlAttribute("number")]
        public int Number { get; set; }

        [XmlAttribute("title")]
        public string Title { get; set; }

        [XmlAttribute("price")]
        public decimal Price { get; set; }
    }
}
