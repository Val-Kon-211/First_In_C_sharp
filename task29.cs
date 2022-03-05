using System;
using System.Collections.Generic;
using System.Linq;

namespace task29
{
    public class Solution
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            int[] arr = Array.ConvertAll(Console.ReadLine().Split(' '), s => int.Parse(s));
            List<int> positions = new List<int>();

            int minElem = 101;

            for (int i = 0; i < n; i++)
                if (arr[i] < minElem)
                    minElem = arr[i];

            for (int i = 0; i < n; i++)
                if (arr[i] == minElem)
                    positions.Add(i + 1);

            var c = positions.Count();
            if (c % 2 == 0)
                Console.WriteLine(positions[c / 2 - 1]);
            else
                Console.WriteLine(positions[c / 2]);
        }
    }
}
