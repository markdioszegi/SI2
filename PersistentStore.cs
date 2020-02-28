namespace InventoryProject
{
    /// <summary>
    /// Stores to an XML File
    /// </summary>
    public class PersistentStore : Store
    {
        public override void StoreProduct(Product product)
        {
            products.Add(product);
        }
    }
}