namespace InventoryProject
{
    public abstract class Product
    {
        protected string _name;
        protected int _price;

        public string Name { get { return _name; } set { _name = value; } }
        public int Price { get { return _price; } set { _price = value; } }

        public override string ToString()
        {
            return $"{Name}: {Price}";
        }
    }
}