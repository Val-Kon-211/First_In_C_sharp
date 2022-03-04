using System;
using System.Linq;

namespace task5
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            int[] numbers = Array.ConvertAll(Console.ReadLine().Split(' '), s => int.Parse(s));
            int min = 10001;

            for (int i = 0; i < n; i++)
            {
                if (min > numbers[i])
                    min = numbers[i];
            }

            for (int i = 0; i < n; i++)
            {
                if (numbers[i] == min)
                {
                    Console.WriteLine(i + 1);
                    break;
                }
            }
        }
    }
}
