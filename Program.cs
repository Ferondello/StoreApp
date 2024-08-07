

using Course.Entities.Enums;
using StoreApp.Entities;
using System.ComponentModel;

namespace StoreApp
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter client data: ");
            Console.Write("Name: ");
            string name = Console.ReadLine();
            Console.Write("Email: ");
            string email = Console.ReadLine();
            Console.Write("Birth date (DD/MM/YYYY): ");
            DateTime birthdate = DateTime.Parse(Console.ReadLine());
            Console.Write("Status do pedido: ");
            OrderStatus status = Enum<OrderStatus>.Parse(Console.ReadLine());

            Client client = new Client(name, email, birthdate);
            Order order = new Order(DateTime.Now, status, client);

            Console.WriteLine("Enter order data: ");
            Console.Write("How many items to this order: ");
            int n = int.Parse(Console.ReadLine());


            for (int i = 1; i <= n; i++)
            {
                Console.WriteLine($"Enter #{i} item data");

                Console.Write("Product name: ");
                string prodName = Console.ReadLine();
                Console.Write("Product price: ");
                double prodPrice = double.Parse(Console.ReadLine());

                Product product = new Product(prodName, prodPrice);

                Console.Write("Quantity: ");
                int quantity = int.Parse(Console.ReadLine());

                OrderItem orderItem = new OrderItem(quantity, prodPrice, product);
                order.AddItem(orderItem);
            }
            Console.WriteLine();
            Console.WriteLine("Order sumary: ");
            Console.WriteLine(order);
        }
    }
}
