using SalesTaxCalculator;
using System;
using System.Collections.Generic;

namespace SalesTaxApp
{
    class Program
    {
        static void Main(string[] args)
        {
            var receipt = new Receipt();
            var preItemsList = new List<Item>();

            Console.WriteLine("Welcome to the Sales Tax Calculator!");

            bool addingItems = true;

            while (addingItems)
            {
                Console.WriteLine("\nEnter item details (or type 'done' to finish):");

                Console.Write("Enter item name: ");
                string name = Console.ReadLine();
                if (name.ToLower() == "done")
                {
                    addingItems = false;
                    Console.WriteLine("\n");
                    break;
                }

                decimal price;
                while (true)
                {
                    Console.Write("Enter item price: ");
                    if (!decimal.TryParse(Console.ReadLine(), out price) || price < 0)
                    {
                        Console.WriteLine("Invalid price. Please enter a valid non-negative number.");
                    }
                    else
                    {
                        break;
                    }
                }

                int quantity;
                while (true)
                {
                    Console.Write("Enter item quantity: ");
                    if (!int.TryParse(Console.ReadLine(), out quantity) || quantity < 0)
                    {
                        Console.WriteLine("Invalid quantity. Please enter a valid non-negative number.");
                    }
                    else
                    {
                        break;
                    }
                }

                bool isImported = GetYesOrNoInput("Is the item imported? (y/n): ");
                bool isExempt = GetYesOrNoInput("Is the item tax-exempt? (y/n): ");

                var item = new Item(name, price, quantity, isImported, isExempt);
                preItemsList.Add(item);
                Console.WriteLine($"{name} has been added.");
            }

            Console.WriteLine("*********** RECEIPT ***********");
            foreach (var item in preItemsList)
            {
                receipt.AddItem(item);
            }
            receipt.PrintReceipt();
            Console.WriteLine("*******************************");
        }

        static bool GetYesOrNoInput(string message)
        {
            while (true)
            {
                Console.Write(message);
                string input = Console.ReadLine().ToLower();
                if (input == "y") return true;
                if (input == "n") return false;
                Console.WriteLine("Invalid input. Please enter 'y' or 'n'.");
            }
        }
    }
}
