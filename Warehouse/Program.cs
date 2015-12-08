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
                            stock = CreateProduct(stock);
                            break;
                        case 2:
                            //met 2
                            break;
                        case 3:
                            Console.WriteLine(stock[0]);
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

            private static Stock CreateProduct(Stock stock)
            {
                Console.WriteLine("What kind of product do you want to create?");
                Console.WriteLine("[1] Juice");
                Console.WriteLine("[2] Plate");
                Console.WriteLine("[3] Go back");
                int choiceProduct = int.Parse(Console.ReadLine());
                switch (choiceProduct)
                {
                    case 1:
                        stock = CreateJuice(stock);
                        break;
                    case 2:
                        stock = CreatePlate(stock);
                        break;
                    case 3:
                        Program.MainMenu();
                        break;
                }
                return stock;
            }

            private static Stock CreatePlate(Stock stock)
            {
                Console.WriteLine("Enter id:");
                int plateId = int.Parse(Console.ReadLine());
                Console.WriteLine("Enter name:");
                string plateName = Console.ReadLine();
                Console.WriteLine("Enter type (flat/deep):");
                string plateType = Console.ReadLine();
                Console.WriteLine("How many products do you want to create?");
                int plateAmount = int.Parse(Console.ReadLine());
                for (int i = 0; i < plateAmount; i++)
                {
                    Plate plate = new Plate(plateId, plateName, plateType);
                    stock.AddItem(plate);
                }
            return stock;
            }

            private static Stock CreateJuice(Stock stock)
            {
                Console.WriteLine("Enter id:");
                int juiceId = int.Parse(Console.ReadLine());
                Console.WriteLine("Enter name:");
                string juiceName = Console.ReadLine();
                Console.WriteLine("Enter mark (Krav/EG):");
                string juiceMark = Console.ReadLine();
                Console.WriteLine("Enter type (apple/orange):");
                string juiceType = Console.ReadLine();
                Console.WriteLine("How many products do you want to create?");
                int juiceAmount = int.Parse(Console.ReadLine());

                for (int i = 0; i < juiceAmount; i++)
                {
                    Juice juice = new Juice(juiceId, juiceName, juiceMark, juiceType);
                    //Stock newStock = new Stock();
                    stock.AddItem(juice);
                }
                return stock;




            }
        }
    
}
