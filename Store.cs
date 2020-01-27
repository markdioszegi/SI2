using System;
using System.Collections.Generic;
using System.IO;
using System.Xml.Serialization;

namespace InventoryProject
{
    public abstract class Store : IStorageCapable
    {
        //List<Product> Products;
        /* public Store()
        {
            //Products = new List<Product>();
        } */
        void SaveToXML(Product product)
        {
            XmlSerializer xml = new XmlSerializer(typeof(Product));
            using (StreamWriter tw = new StreamWriter("products.xml"))
            {
                xml.Serialize(tw, product);
            }
        }

        protected void StoreProduct(Product product)
        {

        }

        protected Product CreateProduct(string type, string name, int price, int size)
        {
            Product product;
            switch (type)
            {
                case "CD": product = new CDProduct(name, price, size); break;
                case "Book": product = new BookProduct(name, price, size); break;
                default: throw new Exception("RIP tesla");
            }
            return product;
        }

        public List<Product> LoadProducts()
        {
            List<Product> products = new List<Product>();

            using (Stream stream = new FileStream("products.xml", FileMode.Open))
            {

            }

            return products;
        }

        public void store(Product product)
        {

        }

        public List<Product> GetAllProduct()
        {
            throw new NotImplementedException();
        }

        public void StoreCDProduct(string name, int price, int tracks)
        {
            throw new NotImplementedException();
        }

        public void StoreBookProduct(string name, int price, int pages)
        {
            throw new NotImplementedException();
        }
    }
}