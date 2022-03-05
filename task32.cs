using System;

namespace task32
{
    public class Solution
    {
        static void Main(string[] args)
        {
            int n1 = int.Parse(Console.ReadLine());
            int[] arr1 = Array.ConvertAll(Console.ReadLine().Split(' '), s => int.Parse(s));
            int n2 = int.Parse(Console.ReadLine());
            int[] arr2 = Array.ConvertAll(Console.ReadLine().Split(' '), s => int.Parse(s));
            int num1 = 0, num2 = 0;

            double d = Math.Pow(10, n1 - 1);

            for (int i = 0; i < n1; i++)
            {
                num1 += arr1[i] * Convert.ToInt32(d);
                d /= 10;
            }

            d = Math.Pow(10, n2 - 1);

            for (int i = 0; i < n2; i++)
            {
                num2 += arr2[i] * Convert.ToInt32(d);
                d /= 10;
            }

            if (num1 < num2)
                Console.WriteLine(-1);
            else if (num1 > num2)
                Console.WriteLine(1);
            else
                Console.WriteLine(0);
        }
    }
}
