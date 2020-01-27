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
            //storeManager.StoreBookProduct("cheese", 10, 20);
            Console.WriteLine("Hello World!");
            while (true)
            {
                System.Console.WriteLine("Main Menu");
                System.Console.WriteLine("1. Create product");
                System.Console.WriteLine("2. List products");
                System.Console.WriteLine("3. Exit");
                switch (Console.ReadLine())
                {
                    case "1":; break;
                    case "2":; break;
                    case "3": Environment.Exit(0); break;
                    default: System.Console.WriteLine("Choose a valid option!"); break;
                }
            }
        }

        void GetInputs()
        {

        }
    }
}
