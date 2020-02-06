using System.Linq;

namespace InventoryProject
{
    public class StoreManager
    {
        IStorageCapable Storage;

        public void AddStorage(IStorageCapable storage)
        {
            Storage = storage;
        }

        public void AddCDProduct(string name, int price, int tracks)
        {
            Storage.StoreCDProduct(name, price, tracks);
        }

        public void AddBookProduct(string name, int price, int pages)
        {
            Storage.StoreBookProduct(name, price, pages);
        }

        public string ListProducts()
        {
            string s = string.Empty;
            foreach (var product in Storage.GetAllProducts())
            {
                s += product.ToString();
            }
            return s;
        }

        public int GetTotalProductPrice()
        {
            return Storage.GetAllProducts().Sum(x => x.Price);
        }
    }
}