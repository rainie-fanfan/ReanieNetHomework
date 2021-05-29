using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Serialization;

namespace Order
{
    public class OrderService
    {
        public List<Order> Orders { get; set; }

        public OrderService()
        {
            Orders = new List<Order>();
        }

        public void AddOrder(Order order)
        {
            if (order == null) return;
            if (FindOrder(order) == null)
            {
                Orders.Add(order);
            }
        }

        public void DeleteOrder(Order order)
        {
            if (!Orders.Remove(FindOrder(order)))
            {
                throw new Exception("该订单不存在！");
            }
        }

        // 查询列表中某订单
        public Order FindOrder(Order order)
        {
            if (order == null) return null;
            var orderNeed = Orders.Where(ord => ord.Equals(order));
            if (orderNeed.Count() == 0) return null;
            Order[] ordersNeed = orderNeed.ToArray();
            if (ordersNeed.Length > 1) throw new Exception("存在相同订单！");
            return ordersNeed[0];
        }

        // 修改订单配送地址
        public void ChangeOrderAddress(Order order, string orderAddress)
        {
            FindOrder(order).Address = orderAddress;
        }

        public void ChangeOrderCustomer(Order order, string customerName)
        {
            FindOrder(order).Customer = new Customer(customerName);
        }

        // 查询订单
        public IEnumerable<Order> FindOrder(int orderID)
        {
            return Orders.Where(order => order.OrderID == orderID);
        }

        public IEnumerable<Order> FindOrder(Product product)
        {
            return Orders.Where(order => order.ContainProduct(product));
        }

        public IEnumerable<Order> FindOrder(Customer customer)
        {
            return Orders.Where(order => order.Customer.Equals(customer));
        }

        public IEnumerable<Order> FindOrder(float totalPrice)
        {
            return Orders.Where(order => order.TotalPrice == totalPrice);
        }

        // 导出xml文件
        public void Export(string fileName)
        {
            XmlSerializer xmlSerializer = new XmlSerializer(typeof(List<Order>));
            using (FileStream fs = new FileStream(fileName + ".xml", FileMode.Create))
            {
                xmlSerializer.Serialize(fs, Orders);
            }
        }

        public void Export(List<Order> orders, string fileName)
        {
            XmlSerializer xmlSerializer = new XmlSerializer(typeof(List<Order>));
            using (FileStream fs = new FileStream(fileName + ".xml", FileMode.Create))
            {
                xmlSerializer.Serialize(fs, orders);
            }
        }

        // 导入xml文件
        public void Import(string fileName, bool isOverride = true)
        {
            XmlSerializer xmlSerializer = new XmlSerializer(typeof(List<Order>));
            List<Order> orders = new List<Order>();
            using (FileStream fs = new FileStream(fileName + ".xml", FileMode.Open))
            {
                orders = (List<Order>)xmlSerializer.Deserialize(fs);
            }

            if (isOverride)
            {
                Orders = orders;
            }
            else
            {
                for (int i = 0; i < orders.Count; i++)
                {
                    AddOrder(orders[i]);
                }
            }

        }
    }
}
