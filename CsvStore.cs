using System;
using System.Collections.Generic;
using System.IO;

namespace InventoryProject
{
    public abstract class CsvStore : IStorageCapable
    {
        protected List<Product> products;
        public List<Product> Products { get { return products; } set { products = value; } }
        public abstract void StoreProduct(Product product);
        public CsvStore()
        {
            Products = new List<Product>();
        }

        public List<Product> GetAllProducts()
        {
            return products;
        }

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

        public void StoreIt(Product product)
        {
            StoreProduct(product);
            SaveToCsv(product);
        }

        private void SaveToCsv(Product product)
        {
            string fileName = "products.csv";
            using (var fileStream = new StreamWriter(fileName, true))
            {
                fileStream.WriteLine(product.ToString());
            }
        }
    }
}