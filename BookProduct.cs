namespace InventoryProject
{
    public class BookProduct : Product
    {
        int NumOfPages;
        public BookProduct(string name, int price, int numOfPages) : base(name, price)
        {
            Name = name;
            Price = price;
            NumOfPages = numOfPages;
        }
    }
}