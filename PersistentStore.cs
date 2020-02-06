using System.Collections.Generic;

namespace InventoryProject
{
    public class PersistentStore : Store
    {
        public override void StoreProduct(Product product)
        {
            _products.Add(product);
        }
    }
}