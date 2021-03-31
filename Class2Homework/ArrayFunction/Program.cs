using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ArrayFunction
{
    class Program
    {
        static void Main(string[] args)
        {
            try
            {
                Console.WriteLine("整数数组长度为：");
                int length = int.Parse(Console.ReadLine());
                int[] arr = new int[length];
                Console.WriteLine("请输入数组成员：");
                for (int i = 0; i < length; i++)
                {
                    arr[i] = int.Parse(Console.ReadLine());
                }
                int max, min, sum;
                GetMaxAndMin(arr, out max, out min);
                sum = GetSum(arr);
                Console.WriteLine($"该数组的最大值为{max}, 最小值为{min}, 和为{sum}, 平均值为{GetAver(sum, length)}");
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Exception: {ex}");
            }
        }

        static void GetMaxAndMin(int[] arr, out int max, out int min)
        {
            max = arr[0];
            min = arr[0];
            for (int i = 1; i < arr.Length; i++)
            {
                if (arr[i] > max) max = arr[i];
                if (arr[i] < min) min = arr[i];
            }
        }

        static int GetSum(int[] arr)
        {
            int sum = 0;
            for (int i = 0; i < arr.Length; i++)
            {
                sum += arr[i];
            }
            return sum;
        }

        static double GetAver(int arrSum, int length) => (double)arrSum / length;
    }
}
