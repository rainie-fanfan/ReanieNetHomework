using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Order
{
    public class OrderDetails
    {
        public Product Product { get; set; }
        public int Num { get; set; }

        public OrderDetails(Product product, int num)
        {
            this.Product = product;
            this.Num = num;
        }

        public OrderDetails() { }

        public override string ToString()
        {
            return Product + $"  数量：{Num}";
        }

        public override bool Equals(object obj)
        {
            OrderDetails orderDetails = obj as OrderDetails;
            if (orderDetails == null) return false;
            if (orderDetails.Product == null && this.Product == null) return true;
            if (orderDetails.Product != null && this.Product != null)
            {
                return (orderDetails.Product.Equals(this.Product)) && (orderDetails.Num == this.Num);
            }
            return false;
        }

        public override int GetHashCode()
        {
            return this.ToString().GetHashCode();
        }
    }
}
