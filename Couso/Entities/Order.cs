using Couso.Entities.Enums;
using System.Globalization;
using System.Text;

namespace Couso.Entities
{
    internal class Order
    {
        public DateTime Moment { get; set; }
        public OrderStatus Status { get; set; }
        public Client Client { get; set; }
        public List<OrderItem> Items { get; set; } = new List<OrderItem>();

        public Order() { }

        public Order(DateTime moment, OrderStatus status, Client client)
        {
            Moment = moment;
            Status = status;
            Client = client;
        }

        public void AddItem (OrderItem item)
        {
            Items.Add(item);
        }
        public void RemoveItem (OrderItem item) 
        {  
            Items.Remove(item); 
        }

        public double Total()
        {
            double total = 0;
            foreach (OrderItem item in Items)
            {
                total += item.SubTotal();
            }
            return total;
        }

        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.AppendLine("ORDER SUMMARY:");
            sb.AppendLine($"Order moment: {Moment}");
            sb.AppendLine($"Order Status {Status}");
            sb.AppendLine($"Client: {Client}");
            sb.AppendLine("Order items:");
            foreach (OrderItem p in Items)
            {
                sb.AppendLine($"{p.Product.Name}, {p.Price.ToString("f2", CultureInfo.InvariantCulture)}, Quantity: {p.Quantity} Subtotal: ${p.SubTotal().ToString("f2", CultureInfo.InvariantCulture)}");                
            }
            sb.AppendLine($"Total price: ${Total().ToString("f2", CultureInfo.InvariantCulture)}");
            return sb.ToString();
        }
    }
}
//.ToString("f3", CultureInfo.InvariantCulture));