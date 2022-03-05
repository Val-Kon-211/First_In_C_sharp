using System;
using System.Collections.Generic;

namespace task17
{
    public class Solution
    {
        static void Main(string[] args)
        {
            int a, b, n, maxElem = 0;
            var dividers = new Dictionary<int, int>();
            List<int> numbers = new List<int>();
            int[] arr = Array.ConvertAll(Console.ReadLine().Split(' '), s => int.Parse(s));
            a = arr[0];
            b = arr[1];
            
            for (int num = a; num <= b; num++)
            {
                n = 0;
                for (int i = 1; i <= num; i++)
                    if (num % i == 0)
                        n++;

                dividers[num] = n;
            }

            for (int num = a; num <= b; num++)
            {
                if (dividers[num] > maxElem)
                    maxElem = dividers[num];
            }
            n = 0;
            for (int num = a; num <= b; num++)
            {
                if (dividers[num] == maxElem)
                {
                    numbers.Add(num);
                    n += 1;
                }
            }

            Console.WriteLine(n);
            Console.WriteLine(string.Join(" ", numbers));
        }
    }
}
