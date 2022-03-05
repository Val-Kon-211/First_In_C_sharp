using System;

namespace task14
{
    public class Solution
    {
        static void Main(string[] args)
        {
            int a, b, n = 0;
            int[] arr = Array.ConvertAll(Console.ReadLine().Split(' '), s => int.Parse(s));
            a = arr[0];
            b = arr[1];
            if (a < b)
                (a, b) = (b, a);

            while (a > 0 && b > 0)
            {
                a -= b;
                (a, b) = (b, a);
                n += 1;
            }

            Console.WriteLine(n + " " + a);
        }
    }
}
