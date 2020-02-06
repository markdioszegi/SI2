using System;
using System.Collections.Generic;
using System.IO;
using System.Xml.Serialization;

namespace InventoryProject
{
    [XmlRoot("Products")]
    [XmlInclude(typeof(PersistentStore))]
    [XmlInclude(typeof(BookProduct))]
    [XmlInclude(typeof(CDProduct))]
    public abstract class Store : IStorageCapable
    {
        protected List<Product> _products;
        public List<Product> Products { get { return _products; } set { _products = value; } }
        public Store()
        {
            _products = new List<Product>();
        }
        void SaveToXML(Product product)
        {
            string fileName = "products.xml";
            using (var fileStream = new FileStream(fileName, FileMode.OpenOrCreate))
            {
                XmlSerializer xml = new XmlSerializer(typeof(Store));
                xml.Serialize(fileStream, this);
            }
        }

        public abstract void StoreProduct(Product product);
        protected Product CreateProduct(string type, string name, int price, int size)
        {
            Product product;
            switch (type)
            {
                case "CD": product = new CDProduct(name, price, size); break;
                case "Book": product = new BookProduct(name, price, size); break;
                default: throw new Exception("There is no such type!");
            }
            return product;
        }

        public List<Product> LoadProducts()
        {
            return new List<Product>();
        }

        public void StoreIt(Product product)
        {
            SaveToXML(product);
            StoreProduct(product);
        }

        public List<Product> GetAllProducts()
        {
            return _products;
        }

        public void StoreCDProduct(string name, int price, int tracks)
        {
            Product product = CreateProduct("CD", name, price, tracks);
            StoreIt(product);
        }

        public void StoreBookProduct(string name, int price, int pages)
        {
            Product product = CreateProduct("Book", name, price, pages);
            StoreIt(product);
        }
    }
}