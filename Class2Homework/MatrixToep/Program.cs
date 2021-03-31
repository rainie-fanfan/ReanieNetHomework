using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MatrixToep
{
    class Program
    {
        static void Main(string[] args)
        {
            try
            {
                Console.WriteLine("请输入M*N矩阵M与N：");
                int m = int.Parse(Console.ReadLine());
                int n = int.Parse(Console.ReadLine());
                int[,] matrix = new int[n,m];
                Console.WriteLine($"请输入这个{m}*{n}矩阵：");
                for (int i = 0; i < n; i++)
                {
                    string str = Console.ReadLine();
                    string[] values = str.Split(' ');
                    for (int j = 0; j < m; j++)
                    {
                        matrix[i, j] = int.Parse(values[j]);
                    }
                }
                if (IsToep(matrix, n, m))
                    Console.WriteLine("这个矩阵是托普利茨矩阵");
                else
                    Console.WriteLine("这个矩阵不是托普利茨矩阵");
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Exception: {ex.Message}");
            }
        }

        static bool IsToep(int[,] matrix, int m, int n)
        {
            for (int i = 0; i < m; i++)
            {
                for (int j = 0; j < n; j++)
                {
                    if (i + 1 >= m || j + 1 >= n) break;
                    if (matrix[i, j] != matrix[i + 1, j + 1]) return false;
                }
            }
            return true;
        }
    }
}
