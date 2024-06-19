using Couso.Entities;
using Couso.Entities.Enums;
using System;

namespace Couso
{
    internal class Program
    {
        private static void Main(string[] args)
        {
            Console.WriteLine("Entre cliente data:");
            Console.Write("Name: ");
            string name = Console.ReadLine();
            Console.Write("Email: ");
            string email = Console.ReadLine();
            Console.Write("Birth date (DD/MM/YYYY): ");
            DateTime date = DateTime.Parse(Console.ReadLine());
            Client client = new Client(name, email , date);
            
            Console.WriteLine("Enter order data:");
            DateTime now = DateTime.Now;
            Console.Write("Status: ");
            OrderStatus status = Enum.Parse<OrderStatus>(Console.ReadLine());
            Console.Write("How many items order? ");
            int quantItems = int.Parse(Console.ReadLine());

            for (int i = 1; i <= quantItems; i++)
            {
                Console.WriteLine($"Enter #{i} item data:");
                Console.Write("Product name: ");
                string nameProduct = Console.ReadLine();
                Console.Write("Product price: ");
                double price = double.Parse(Console.ReadLine());
                Console.Write("quantity: ");
                int quantity = int.Parse(Console.ReadLine());


            }


        }
    }
}