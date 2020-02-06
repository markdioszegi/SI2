namespace InventoryProject
{
    public class BookProduct : Product
    {
        int _numOfPages;
        public int NumOfPages { get { return _numOfPages; } set { _numOfPages = value; } }
        public BookProduct() { }
        public BookProduct(string name, int price, int numOfPages)
        {
            _name = name;
            _price = price;
            NumOfPages = numOfPages;
        }
        public override string ToString()
        {
            return $"Name: {Name}, Price: {Price}, Number of pages: {NumOfPages}.\n";
        }
    }
}