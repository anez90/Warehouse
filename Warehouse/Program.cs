using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Warehouse
{
    class Program
    {

        static void Main(string[] args)
        {
            Stock stock = new Stock();

            bool loop = true;
            while (loop)
            {
                MainMenu();
                int choice = int.Parse(Console.ReadLine());
                switch (choice)
                {
                    case 1:
                        CreateProduct();
                        int choiceProduct = int.Parse(Console.ReadLine());
                        switch (choiceProduct)
                        {
                            case 1:
                                CreateJuice(stock);
                                break;
                            case 2:
                                CreatePlate(stock);
                                break;
                        }
                        break;
                    case 2:
                        Console.WriteLine("Enter ID:");
                        int id = int.Parse(Console.ReadLine());
                        Console.WriteLine("Enter new quantity:");
                        int newStock = int.Parse(Console.ReadLine());
                        StockItem stockItem = stock.GetItem(id);
                        stockItem.StockCount = newStock;

                        break;
                    case 3:
                        for (int i = 0; i < stock.StockItemsLength; i++)
                        {
                            if(stock[i] is EcoStockItem)
                            Console.WriteLine($"{stock[i]} ECO");
                            else
                                Console.WriteLine(stock[i]);
                        }
                        break;
                    case 4:
                        loop = false;
                        break;
                    default:
                        Console.WriteLine("Wrong value");
                        break;
                }
            }
            Console.ReadLine();
        }

        public static void MainMenu()
        {
            Console.WriteLine("***   MENU   ***");
            Console.WriteLine("[1] Create product");
            Console.WriteLine("[2] Inventory product");
            Console.WriteLine("[3] List products");
            Console.WriteLine("[4] Exit");
        }
        private static void CreateProduct()
        {
            Console.WriteLine("What kind of product do you want to create?");
            Console.WriteLine("[1] Juice");
            Console.WriteLine("[2] Plate");
            Console.WriteLine("[3] Go back");
        }
        private static void CreatePlate(Stock stock)
        {
            Console.WriteLine("Enter ID:");
            int plateId = int.Parse(Console.ReadLine());
            Console.WriteLine("Enter name:");
            string plateName = Console.ReadLine();
           Console.WriteLine("Enter type (flat/deep):");
            string plateType = Console.ReadLine();
            Console.WriteLine("How many products do you want to create?");
            int plateStock = int.Parse(Console.ReadLine());
            Plate plate = new Plate(plateId, plateName, plateStock, plateType);
            stock.AddItem(plate);
        }
        private static void CreateJuice(Stock stock)
        {
            Console.WriteLine("Enter ID:");
            int juiceId = int.Parse(Console.ReadLine());
            Console.WriteLine("Enter name:");
            string juiceName = Console.ReadLine();
            Console.WriteLine("Enter mark (Krav/EG):");
            string juiceMark = Console.ReadLine();
            Console.WriteLine("Enter type (apple/orange):");
            string juiceType = Console.ReadLine();
            Console.WriteLine("How many products do you want to create?");
            int juiceStock = int.Parse(Console.ReadLine());

            Juice juice = new Juice(juiceId, juiceName, juiceStock, juiceMark, juiceType);
            stock.AddItem(juice);

        }

    }
}


