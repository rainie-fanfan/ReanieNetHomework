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
    public partial class Form1 : Form
    {
        public string CusName { get; set; }
        public int OrderID { get; set; }

        private OrderService orderService = new OrderService();
        public Form1()
        {
            InitializeComponent();

            Form formSignIn = new FormSignIn(this);
            formSignIn.ShowDialog();

            labCusName.DataBindings.Add("Text", this, "CusName");
            textOrderID.DataBindings.Add("Text", this, "OrderID");
            orderBindingSource.DataSource = orderService;
            orderBindingSource.DataMember = "Orders";            
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            this.Hide();
        }

        private void btnCreate_Click(object sender, EventArgs e)
        {
            FormCreate formCreate = new FormCreate();
            formCreate.ShowDialog();
            formCreate.Order.Customer = new Customer(CusName);
            orderService.AddOrder(formCreate.Order);
        }

        private void butOrder_Click(object sender, EventArgs e)
        {
            dataGridView.Visible = !dataGridView.Visible;
        }

        private void deleteToolStripMenuItem_Click(object sender, EventArgs e)
        {
            orderService.DeleteOrder((Order.Order)this.dataGridView.SelectedRows[0].DataBoundItem);
        }

        private void btnExport_Click(object sender, EventArgs e)
        {
            orderService.Export("Orders.xml");
        }

        private void btnImport_Click(object sender, EventArgs e)
        {
            orderService.Import("Orders.xml");
        }

        private void btnFind_Click(object sender, EventArgs e)
        {
            orderBindingSource.DataSource = orderService.FindOrder(OrderID);
        }
    }
}
