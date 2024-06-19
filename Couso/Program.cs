using Couso.Entities;
using Couso.Entities.Enums;
using System.Globalization;

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
            DateTime moment = DateTime.Now;
            Console.Write("Status: ");
            OrderStatus status = Enum.Parse<OrderStatus>(Console.ReadLine());
            Console.Write("How many items order? ");
            int quantItems = int.Parse(Console.ReadLine());
            Order order = new Order(moment, status, client);

            for (int i = 1; i <= quantItems; i++)
            {
                Console.WriteLine($"Enter #{i} item data:");
                Console.Write("Product name: ");
                string nameProduct = Console.ReadLine();
                Console.Write("Product price: ");
                double price = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
                Console.Write("quantity: ");
                int quantity = int.Parse(Console.ReadLine());
                Product product = new Product(nameProduct, price);
                OrderItem item = new OrderItem(quantity, price, product);
                order.AddItem(item);

            }
            Console.WriteLine(order);


        }
    }
}