namespace InventoryProject
{
    public class PersistentStoreCsv : CsvStore
    {
        public override void StoreProduct(Product product)
        {
            products.Add(product);
        }
    }
}