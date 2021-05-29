using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Order
{
    public class Order : IComparable
    {
        public List<OrderDetails> OrderDetails { get; set; }
        public int OrderID { get => Customer.GetHashCode() + OrderDate.GetHashCode(); }
        public Customer Customer { get; set; }
        public DateTime OrderDate { get; set; }
        public float TotalPrice 
        {
            get
            {
                float totalPrice = 0f;
                foreach(OrderDetails orderDetails in OrderDetails)
                {
                    totalPrice += orderDetails.Product.Price * orderDetails.Num;
                }
                return totalPrice;
            }
        }
        public string Address { get; set; }

        public Order()
        {
            this.OrderDetails = new List<OrderDetails>();
            this.OrderDate = DateTime.Now;
        }

        // 判断该明细是否含有某产品
        public bool ContainProduct(Product product)
        {
            var orderDetailNeed = OrderDetails.Where(orderDetail => orderDetail.Product.Equals(product));
            if (orderDetailNeed.Count() != 0) return true;
            return false;
        }

        public override string ToString()
        {
            StringBuilder stringBuilder = new StringBuilder($"订单{OrderID}：\n" + Customer + $"\n下单时间：{OrderDate}\n总金额：{TotalPrice}\n配送地址：{Address}\n");
            foreach(OrderDetails orderDetails in OrderDetails)
            {
                stringBuilder.Append(orderDetails + "\n");
            }
            return stringBuilder.ToString();
        }

        public override bool Equals(object obj)
        {
            Order order = obj as Order;
            if (order == null) return false;
            return order.OrderID == this.OrderID;
        }

        public override int GetHashCode()
        {
            return this.ToString().GetHashCode();
        }

        public int CompareTo(object obj)
        {
            Order order = obj as Order;
            return this.OrderID.CompareTo(order.OrderID);
        }
    }
}
