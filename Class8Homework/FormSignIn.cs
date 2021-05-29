using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace HomeWork8
{
    public partial class FormSignIn : Form
    {
        public string CusName { get; set; }

        private FormMain mainForm;

        public FormSignIn(FormMain mainForm)
        {
            InitializeComponent();
            this.mainForm = mainForm;

            mainForm.Hide();
            textCusName.DataBindings.Add("Text", this, "CusName");
        }

        private void btnSignIn_Click(object sender, EventArgs e)
        {
            if (CusName == null)
            {
                MessageBox.Show("请输入姓名！");
                return;
            }
            mainForm.CusName = CusName;
            mainForm.Show();
            this.Hide();
        }

        private void FormSignIn_FormClosed(object sender, FormClosedEventArgs e)
        {
            Application.Exit();
        }
    }
}
