using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PrimeEraSeive
{
    class Program
    {
        static void Main(string[] args)
        {
            try
            {
                int[] primes = new int[101];                     // if the number n is prime, then primes[n] = 0;
                int i = 2;
                while (i <= 10)
                {
                    if (primes[i] == 1)
                    {
                        i++;
                        continue;
                    }
                    for (int j = i + i; j <= 100; j += i)
                    {
                        primes[j] = 1;
                    }
                    i++;
                }
                Console.WriteLine("2~100以内的素数有：");
                for (int j = 2; j <= 100; j++)
                {
                    if (primes[j] == 0)
                        Console.Write($"{j} ");
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Exception: {ex.Message}");
            }
        }
    }
}
