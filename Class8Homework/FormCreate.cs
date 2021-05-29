using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Order;

namespace HomeWork8
{
    public partial class FormCreate : Form
    {
        public Order.Order Order { get; set; }
        public int Num { get; set; }
        public float Price { get; set; }
        public string ProName { get; set; }

        private Product product = new Product();
        private OrderDetails orderDetail = new OrderDetails();

        public FormCreate()
        {
            InitializeComponent();
            Order = new Order.Order();
        }

        private void btnOK_Click(object sender, EventArgs e)
        {
            if (Order.Address == "" || Order.Address == null)
            {
                MessageBox.Show("请输入订单地址！");
                return;
            }
            if (Order.OrderDetails.Count == 0)
            {
                MessageBox.Show("请添加订单明细！");
                return;
            }
            this.DialogResult = DialogResult.OK;
            this.Close();
        }

        private void FormCreate_Load(object sender, EventArgs e)
        {
            textAddress.DataBindings.Add("Text", Order, "Address");
            textNum.DataBindings.Add("Text", this, "Num");
            textProduct.DataBindings.Add("Text", this, "ProName");
            textPrice.DataBindings.Add("Text", this, "Price");

            bindingSourceDetail.DataSource = Order.OrderDetails;
        }

        private void btnCreate_Click(object sender, EventArgs e)
        {
            product = new Product() { Name = ProName, Price = Price};
            orderDetail = new OrderDetails(product, Num);
            Order.OrderDetails.Add(orderDetail);
            bindingSourceDetail.ResetBindings(false);
            ProName = "";
            Num = 0;
            Price = 0f;
        }
    }
}
