using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Order
{
    class Program
    {
        static void Main(string[] args)
        {
            try
            {
                OrderService orderService = new OrderService();

                Console.WriteLine("是否导入数据？ true / false");
                bool choice = bool.Parse(Console.ReadLine());
                if (choice)
                {
                    orderService.Import("orders");
                    Console.WriteLine("输出导入数据");
                    foreach (Order order in orderService.Orders)
                    {
                        Console.WriteLine(order);
                    }
                    return;
                }

                Product[] products = new Product[]
                {
                new Product(){ Name = "A", Price = 1f },
                new Product(){ Name = "B", Price = 2f },
                new Product(){ Name = "C", Price = 3f }
                };

                OrderDetails[] orderDetails = new OrderDetails[]
                {
                new OrderDetails(products[0], 3),
                new OrderDetails(products[1], 5),
                new OrderDetails(products[2], 4)
                };

                Order[] orders = new Order[3];

                orders[0] = new Order()
                {
                    OrderDetails =
                    {
                        orderDetails[0],
                        orderDetails[1]
                    },
                    Customer = new Customer("AAA"),
                    Address = "武汉大学"

                };

                orders[1] = new Order()
                {
                    OrderDetails =
                    {
                        orderDetails[1]
                    },
                    Customer = new Customer("BBB"),
                    Address = "武汉大学"

                };

                orderService.AddOrder(orders[0]);
                orderService.AddOrder(orders[1]);

                orderService.Orders.Sort();

                foreach (Order order in orderService.FindOrder(new Customer("AAA")))
                {
                    Console.WriteLine(order);
                }

                orderService.Orders.Sort((order1, order2) => order1.OrderDetails.Count - order2.OrderDetails.Count);

                foreach (Order order in orderService.FindOrder(new Product() { Name = "B", Price = 2f }))
                {
                    Console.WriteLine(order);
                }

                orderService.Export("orders");
            }
            catch (FileNotFoundException ex)
            {
                Console.WriteLine($"Exception: {ex.FileName} Not Found!");
            }
            catch (IOException ex)
            {
                Console.WriteLine($"Exception: {ex.Message}");
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Exception: {ex.Message}");
            }
            
        }
    }
}
