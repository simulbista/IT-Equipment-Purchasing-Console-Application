using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ITE_5231_FinalProject
{
    internal class MyProgram
    {
        public static void Main(String[] args)
        {
            string userName1, userName2;
            int userInput1, userInput2;

            //using HashTable data structure to store customer and purchase information
            Hashtable customerInfo = new Hashtable();

            Console.ForegroundColor = ConsoleColor.Magenta;
            Console.WriteLine("Individual Purchases!");
            //customer1
            Console.ResetColor();

            Console.ForegroundColor = ConsoleColor.Cyan;
            Console.WriteLine("What is your name?");
            Console.ResetColor();
            userName1 = Console.ReadLine();

            //using Dictionary data structure
            Dictionary<int, string> inventory = new Dictionary<int, string>();
            inventory.Add(1, "office");
            inventory.Add(2, "gaming");

            Console.ForegroundColor = ConsoleColor.Cyan;
            Console.WriteLine("What would you like to purchase? Type 1 for Office or 2 for Gaming");
            Console.ResetColor();
            userInput1 = Convert.ToInt32(Console.ReadLine());
            ApplicationFacade MyApp = new ApplicationFacade();
            MyApp.GetBundle(inventory[userInput1]);

            customerInfo.Add(userName1, inventory[userInput1]);

            //end of customer1


            //customer2

            Console.ForegroundColor = ConsoleColor.Cyan;
            Console.WriteLine("What is your name?");
            Console.ResetColor();
            userName2 = Console.ReadLine();

            Console.ForegroundColor = ConsoleColor.Cyan;
            Console.WriteLine("What would you like to purchase? Type 1 for Office or 2 for Gaming");
            Console.ResetColor();
            userInput2 = Convert.ToInt32(Console.ReadLine());
            MyApp.GetBundle(inventory[userInput2]);

            customerInfo.Add(userName2, inventory[userInput2]);

            //end of customer2


            Console.ForegroundColor = ConsoleColor.Magenta;
            Console.WriteLine("Displaying info about individual purchases");
            Console.ResetColor();

            Console.ForegroundColor = ConsoleColor.Yellow;
            foreach (string key in customerInfo.Keys)
            {
                Console.WriteLine("{0} purchased - {1} product.", key, customerInfo[key]);
            }
            Console.ResetColor();

            Console.ForegroundColor = ConsoleColor.Magenta;
            Console.WriteLine("Individual purchasing successful!");
            Console.WriteLine();
            Console.ResetColor();

            Console.ForegroundColor = ConsoleColor.Cyan;
            Console.WriteLine("Please press enter to start mass purchasing...");
            Console.ReadLine();
            Console.ResetColor();


            //using List data structures
            Console.ForegroundColor = ConsoleColor.Magenta;
            Console.WriteLine("Mass purchasing gaming and office products");
            List<string> massPurchase = new List<string>();
            Console.ResetColor();

            //Using Queue data structure to store the types of bundle for mass purchase
            Queue<string> typesQueue = new Queue<string>();

            typesQueue.Enqueue("gaming");
            typesQueue.Enqueue("office");
            typesQueue.Enqueue("office");
            typesQueue.Enqueue("gaming");


            foreach (string type in typesQueue)
            {
                massPurchase.Add(type);
            }


            //getting bundle details about mass purchasing
            foreach (string purchase in massPurchase)
            {
                MyApp.GetBundle(purchase);
            }
            Console.ForegroundColor = ConsoleColor.Magenta;
            Console.WriteLine("Mass purchasing successful!");
            Console.ResetColor();
            Console.WriteLine();
        }
    }
}
