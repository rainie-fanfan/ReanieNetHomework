using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Order;

namespace HomeWork8
{
    public partial class FormMain : Form
    {
        public string CusName { get; set; }
        public int OrderID { get; set; }

        private OrderService orderService = new OrderService();
        private Customer customer = new Customer();
        public FormMain()
        {
            InitializeComponent();

            Form formSignIn = new FormSignIn(this);
            formSignIn.ShowDialog();

            customer.Name = CusName;

            labCusName.DataBindings.Add("Text", this, "CusName");
            textOrderID.DataBindings.Add("Text", this, "OrderID");
            orderBindingSource.DataSource = orderService.Orders;
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            this.Hide();
        }

        private void btnCreate_Click(object sender, EventArgs e)
        {
            FormCreate formCreate = new FormCreate();
            if (formCreate.ShowDialog() == DialogResult.OK)
            {
                formCreate.Order.Customer = new Customer(CusName);
                orderService.AddOrder(formCreate.Order);

                RefreshAllData();
            }
        }

        private void deleteToolStripMenuItem_Click(object sender, EventArgs e)
        {
            orderService.DeleteOrder((Order.Order)orderBindingSource.Current);
            RefreshAllData();
        }

        private void btnExport_Click(object sender, EventArgs e)
        {
            SaveFileDialog saveFileDialog = new SaveFileDialog();
            saveFileDialog.Filter = "XML文件(*.xml)|*.xml";
            saveFileDialog.Title = "导出订单至";
            saveFileDialog.AddExtension = true;
            if (saveFileDialog.ShowDialog() == DialogResult.OK)
            {
                orderService.Export(((IEnumerable<Order.Order>)orderBindingSource.DataSource).ToList(), saveFileDialog.FileName);
            }
        }

        private void btnImport_Click(object sender, EventArgs e)
        {
            try
            {
                OpenFileDialog openFileDialog = new OpenFileDialog();
                openFileDialog.Filter = "XML文件(*.xml)|*.xml";
                openFileDialog.Title = "导入订单";
                if (openFileDialog.ShowDialog() == DialogResult.OK)
                {
                    orderService.Import(openFileDialog.FileName);
                    RefreshAllData();
                }
            }
            catch (FileNotFoundException)
            {
                MessageBox.Show("找不到该文件！");
            }
        }

        private void btnFind_Click(object sender, EventArgs e)
        {
            orderBindingSource.DataSource = orderService.FindOrder(OrderID);
            orderBindingSource.ResetBindings(false);
        }

        private void btnOrder_Click(object sender, EventArgs e)
        {
            orderBindingSource.DataSource = orderService.FindOrder(customer);
            orderBindingSource.ResetBindings(false);
        }

        private void RefreshAllData()
        {
            orderBindingSource.DataSource = orderService.FindOrder(customer);
            orderBindingSource.ResetBindings(false);
        }

    }
}
