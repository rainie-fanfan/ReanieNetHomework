using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Order
{
    public class Product
    {
        public string Name { get; set; }
        public float Price { get; set; }

        public override string ToString()
        {
            return $"商品：{Name} 单价：{Price}";
        }

        public override bool Equals(object obj)
        {
            Product product = obj as Product;
            if (product == null) return false;
            return (product.Name == this.Name) && (product.Price == this.Price);
        }

        public override int GetHashCode()
        {
            return this.ToString().GetHashCode();
        }
    }
}
