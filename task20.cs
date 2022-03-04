using System;
using System.Collections.Generic;
using System.Linq;

namespace task20
{
    class Program
    {
        static void Main(string[] args)
        {
            int pred, cur, k = 1;
            int n = int.Parse(Console.ReadLine());
            int[] numbers = Array.ConvertAll(Console.ReadLine().Split(' '), s => int.Parse(s));
            var count = new Dictionary<int, int>();

            for (int i = 1; i < n; i++)
            {
                pred = numbers[i-1];
                cur = numbers[i];

                if (pred == cur)
                    k += 1;
                else
                {
                    count[pred] = k;
                    k = 1;
                }

                if (i == n - 1)
                    count[pred] = k;
            }

            int maxValue = count.Values.Max();
            foreach (var num in count)
            {
                if (num.Value == maxValue)
                {
                    Console.WriteLine(num.Key + " " + maxValue);
                    break;
                }
            }

        }
    }
}
