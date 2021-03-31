using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PrimeFactor
{
    class Program
    {
        static void Main(string[] args)
        {
            try
            {
                Console.WriteLine("请输入一个正整数：");
                int n = int.Parse(Console.ReadLine());
                Console.WriteLine($"正整数{n}的素数因子为：");
                //Console.Write("1 ");
                GetPrimeFactor(n);
            }
            catch(Exception ex)
            {
                Console.WriteLine($"Exception: {ex.Message}");
            }
        }

        static void GetPrimeFactor(int n)
        {
            bool flag = true;
            for (int i = 2; i * i <= n; i++)
            {
                if (n % i == 0)
                {
                    Console.Write($"{i} ");
                    GetPrimeFactor(n / i);
                    flag = false;
                    break;
                }
            }
            if (flag)
                Console.WriteLine(n);
        }
    }
}
