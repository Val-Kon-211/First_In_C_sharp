using System;
using System.Collections.Generic;
using System.Linq;

namespace task23
{
    public class Solution
    {
        static void Main(string[] args)
        {
            int n1 = int.Parse(Console.ReadLine());
            int[] arr1 = Array.ConvertAll(Console.ReadLine().Split(' '), s => int.Parse(s));
            int n2 = int.Parse(Console.ReadLine());
            int[] arr2 = Array.ConvertAll(Console.ReadLine().Split(' '), s => int.Parse(s));
            List<int> res = new List<int>();
            int m = 0;

            for(int i = 0; i < n1; i++)
            {
                if (arr2.Contains(arr1[i]))
                {
                    res.Add(arr1[i]);
                    m += 1;
                }
            }

            Console.WriteLine(m);
            Console.WriteLine(string.Join(" ", res));
        }
    }
}
