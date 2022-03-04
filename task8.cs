using System;

namespace task8
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] arr = Array.ConvertAll(Console.ReadLine().Split(' '), s => int.Parse(s));
            int n = arr[0];
            int maxWeight = arr[1];
            int[] numbers = Array.ConvertAll(Console.ReadLine().Split(' '), s => int.Parse(s));

            int num = 0;
            int sumWeight = 0;

            for (int i = 0; i < n; i++)
            {
                if (sumWeight + numbers[i] < maxWeight)
                {
                    sumWeight += numbers[i];
                    num += 1;
                }
            }

            Console.WriteLine(num + " " + sumWeight);
        }
    }
}
