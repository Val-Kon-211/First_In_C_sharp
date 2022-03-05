using System;

namespace task26
{
    public class Solution
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            int[] arr = Array.ConvertAll(Console.ReadLine().Split(' '), s => int.Parse(s));

            for (int i = 0; i < n; i++)
            {
                for (int j = i + 1; j < n; j++)
                {
                    if (arr[j] > arr[i])
                    {
                        arr[i] = arr[j];
                        break;
                    }

                    if (j == n - 1)
                        arr[i] = 0;
                }
            }
            arr[n-1] = 0;

            Console.WriteLine(string.Join(" ", arr));
        }
    }
}
