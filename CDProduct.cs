namespace InventoryProject
{
    public class CDProduct : Product
    {
        int NumOfTracks;
        public CDProduct(string name, int price, int numOfTracks) : base(name, price)
        {
            Name = name;
            Price = price;
            NumOfTracks = numOfTracks;
        }
    }
}