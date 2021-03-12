using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Class1Homework2
{
    public partial class Form1 : Form
    {
        //记录上次点击的按键类型，0表示什么都没按，1表示数字，2表示运算符
        private int preButtonType = 0;
        //记录上次点击的按键是什么运算符
        private string preOperator = "+";
        //记录计算的中间结果
        private decimal tmp = 0; 


        public Form1()
        {
            InitializeComponent();
        }

        //按键6
        private void button11_Click(object sender, EventArgs e)
        {
            //将事件源转换为按钮
            Button btn = sender as Button;

            //当文本框内容为0或者当上次按键为运算符时
            if (preButtonType == 2 || textBox2.Text == "0")
            {
                textBox2.Text = btn.Text;//在下层显示所选择数字
                textBox1.Text += btn.Text;//进行显示拼接
            }
            else//其他情况：文本框内容不为0且上次按键不是运算符（需要被替换时）
            {
                textBox2.Text += btn.Text;
                textBox1.Text += btn.Text;//进行显示拼接
            }

            //修改参数
            preButtonType = 1;
        }

        //按键8
        private void button14_Click(object sender, EventArgs e)
        {
            //将事件源转换为按钮
            Button btn = sender as Button;

            //当文本框内容为0或者当上次按键为运算符时
            if (preButtonType == 2 || textBox2.Text == "0")
            {
                textBox2.Text = btn.Text;//在下层显示所选择数字
                textBox1.Text += btn.Text;//进行显示拼接
            }
            else//其他情况：文本框内容不为0且上次按键不是运算符（需要被替换时）
            {
                textBox2.Text += btn.Text;
                textBox1.Text += btn.Text;//进行显示拼接
            }

            //修改参数
            preButtonType = 1;
        }

        private void button16_Click(object sender, EventArgs e)
        {

        }

        private void button19_Click(object sender, EventArgs e)
        {

        }

        //当用户点击*键
        private void button8_Click(object sender, EventArgs e)
        {
            //事件源转换为按钮
            Button btn = sender as Button;

            if (preButtonType == 0)//当上次什么都没有按时，此时直接输入一个运算符，不符合运算规则
            {
                textBox2.Text = "不符合运算规则！";
            }
            else if (preButtonType == 1)//当上次按数字键时
            {
                
                textBox1.Text += "*";//进行显示拼接
                tmp = tmp + Convert.ToDecimal(textBox2.Text);//保证textBox2是第一个乘数
                textBox2.Text = tmp.ToString(); //在textBox2中进行显示
            }
            else//当上次按运算符键时，此时也不符合运算规则
            {
                textBox2.Text = "不符合运算规则！";
            }

            //进行参数修改
            preButtonType = 2;
            preOperator = "*";
        }

        //当用户点击CE时，将所有的参数初始化
        private void button1_Click(object sender, EventArgs e)
        {
            textBox1.Text = "";
            textBox2.Text = "";
            preButtonType = 0;
            preOperator = "+";
            tmp = 0;
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            textBox1.Text = "";
            textBox2.Text = "";
        }

        //当用户点击/键
        private void button2_Click(object sender, EventArgs e)
        {
            //事件源转换为按钮
            Button btn = sender as Button;

            if(preButtonType == 0)//当上次什么都没有按时，此时直接输入一个运算符，不符合运算规则
            {
                textBox2.Text = "不符合运算规则！";
            }
            else if(preButtonType == 1)//当上次按数字键时
            {
                textBox1.Text += "/";//进行显示拼接
                tmp = tmp + Convert.ToDecimal(textBox2.Text);//保证textBox2是被除数
                textBox2.Text = tmp.ToString(); //在textBox2中进行显示
            }
            else//当上次按运算符键时，此时也不符合运算规则
            {
                textBox2.Text = "不符合运算规则！";
            }

            //进行参数修改
            preButtonType = 2;
            preOperator = "/";
        }

        //当用户点击-键
        private void button3_Click(object sender, EventArgs e)
        {
            //事件源转换为按钮
            Button btn = sender as Button;

            if (preButtonType == 0)//当上次什么都没有按时，此时直接输入一个运算符，不符合运算规则
            {
                textBox2.Text = "不符合运算规则！";
            }
            else if (preButtonType == 1)//当上次按数字键时
            {
                textBox1.Text += "-";//进行显示拼接
                tmp = tmp + Convert.ToDecimal(textBox2.Text);//保证textBox2是被减数
                textBox2.Text = tmp.ToString(); //在textBox2中进行显示
            }
            else//当上次按运算符键时，此时也不符合运算规则
            {
                textBox2.Text = "不符合运算规则！";
            }

            //进行参数修改
            preButtonType = 2;
            preOperator = "-";
        }

        //当用户点击+键
        private void button4_Click(object sender, EventArgs e)
        {
            //事件源转换为按钮
            Button btn = sender as Button;

            if (preButtonType == 0)//当上次什么都没有按时，此时直接输入一个运算符，不符合运算规则
            {
                textBox2.Text = "不符合运算规则！";
            }
            else if (preButtonType == 1)//当上次按数字键时
            {
                textBox1.Text += "+";//进行显示拼接
                tmp = tmp + Convert.ToDecimal(textBox2.Text);//保证textBox2是第一个加数
                textBox2.Text = tmp.ToString(); //在textBox2中进行显示
            }
            else//当上次按运算符键时，此时也不符合运算规则
            {
                textBox2.Text = "不符合运算规则！";
            }

            //进行参数修改
            preButtonType = 2;
            preOperator = "+";
        }

        //当用户点击=键
        private void button12_Click(object sender, EventArgs e)
        {
            //上次按了数字
            if (preButtonType == 1)
            {
                textBox1.Text += "=";//进行显示拼接  
                //事件源转换为按钮
                Button btn = sender as Button;
                switch (preOperator)
                {
                    case "+":
                        try
                        {
                            tmp = tmp + Convert.ToDecimal(textBox2.Text); //计算上次运行的结果
                        }
                        catch (Exception)
                        {
                            tmp = 0;
                        }
                        break;
                    case "-":
                        tmp = tmp - Convert.ToDecimal(textBox2.Text); //计算上次运行的结果
                        break;
                    case "*":
                        tmp = tmp * Convert.ToDecimal(textBox2.Text); //计算上次运行的结果
                        break;
                    case "/":
                        tmp = tmp / Convert.ToDecimal(textBox2.Text); //计算上次运行的结果
                        break;
                    default:
                        textBox2.Text = "未检测到运算式";
                        break;
                }
                textBox2.Text = tmp.ToString();
                preOperator = "";
                preButtonType = 2;
            }
            if (textBox2.Text == "0.")
            {
                textBox2.Text = "";
                preOperator = "";
                preButtonType = 2;
            }
        }

        //按键1
        private void button5_Click(object sender, EventArgs e)
        {
            //将事件源转换为按钮
            Button btn = sender as Button;

            //当文本框内容为0或者当上次按键为运算符时
            if (preButtonType == 2 || textBox2.Text == "0")
            {
                textBox2.Text = btn.Text;//在下层显示所选择数字
                textBox1.Text += btn.Text;//进行显示拼接
            }
            else//其他情况：文本框内容不为0且上次按键不是运算符（需要被替换时）
            {
                textBox2.Text += btn.Text;
                textBox1.Text += btn.Text;//进行显示拼接
            }

            //修改参数
            preButtonType = 1;
        }

        //按键2
        private void button6_Click(object sender, EventArgs e)
        {
            //将事件源转换为按钮
            Button btn = sender as Button;

            //当文本框内容为0或者当上次按键为运算符时
            if (preButtonType == 2 || textBox2.Text == "0")
            {
                textBox2.Text = btn.Text;//在下层显示所选择数字
                textBox1.Text += btn.Text;//进行显示拼接
            }
            else//其他情况：文本框内容不为0且上次按键不是运算符（需要被替换时）
            {
                textBox2.Text += btn.Text;
                textBox1.Text += btn.Text;//进行显示拼接
            }

            //修改参数
            preButtonType = 1;
        }

        //按键3
        private void button7_Click(object sender, EventArgs e)
        {
            //将事件源转换为按钮
            Button btn = sender as Button;

            //当文本框内容为0或者当上次按键为运算符时
            if (preButtonType == 2 || textBox2.Text == "0")
            {
                textBox2.Text = btn.Text;//在下层显示所选择数字
                textBox1.Text += btn.Text;//进行显示拼接
            }
            else//其他情况：文本框内容不为0且上次按键不是运算符（需要被替换时）
            {
                textBox2.Text += btn.Text;
                textBox1.Text += btn.Text;//进行显示拼接
            }

            //修改参数
            preButtonType = 1;
        }

        //按键4
        private void button9_Click(object sender, EventArgs e)
        {
            //将事件源转换为按钮
            Button btn = sender as Button;

            //当文本框内容为0或者当上次按键为运算符时
            if (preButtonType == 2 || textBox2.Text == "0")
            {
                textBox2.Text = btn.Text;//在下层显示所选择数字
                textBox1.Text += btn.Text;//进行显示拼接
            }
            else//其他情况：文本框内容不为0且上次按键不是运算符（需要被替换时）
            {
                textBox2.Text += btn.Text;
                textBox1.Text += btn.Text;//进行显示拼接
            }

            //修改参数
            preButtonType = 1;
        }

        //按键5
        private void button10_Click(object sender, EventArgs e)
        {
            //将事件源转换为按钮
            Button btn = sender as Button;

            //当文本框内容为0或者当上次按键为运算符时
            if (preButtonType == 2 || textBox2.Text == "0")
            {
                textBox2.Text = btn.Text;//在下层显示所选择数字
                textBox1.Text += btn.Text;//进行显示拼接
            }
            else//其他情况：文本框内容不为0且上次按键不是运算符（需要被替换时）
            {
                textBox2.Text += btn.Text;
                textBox1.Text += btn.Text;//进行显示拼接
            }

            //修改参数
            preButtonType = 1;
        }

        //按键7
        private void button13_Click(object sender, EventArgs e)
        {
            //将事件源转换为按钮
            Button btn = sender as Button;

            //当文本框内容为0或者当上次按键为运算符时
            if (preButtonType == 2 || textBox2.Text == "0")
            {
                textBox2.Text = btn.Text;//在下层显示所选择数字
                textBox1.Text += btn.Text;//进行显示拼接
            }
            else//其他情况：文本框内容不为0且上次按键不是运算符（需要被替换时）
            {
                textBox2.Text += btn.Text;
                textBox1.Text += btn.Text;//进行显示拼接
            }

            //修改参数
            preButtonType = 1;
        }

        //按键9
        private void button15_Click(object sender, EventArgs e)
        {
            //将事件源转换为按钮
            Button btn = sender as Button;

            //当文本框内容为0或者当上次按键为运算符时
            if (preButtonType == 2 || textBox2.Text == "0")
            {
                textBox2.Text = btn.Text;//在下层显示所选择数字
                textBox1.Text += btn.Text;//进行显示拼接
            }
            else//其他情况：文本框内容不为0且上次按键不是运算符（需要被替换时）
            {
                textBox2.Text += btn.Text;
                textBox1.Text += btn.Text;//进行显示拼接
            }

            //修改参数
            preButtonType = 1;
        }

        //按键0
        private void button17_Click(object sender, EventArgs e)
        {
            //将事件源转换为按钮
            Button btn = sender as Button;

            //当文本框内容为0或者当上次按键为运算符时
            if (preButtonType == 2 || textBox2.Text == "0")
            {
                textBox2.Text = btn.Text;//在下层显示所选择数字
                textBox1.Text += btn.Text;//进行显示拼接
            }
            else//其他情况：文本框内容不为0且上次按键不是运算符（需要被替换时）
            {
                textBox2.Text += btn.Text;
                textBox1.Text += btn.Text;//进行显示拼接
            }

            //修改参数
            preButtonType = 1;
        }


        //按键.
        private void button18_Click(object sender, EventArgs e)
        {
            if(preButtonType == 0 || preButtonType == 2)//上次按键为运算符或者什么都没有（用户想通过输入.直接表示“0.”）
            {
                textBox2.Text = "0.";
                textBox1.Text += "0.";//进行显示拼接
            }
            else if (textBox2.Text == "0.")//已经输入“0.”
            {
                textBox2.Text = "0.";
            }
            else if (preButtonType == 3)//已经输入.
            {
                textBox2.Text = textBox2.Text;
                textBox1.Text = textBox1.Text;//进行显示拼接
            }
            else
            {
                textBox2.Text += ".";
                textBox1.Text += ".";//进行显示拼接
            }

            //修改参数
            preButtonType = 3;
        }
    }
}
