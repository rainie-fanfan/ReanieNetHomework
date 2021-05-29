using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Homework10
{
    public partial class FormCrawler : Form
    {
        public string StartUrl { get; set; }

        private SimpleCrawler simpleCrawler = new SimpleCrawler();

        public FormCrawler()
        {
            InitializeComponent();
            simpleCrawler.statusChange += RefreshStatus;
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            textWebsite.DataBindings.Add("Text", this, "StartUrl");
            bindingSourceUrl.DataSource = simpleCrawler.Urls;
        }

        private void btnStart_Click(object sender, EventArgs e)
        {
            if (StartUrl == null || StartUrl == "")
            {
                if (MessageBox.Show("请输入爬取的网站") == DialogResult.OK) return;
            }
            if (!IsValid(StartUrl))
            {
                if (MessageBox.Show("网站输入不合法") == DialogResult.OK) return;
            }
            simpleCrawler.OnlyCurrent = radioCurrentYes.Checked;
            try
            {
                simpleCrawler.PrepareCrawl(textWebsite.Text);
            }
            catch (ArgumentException)
            {
                if (MessageBox.Show("该网站已爬取，请输入未爬取过的网站！") == DialogResult.OK) return;
            }
        }

        private bool IsValid(string website)
        {
            try
            {
                Uri uri = new Uri(website);
                return true;
            }
            catch (UriFormatException)
            {
                return false;
            }
        }

        // 刷新状态信息
        private void RefreshStatus(string str)
        {
            if (this.labStatus.InvokeRequired)
            {
                Action<string> action = this.ChangeStatus;
                this.Invoke(action, new object[] {str});
            }
            else
            {
                this.ChangeStatus(str);
            }

            if (this.dataGridView.InvokeRequired)
            {
                Action action = this.RefreshDgv;
                this.Invoke(action);
            }
            else
            {
                this.RefreshDgv();
            }
        }

        // 修改状态信息
        private void ChangeStatus(string str)
        {
            labStatus.Text = str;
            labStatus.Refresh();
        }

        // 刷新表单信息
        private void RefreshDgv()
        {
            bindingSourceUrl.ResetBindings(false);
        }
    }
}
