using System;

namespace InventoryProject
{
    class Program
    {
        public static void Main(string[] args)
        {
            Program p = new Program();
            p.HandleMenu();
        }

        void HandleMenu()
        {
            StoreManager storeManager = new StoreManager();
            IStorageCapable store = new PersistentStore();
            storeManager.AddStorage((IStorageCapable)store);
            storeManager.AddBookProduct("Harry Pjotter and the prisoner of Moscow", 1250, 320);
            storeManager.AddBookProduct("Slavic dishes", 3500, 3);
            storeManager.AddCDProduct("Zámbó Jimmy selection", 790, 12);
            storeManager.AddCDProduct("DJ Tőtöttcigi discography", 1590, 8);
            while (true)
            {
                System.Console.WriteLine("Main Menu");
                System.Console.WriteLine("1. Create product");
                System.Console.WriteLine("2. List products");
                System.Console.WriteLine("3. Get the total price of the products");
                System.Console.WriteLine("0. Exit");
                //System.Console.WriteLine(store.GetAllProducts().Count);
                switch (Console.ReadLine())
                {
                    case "0": Environment.Exit(0); break;
                    case "1": GetInputs(storeManager); break;
                    case "2":
                        System.Console.WriteLine(storeManager.ListProducts());
                        break;
                    case "3": System.Console.WriteLine($"Total product price: {storeManager.GetTotalProductPrice()}"); ; break;
                    default: System.Console.WriteLine("Choose a valid option!"); break;
                }
            }
        }

        void GetInputs(StoreManager storeManager)
        {
            try
            {
                System.Console.WriteLine("Choose a type (Book, CD)");
                string type = Console.ReadLine().Trim();
                string[] parameters = new string[3];
                for (int i = 0; i < parameters.Length; i++)
                {
                    System.Console.Write($"Param {i + 1}: ");
                    parameters[i] = Console.ReadLine();
                }
                if (type.ToLower() == "book")
                {
                    storeManager.AddBookProduct(parameters[0], Convert.ToInt32(parameters[1]), Convert.ToInt32(parameters[2]));
                }
                else
                {
                    storeManager.AddCDProduct(parameters[0], Convert.ToInt32(parameters[1]), Convert.ToInt32(parameters[2]));
                }
            }
            catch (FormatException)
            {
                System.Console.WriteLine("ERROR: Invalid type!");
            }
        }
    }
}
