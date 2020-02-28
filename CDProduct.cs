namespace InventoryProject
{
    public class CDProduct : Product
    {
        private int _numOfTracks;
        public int NumOfTracks { get { return _numOfTracks; } set { _numOfTracks = value; } }

        public CDProduct() { }

        public CDProduct(string name, int price, int size)
        {
            _name = name;
            _price = price;
            _numOfTracks = size;
        }

        public override string ToString()
        {
            return $"Name: {Name} | Price: {Price} | Number of tracks: {NumOfTracks}.";
        }
    }
}