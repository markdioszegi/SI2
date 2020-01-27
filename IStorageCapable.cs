using System.Collections.Generic;

namespace InventoryProject
{
    public interface IStorageCapable
    {
        List<Product> GetAllProduct();
        void StoreCDProduct(string name, int price, int tracks);
        void StoreBookProduct(string name, int price, int pages);
    }
}